using System;
using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

internal interface IUserOutfitEntityFactory : IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	/// <summary>
	/// OnCreated Event for <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> to be used in Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	event Action<IUserOutfit> EntityCreated;

	/// <summary>
	/// OnUpdated Event for <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> to be used in Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	event Action<IUserOutfit> EntityUpdated;

	/// <summary>
	/// OnDeleted Event for <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> to be used in Platform.Avatar.RecentAvatarItemListener
	/// </summary>
	event Action<IUserOutfit> EntityDeleted;

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> with the given ID, or null if none existed.</returns>
	IUserOutfitEntity Get(long id);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" />s by their userId and startIndex
	/// </summary>
	/// <param name="userId">The userId.</param>
	/// <param name="startIndex">The 1-base begining row number of entities to be returned</param>
	/// <param name="maxRows">The maximum number of rows to get</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" />s</returns>
	IEnumerable<IUserOutfitEntity> GetByUserIdPaged(long userId, int startIndex, int maxRows);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" />s by their userId, filtered by IsEditable and startIndex
	/// </summary>
	/// <param name="userId">The userId.</param>
	/// <param name="isEditable">Whethr we want editable outfits or non-editable outfits.</param>
	/// <param name="startIndex">The 1-base begining row number of entities to be returned</param>
	/// <param name="maxRows">The maximum number of rows to get</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" />s</returns>
	IEnumerable<IUserOutfitEntity> GetByUserIdIsEditablePaged(long userId, bool isEditable, int startIndex, int maxRows);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> of a user
	/// </summary>
	/// <param name="userId">The Id of the user</param>
	/// <returns>The total number of outfits that belong to this user</returns>
	int GetTotalNumberByUserId(long userId);

	/// <summary>
	/// Gets the total number of <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> of a user that are editable.
	/// </summary>
	/// <param name="userId">The Id of the user</param>
	/// <returns>The total number of editable outfits that belong to this user</returns>
	int GetEditableCountByUserId(long userId);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> for a user from an existing outfit
	/// </summary>
	/// <param name="outfitId">The Id of the existing outfit</param>
	/// <param name="userId">The Id of the user</param>
	/// <param name="outfitName">The name of the new outfit</param>
	/// <param name="isEditable">Boolean indicating if the userOutfit can be modified</param>
	/// <returns>The <see cref="T:Roblox.Platform.Outfits.IUserOutfitEntity" /> created from the existing outfit</returns>
	IUserOutfitEntity CreateFromOutfit(long outfitId, long userId, string outfitName, bool isEditable = true);

	/// <summary>
	/// To invoke the EntityCreated event when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is created
	/// </summary>
	/// <param name="userOutfit">The created <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	void OnCreated(IUserOutfit userOutfit);

	/// <summary>
	/// To invoke the EntityUpdated event when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is updated
	/// </summary>
	/// <param name="userOutfit">The updated <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	void OnUpdated(IUserOutfit userOutfit);

	/// <summary>
	/// To invoke the EntityDeleted event when a <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> is deleted
	/// </summary>
	/// <param name="userOutfit">The deleted <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /></param>
	void OnDeleted(IUserOutfit userOutfit);
}
