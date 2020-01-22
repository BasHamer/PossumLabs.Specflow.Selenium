using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class Activity : IValueObject
    {
    }

    [Binding]
    public class ActivityRepositorySteps : RepositoryStepBase<Activity>
    {
        public ActivityRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
