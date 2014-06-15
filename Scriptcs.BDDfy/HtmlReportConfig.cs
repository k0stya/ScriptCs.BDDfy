using TestStack.BDDfy.Processors.Reporters.Html;

namespace Scriptcs.BDDfy
{
	/// <summary>
	/// This overrides the default html report setting
	/// </summary>
	public class HtmlReportConfig : DefaultHtmlReportConfiguration
	{
		internal static string ReportPath { get; set; }

		public override string OutputPath
		{
			get { return ReportPath ?? base.OutputPath; }
		}
	}
}
