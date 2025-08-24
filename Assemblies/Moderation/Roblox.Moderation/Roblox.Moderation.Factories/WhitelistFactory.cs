using Roblox.ContentFilterApi.Client;
using Roblox.Platform.Moderation.Implementation;
using Roblox.Platform.Moderation.Interfaces;

namespace Roblox.Platform.Moderation.Factories;

public class WhitelistFactory
{
	private readonly ContentFilterClient _Client;

	public WhitelistFactory(ContentFilterClient client)
	{
		_Client = client;
	}

	public IWhitelist Get(CategoryType categoryType, long categoryTargetId)
	{
		return new Whitelist(_Client, categoryType, categoryTargetId);
	}
}
