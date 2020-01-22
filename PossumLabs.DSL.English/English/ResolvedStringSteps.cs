using BoDi;
using PossumLabs.Specflow.Core;
using TechTalk.SpecFlow;

namespace PossumLabs.DSL.English
{
    [Binding]
    public class ResolvedStringSteps : ResolvedStringStepsBase
    {
        public ResolvedStringSteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }

        [StepArgumentTransformation]
        public new ResolvedString Transform(string id) 
            => base.Transform(id);
    }
}
