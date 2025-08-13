using System;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Provides a common interface for an object that represents a user outfit
/// </summary>
public interface IUserOutfit
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long Id { get; }

	/// <summary>
	/// Gets the Id of the <see cref="T:Roblox.Platform.Outfits.IOutfit" />.
	/// </summary>
	/// <value>
	/// The Id of the <see cref="T:Roblox.Platform.Outfits.IOutfit" />.
	/// </value>
	long OutfitId { get; }

	/// <summary>
	/// Gets the Id of the user.
	/// </summary>
	/// <value>
	/// The Id of the user.
	/// </value>
	long UserId { get; }

	/// <summary>
	/// Gets the Name of the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />.
	/// </summary>
	/// <value>
	/// The name of the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />.
	/// </value>
	string Name { get; }

	/// <summary>
	/// Gets the editability of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />.
	/// </summary>
	/// <value>
	/// Whether the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> can be modified.
	/// </value>
	bool IsEditable { get; }

	/// <summary>
	/// Gets the created.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Gets the updated.
	/// </summary>
	/// <value>
	/// The updated.
	/// </value>
	DateTime Updated { get; }

	/// <summary>
	/// Update the <see cref="T:Roblox.Platform.Outfits.IOutfit" /> of the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> to be the target <see cref="T:Roblox.Platform.Outfits.IOutfit" />
	/// </summary>
	/// <param name="outfit">The target <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	/// <param name="overrideIsEditable">Overrides the outfit being editable even if it's owned by Roblox. Do NOT pass this into this method unless you know exactly what you're doing.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input <see cref="T:Roblox.Platform.Outfits.IOutfit" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if the entity was not found while updating.</exception>
	void UpdateFromOutfit(IOutfit outfit, bool overrideIsEditable = false);

	/// <summary>
	/// Rename the current <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> with validation from TextFilter service
	/// </summary>
	/// <param name="name">The new name for the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	/// <param name="author">The <see cref="T:Roblox.TextFilter.Client.IClientTextAuthor" /> of the new name</param>
	/// <param name="textFilterClientV2">The <see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /> used for filtering</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the outfit name is invalid.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if text filter service is unavailable.</exception>
	/// <exception cref="T:Roblox.Platform.Outfits.PlatformOutfitTextFullyModeratedException">Thrown if the input name got fully moderated.</exception>
	void Rename(string name, IClientTextAuthor author, ITextFilterClientV2 textFilterClientV2);

	/// <summary>
	/// Rename the current <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />, skipping any text filtering. Only use if the text is coming from a trusted source.
	/// </summary>
	/// <param name="name">The new name for the <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the outfit name is invalid.</exception>
	void RenameNoValidation(string name);

	/// <summary>
	/// Delete this instance.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if the entity was not found while deleting.</exception>
	void Delete();
}
