﻿using BoDi;
using PossumLabs.Specflow.Core.Validations;

namespace PossumLabs.DSL
{
    public abstract class LogStepsBase: WebDriverStepsBase
    {
        public LogStepsBase(IObjectContainer objectContainer) : base(objectContainer)
        { }

        protected virtual void ThenTheBrowserLogsHasTheValue(Validation validation)
            => Executor.Execute(() => WebDriver.BrowserLogs.Validate(validation));

    }
}
