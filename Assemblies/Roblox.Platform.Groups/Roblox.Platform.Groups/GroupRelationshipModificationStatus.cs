namespace Roblox.Platform.Groups;

public enum GroupRelationshipModificationStatus
{
	/// <summary>
	/// Success.
	/// </summary>
	Success,
	/// <summary>
	/// Trying to form relationship with self
	/// </summary>
	SelfError,
	/// <summary>
	/// Trying to form relationship with an existing or requested target
	/// </summary>
	DuplicateError,
	/// <summary>
	/// Does not have permission to create relationship
	/// </summary>
	PermissionError,
	/// <summary>
	/// Incorrect relationship type
	/// </summary>
	TypeError,
	/// <summary>
	/// Relationship does not exist
	/// </summary>
	DoesNotExist
}
