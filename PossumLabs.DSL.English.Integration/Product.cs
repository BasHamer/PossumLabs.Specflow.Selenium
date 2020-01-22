using BoDi;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English.Integration
{
    public class Product : IValueObject
    {
    }

    [Binding]
    public class ProductRepositorySteps : RepositoryStepBase<Product>
    {
        public ProductRepositorySteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }
    }
}
