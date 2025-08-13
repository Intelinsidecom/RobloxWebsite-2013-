using Roblox.TextFilter;

namespace Roblox.Platform.Groups;

/// <summary>
/// A public interface for creating GroupRoleSets.
/// </summary>
public interface IGroupRoleSetFactory
{
	/// <summary>
	/// Creates the new <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </summary>
	/// <param name="name">The name.</param>
	/// <param name="description">The description.</param>
	/// <param name="rank">The rank.</param>
	/// <param name="group">The group.</param>
	/// <param name="textAuthor">The text author.</param>
	/// <returns>
	/// The newly created <see cref="T:Roblox.Platform.Groups.IGroupRoleSet" />.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="group" /> or <paramref name="textAuthor" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="name" /> is null or empty or name length is exceeding 
	/// or
	/// if description length is exceeding.</exception>
	/// <exception cref="T:Roblox.Platform.Groups.PlatformGroupTextFullyModeratedException">Thrown if the <paramref name="name" /> or <paramref name="description" /> is moderated.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the underlying service is unavailable.</exception>
	IGroupRoleSet CreateNew(string name, string description, byte rank, IGroup group, ITextAuthor textAuthor);
}
