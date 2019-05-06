// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PossumLabs.Specflow.Selenium.UnitTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SelectableSelectorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Selectable.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Selectable selector", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Selectable selector")))
            {
                global::PossumLabs.Specflow.Selenium.UnitTests.Features.SelectableSelectorFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SelectingInputs(string description, string target, string value, string html, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("selecting inputs", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Html"});
            table23.AddRow(new string[] {
                        string.Format("{0}", html)});
#line 4
 testRunner.Given("injecting browser content", ((string)(null)), table23, "Given ");
#line 7
 testRunner.When(string.Format("selecting \'{0}\' for element \'{1}\'", value, target), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.Then(string.Format("the element \'{0}\' has the value \'{1}\'", target, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: n for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "n for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "n for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label for=\"linky\">target</label><select id=\"linky\"><option value=\"bad\">Bad</opti" +
            "on><option value=\"test\">Bob</option></select>")]
        public virtual void SelectingInputs_NFor()
        {
#line 3
this.SelectingInputs("n for", "target", "Bob", "<label for=\"linky\">target</label><select id=\"linky\"><option value=\"bad\">Bad</opti" +
                    "on><option value=\"test\">Bob</option></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: n nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "n nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "n nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label>target<select><option value=\"bad\">Bad</option><option value=\"test\">Bob</op" +
            "tion></select></label >")]
        public virtual void SelectingInputs_NNested()
        {
#line 3
this.SelectingInputs("n nested", "target", "Bob", "<label>target<select><option value=\"bad\">Bad</option><option value=\"test\">Bob</op" +
                    "tion></select></label >", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: n aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "n aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "n aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select aria-label=\"target\"><option value=\"bad\">Bad</option><option value=\"test\">" +
            "Bob</option></select>")]
        public virtual void SelectingInputs_NAria_Label()
        {
#line 3
this.SelectingInputs("n aria-label", "target", "Bob", "<select aria-label=\"target\"><option value=\"bad\">Bad</option><option value=\"test\">" +
                    "Bob</option></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: n name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "n name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "n name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select name=\"target\"><option value=\"bad\">Bad</option><option value=\"test\">Bob</o" +
            "ption></select>")]
        public virtual void SelectingInputs_NName()
        {
#line 3
this.SelectingInputs("n name", "target", "Bob", "<select name=\"target\"><option value=\"bad\">Bad</option><option value=\"test\">Bob</o" +
                    "ption></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: n aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "n aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "n aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "t1 t2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select aria-labelledby= \"l1 l2\"><option value=\"bad\">Bad</option><option value=\"t" +
            "est\">Bob</option></select><label id=\"l1\">t1</label><label id=\"l2\">t2</label>")]
        public virtual void SelectingInputs_NAria_Labelledby()
        {
#line 3
this.SelectingInputs("n aria-labelledby", "t1 t2", "Bob", "<select aria-labelledby= \"l1 l2\"><option value=\"bad\">Bad</option><option value=\"t" +
                    "est\">Bob</option></select><label id=\"l1\">t1</label><label id=\"l2\">t2</label>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: v for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "v for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "v for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label for=\"linky\">target</label><select id=\"linky\"><option value=\"bad\">Bad</opti" +
            "on><option value=\"Bob\">test</option></select>")]
        public virtual void SelectingInputs_VFor()
        {
#line 3
this.SelectingInputs("v for", "target", "Bob", "<label for=\"linky\">target</label><select id=\"linky\"><option value=\"bad\">Bad</opti" +
                    "on><option value=\"Bob\">test</option></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: v nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "v nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "v nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label>target<select><option value=\"bad\">Bad</option><option value=\"Bob\">test</op" +
            "tion></select></label >")]
        public virtual void SelectingInputs_VNested()
        {
#line 3
this.SelectingInputs("v nested", "target", "Bob", "<label>target<select><option value=\"bad\">Bad</option><option value=\"Bob\">test</op" +
                    "tion></select></label >", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: v aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "v aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "v aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select aria-label=\"target\"><option value=\"bad\">Bad</option><option value=\"Bob\">t" +
            "est</option></select>")]
        public virtual void SelectingInputs_VAria_Label()
        {
#line 3
this.SelectingInputs("v aria-label", "target", "Bob", "<select aria-label=\"target\"><option value=\"bad\">Bad</option><option value=\"Bob\">t" +
                    "est</option></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: v name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "v name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "v name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select name=\"target\"><option value=\"bad\">Bad</option><option value=\"Bob\">test</o" +
            "ption></select>")]
        public virtual void SelectingInputs_VName()
        {
#line 3
this.SelectingInputs("v name", "target", "Bob", "<select name=\"target\"><option value=\"bad\">Bad</option><option value=\"Bob\">test</o" +
                    "ption></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: v aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "v aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "v aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "t1 t2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select aria-labelledby= \"l1 l2\"><option value=\"bad\">Bad</option><option value=\"B" +
            "ob\">test</option></select><label id=\"l1\">t1</label><label id=\"l2\">t2</label>")]
        public virtual void SelectingInputs_VAria_Labelledby()
        {
#line 3
this.SelectingInputs("v aria-labelledby", "t1 t2", "Bob", "<select aria-labelledby= \"l1 l2\"><option value=\"bad\">Bad</option><option value=\"B" +
                    "ob\">test</option></select><label id=\"l1\">t1</label><label id=\"l2\">t2</label>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: dl for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "dl for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "dl for")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label for=\"linky\">target</label><input id=\"linky\" list=\"o\"><datalist id=\"o\"><opt" +
            "ion value=\"bad\"><option value=\"Bob\"></datalist></select>")]
        public virtual void SelectingInputs_DlFor()
        {
#line 3
this.SelectingInputs("dl for", "target", "Bob", "<label for=\"linky\">target</label><input id=\"linky\" list=\"o\"><datalist id=\"o\"><opt" +
                    "ion value=\"bad\"><option value=\"Bob\"></datalist></select>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: dl nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "dl nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "dl nested")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<label>target<input list=\"o\"><datalist id=\"o\"><option value=\"bad\"><option value=\"" +
            "Bob\"></datalist></label >")]
        public virtual void SelectingInputs_DlNested()
        {
#line 3
this.SelectingInputs("dl nested", "target", "Bob", "<label>target<input list=\"o\"><datalist id=\"o\"><option value=\"bad\"><option value=\"" +
                    "Bob\"></datalist></label >", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: dl aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "dl aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "dl aria-label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<input aria-label=\"target\" list=\"o\"><datalist id=\"o\"><option value=\"bad\"><option " +
            "value=\"Bob\"></datalist>")]
        public virtual void SelectingInputs_DlAria_Label()
        {
#line 3
this.SelectingInputs("dl aria-label", "target", "Bob", "<input aria-label=\"target\" list=\"o\"><datalist id=\"o\"><option value=\"bad\"><option " +
                    "value=\"Bob\"></datalist>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: dl aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "dl aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "dl aria-labelledby")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "t1 t2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<input aria-labelledby= \"l1 l2\" list=\"o\"><datalist id=\"o\"><option value=\"bad\"><op" +
            "tion value=\"Bob\"></datalist><label id=\"l1\">t1</label><label id=\"l2\">t2</label>")]
        public virtual void SelectingInputs_DlAria_Labelledby()
        {
#line 3
this.SelectingInputs("dl aria-labelledby", "t1 t2", "Bob", "<input aria-labelledby= \"l1 l2\" list=\"o\"><datalist id=\"o\"><option value=\"bad\"><op" +
                    "tion value=\"Bob\"></datalist><label id=\"l1\">t1</label><label id=\"l2\">t2</label>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("selecting inputs: default name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "default name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "default name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<select name=\"target\"><option value=\"\" groupname displayorder=\"-1\"></option><opti" +
            "on value=\"bad\">Bad</option><option value=\"Bob\">test</option></select>")]
        public virtual void SelectingInputs_DefaultName()
        {
#line 3
this.SelectingInputs("default name", "target", "Bob", "<select name=\"target\"><option value=\"\" groupname displayorder=\"-1\"></option><opti" +
                    "on value=\"bad\">Bad</option><option value=\"Bob\">test</option></select>", ((string[])(null)));
#line hidden
        }
        
        public virtual void ErrorMessages(string description, string target, string value, string html, string error, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("error messages", null, exampleTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Html"});
            table24.AddRow(new string[] {
                        string.Format("{0}", html)});
#line 28
 testRunner.Given("injecting browser content", ((string)(null)), table24, "Given ");
#line 31
 testRunner.Given("an error is expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.When(string.Format("entering \'{0}\' into element \'{1}\'", value, target), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Message"});
            table25.AddRow(new string[] {
                        string.Format("{0}", error)});
#line 33
 testRunner.Then("the Error has values", ((string)(null)), table25, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("error messages: value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Selectable selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "value")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "checked")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<input type=\"checkbox\" id=\"i1\" name=\"t\" value=\"Bob\"></input><label for=\"i1\">noop<" +
            "/label>")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:error", "/element was not found/")]
        public virtual void ErrorMessages_Value()
        {
#line 27
this.ErrorMessages("value", "target", "checked", "<input type=\"checkbox\" id=\"i1\" name=\"t\" value=\"Bob\"></input><label for=\"i1\">noop<" +
                    "/label>", "/element was not found/", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
