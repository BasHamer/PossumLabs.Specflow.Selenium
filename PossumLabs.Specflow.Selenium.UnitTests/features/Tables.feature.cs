// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PossumLabs.Specflow.Selenium.Integration.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TableSelectorsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = new string[] {
                "injected-html"};
        
#line 1 "Tables.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Table Selectors", null, ProgrammingLanguage.CSharp, new string[] {
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Table Selectors")))
            {
                global::PossumLabs.Specflow.Selenium.Integration.Features.TableSelectorsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestTearDown()
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
        
        public virtual void EnteringDataIntoTable(string description, string target, string value, string table, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Entering data into table", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                            "Table"});
                table48.AddRow(new string[] {
                            string.Format("{0}", table)});
#line 5
 testRunner.Given("injecting browser content", ((string)(null)), table48, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "Col1"});
                table49.AddRow(new string[] {
                            string.Format("{0}", target),
                            string.Format("{0}", value)});
#line 8
 testRunner.When("entering into Table", ((string)(null)), table49, "When ");
#line hidden
                TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                            "",
                            "Col1"});
                table50.AddRow(new string[] {
                            string.Format("{0}", target),
                            string.Format("{0}", value)});
#line 11
 testRunner.Then("the Table has values", ((string)(null)), table50, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entering data into table: th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Table Selectors")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:table", "<tr><th>Key</th><th>Col1</th></tr><tr><td>target</td><td><input type=\"text\"/></td" +
            "></tr>")]
        public virtual void EnteringDataIntoTable_ThSimpleTextInput()
        {
#line 4
this.EnteringDataIntoTable("th simple text input", "target", "Bob", "<tr><th>Key</th><th>Col1</th></tr><tr><td>target</td><td><input type=\"text\"/></td" +
                    "></tr>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entering data into table: td simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Table Selectors")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "td simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "td simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:table", "<tr><td>Key</td><td>Col1</td></tr><tr><td>target</td><td><input type=\"text\"/></td" +
            "></tr>")]
        public virtual void EnteringDataIntoTable_TdSimpleTextInput()
        {
#line 4
this.EnteringDataIntoTable("td simple text input", "target", "Bob", "<tr><td>Key</td><td>Col1</td></tr><tr><td>target</td><td><input type=\"text\"/></td" +
                    "></tr>", ((string[])(null)));
#line hidden
        }
        
        public virtual void FindingPropperCellsInTables(string description, string target, string value, string table, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Finding propper cells in tables", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                            "Table"});
                table51.AddRow(new string[] {
                            string.Format("{0}", table)});
#line 20
 testRunner.Given("injecting browser content", ((string)(null)), table51, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Col1"});
                table52.AddRow(new string[] {
                            string.Format("{0}", target),
                            string.Format("{0}", value)});
#line 23
 testRunner.When("entering into Table", ((string)(null)), table52, "When ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Col1"});
                table53.AddRow(new string[] {
                            string.Format("{0}", target),
                            string.Format("{0}", value)});
#line 26
 testRunner.Then("the Table has values", ((string)(null)), table53, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Finding propper cells in tables: th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Table Selectors")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "th simple text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:table", "<tr><th>Key</th><th>Col1</th></tr><tr><td>target</td><td><input type=\"text\"/></td" +
            "></tr>")]
        public virtual void FindingPropperCellsInTables_ThSimpleTextInput()
        {
#line 19
this.FindingPropperCellsInTables("th simple text input", "target", "Bob", "<tr><th>Key</th><th>Col1</th></tr><tr><td>target</td><td><input type=\"text\"/></td" +
                    "></tr>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Finding propper cells in tables: th noise text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Table Selectors")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "th noise text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "th noise text input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:target", "target")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:value", "Bob")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:table", "<tr><th>stuff</th><th>Key</th><th>Col1</th></tr><tr><td>junk</td><td>target</td><" +
            "td><input type=\"text\"/></td></tr>")]
        public virtual void FindingPropperCellsInTables_ThNoiseTextInput()
        {
#line 19
this.FindingPropperCellsInTables("th noise text input", "target", "Bob", "<tr><th>stuff</th><th>Key</th><th>Col1</th></tr><tr><td>junk</td><td>target</td><" +
                    "td><input type=\"text\"/></td></tr>", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Failed match")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Table Selectors")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("injected-html")]
        public virtual void FailedMatch()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Failed match", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "Table"});
                table54.AddRow(new string[] {
                            "<tr><th>Key</th><th>Col1</th></tr><tr><td>target</td><td><input type=\"text\"/></td" +
                                "></tr>"});
#line 35
 testRunner.Given("injecting browser content", ((string)(null)), table54, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Col1"});
                table55.AddRow(new string[] {
                            "target",
                            "Bob"});
#line 38
 testRunner.When("entering into Table", ((string)(null)), table55, "When ");
#line hidden
#line 41
 testRunner.Given("an error is expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table56 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Col1"});
                table56.AddRow(new string[] {
                            "target",
                            "Marry"});
#line 42
 testRunner.Then("the Table has values", ((string)(null)), table56, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table57 = new TechTalk.SpecFlow.Table(new string[] {
                            "Message"});
                table57.AddRow(new string[] {
                            "/the value was \'Bob\' wich was not \'Marry\'/"});
#line 45
 testRunner.Then("the Error has values", ((string)(null)), table57, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
