using System.Reflection;
using ScriptCs.Contracts;
using ScriptCs.NUnit;
using TestStack.BDDfy.Configuration;
using TestStack.BDDfy.Processors;
using TestStack.BDDfy.Processors.Reporters.Html;

namespace Scriptcs.BDDfy
{
    public class BDDfyRunner : IScriptPackContext
    {
	    private readonly NUnitRunner _nUnitRunner;

	    public BDDfyRunner(NUnitRunner nUnitRunner)
	    {
		    _nUnitRunner = nUnitRunner;
	    }

	    public string HtmlReportOutputPath
	    {
		    set { HtmlReportConfig.ReportPath = value; }
	    }
		
		public void RunAllTests(Assembly testAssembly = null)
		{
			_nUnitRunner.RunAllUnitTests(testAssembly ?? Assembly.GetCallingAssembly());
			foreach (var item in Configurator.BatchProcessors.GetProcessors())
			{
				var reporter = item as HtmlReporter;
				if (reporter != null)
					reporter.Process(StoryCache.Stories);
			}
		}
    }
}
