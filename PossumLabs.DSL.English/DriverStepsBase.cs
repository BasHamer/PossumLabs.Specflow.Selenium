using BoDi;
using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Selenium;
using PossumLabs.Specflow.Selenium.Selectors;

namespace PossumLabs.DSL
{

    public abstract class DriverStepsBase: WebDriverStepsBase
    {
        public DriverStepsBase(IObjectContainer objectContainer) : base(objectContainer)
        { }

        //selectors
        protected virtual ActiveElementSelector TransformActiveElementSelector(string Constructor)
            => SelectorFactory.CreateSelector<ActiveElementSelector>(Interpeter.Get<string>(Constructor));

        protected virtual ContentSelector TransformContentSelector(string Constructor)
            => SelectorFactory.CreateSelector<ContentSelector>(Interpeter.Get<string>(Constructor));

        protected virtual CheckableElementSelector TransformCheckableElementSelector(string Constructor)
            => SelectorFactory.CreateSelector<CheckableElementSelector>(Interpeter.Get<string>(Constructor));

        protected virtual ClickableElementSelector TransformClickableElementSelector(string Constructor)
            => SelectorFactory.CreateSelector<ClickableElementSelector>(Interpeter.Get<string>(Constructor));

        protected virtual SelectableElementSelector TransformSelectableElementSelectorr(string Constructor)
            => SelectorFactory.CreateSelector<SelectableElementSelector>(Interpeter.Get<string>(Constructor));

        protected virtual SettableElementSelector TransformSettableElementSelector(string Constructor)
            => SelectorFactory.CreateSelector<SettableElementSelector>(Interpeter.Get<string>(Constructor));


        //prefixes
        protected virtual UnderSelectorPrefix TransformUnderSearcherPrefix(string Constructor)
            => SelectorFactory.CreatePrefix<UnderSelectorPrefix>(Interpeter.Get<string>(Constructor));

        protected virtual RowSelectorPrefix TransformRowSearcherPrefix(string Constructor)
            => SelectorFactory.CreatePrefix<RowSelectorPrefix>(Interpeter.Get<string>(Constructor));

        protected virtual WarningSelectorPrefix TransformWarningSearcherPrefix(string Constructor)
            => SelectorFactory.CreatePrefix<WarningSelectorPrefix>(Interpeter.Get<string>(Constructor));

        protected virtual ErrorSelectorPrefix TransformErrorSearcherPrefix(string Constructor)
            => SelectorFactory.CreatePrefix<ErrorSelectorPrefix>(Interpeter.Get<string>(Constructor));

        protected virtual void Cleanup()
        {
            if (WebDriverManager.IsInitialized && WebDriver != null && !WebDriver.HasAlert)
                WebDriver.LeaveFrames();
        }

        protected virtual void WhenClickingTheElement(ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Click());

        protected virtual void WhenScriptClearing(ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).ScriptClear());

        protected virtual void WhenScriptSetting(ResolvedString text, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).ScriptSet(text));

        protected virtual void WhenSelectingTheElement(ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Select());

        protected virtual void WhenEnteringForTheElement(ResolvedString text, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Enter(text));

        protected virtual void WhenClickingTheElementRow(RowSelectorPrefix row, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.ForRow(row).Select(selector).Click());

        protected virtual void WhenSelectingTheElementRow(RowSelectorPrefix row, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.ForRow(row).Select(selector).Select());

        protected virtual void WhenEnteringForTheElementRow(RowSelectorPrefix row, ResolvedString text, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.ForRow(row).Select(selector).Enter(text));

        protected virtual void WhenClickingTheElementUnder(UnderSelectorPrefix under, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Under(under).Select(selector).Click());

        protected virtual void WhenSelectingTheElementUnder(UnderSelectorPrefix under, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Under(under).Select(selector).Select());

        protected virtual void WhenEnteringForTheElementUnder(UnderSelectorPrefix under, ResolvedString text, ActiveElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Under(under).Select(selector).Enter(text));

        protected virtual void GivenNavigatedTo(string page)
            => Executor.Execute(()
            => WebDriver.NavigateTo(page));

        protected virtual void WhenSelectingForElement(ResolvedString text, SelectableElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Enter(text));

        protected virtual void WhenSettingTheElement(ResolvedString text, SettableElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Enter(text));

        protected virtual void WhenCheckingElement(CheckableElementSelector selector)
            => Executor.Execute(()
            => WebDriver.Select(selector).Enter("checked"));

        protected virtual void WhenUncheckingElement(CheckableElementSelector selector)
           => Executor.Execute(()
           => WebDriver.Select(selector).Enter("unchecked"));
    }
}
