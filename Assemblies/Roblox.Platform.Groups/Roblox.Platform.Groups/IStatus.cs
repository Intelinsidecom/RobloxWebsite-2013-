using System;

namespace Roblox.Platform.Groups;

/// <summary>
/// A public interface representing the status message (aka "shout") of a group
/// </summary>
public interface IStatus
{
	/// <summary>
	/// The id of the group
	/// </summary>
	long GroupId { get; }

	/// <summary>
	/// The id of the user who submitted the status message.
	/// </summary>
	long PosterId { get; }

	/// <summary>
	/// The status message itself.
	/// </summary>
	string Message { get; }

	/// <summary>
	/// When the status was created
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// When the status was updated
	/// </summary>
	DateTime Updated { get; }
}
