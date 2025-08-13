using System;

namespace Roblox.Platform.Groups;

/// <summary>
/// An interface representing a Group Wall Post
/// </summary>
public interface IWallPost
{
	/// <summary>
	/// The identifier
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The id of the group the wall post is associated with.
	/// </summary>
	long GroupId { get; }

	/// <summary>
	/// The id of the user who made the post.
	/// </summary>
	long UserId { get; }

	/// <summary>
	/// The contents of the post.
	/// </summary>
	string Value { get; }

	/// <summary>
	/// When the post was created
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// When the post was last modified
	/// </summary>
	DateTime Updated { get; }
}
