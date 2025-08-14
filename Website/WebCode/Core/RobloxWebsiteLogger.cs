using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.EventLog;
using Roblox.EventLog.Windows;

namespace Roblox.Website
{
    public class RobloxWebsiteLogger : Logger
	{
		public RobloxWebsiteLogger(bool removeLineBreaks = false)
			: base(
				  WebsiteSettings.Properties.WebsiteBootstrapSettings.Default.GeneralEventLogSource,
				  () => WebsiteSettings.Properties.WebsiteBootstrapSettings.Default.GeneralEventLogLevel,
				  removeLineBreaks
			)
		{
		}

		protected override void Log(LogLevel logLevel, string format, params object[] args)
		{
			/*string message = string.Format(
				"Error Detail:\r\n{0}\r\nException:\r\n{1}\r\nInner Exception:{2}\r\nException Source:\r\n{3}\r\nException TargetSite:\r\n{4}\r\nException Data:\r\n{5}",
				
			);*/
			string text = ((args != null && args.Length != 0) ? string.Format(format, args) : format);

			base.Log(logLevel, format, args);
		}
	}
}