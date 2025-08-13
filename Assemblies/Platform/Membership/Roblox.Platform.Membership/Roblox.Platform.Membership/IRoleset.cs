namespace Roblox.Platform.Membership;

/// <summary>
/// A Roleset. 
/// Represents the a group of access permissions to various parts of the system.
/// </summary>
public interface IRoleset
{
	/// <summary>
	/// Id of the Roleset.
	/// </summary>
	int Id { get; }

	/// <summary>
	/// Name of the Roleset.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Rank of the Roleset.
	/// </summary>
	int Rank { get; }
}
