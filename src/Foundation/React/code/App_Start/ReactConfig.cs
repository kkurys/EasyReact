using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Sitecore.Foundation.React.ReactConfig), "Configure")]

namespace Sitecore.Foundation.React
{
	using System.Web.Mvc;
	using Sitecore.Foundation.React.Mvc;
    using JavaScriptEngineSwitcher.Core;
    using JavaScriptEngineSwitcher.V8;

    public static class ReactConfig
	{
		public static void Configure()
		{
			ViewEngines.Engines.Add(new JsxViewEngine());

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

            ReactSiteConfiguration.Configuration
                .SetReuseJavaScriptEngines(true);
        }
	}
}