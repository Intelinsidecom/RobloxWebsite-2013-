using System;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// A platform object used to validate birthdate changes for users.
/// </summary>
public interface IBirthdateChangeValidator
{
	/// <summary>
	/// Determines if a user is currently over 13 years old and if so, whether changing to the new Birthdate
	/// will make them under 13 years old.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="nowDate">The current date.</param>
	/// <param name="newBirthdate">The birthdate.</param>
	/// <returns>True if current over 13 and new birthdate is under 13, false otherwise. </returns>
	bool Is13OrOverToUnder13Change(IUser user, DateTime nowDate, DateTime newBirthdate);

	/// <summary>
	/// Validates whether the given user is allowed to change to the newBirthdate based on the given parameters.
	/// </summary>
	/// <param name="user">The user.</param>
	/// <param name="nowDate">The current date.</param>
	/// <param name="newBirthdate">The new birthdate.</param>
	/// <param name="checkAge">if set to <c>false</c> will skip check to see if user is under 13 before changing age. This should only be false when setting through CS.</param>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InvalidBirthdateException">Thrown if the given newBirthdate is in an invalid date for a birthdate.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.UnauthorizedUserOperationException">The user cannot change their birthdate if they are under 13.</exception>
	/// <exception cref="T:Roblox.Platform.Membership.Commands.InsufficientAuthenticationMethodsException">Thrown if the user is changing from over 13 to under 13 and cannot disconnect social sign on.</exception>
	void ValidateBirthdateChange(IUser user, DateTime nowDate, DateTime newBirthdate, bool checkAge);
}
