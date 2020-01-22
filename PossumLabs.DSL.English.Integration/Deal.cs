using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class Deal : IValueObject
    {
    }

    [Binding]
    public class DealRepositorySteps : RepositoryStepBase<Deal>
    {
        public DealRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
