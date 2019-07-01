using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Core.Exceptions;
using PossumLabs.Specflow.Core.Logging;
using PossumLabs.Specflow.Core.Variables;
using PossumLabs.Specflow.Selenium.Configuration;
using PossumLabs.Specflow.Selenium.Selectors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossumLabs.Specflow.Selenium
{
    public class WebDriver : IDomainObject, IWebDriverWrapper
    {
        public WebDriver(
            IWebDriver seleniumDriver, 
            Func<Uri> rootUrl, 
            SeleniumGridConfiguration configuration, 
            RetryExecutor retryExecutor, 
            SelectorFactory selectorFactory,
            ElementFactory elementFactory,
            XpathProvider xpathProvider,
            MovieLogger movieLogger,
            IEnumerable<SelectorPrefix> prefixes = null)
        {
            SeleniuimDriver = seleniumDriver;
            SuccessfulSearchers = new List<Searcher>();
            RootUrl = rootUrl;
            SeleniumGridConfiguration = configuration;
            RetryExecutor = retryExecutor;
            SelectorFactory = selectorFactory;
            MovieLogger = movieLogger;
            Prefixes = prefixes?.ToList() ?? new List<SelectorPrefix>() { new EmptySelectorPrefix() };

            Children = new List<WebDriver>();
            Screenshots = new List<byte[]>();
            ElementFactory = elementFactory;
            XpathProvider = xpathProvider;
        }

        private ElementFactory ElementFactory { get; }
        private XpathProvider XpathProvider { get; }
        private Func<Uri> RootUrl { get; set; }
        public IWebDriver SeleniuimDriver { get; }
        public IJavaScriptExecutor ScriptExecutor
        { get
            {
                var scriptExecutor = SeleniuimDriver as IJavaScriptExecutor;
                if (scriptExecutor == null)
                    throw new Exception("this webdriver does not support script executon.");

                    return scriptExecutor;
            }
        }
        private SelectorFactory SelectorFactory { get; }
        private List<Searcher> SuccessfulSearchers { get; }
        private MovieLogger MovieLogger { get; }

        public TableElement GetTables(IEnumerable<string> headers, StringComparison comparison = StringComparison.CurrentCulture, int? index = null )
        => RetryExecutor.RetryFor(() =>
        {
            
            var loggingWebdriver = new LoggingWebDriver(SeleniuimDriver, MovieLogger);
            try
            {
                var possilbeTables = GetTables(headers.Count()).ToList();
                Func<string, string, bool> comparer = (s1, s2) => s1.Equals(s2, comparison);

                var tableElements = possilbeTables.Where(t => headers.Where(h => !string.IsNullOrEmpty(h)).Except(t.Header.Keys, 
                    new Core.EqualityComparer<string>(comparer)).None());

                if (tableElements.One())
                    return tableElements.First();
                //Exact match overrides in case of multiples.
                if (tableElements.Where(x => headers.Count() == x.MaxColumnIndex).One())
                    return tableElements.Where(x => headers.Count() == x.MaxColumnIndex).First();
                if (tableElements.Many())
                {
                    if (index == null)
                        throw new Exception($"multiple talbes matched the definition of {headers.LogFormat()}, table headers were {tableElements.LogFormat(t => $"Table: {t.Header.Keys.LogFormat()}")};");
                    if (index >= tableElements.Count())
                        throw new Exception($"only found {tableElements.Count()} tables, index of {index} is out of range. (zero based)");
                    return tableElements.ToArray()[index.Value];
                }
                //iframes ? 
                var iframes = SeleniuimDriver.FindElements(By.XPath("//iframe"));
                foreach (var iframe in iframes)
                {
                    try
                    {
                        loggingWebdriver.Log($"Trying iframe:{iframe}");
                        SeleniuimDriver.SwitchTo().Frame(iframe);
                        possilbeTables = GetTables(headers.Count() - 1).ToList();

                        tableElements = possilbeTables.Where(t => headers.Where(h => !string.IsNullOrEmpty(h)).Except(t.Header.Keys,
                            new Core.EqualityComparer<string>(comparer)).None());

                        if (tableElements.One())
                            return tableElements.First();
                        if (tableElements.Many())
                        {
                            if(index == null)
                                throw new Exception($"multiple talbes matched the definition of {headers.LogFormat()}, table headers were {tableElements.LogFormat(t => $"Table: {t.Header.Keys.LogFormat()}")};");
                            if (index >= tableElements.Count())
                                throw new Exception($"only found {tableElements.Count()} tables, index of {index} is out of range. (zero based)");
                            return tableElements.ToArray()[index.Value];
                        }
                    }
                    catch
                    { }
                }
                SeleniuimDriver.SwitchTo().DefaultContent();
                throw new Exception($"table was not found");
            }
            finally
            {
                if (loggingWebdriver.Screenshots.Any())
                    Screenshots = loggingWebdriver.Screenshots.Select(x => x.AsByteArray).ToList();

            }
        }, TimeSpan.FromMilliseconds(SeleniumGridConfiguration.RetryMs));

        public IEnumerable<TableElement> GetTables(int minimumWidth)
        {
            var xpath = $"//table[" +
                $"tr[th[{minimumWidth}] or td[{minimumWidth}]] or " +
                $"tbody/tr[th[{minimumWidth}] or td[{minimumWidth}]] or " +
                $"thead/tr[th[{minimumWidth}] or td[{minimumWidth}]]" +
                $"]";
            //var xpath = $"//tr[*[self::td or self::th][{minimumWidth}] and (.|parent::tbody)[1]/parent::table]/ancestor::table[1]";
            var tables = SeleniuimDriver.
                FindElements(By.XPath(xpath))
                .Select(t => new TableElement(t, SeleniuimDriver, ElementFactory, XpathProvider)).ToList();
            var Ordinal = 1;
            foreach (var table in tables)
            {
                table.Ordinal = Ordinal++;
                table.Xpath = xpath;
            }
            tables.AsParallel().ForAll(table => table.Setup());
            return tables.Where(t=>t.IsValid).ToList();
        }

        private SeleniumGridConfiguration SeleniumGridConfiguration { get; }
        private RetryExecutor RetryExecutor { get; }
        private List<SelectorPrefix> Prefixes { get; }
        private List<byte[]> Screenshots { get; set; }
        private List<WebDriver> Children { get; set; }

        //TODO: check this form
        public void NavigateTo(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out var absolute))
                SeleniuimDriver.Navigate().GoToUrl(url);
            else
                SeleniuimDriver.Navigate().GoToUrl(RootUrl().AbsoluteUri + url);
        }

        public void Close()
            => SeleniuimDriver.Close();

        public void LeaveFrames()
            => SeleniuimDriver.SwitchTo().DefaultContent();

        public Actions BuildAction()
            => new Actions(SeleniuimDriver);

        public void LoadPage(string html)
            => SeleniuimDriver.Navigate().GoToUrl("data:text/html;charset=utf-8," + html);

        public void SwitchToWindow(string window)
            => SeleniuimDriver.SwitchTo().Window(window);

        public Element Select(Selector selector, TimeSpan? retryDuration = null, int? index = null)
            => RetryExecutor.RetryFor(() =>
             {
                 var loggingWebdriver = new LoggingWebDriver(SeleniuimDriver, MovieLogger);
                 try
                 {
                     var element = FindElement(selector, loggingWebdriver, index);
                     if (element != null)
                         return element;
                     //iframes ? 
                     var iframes = SeleniuimDriver.FindElements(By.XPath("//iframe"));
                     foreach (var iframe in iframes)
                     {
                         try
                         {
                             loggingWebdriver.Log($"Trying iframe:{iframe}");
                             SeleniuimDriver.SwitchTo().Frame(iframe);
                             element = FindElement(selector, loggingWebdriver, index);
                             if (element != null)
                                 return element;
                         }
                         catch
                         { }
                     }
                     SeleniuimDriver.SwitchTo().DefaultContent();
                     throw new Exception($"element was not found; tried:\n{loggingWebdriver.GetLogs()}, maybe try one of these identifiers {GetIdentifiers().Take(10).LogFormat()}");
                 }
                 finally
                 {
                     if (loggingWebdriver.Screenshots.Any())
                         Screenshots = loggingWebdriver.Screenshots.Select(x => x.AsByteArray).ToList();

                 }
             }, retryDuration ?? TimeSpan.FromMilliseconds(SeleniumGridConfiguration.RetryMs));

        public IEnumerable<Element> SelectMany(Selector selector)
            => RetryExecutor.RetryFor(() =>
            {
                var loggingWebdriver = new LoggingWebDriver(SeleniuimDriver, MovieLogger);
                try
                {
                    var elements = FindElements(selector, loggingWebdriver);
                    if (elements != null)
                        return elements;
                    //iframes ? 
                    var iframes = SeleniuimDriver.FindElements(By.XPath("//iframe"));
                    foreach (var iframe in iframes)
                    {
                        try
                        {
                            loggingWebdriver.Log($"Trying iframe:{iframe}");
                            SeleniuimDriver.SwitchTo().Frame(iframe);
                            elements = FindElements(selector, loggingWebdriver);
                            if (elements != null)
                                return elements;
                        }
                        catch
                        { }
                    }
                    SeleniuimDriver.SwitchTo().DefaultContent();
                    return new List<Element>();
                }
                finally
                {
                    if (loggingWebdriver.Screenshots.Any())
                        Screenshots = loggingWebdriver.Screenshots.Select(x => x.AsByteArray).ToList();

                }
            }, TimeSpan.FromMilliseconds(SeleniumGridConfiguration.RetryMs));

        public void DismissAlert()
            => SeleniuimDriver.SwitchTo().Alert().Dismiss();

        public void AcceptAlert()
            => SeleniuimDriver.SwitchTo().Alert().Accept();

        private class Wrapper
        {
            public IEnumerable<Element> Elements;
            public Element Element;
            public Searcher Searcher;
            public Exception Exception;
        }

        private Element FindElement(Selector selector, LoggingWebDriver loggingWebdriver, int? index = null)
        {
            var wrappers = selector.PrioritizedSearchers.Select(s => new Wrapper { Searcher = s }).ToList();
            var loopResults = Parallel.ForEach(wrappers, 
                //new ParallelOptions { MaxDegreeOfParallelism = 4 }, 
                (wrapper, loopState) =>
            {
                var searcher = wrapper.Searcher;

                var results = searcher.SearchIn(loggingWebdriver, Prefixes);
                if (loopState.ShouldExitCurrentIteration)
                    return;
                else if (results.One())
                {
                    SuccessfulSearchers.Add(searcher);
                    loopState.Break();
                    wrapper.Element = results.First();
                    return;
                }
                else if (results.Many() && index.HasValue)
                {
                    SuccessfulSearchers.Add(searcher);
                    loopState.Break();
                    var a = results.ToArray();
                    if (a.Count() <= index.Value)
                        wrapper.Exception = new Exception($"Not enough items found, found {a.Count()} and desired index {index}");
                    else
                        wrapper.Element = a[index.Value];
                    return;
                }
                else if (results.Many())
                {
                    //lets make sure none are hidden
                    var filterHidden = results
                        .Select(e => new { e, o = loggingWebdriver.GetElementFromPoint(e.Location.X + 1, e.Location.Y + 1) })
                        .Where(p => p.e.Tag == p.o?.TagName && p.e.Location == p.o?.Location);
                    if (filterHidden.One())
                    {
                        SuccessfulSearchers.Add(searcher);
                        loopState.Break();
                        wrapper.Element = results.First();
                        return;
                    }
                    //check if they are logical duplicates.
                    if (results.GroupBy(e => e.Id).One())
                    {
                        SuccessfulSearchers.Add(searcher);
                        loopState.Break();
                        wrapper.Element = results.First();
                        return;
                    }
                    //scroll up ?
                    //WebDriver.ExecuteScript("window.scrollTo(0,1)");
                    var items = results.Select(e => $"{e.Tag}@{e.Location.X},{e.Location.Y}").LogFormat();
                    loopState.Break();
                    wrapper.Exception = new Exception($"Multiple results were found using {searcher.LogFormat()}");
                    return;
                }
            });
            var r = loopResults.IsCompleted;
            var wrapperIndex = 0;
            foreach (var w in wrappers)
            {
                if (w.Element != null)
                    return w.Element;
                if (w.Exception != null)
                    throw new AggregateException($"Error throw on xpath {wrapperIndex}", w.Exception);
                wrapperIndex++;
            }
            return null;
        }

        private IEnumerable<Element> FindElements(Selector selector, LoggingWebDriver loggingWebdriver)
        {
            var wrappers = selector.PrioritizedSearchers.Select(s => new Wrapper { Searcher = s }).ToList();
            var loopResults = Parallel.ForEach(wrappers, (wrapper, loopState) =>
            {
                var searcher = wrapper.Searcher;
                var results = searcher.SearchIn(loggingWebdriver, Prefixes);

                SuccessfulSearchers.Add(searcher);
                loopState.Break();
                wrapper.Elements = results;
                return;
            });
            var r = loopResults.IsCompleted;
            var index = 0;
            foreach (var w in wrappers)
            {
                if (w.Elements != null)
                    return w.Elements;
                if (w.Exception != null)
                    throw new AggregateException($"Error throw on xpath {index}", w.Exception);
                index++;
            }
            return null;
        }

        virtual public List<string> GetIdentifiers()
        {
            var options = new List<Tuple<By, Func<IWebElement, string>, List<string>>>()
            {
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//label"), (e)=>e.Text,  new List<string>()),
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//*[self::button or self::a or (self::input and @type='button')]"), (e)=>e.Text, new List<string>()),
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//*[@alt]"), (e)=>e.GetAttribute("alt"),  new List<string>()),
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//*[@name]"), (e)=>e.GetAttribute("name"),  new List<string>()),
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//*[@aria-label]"), (e)=>e.GetAttribute("aria-label"),  new List<string>()),
                new Tuple<By, Func<IWebElement,string>, List<string>>(
                    By.XPath("//*[@title]"), (e)=>e.GetAttribute("title"),  new List<string>()),
            };

            Parallel.ForEach(options, (option, loopState) =>
            {
                var elements = SeleniuimDriver.FindElements(option.Item1);
                foreach (var e in elements)
                {
                    try
                    {
                        option.Item3.Add(option.Item2(e));
                    }
                    catch
                    { }
                }
            });

            return options.SelectMany(o => o.Item3).Distinct().OrderBy(s => s.ToLower()).ToList();
        }

        public void ExecuteScript(string script)
            => ((IJavaScriptExecutor)SeleniuimDriver).ExecuteScript(script);

        public WebDriver Under(UnderSelectorPrefix under)
            => Prefix(under);

        public WebDriver ForRow(RowSelectorPrefix row)
            => Prefix(row);

        public WebDriver ForError()
            => Prefix(SelectorFactory.CreatePrefix<ErrorSelectorPrefix>());

        public WebDriver ForWarning()
            => Prefix(SelectorFactory.CreatePrefix<WarningSelectorPrefix>());

        public WebDriver Prefix(SelectorPrefix prefix)
        {
            var p = new ValidatedPrefix();
            var l = Prefixes.Concat(prefix);

            var possibles = l.CrossMultiply(); 
            RetryExecutor.RetryFor(() =>
               {
                   var iframes = SeleniuimDriver.FindElements(By.XPath("//iframe"));
                   var valid = possibles.AsParallel().AsOrdered().Where(xpath => SeleniuimDriver.FindElements(By.XPath(xpath)).Any()).ToList();
                   if (valid.Any())
                       p.Init("filtered", valid);
                   else if (iframes.Any())
                   {
                       foreach (var iframe in iframes)
                       {
                           try
                           {
                               SeleniuimDriver.SwitchTo().Frame(iframe);
                               valid = possibles.AsParallel().AsOrdered().Where(xpath => SeleniuimDriver.FindElements(By.XPath(xpath)).Any()).ToList();
                               if (valid.Any())
                                   p.Init("filtered", valid);
                           }
                           catch
                           { }
                       }
                       SeleniuimDriver.SwitchTo().DefaultContent();
                   }
                   if(!p.IsInitialized)
                       throw new Exception($"Was unable to find any that matched prefix, tried:{possibles.LogFormat()}");
               }, TimeSpan.FromMilliseconds(SeleniumGridConfiguration.RetryMs));

            var wdm = new WebDriver(
                SeleniuimDriver,
                RootUrl,
                SeleniumGridConfiguration,
                RetryExecutor,
                SelectorFactory,
                ElementFactory,
                XpathProvider,
                MovieLogger,
                new List<SelectorPrefix> { p }
                );

            Children.Add(wdm);
            return wdm;
        }

        public IEnumerable<byte[]> GetScreenshots()
        {
            foreach (var c in Children)
                foreach (var s in c.GetScreenshots())
                    yield return s;
            foreach (var s in Screenshots)
                yield return s;
            byte[] data = null;
            try
            {
                data = ((ITakesScreenshot)SeleniuimDriver).GetScreenshot().AsByteArray;
            }
            catch (OpenQA.Selenium.UnhandledAlertException) { }
            catch (OpenQA.Selenium.NoSuchWindowException) { }
            if (data != null)
                yield return data;
        }

        public void ResetScreenshots()
        {
            Children = new List<WebDriver>();
            Screenshots = new List<byte[]>();
        }

        public string LogFormat() => Url;

        public string PageSource { get => SeleniuimDriver.PageSource; }
        public string Url { get => SeleniuimDriver.Url; }
        public IEnumerable<string> Windows { get => SeleniuimDriver.WindowHandles; }
        public string AlertText
        {
            get
            {
                try
                {
                    return SeleniuimDriver.SwitchTo().Alert().Text;

                }
                catch
                {
                    return null;
                }
            }
        }

        public Size Size
        {
            get => SeleniuimDriver.Manage().Window.Size;
            set => SeleniuimDriver.Manage().Window.Size = value;
        }
        public bool HasAlert
        {
            get {
                try {
                    SeleniuimDriver.SwitchTo().Alert();
                    return true;
                }
                catch {
                    return false;
                }
            }
        }

        IWebDriver IWebDriverWrapper.IWebDriver => SeleniuimDriver;

        public bool Disposed { get; set; }
    }
}

