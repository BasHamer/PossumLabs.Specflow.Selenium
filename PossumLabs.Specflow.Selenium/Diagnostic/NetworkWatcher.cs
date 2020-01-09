﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PossumLabs.Specflow.Selenium.Diagnostic
{
    public class NetworkWatcher
    {
        public Predicate<string> UrlErrorTester { get; set; }
        public void AddUrl(string url)
        {
            if(UrlErrorTester!= null && UrlErrorTester(url))
                ErrorOut(url);
            LastGoodUrl = url;
        }
        public void ErrorOut(string url)
        {
            BadUrl = url;
            throw new Exception("Network Watcher notified of invalid url, terminating test.");
        }

        public string LastGoodUrl { get; private set; }
        public string BadUrl { get; private set; }

        public string LogFormat()
        {
            return $"network watcher\n" +
                $">begin\n" +
                $"> last good url: {LastGoodUrl}\n"+
                $"> bad url: {BadUrl}\n"+
                $">end\n";
        }
    }
}
