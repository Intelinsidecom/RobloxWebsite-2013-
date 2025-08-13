namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Interface for validation of usernames.
/// </summary>
public interface IUsernameValidator
{
	/// <summary>
	/// Validates the username for signup. This also checks if the username provided is available to use and passes filtering rules.
	/// </summary>
	/// <param name="username">The username.</param>
	/// <param name="ageBracket">The age bracket of the user trying to sign up.</param>
	/// <param name="mustUsePiiFiltersForU13Usernames">if set to <c>true</c> [should use pii filters for u13 users].</param>
	/// <param name="canBypassReservedUsername">If request can bypass the reserved username filter</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" /> based on the passed in <paramref name="username" />
	/// </returns>
	IUsernameValidationResult ValidateUsername(string username, AgeBracket ageBracket, bool mustUsePiiFiltersForU13Usernames, bool canBypassReservedUsername = false);

	/// <summary>
	/// Checks if the username is valid to use. This also checks if the username provided is available to use and passes filtering rules.
	/// The passed in user must be a valid <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="username">The username that needs validation.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> for which the username needs validation against.</param>
	/// <param name="mustUsePiiFiltersForU13Usernames">if set to <c>true</c> [should use pii filters for u13 users].</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" /> based on the passed in <paramref name="username" />.
	/// </returns>
	IUsernameValidationResult ValidateUsername(string username, IUser user, bool mustUsePiiFiltersForU13Usernames);

	/// <summary>
	/// Determines whether the specified username is legal under the username validation rules.
	/// NOTE:  DO NOT use this method usless you know what you are doing.
	/// This method determines whether the username is legal under the validation rules.
	/// This method does not check if the username is available to use and also does not check if the username can be validated against the filtering rules.
	/// </summary>
	/// <param name="username">The username.</param>
	/// <returns>
	/// A <see cref="T:Roblox.Platform.Membership.Commands.IUsernameValidationResult" /> based in the passed in <paramref name="username" />.
	/// </returns>
	IUsernameValidationResult IsUserNameLegal(string username);

	/// <summary>
	/// Returns whether the specified <paramref name="username" /> is available to use for the provided <paramref name="user" />.
	/// This method does not check the username against validation rules and filtering rules.
	/// </summary>
	/// <param name="username">The username.</param>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>
	///   <c>true</c> if [the speecified username is available for the user] ; otherwise, <c>false</c>.
	/// </returns>
	bool IsUsernameAvailable(string username, IUser user);
}
