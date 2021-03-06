﻿using BoDi;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Core.Configuration;
using PossumLabs.Specflow.Core.Exceptions;
using PossumLabs.Specflow.Core.Files;
using PossumLabs.Specflow.Core.Logging;
using PossumLabs.Specflow.Selenium;
using PossumLabs.Specflow.Selenium.Configuration;
using PossumLabs.Specflow.Selenium.Diagnostic;
using PossumLabs.Specflow.Selenium.Selectors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PossumLabs.Specflow.Selenium.Integration
{
    [Binding]
    public class FrameworkInitializationSteps : WebDriverStepBase
    {
        public FrameworkInitializationSteps(IObjectContainer objectContainer) : base(objectContainer) { }


        private ScreenshotProcessor ScreenshotProcessor { get; set; }
        private ImageLogging ImageLogging { get; set; }
        private MovieLogger MovieLogger { get; set; }
        private WebElementSourceLog WebElementSourceLog { get; set; }
        private NetworkWatcher NetworkWatcher { get; set; }

        private DefaultLogger Logger { get; set; }

        [BeforeScenario(Order = int.MinValue + 1)]
        public void Setup()
        {
            ScreenshotProcessor = ObjectContainer.Resolve<ScreenshotProcessor>();
        }

        [AfterStep]
        public void LogStep()
        {
            MovieLogger.StepEnd($"{ScenarioContext.StepContext.StepInfo.StepDefinitionType} {ScenarioContext.StepContext.StepInfo.Text}");
        }

        [BeforeStep]
        public void NetworkWatcherHook()
        {
            if (WebDriverManager.IsInitialized)
                if(!WebDriver.HasAlert)
                    NetworkWatcher.AddUrl(WebDriver.Url);
        }

        [AfterScenario]
        public void LogScreenshots()
        {
            if(MovieLogger.IsEnabled)
                MovieLogger.ComposeMovie();
            WebElementSourceLog.Log(Logger);
            NetworkWatcher.Log(Logger);

        }

        [AfterScenario(Order = int.MinValue + 1)]
        public void LogHtml()
        {
            if (WebDriverManager.ActiveDriver)
            {
                try
                {
                    FileManager.PersistFile(Encoding.UTF8.GetBytes(WebDriverManager.Current.PageSource), "source", "html");
                }
                catch (UnhandledAlertException) { return; }
            }
        }

        [AfterScenario(Order = int.MinValue)]
        public void CheckForAlerts()
        {
            if (!WebDriverManager.ActiveDriver)
                return;
            WebDriver.AlertText.Should().BeNull($"An allert was left open at the end of the test with text:{WebDriver.AlertText}");
        }

        [BeforeScenario(Order = int.MinValue+1)]
        public void SetupInfrastructure()
        {
            IConfiguration config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables()
              .Build();

            NetworkWatcher = new NetworkWatcher();

            var configFactory = new ConfigurationFactory(config);

            ObjectContainer.RegisterInstanceAs(configFactory.Create<MovieLoggerConfig>());
            ObjectContainer.RegisterInstanceAs(configFactory.Create<ImageLoggingConfig>());
            WebElementSourceLog = new WebElementSourceLog();

            ImageLogging = new ImageLogging(ObjectContainer.Resolve<ImageLoggingConfig>());
            Register(new FileManager(new DatetimeManager(() => DateTime.Now)));
            FileManager.Initialize(FeatureContext.FeatureInfo.Title, ScenarioContext.ScenarioInfo.Title, null /*Specflow limitation*/);
            MovieLogger = new MovieLogger(FileManager, ObjectContainer.Resolve<MovieLoggerConfig>(), Metadata);

            ObjectContainer.RegisterInstanceAs(ImageLogging);
            ObjectContainer.RegisterInstanceAs(MovieLogger);

            Logger = new DefaultLogger(new DirectoryInfo(Environment.CurrentDirectory), new YamlLogFormatter());
            Register((PossumLabs.Specflow.Core.Logging.ILog)Logger);
            Register<ElementFactory>(new ElementFactory());
            Register<XpathProvider>(new XpathProvider());
            Register<SelectorFactory>(new SelectorFactory(ElementFactory, XpathProvider).UseBootstrap());
            Register(new PossumLabs.Specflow.Selenium.WebDriverManager(
                this.Interpeter,
                this.ObjectFactory,
                new SeleniumGridConfiguration()));

            
            

            var templateManager = new PossumLabs.Specflow.Core.Variables.TemplateManager();
            templateManager.Initialize(Assembly.GetExecutingAssembly());
            Register(templateManager);

            Log.Message($"feature: {FeatureContext.FeatureInfo.Title} scenario: {ScenarioContext.ScenarioInfo.Title} \n" +
                $"Tags: {FeatureContext.FeatureInfo.Tags.LogFormat()} {ScenarioContext.ScenarioInfo.Tags.LogFormat()}");

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            WebDriverManager.Initialize(BuildDriver);
            WebDriverManager.WebDriverFactory = () =>
            {
                var options = new ChromeOptions();

                //grid
                options.AddAdditionalCapability("username", WebDriverManager.SeleniumGridConfiguration.Username, true);
                options.AddAdditionalCapability("accessKey", WebDriverManager.SeleniumGridConfiguration.AccessKey, true);

                var driver = new RemoteWebDriver(new Uri(WebDriverManager.SeleniumGridConfiguration.Url), options.ToCapabilities(), TimeSpan.FromSeconds(180));
                //do not change this, the site is a bloody nightmare with overlaying buttons etc.
                driver.Manage().Window.Size = WebDriverManager.DefaultSize;
                var allowsDetection = driver as IAllowsFileDetection;
                if (allowsDetection != null)
                {
                    allowsDetection.FileDetector = new LocalFileDetector();
                }
                return driver;
            };
        }

        public WebDriver BuildDriver()
            => new WebDriver(
                WebDriverManager.Create(),
                () => WebDriverManager.BaseUrl,
                ObjectContainer.Resolve<SeleniumGridConfiguration>(),
                ObjectContainer.Resolve<RetryExecutor>(),
                SelectorFactory,
                ElementFactory,
                XpathProvider,
                ObjectContainer.Resolve<MovieLogger>(), 
                WebElementSourceLog);

        [BeforeScenario(Order = 1)]
        public void SetupExistingData()
        {
            new PossumLabs.Specflow.Core.Variables.ExistingDataManager(this.Interpeter).Initialize(Assembly.GetExecutingAssembly());
        }
    }
}
