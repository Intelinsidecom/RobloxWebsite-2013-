using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public class XboxLiveCredentials : CredentialsBase, IXboxLiveCredentials, ICredentials
{
	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	public string XboxLivePairWiseId { get; }

	internal XboxLiveCredentials(string pairwiseId, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IUserFactory userFactory)
		: base(userFactory)
	{
		XboxLivePairWiseId = pairwiseId;
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor;
	}

	protected override IUser DoAuthentication()
	{
		IXboxLiveAccount account = _XboxLiveAccountDataAccessor.GetByXboxLivePairwiseId(XboxLivePairWiseId);
		if (account != null)
		{
			return base.UserFactory.GetUserByAccountId(account.AccountId);
		}
		return null;
	}
}
