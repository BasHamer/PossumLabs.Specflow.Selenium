using BoDi;
using PossumLabs.Specflow.Core.Validations;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English
{
    [Binding]
    public class LogSteps: LogStepsBase
    {
        public LogSteps(IObjectContainer objectContainer) : base(objectContainer)
        { }


        [Then(@"the Browser Logs has the value '(.*)'")]
        public new void ThenTheBrowserLogsHasTheValue(Validation validation)
            => base.ThenTheBrowserLogsHasTheValue(validation);

    }
}
