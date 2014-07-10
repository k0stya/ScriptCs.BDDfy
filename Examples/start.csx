#load wikitest.csx

var runner = Require<BDDfyRunner>();

using FluentAutomation;
using NUnit.Framework;

var Test = Require<F14N>()  
    .Init<FluentAutomation.SeleniumWebDriver>()
    .Bootstrap("Chrome")
    .Config(settings => {
        // Easy access to FluentAutomation.Settings values
        settings.DefaultWaitUntilTimeout = TimeSpan.FromSeconds(1);
    });

runner.HtmlReportOutputPath = @"c:\OneDrive\Documents\Epam\Presentation\ScriptCs\Examples\3.TestAutomation\";
runner.RunAllTests();