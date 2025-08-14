namespace Roblox.ContentFilter.Client.Properties
{
	public class Settings
	{
		private static Settings _default;
		
		public static Settings Default
		{
			get
			{
				if (_default == null)
				{
					_default = new Settings();
				}
				return _default;
			}
		}
		
		public string WebSiteApiKey => "";
		
		public string ContentFilterApiKey => "";
	}
}
