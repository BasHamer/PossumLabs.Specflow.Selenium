using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class User : IEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string LogFormat()
            => $"email:{Email}";
    }

    [Binding]
    public class UserRepositorySteps : RepositoryStepBase<User>
    {
        public UserRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
