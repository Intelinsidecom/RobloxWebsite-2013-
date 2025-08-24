namespace Roblox.Platform.Assets.Client.Properties
{
	public class Settings
	{
		private static readonly Settings _Default = new Settings();
		
		public static Settings Default => _Default;
		
		public string AssetsServiceEndpoint => "https://assets.roblox.com";
		
		public int AssetsServiceTimeoutMs => 30000;
	}
}
