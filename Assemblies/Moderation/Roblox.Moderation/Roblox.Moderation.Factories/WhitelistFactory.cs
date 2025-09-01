using Roblox.ContentFilterApi.Client;
using Roblox.Moderation.Implementation;
using Roblox.Moderation.Interfaces;
namespace Roblox.Moderation.Factoriespublic {
    class WhitelistFactory

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


}
