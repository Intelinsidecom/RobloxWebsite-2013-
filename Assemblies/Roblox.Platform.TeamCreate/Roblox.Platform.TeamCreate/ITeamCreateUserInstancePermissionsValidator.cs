using Roblox.Platform.Membership;

namespace Roblox.Platform.TeamCreate;

/// <summary>
/// Validate that a user in TeamCreate has permission to edit the place, if not kick them.
/// </summary>
/// <seealso cref="T:Roblox.Platform.TeamCreate.ITeamCreateUserInstancePermissionsValidator" />
public interface ITeamCreateUserInstancePermissionsValidator
{
	/// <summary>
	/// Validates the team create user instances.
	/// Kicks users out of any team create sessions they no longer have permission to edit
	/// </summary>
	/// <param name="user">The user who's permissions to validate.</param>
	/// <exception cref="T:System.ArgumentNullException">On user is null.</exception>
	void ValidateTeamCreateUserInstances(IUser user);
}
