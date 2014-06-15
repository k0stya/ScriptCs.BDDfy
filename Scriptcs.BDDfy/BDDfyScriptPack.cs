using ScriptCs.Contracts;
using ScriptCs.NUnit;
using TestStack.BDDfy.Configuration;
using TestStack.BDDfy.Processors.Reporters.Html;

namespace Scriptcs.BDDfy
{
	public class BDDfyScriptPack : IScriptPack
	{
		private NUnitScriptPack _nUnitScriptPack;

		public BDDfyScriptPack()
		{
			_nUnitScriptPack = new NUnitScriptPack();
		}

		public void Initialize(IScriptPackSession session)
		{
			_nUnitScriptPack.Initialize(session);

			session.ImportNamespace("Scriptcs.BDDfy");
			session.ImportNamespace("Scriptcs.BDDfy");
			session.ImportNamespace("NUnit.Framework");
		}

		public IScriptPackContext GetContext()
		{
			Configurator.BatchProcessors.Add(new HtmlReporter(new HtmlReportConfig()));
			return new BDDfyRunner((NUnitRunner)_nUnitScriptPack.GetContext());
		}

		public void Terminate()
		{
			_nUnitScriptPack.Terminate();
		}
	}
}