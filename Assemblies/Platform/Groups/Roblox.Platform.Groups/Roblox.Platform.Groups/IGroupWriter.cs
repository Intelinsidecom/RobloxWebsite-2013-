using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <summary>
/// A class for group actions that modify existing groups
/// </summary>
public interface IGroupWriter
{
	/// <summary>
	/// update a groups name
	/// </summary>
	/// <param name="group"><see cref="T:Roblox.Platform.Groups.IGroup" /></param>
	/// <param name="newName">the new name</param>
	/// <param name="textAuthor"><see cref="T:Roblox.TextFilter.ITextAuthor" /></param>
	void UpdateName(IGroup group, string newName, ITextAuthor textAuthor);

	/// <summary>
	/// update a groups description
	/// </summary>
	/// <param name="group"><see cref="T:Roblox.Platform.Groups.IGroup" /></param>
	/// <param name="newDescription">the new description</param>
	/// <param name="textAuthor"><see cref="T:Roblox.TextFilter.ITextAuthor" /></param>
	void UpdateDescription(IGroup group, string newDescription, ITextAuthor textAuthor);

	void UpdateEmblem(IGroup group, long emblemId);

	/// <summary>
	/// Update a groups settings
	/// </summary>
	/// <param name="group"><see cref="T:Roblox.Platform.Groups.IGroup" /></param>
	/// <param name="bcOnly">only builders club?</param>
	/// <param name="publicEntryAllowed">public entry allowed?</param>
	void UpdateSettings(IGroup group, bool? bcOnly, bool? publicEntryAllowed);
}
