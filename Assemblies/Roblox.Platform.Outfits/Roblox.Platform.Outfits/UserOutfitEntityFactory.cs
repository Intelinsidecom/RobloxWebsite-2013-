using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Outfits;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

internal class UserOutfitEntityFactory : IUserOutfitEntityFactory, IDomainFactory<OutfitDomainFactories>, IDomainObject<OutfitDomainFactories>
{
	public OutfitDomainFactories DomainFactories { get; }

	public event Action<IUserOutfit> EntityCreated;

	public event Action<IUserOutfit> EntityUpdated;

	public event Action<IUserOutfit> EntityDeleted;

	internal UserOutfitEntityFactory(OutfitDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUserOutfitEntity Get(long id)
	{
		return CalToEntity(Roblox.Outfits.UserOutfit.Get(id));
	}

	private static IUserOutfitEntity CalToEntity(Roblox.Outfits.UserOutfit cal)
	{
		if (cal != null)
		{
			return new UserOutfitEntity
			{
				Id = cal.ID,
				OutfitId = cal.OutfitID,
				UserId = cal.UserID,
				Name = cal.Name,
				IsEditable = cal.IsEditable,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	public IEnumerable<IUserOutfitEntity> GetByUserIdPaged(long userId, int startIndex, int maxRows)
	{
		return Roblox.Outfits.UserOutfit.GetUserOutfitsByUserIDPaged(userId, startIndex, maxRows).Select(CalToEntity);
	}

	public IEnumerable<IUserOutfitEntity> GetByUserIdIsEditablePaged(long userId, bool isEditable, int startIndex, int maxRows)
	{
		return Roblox.Outfits.UserOutfit.GetUserOutfitsByUserIDIsEditablePaged(userId, isEditable, startIndex, maxRows).Select(CalToEntity);
	}

	public int GetTotalNumberByUserId(long userId)
	{
		return Roblox.Outfits.UserOutfit.GetTotalNumberOfUserOutfitsByUserID(userId);
	}

	public int GetEditableCountByUserId(long userId)
	{
		return Roblox.Outfits.UserOutfit.GetTotalNumberOfEditableUserOutfitsByUserID(userId);
	}

	public IUserOutfitEntity CreateFromOutfit(long outfitId, long userId, string outfitName, bool isEditabe = true)
	{
		return CalToEntity(Roblox.Outfits.UserOutfit.CreateNew(outfitId, userId, outfitName, isEditabe));
	}

	public void OnCreated(IUserOutfit userOutfit)
	{
		this.EntityCreated?.Invoke(userOutfit);
	}

	public void OnUpdated(IUserOutfit userOutfit)
	{
		this.EntityUpdated?.Invoke(userOutfit);
	}

	public void OnDeleted(IUserOutfit userOutfit)
	{
		this.EntityDeleted?.Invoke(userOutfit);
	}
}
