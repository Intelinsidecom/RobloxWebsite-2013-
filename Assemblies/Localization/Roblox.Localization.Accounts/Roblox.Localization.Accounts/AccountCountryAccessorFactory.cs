using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
namespace Roblox.Localization.Accounts {
    class AccountCountryAccessorFactory

{
	public static IAccountCountryAccessor GetAccountCountryAccessor(IUserFactory userFactory)
	{
		return new AccountCountryAccessor(new AccountCountryEntityFactory(), new CountryFactory());
	}
}


}
