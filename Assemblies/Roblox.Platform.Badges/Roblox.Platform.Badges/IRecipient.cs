namespace Roblox.Platform.Badges;

/// <summary>
/// Represents internal recipient DTO
/// </summary>
internal interface IRecipient
{
	/// <summary>
	/// Gets the type of the recipient target.
	/// </summary>
	string TargetType { get; }

	/// <summary>
	/// Gets the Id of the recipient target.
	/// </summary>
	long TargetId { get; }
}
