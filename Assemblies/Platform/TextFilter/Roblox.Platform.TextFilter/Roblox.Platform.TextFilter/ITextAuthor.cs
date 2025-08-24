namespace Roblox.TextFilter;

/// <summary>
/// Fields required by Moderation to identify the Author of a given piece of text.
/// </summary>
public interface ITextAuthor
{
	/// <summary>
	/// The Id of the Author, typically User.Id
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The Name of the Author, typically username.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Is the user Under 13.
	/// </summary>
	bool IsUnder13 { get; }
}
