using Roblox.Platform.Core;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// An object to contain the response from changing a user object. T is expected to be an enum representing possible responses (success and failure reasons) for the change being made.
/// </summary>
public interface IChangeUserResult<T> : IResult<T> where T : struct
{
	/// <summary>
	/// The updated IUser object
	/// </summary>
	IUser User { get; }
}
