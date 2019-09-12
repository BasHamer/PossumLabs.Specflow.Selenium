using BoDi;
using PossumLabs.Specflow.Core.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.Specflow.Selenium.Integration
{
    [Binding]
    public class LogSteps: WebDriverStepBase
    {
        public LogSteps(IObjectContainer objectContainer) : base(objectContainer)
        { }


        [Then(@"the Browser Logs has the value '(.*)'")]
        public void ThenTheBrowserLogsHasTheValue(Validation validation)
            => Executor.Execute(() => WebDriver.BrowserLogs.Validate(validation));

    }
}
