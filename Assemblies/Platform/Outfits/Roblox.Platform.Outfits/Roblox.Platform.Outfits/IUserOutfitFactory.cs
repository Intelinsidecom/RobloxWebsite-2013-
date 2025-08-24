using System;
using System.Collections.Generic;
using Roblox.Paging;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Load and create <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s for a user
/// </summary>
public interface IUserOutfitFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> with the given ID, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the input Id is invalid.</exception>
	IUserOutfit GetUserOutfit(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s by their userId and start index, wrapping in <see cref="T:Roblox.Paging.IPagedResult`2" />
	/// </summary>
	/// <param name="user">The user</param>
	/// <param name="startIndex">The 0-Based starting row index of the user outfits to be returned</param>
	/// <param name="maxRows">The maximum number of rows to get</param>
	/// <returns>The <see cref="T:Roblox.Paging.IPagedResult`2" /> of a of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the startIndex is less than default(int) or maxRows is less than 1.</exception>
	IPagedResult<long, IUserOutfit> GetUserOutfitsPagedResult(IUser user, int startIndex, int maxRows);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s by their userId, whether they are editable and start index, wrapping in <see cref="T:Roblox.Paging.IPagedResult`2" />
	/// </summary>
	/// <param name="user">The user</param>
	/// <param name="isEditable">The filter value for whether a user outfit can be edited.</param>
	/// <param name="startIndex">The 1-Based starting row index of the user outfits to be returned</param>
	/// <param name="maxRows">The maximum number of rows to get</param>
	/// <returns>The <see cref="T:Roblox.Paging.IPagedResult`2" /> of a of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the startIndex is less than default(int) or maxRows is less than 1.</exception>
	IEnumerable<IUserOutfit> GetUserOutfitsFilteredByIsEditablePaged(IUser user, bool isEditable, int startIndex, int maxRows);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s by their userId and start index.
	/// </summary>
	/// <param name="user">The user</param>
	/// <param name="startIndex">The 1-based starting row index of the user outfits to be returned</param>
	/// <param name="maxRows">The maximum number of rows to get</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />s</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the startIndex is less than default(int) or maxRows is less than 1.</exception>
	IEnumerable<IUserOutfit> GetUserOutfitsPaged(IUser user, int startIndex, int maxRows);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> for a user from an existing outfit. 
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> of the new <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	/// <param name="outfit">The <see cref="T:Roblox.Platform.Outfits.IOutfit" /> to be created from</param>
	/// <param name="overrideToUneditable">Optional parameter that makes the outfit not editable.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> created from the existing outfit, , or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user or outfit is invalid.</exception>
	IUserOutfit CreateFromOutfit(IUser user, IOutfit outfit, bool overrideToUneditable = false);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> of a user.
	/// </summary>
	/// <param name="user">The user</param>
	/// <returns>The total number of outfits belong to this user</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user is null.</exception>
	int GetTotalNumberOfUserOutfits(IUser user);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> of a user, filtered by whether they are editable..
	/// </summary>
	/// <param name="user">The user</param>
	/// <returns>The total number of outfits belong to this user</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the input user is null.</exception>
	int GetTotalNumberOfEditableUserOutfits(IUser user);

	/// <summary>
	/// To register the OnCreated event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="onUserOutfitCreated">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is created</param>
	void RegisterUserOutfitCreatedEvent(Action<IUserOutfit> onUserOutfitCreated);

	/// <summary>
	/// To unregister the OnCreated event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="onUserOutfitCreated">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is created</param>
	void UnregisterUserOutfitCreatedEvent(Action<IUserOutfit> onUserOutfitCreated);

	/// <summary>
	/// To register the OnUpdated event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="onUserOutfitUpdated">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is updated</param>
	void RegisterUserOutfitUpdatedEvent(Action<IUserOutfit> onUserOutfitUpdated);

	/// <summary>
	/// To unregister the OnUpdated event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="onUserOutfitUpdated">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is updated</param>
	void UnregisterUserOutfitUpdatedEvent(Action<IUserOutfit> onUserOutfitUpdated);

	/// <summary>
	/// To register the OnDeleted event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="OnUserOutfitDeleted">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is deleted</param>
	void RegisterUserOutfitDeletedEvent(Action<IUserOutfit> OnUserOutfitDeleted);

	/// <summary>
	/// To unregister the OnDeleted event of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> by Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	/// <param name="OnUserOutfitDeleted">The action to be executed when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is deleted</param>
	void UnregisterUserOutfitDeletedEvent(Action<IUserOutfit> OnUserOutfitDeleted);
}
