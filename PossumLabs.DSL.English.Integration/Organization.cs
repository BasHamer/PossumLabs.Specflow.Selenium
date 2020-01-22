using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class Organization : IValueObject
    {
    }

    [Binding]
    public class OrganizationRepositorySteps : RepositoryStepBase<Organization>
    {
        public OrganizationRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
