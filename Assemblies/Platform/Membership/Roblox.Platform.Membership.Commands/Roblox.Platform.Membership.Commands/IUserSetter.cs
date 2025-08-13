using System;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// A platform object used to change user properties.
/// </summary>
public interface IUserSetter
{
	/// <summary>
	/// Sets the user's birthdate to the given value.
	/// First validates the birthdate and whether the user can perform the action, so caller does not need to validate.
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="newBirthdate">New value for the birthdate.</param>
	/// <param name="targetUser">The user changing their birthdate.</param>
	/// <param name="actorUser">The user performing the action.</param>
	/// <param name="checkAge">if set to <c>false</c> will skip check to see if user is under 13 before changing age. This should only be false when setting through CS.</param>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InvalidBirthdateException">Attempted to set a birthdate out of range, also <see cref="T:Roblox.Platform.Membership.Commands.IBirthdateValidator" />.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.UnauthorizedUserOperationException">The user cannot change their birthdate if they are under 13.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InsufficientAuthenticationMethodsException">Thrown if the user cannot disconnect social sign on, also <see cref="T:Roblox.Platform.Membership.Commands.IBirthdateValidator" />.</exception>
	void SetBirthdate(DateTime newBirthdate, IUser targetUser, IUser actorUser, bool checkAge = true);

	/// <summary>
	/// Saves age bracket and related privacy settings where birthdate is null
	/// (new user creation from certain platforms where such information is not available).
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="ageBracket">New value for the AgeBracket.</param>
	/// <param name="user">The user setting their AgeBracket.</param>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.ExplicitAgeBracketWithBirthdateException">Cannot set age bracket explicitly if the user already has a birthdate (age bracket should be derived from birthdate when available).</exception>
	void SetAgeBracket(AgeBracket ageBracket, IUser user);

	/// <summary>
	/// Sets the user's gender type.
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="genderType">New value for the genderType.</param>
	/// <param name="targetUser">The user changing their birthdate.</param>
	/// <param name="actorUser">The user performing the action.</param>
	void SetGenderType(GenderType genderType, IUser targetUser, IUser actorUser);

	/// <summary>
	/// Sets the user's birthdate and gender type.
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="newBirthdate">New value for the Birthdate.</param>
	/// <param name="genderType">New value for the GenderType.</param>
	/// <param name="targetUser">The user changing their birthdate.</param>
	/// <param name="actorUser">The user performing the action.</param>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InvalidBirthdateException">Attempted to set a birthdate out of range, also <see cref="T:Roblox.Platform.Membership.Commands.IBirthdateValidator" />.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.UnauthorizedUserOperationException">The user cannot change their birthdate if they are under 13.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InsufficientAuthenticationMethodsException">Thrown if the user cannot disconnect social sign on, also <see cref="T:Roblox.Platform.Membership.Commands.IBirthdateValidator" />.</exception>
	void SetBirthdateAndGenderType(DateTime newBirthdate, GenderType genderType, IUser targetUser, IUser actorUser);

	/// <summary>
	/// Saves age bracket, age-related privacy settings, and gender type for situations where birthdate is null
	/// (new user creation from certain platforms where such information is not available).
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="ageBracket">New value for the AgeBracket.</param>
	/// <param name="genderType">New value for the GenderType.</param>
	/// <param name="user">The new user setting their AgeBracket and GenderType.</param>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.ExplicitAgeBracketWithBirthdateException">Cannot set age bracket explicitly if the user already has a birthdate (age bracket should be derived from birthdate when available).</exception>
	void SetAgeBracketAndGenderTypeForNewUser(AgeBracket ageBracket, GenderType genderType, IUser user);

	/// <summary>
	/// Saves the given description as the "User Blurb".
	/// Note that the value will be filtered before being committed.
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="description">The new value for the user description / blurb</param>
	/// <param name="user">The user setting their description.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException"></exception>
	void SetDescription(string description, IUser user);

	/// <summary>
	/// Check to see if the current data is reflected by the audit system.
	/// If there is a discrepency, backfill an audit entry for the current data with acknowledgement that we don't know when the data was set.
	/// [WARNING] This method does not update the properties on the original IUser.
	/// If the <see cref="T:Roblox.Platform.Membership.IUser" /> needs to have the updated properties, then grab a new IUser using the <see cref="T:Roblox.Platform.Membership.IUserFactory" />
	/// </summary>
	/// <param name="user">The user this is called for.</param>
	void BackfillUnauditedPastData(IUser user);

	/// <summary>
	/// Updates the user's name (if the name is valid and legal), and records the previous name in the history log. Does not handle the purchasing of the new username.
	/// WARNING: Not meant to be used by CS (as implemented). Does not check roleset/elevated action permissions on the actor.
	/// If the actor is the roblox system user (ie, the request is coming from a processor), we skip all validation other than that the name does not already exist.
	/// </summary>
	/// <param name="user">The user whose name is changing</param>
	/// <param name="newName">The proposed new name</param>
	/// <param name="actor">Who is initiating this request. Processors should pass the Roblox IUser.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the <paramref name="user" /> is null</exception>
	/// <exception cref="T:System.InvalidOperationException">Thrown if the AccountId of the <paramref name="user" /> returns a null entity object (ie, the accountid is invalid)</exception>
	IChangeUserResult<UsernameValidatorResultCode> SetName(IUser user, string newName, IUser actor);

	/// <summary>
	/// Sets the status of the underlying Account entity.
	/// </summary>
	/// <param name="actor">Who is initiating this request. Processors should pass the Roblox IUser.</param>
	/// <returns>Returns false if an error occurred. True if successful.</returns>
	IChangeUserResult<AccountStatusChangeResponseCode> SetAccountStatus(IUser user, AccountStatus newStatus, IUser actor);
}
