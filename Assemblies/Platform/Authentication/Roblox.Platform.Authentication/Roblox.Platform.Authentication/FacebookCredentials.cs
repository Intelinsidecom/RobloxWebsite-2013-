using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

internal class FacebookCredentials : CredentialsBase, IFacebookCredentials, ICredentials
{
	private readonly IFacebookAccountDataAccessor _FacebookAccountDataAccessor;

	public ulong FacebookId { get; }

	internal FacebookCredentials(ulong facebookId, IUserFactory userFactory)
		: base(userFactory)
	{
		FacebookId = facebookId;
		_FacebookAccountDataAccessor = new FacebookAccountDataAccessor();
	}

	protected override IUser DoAuthentication()
	{
		IFacebookAccount facebookAccount = _FacebookAccountDataAccessor.GetByFacebookId(FacebookId);
		if (facebookAccount != null)
		{
			return base.UserFactory.GetUserByAccountId(facebookAccount.AccountId);
		}
		return null;
	}
}
