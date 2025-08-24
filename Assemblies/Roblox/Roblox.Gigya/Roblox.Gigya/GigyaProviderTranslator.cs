namespace Roblox.Gigya;

/// <summary>
/// This class is used to convert a GigyaProvider to its equivalent string and vice versa
/// </summary>
public class GigyaProviderTranslator
{
	private const string _Facebook = "facebook";

	private const string _WeChat = "wechat";

	public static string TranslateFromGigyaProvider(GigyaProviderType provider)
	{
		return provider switch
		{
			GigyaProviderType.Facebook => "facebook", 
			GigyaProviderType.WeChat => "wechat", 
			_ => string.Empty, 
		};
	}

	public static GigyaProviderType TranslateToGigyaProvider(string provider)
	{
		if (!(provider == "facebook"))
		{
			if (provider == "wechat")
			{
				return GigyaProviderType.WeChat;
			}
			return GigyaProviderType.Unknown;
		}
		return GigyaProviderType.Facebook;
	}
}
