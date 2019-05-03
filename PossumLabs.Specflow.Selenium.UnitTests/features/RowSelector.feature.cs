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
    public partial class RowSelectorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "RowSelector.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Row Selector", null, ProgrammingLanguage.CSharp, new string[] {
                        "SingleBrowser",
                        "injected-html"});
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Row Selector")))
            {
                global::PossumLabs.Specflow.Selenium.UnitTests.Features.RowSelectorFeature.FeatureSetup(null);
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
        
        public virtual void TableRow(string description, string row, string target, string value, string html, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("table row", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "TableRow"});
            table9.AddRow(new string[] {
                        string.Format("{0}", html)});
#line 5
 testRunner.Given("injecting browser content", ((string)(null)), table9, "Given ");
#line 8
 testRunner.When(string.Format("for row \'{0}\' entering \'{1}\' into element \'{2}\'", row, value, target), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then(string.Format("for row \'{0}\' the element \'{1}\' has the value \'{2}\'", row, target, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td>row1<td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_01Simple()
        {
#line 4
this.TableRow("01 simple", "row1", "target", "Bob", "<td>row1<td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><label>row1</label><td><td><label>target<input type=\"text\"></input></label></" +
            "td>")]
        public virtual void TableRow_02Label()
        {
#line 4
this.TableRow("02 label", "row1", "target", "Bob", "<td><label>row1</label><td><td><label>target<input type=\"text\"></input></label></" +
                    "td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><b>row1</b><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_03B()
        {
#line 4
this.TableRow("03 b", "row1", "target", "Bob", "<td><b>row1</b><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h1>row1</h1><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_04H1()
        {
#line 4
this.TableRow("04 h1", "row1", "target", "Bob", "<td><h1>row1</h1><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h2>row1</h2><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_05H2()
        {
#line 4
this.TableRow("05 h2", "row1", "target", "Bob", "<td><h2>row1</h2><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h3>row1</h3><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_06H3()
        {
#line 4
this.TableRow("06 h3", "row1", "target", "Bob", "<td><h3>row1</h3><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h4>row1</h4><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_07H4()
        {
#line 4
this.TableRow("07 h4", "row1", "target", "Bob", "<td><h4>row1</h4><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h5>row1</h5><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_08H5()
        {
#line 4
this.TableRow("08 h5", "row1", "target", "Bob", "<td><h5>row1</h5><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><h6>row1</h6><td><td><label>target<input type=\"text\"></input></label></td>")]
        public virtual void TableRow_09H6()
        {
#line 4
this.TableRow("09 h6", "row1", "target", "Bob", "<td><h6>row1</h6><td><td><label>target<input type=\"text\"></input></label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><input value=\"row1\"></input><td><td><label>target<input type=\"text\"></input><" +
            "/label></td>")]
        public virtual void TableRow_10Input()
        {
#line 4
this.TableRow("10 input", "row1", "target", "Bob", "<td><input value=\"row1\"></input><td><td><label>target<input type=\"text\"></input><" +
                    "/label></td>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("table row: 11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<td><span>row1</span><td><td><label>target<input type=\"text\"></input></label></td" +
            ">")]
        public virtual void TableRow_11Span()
        {
#line 4
this.TableRow("11 span", "row1", "target", "Bob", "<td><span>row1</span><td><td><label>target<input type=\"text\"></input></label></td" +
                    ">", ((string[])(null)));
#line hidden
        }
        
        public virtual void DivRow(string description, string row, string target, string value, string html, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("div row", null, exampleTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Html"});
            table10.AddRow(new string[] {
                        string.Format("{0}", html)});
#line 26
 testRunner.Given("injecting browser content", ((string)(null)), table10, "Given ");
#line 29
 testRunner.When(string.Format("for row \'{0}\' entering \'{1}\' into element \'{2}\'", row, value, target), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("for row \'{0}\' the element \'{1}\' has the value \'{2}\'", row, target, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "01 simple")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\">row1<label>target<input type=\"text\"></input></label></div>")]
        public virtual void DivRow_01Simple()
        {
#line 25
this.DivRow("01 simple", "row1", "target", "Bob", "<div role=\"row\">row1<label>target<input type=\"text\"></input></label></div>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "02 label")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><label>row1</label><label>target<input type=\"text\"></input></labe" +
            "l></div>")]
        public virtual void DivRow_02Label()
        {
#line 25
this.DivRow("02 label", "row1", "target", "Bob", "<div role=\"row\"><label>row1</label><label>target<input type=\"text\"></input></labe" +
                    "l></div>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "03 b")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><b>row1</b><label>target<input type=\"text\"></input></label></div>" +
            "")]
        public virtual void DivRow_03B()
        {
#line 25
this.DivRow("03 b", "row1", "target", "Bob", "<div role=\"row\"><b>row1</b><label>target<input type=\"text\"></input></label></div>" +
                    "", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "04 h1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h1>row1</h1><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_04H1()
        {
#line 25
this.DivRow("04 h1", "row1", "target", "Bob", "<div role=\"row\"><h1>row1</h1><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "05 h2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h2>row1</h2><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_05H2()
        {
#line 25
this.DivRow("05 h2", "row1", "target", "Bob", "<div role=\"row\"><h2>row1</h2><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "06 h3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h3>row1</h3><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_06H3()
        {
#line 25
this.DivRow("06 h3", "row1", "target", "Bob", "<div role=\"row\"><h3>row1</h3><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "07 h4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h4>row1</h4><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_07H4()
        {
#line 25
this.DivRow("07 h4", "row1", "target", "Bob", "<div role=\"row\"><h4>row1</h4><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "08 h5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h5>row1</h5><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_08H5()
        {
#line 25
this.DivRow("08 h5", "row1", "target", "Bob", "<div role=\"row\"><h5>row1</h5><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "09 h6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><h6>row1</h6><label>target<input type=\"text\"></input></label></di" +
            "v>")]
        public virtual void DivRow_09H6()
        {
#line 25
this.DivRow("09 h6", "row1", "target", "Bob", "<div role=\"row\"><h6>row1</h6><label>target<input type=\"text\"></input></label></di" +
                    "v>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "10 input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><input value=\"row1\"></input><label>target<input type=\"text\"></inp" +
            "ut></label></div>")]
        public virtual void DivRow_10Input()
        {
#line 25
this.DivRow("10 input", "row1", "target", "Bob", "<div role=\"row\"><input value=\"row1\"></input><label>target<input type=\"text\"></inp" +
                    "ut></label></div>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("div row: 11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Row Selector")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("SingleBrowser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "11 span")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:row", "row1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:html", "<div role=\"row\"><span>row1</span><label>target<input type=\"text\"></input></label>" +
            "</div>")]
        public virtual void DivRow_11Span()
        {
#line 25
this.DivRow("11 span", "row1", "target", "Bob", "<div role=\"row\"><span>row1</span><label>target<input type=\"text\"></input></label>" +
                    "</div>", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
