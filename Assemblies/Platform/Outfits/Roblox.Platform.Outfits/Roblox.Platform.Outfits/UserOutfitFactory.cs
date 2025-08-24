using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Paging;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Outfits;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Outfits.IUserOutfitFactory" />
/// </summary>
internal class UserOutfitFactory : IUserOutfitFactory
{
	private readonly OutfitDomainFactories _DomainFactories;

	private const int _RobloxUserId = 1;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.UserOutfitFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal UserOutfitFactory(OutfitDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUserOutfit GetUserOutfit(long id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException("id");
		}
		IUserOutfitEntity entity = _DomainFactories.UserOutfitEntityFactory.Get(id);
		if (entity != null)
		{
			return new UserOutfit(entity, _DomainFactories);
		}
		return null;
	}

	public IPagedResult<long, IUserOutfit> GetUserOutfitsPagedResult(IUser user, int startIndex, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (startIndex < 0)
		{
			throw new PlatformArgumentException("startIndex");
		}
		if (maxRows < 1)
		{
			throw new PlatformArgumentException("maxRows");
		}
		maxRows = Math.Min(maxRows, 100);
		return new PagedResult<long, IUserOutfit>
		{
			PageItems = GetUserOutfitsPaged(user, startIndex + 1, maxRows),
			Count = GetTotalNumberOfUserOutfits(user)
		};
	}

	public IEnumerable<IUserOutfit> GetUserOutfitsPaged(IUser user, int startIndex, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (startIndex <= 0)
		{
			throw new PlatformArgumentException("startIndex");
		}
		if (maxRows < 1)
		{
			throw new PlatformArgumentException("maxRows");
		}
		return from x in _DomainFactories.UserOutfitEntityFactory.GetByUserIdPaged(user.Id, startIndex, maxRows)
			select new UserOutfit(x, _DomainFactories);
	}

	public IEnumerable<IUserOutfit> GetUserOutfitsFilteredByIsEditablePaged(IUser user, bool isEditable, int startIndex, int maxRows)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (startIndex <= 0)
		{
			throw new PlatformArgumentException("startIndex");
		}
		if (maxRows < 1)
		{
			throw new PlatformArgumentException("maxRows");
		}
		return from x in _DomainFactories.UserOutfitEntityFactory.GetByUserIdIsEditablePaged(user.Id, isEditable, startIndex, maxRows)
			select new UserOutfit(x, _DomainFactories);
	}

	public int GetTotalNumberOfUserOutfits(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return _DomainFactories.UserOutfitEntityFactory.GetTotalNumberByUserId(user.Id);
	}

	public int GetTotalNumberOfEditableUserOutfits(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return _DomainFactories.UserOutfitEntityFactory.GetEditableCountByUserId(user.Id);
	}

	public IUserOutfit CreateFromOutfit(IUser user, IOutfit outfit, bool overrideToUneditable = false)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (outfit == null)
		{
			throw new PlatformArgumentNullException("outfit");
		}
		string outfitName = DefaultOutfitName(user);
		bool isEditable = user.Id != 1;
		if (overrideToUneditable)
		{
			isEditable = false;
		}
		IUserOutfitEntity entity = _DomainFactories.UserOutfitEntityFactory.CreateFromOutfit(outfit.ID, user.Id, outfitName, isEditable);
		if (entity == null)
		{
			return null;
		}
		UserOutfit userOutfit = new UserOutfit(entity, _DomainFactories);
		_DomainFactories.UserOutfitEntityFactory.OnCreated(userOutfit);
		return userOutfit;
	}

	private string DefaultOutfitName(IUser user)
	{
		return $"Outfit {GetTotalNumberOfEditableUserOutfits(user) + 1}";
	}

	public void RegisterUserOutfitCreatedEvent(Action<IUserOutfit> onUserOutfitCreated)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityCreated += onUserOutfitCreated;
	}

	public void UnregisterUserOutfitCreatedEvent(Action<IUserOutfit> onUserOutfitCreated)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityCreated -= onUserOutfitCreated;
	}

	public void RegisterUserOutfitUpdatedEvent(Action<IUserOutfit> onUserOutfitUpdated)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityUpdated += onUserOutfitUpdated;
	}

	public void UnregisterUserOutfitUpdatedEvent(Action<IUserOutfit> onUserOutfitUpdated)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityUpdated -= onUserOutfitUpdated;
	}

	public void RegisterUserOutfitDeletedEvent(Action<IUserOutfit> onUserOutfitDeleted)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityDeleted += onUserOutfitDeleted;
	}

	public void UnregisterUserOutfitDeletedEvent(Action<IUserOutfit> onUserOutfitDeleted)
	{
		_DomainFactories.UserOutfitEntityFactory.EntityDeleted -= onUserOutfitDeleted;
	}
}
