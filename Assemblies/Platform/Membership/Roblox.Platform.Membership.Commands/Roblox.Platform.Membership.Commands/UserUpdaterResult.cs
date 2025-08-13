namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Result of the updater execution
/// </summary>
public struct UserUpdaterResult
{
	/// <summary>
	/// Result of last command
	/// </summary>
	public readonly UserUpdateCommandResult CommandResult;

	/// <summary>
	/// Updated user if available
	/// </summary>
	public readonly IUser UpdatedUser;

	/// <summary>
	/// Default Constructor
	/// </summary>
	/// <param name="result"><see cref="T:Roblox.Platform.Membership.Commands.UserUpdateCommandResult" /></param>
	/// <param name="updatedUser"><see cref="F:Roblox.Platform.Membership.Commands.UserUpdaterResult.UpdatedUser" /></param>
	public UserUpdaterResult(UserUpdateCommandResult result, IUser updatedUser)
	{
		CommandResult = result;
		UpdatedUser = updatedUser;
	}

	/// <summary>
	/// Creates result with null user
	/// </summary>
	/// <param name="result"><see cref="T:Roblox.Platform.Membership.Commands.UserUpdateCommandResult" /></param>
	/// <returns><see cref="T:Roblox.Platform.Membership.Commands.UserUpdaterResult" /></returns>
	public static UserUpdaterResult CreateWithNoUser(UserUpdateCommandResult result)
	{
		return new UserUpdaterResult(result, null);
	}
}
