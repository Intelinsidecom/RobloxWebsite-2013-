using System;
using System.Collections.Generic;
using Roblox.Platform.Authentication;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.PolicyLookup;
using Roblox.RequestContext;

namespace Roblox.Platform.PolicyLookup;

/// <summary>
/// The default implementation for <see cref="T:Roblox.Platform.PolicyLookup.IUserPolicyLookup" />.
/// </summary>
public class UserPolicyLookup : IUserPolicyLookup
{
	private readonly IDefaultPolicyLookup _DefaultPolicyLookup;

	private readonly IGeolocationProvider _GeolocationProvider;

	private readonly IUserFactory _UserFactory;

	private readonly ICountryFactory _CountryFactory;

	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	private readonly IRoleSetValidator _RoleSetValidator;

	/// <summary>
	/// The default constructor for <see cref="T:Roblox.Platform.PolicyLookup.UserPolicyLookup" />.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Throws when either defaultPolicyLookup, geolocationProvider, userFactory, countryFactory, xboxLiveAccountDataAccessor, or roleSetValidator is null.</exception>
	public UserPolicyLookup(IDefaultPolicyLookup defaultPolicyLookup, IGeolocationProvider geolocationProvider, IUserFactory userFactory, ICountryFactory countryFactory, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IRoleSetValidator roleSetValidator)
	{
		_DefaultPolicyLookup = defaultPolicyLookup ?? throw new ArgumentNullException("defaultPolicyLookup");
		_GeolocationProvider = geolocationProvider ?? throw new ArgumentNullException("geolocationProvider");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_CountryFactory = countryFactory ?? throw new ArgumentNullException("countryFactory");
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor ?? throw new ArgumentNullException("xboxLiveAccountDataAccessor");
		_RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
	}

	/// <inheritdoc />
	public ICollection<Policy> GetApplicablePoliciesForTargetUser(IRequestContext requestContext, long targetUserId)
	{
		if (requestContext == null)
		{
			throw new ArgumentNullException("requestContext");
		}
		IUser targetUser = _UserFactory.GetUser(targetUserId);
		if (targetUser == null)
		{
			return new Policy[1];
		}
		string userCountryCode = null;
		IGeolocation userGeolocation = _GeolocationProvider.GetGeolocationByUser(targetUser);
		if (userGeolocation != null && userGeolocation.CountryId.HasValue)
		{
			userCountryCode = _CountryFactory.Get(userGeolocation.CountryId.Value)?.Code;
		}
		bool isXboxUser = _XboxLiveAccountDataAccessor.GetByAccountId(targetUser.AccountId) != null;
		bool isChinaLicenseUser = _RoleSetValidator.IsChinaLicenseUser(targetUser);
		bool isChinaBetaUser = _RoleSetValidator.IsChinaBetaUser(targetUser);
		return _DefaultPolicyLookup.GetApplicablePolicies(userCountryCode, isXboxUser, isChinaLicenseUser, isChinaBetaUser);
	}
}
