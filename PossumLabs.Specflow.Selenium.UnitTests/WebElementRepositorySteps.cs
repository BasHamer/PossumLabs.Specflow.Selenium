﻿using BoDi;
using FluentAssertions;
using OpenQA.Selenium;
using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Core.Variables;
using PossumLabs.Specflow.Selenium.Selectors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.Specflow.Selenium.Integration
{
    public class WebElementWrapper:IValueObject, IWebElement
    {
        public WebElementWrapper(IWebElement element)
        {
            Element = element;
        }

        private IWebElement Element { get; }

        public string TagName => Element.TagName;
        public string Text => Element.Text;
        public bool Enabled => Element.Enabled;
        public bool Selected => Element.Selected;
        public Point Location => Element.Location;
        public Size Size => Element.Size;
        public bool Displayed => Element.Displayed;
        public void Clear() => Element.Clear();
        public void Click() => Element.Click();
        public IWebElement FindElement(By by) => Element.FindElement(by);
        public ReadOnlyCollection<IWebElement> FindElements(By by) => Element.FindElements(by);
        public string GetAttribute(string attributeName) => Element.GetAttribute(attributeName);
        public string GetCssValue(string propertyName) => Element.GetCssValue(propertyName);
        public string GetProperty(string propertyName) => Element.GetProperty(propertyName);
        public void SendKeys(string text) => Element.SendKeys(text);
        public void Submit() => Element.Submit();
    }

    [Binding]
    public class WebElementRepositorySteps : RepositoryStepBase<WebElementWrapper>
    {
        public WebElementRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }

        protected WebDriver WebDriver => ObjectContainer.Resolve<WebDriverManager>().Current;

        [Given(@"the Active Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, ActiveElementSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
               });

        [Given(@"the Selectable Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, SelectableElementSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
           });

        [Given(@"the Checkable Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, CheckableElementSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
           });

        [Given(@"the Settable Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, SettableElementSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
           });

        [Given(@"the Content Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, ContentSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
           });

        [Given(@"the Clickable Element '(.*)' found by '(.*)'")]
        public void WhenScriptSetting(ResolvedString text, ClickableElementSelector selector)
           => Executor.Execute(()
           => {
               var e = WebDriver.Select(selector);
               e.Should().NotBeNull();
               Add(text, new WebElementWrapper(e.WebElement));
           });
    }
}
