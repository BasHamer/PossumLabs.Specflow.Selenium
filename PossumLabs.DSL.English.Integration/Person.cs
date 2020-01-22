using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class Person : IValueObject
    {
    }

    [Binding]
    public class PersonRepositorySteps : RepositoryStepBase<Person>
    {
        public PersonRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
