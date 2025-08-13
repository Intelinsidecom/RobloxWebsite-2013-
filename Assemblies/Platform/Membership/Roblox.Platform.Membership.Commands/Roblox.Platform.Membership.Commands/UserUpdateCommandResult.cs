namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Result of the command execution
/// </summary>
public struct UserUpdateCommandResult
{
	/// <summary>
	/// Represents a success result
	/// </summary>
	public static readonly UserUpdateCommandResult Success = new UserUpdateCommandResult(UserUpdateResultCode.Success, 0);

	/// <summary>
	/// Result code
	/// </summary>
	public readonly UserUpdateResultCode ResultCode;

	/// <summary>
	/// Miscellaneous result code, if available. Means nothing if it is not interpreted.
	/// </summary>
	public readonly int InnerResultCode;

	/// <summary>
	/// Default Constructor
	/// </summary>
	/// <param name="resultCode"><see cref="T:Roblox.Platform.Membership.Commands.UserUpdateResultCode" /></param>
	/// <param name="innerResultCode"><see cref="F:Roblox.Platform.Membership.Commands.UserUpdateCommandResult.InnerResultCode" /></param>
	public UserUpdateCommandResult(UserUpdateResultCode resultCode, int innerResultCode)
	{
		ResultCode = resultCode;
		InnerResultCode = innerResultCode;
	}
}
