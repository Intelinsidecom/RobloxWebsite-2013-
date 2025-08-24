using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Core;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Outfits;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
/// </summary>
internal class UserOutfit : IUserOutfit
{
	private readonly OutfitDomainFactories _DomainFactories;

	public long Id { get; }

	public long OutfitId { get; private set; }

	public long UserId { get; }

	public string Name { get; private set; }

	public bool IsEditable { get; }

	public DateTime Created { get; }

	public DateTime Updated { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.UserOutfit" /> class
	/// </summary>
	/// <param name="entity">The entity</param>
	/// <param name="domainFactories">The domain factories</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal UserOutfit(IUserOutfitEntity entity, OutfitDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.Id;
		OutfitId = entity.OutfitId;
		UserId = entity.UserId;
		Name = entity.Name;
		IsEditable = entity.IsEditable;
		Created = entity.Created;
		Updated = entity.Updated;
		_DomainFactories = domainFactories;
	}

	public void UpdateFromOutfit(IOutfit outfit, bool overrideIsEditable = false)
	{
		if (outfit == null)
		{
			throw new PlatformArgumentNullException("outfit");
		}
		if (outfit.ID != OutfitId)
		{
			IUserOutfitEntity entity = _DomainFactories.UserOutfitEntityFactory.Get(Id);
			if (entity == null)
			{
				throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity");
			}
			if (!((entity.IsEditable && !overrideIsEditable) || overrideIsEditable))
			{
				throw new PlatformPermissionDeniedException("Cannot update a user outfit created by Roblox.");
			}
			entity.OutfitId = outfit.ID;
			entity.Update();
			OutfitId = outfit.ID;
			_DomainFactories.UserOutfitEntityFactory.OnUpdated(this);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Outfits.IUserOutfit.Rename(System.String,Roblox.TextFilter.Client.IClientTextAuthor,Roblox.TextFilter.Client.ITextFilterClientV2)" />&gt;
	public void Rename(string name, IClientTextAuthor author, ITextFilterClientV2 textFilterClientV2)
	{
		if (!_DomainFactories.OutfitRulesManager.IsValidName(name))
		{
			throw new PlatformArgumentException($"Invalid outfit name supplied: {name}");
		}
		if (author == null)
		{
			throw new PlatformArgumentNullException("author");
		}
		FilterTextResult filteredResult;
		try
		{
			filteredResult = textFilterClientV2.FilterText(
				name,
				author,
				(TextFilterUsage)Enum.Parse(typeof(TextFilterUsage), "OutfitName_Rename", ignoreCase: true),
				"",
				false);
		}
		catch (Exception ex)
		{
			throw new PlatformOperationUnavailableException("Cannot filter the name", ex);
		}
		if (filteredResult.ModerationLevel == 3)
		{
			throw new PlatformOutfitTextFullyModeratedException("name");
		}
		SetName(filteredResult.FilteredText);
	}

	public void RenameNoValidation(string name)
	{
		SetName(name);
	}

	private void SetName(string name)
	{
		IUserOutfitEntity obj = _DomainFactories.UserOutfitEntityFactory.Get(Id) ?? throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity");
		obj.Name = name;
		obj.Update();
		Name = name;
	}

	public void Delete()
	{
		(_DomainFactories.UserOutfitEntityFactory.Get(Id) ?? throw new PlatformDataIntegrityException("Unable to retrive a non-persistent entity")).Delete();
		_DomainFactories.UserOutfitEntityFactory.OnDeleted(this);
	}
}

// Merge-in of the source entity to avoid separate files.
namespace Roblox.Outfits
{
    public class UserOutfit : IRobloxEntity<long, UserOutfitDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
    {
        private UserOutfitDAL _EntityDAL;

        public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UserOutfit).ToString(), isNullCacheable: true);

        public long ID => _EntityDAL.ID;

        public long OutfitID
        {
            get { return _EntityDAL.OutfitID; }
            set { _EntityDAL.OutfitID = value; }
        }

        public long UserID
        {
            get { return _EntityDAL.UserID; }
            set { _EntityDAL.UserID = value; }
        }

        public string Name
        {
            get { return _EntityDAL.Name; }
            set { _EntityDAL.Name = value; }
        }

        public DateTime Created
        {
            get { return _EntityDAL.Created; }
            set { _EntityDAL.Created = value; }
        }

        public DateTime Updated
        {
            get { return _EntityDAL.Updated; }
            set { _EntityDAL.Updated = value; }
        }

        public bool IsEditable
        {
            get { return _EntityDAL.IsEditable; }
            set { _EntityDAL.IsEditable = value; }
        }

        public CacheInfo CacheInfo => EntityCacheInfo;

        public UserOutfit()
        {
            _EntityDAL = new UserOutfitDAL();
        }

        public UserOutfit(UserOutfitDAL userOutfitDAL)
        {
            _EntityDAL = userOutfitDAL;
        }

        public void Delete()
        {
            EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
        }

        public void Save()
        {
            EntityHelper.SaveEntityWithRemoteCache(this, delegate
            {
                _EntityDAL.Created = DateTime.Now;
                _EntityDAL.Updated = _EntityDAL.Created;
                _EntityDAL.Insert();
            }, delegate
            {
                _EntityDAL.Updated = DateTime.Now;
                _EntityDAL.Update();
            });
        }

        public static UserOutfit CreateNew(long outfitid, long userId, string name, bool isEditable)
        {
            UserOutfit userOutfit = new UserOutfit();
            userOutfit.OutfitID = outfitid;
            userOutfit.UserID = userId;
            userOutfit.Name = name;
            userOutfit.IsEditable = isEditable;
            userOutfit.Save();
            return userOutfit;
        }

        public static UserOutfit Get(long id)
        {
            return EntityHelper.GetEntity<long, UserOutfitDAL, UserOutfit>(EntityCacheInfo, id, () => UserOutfitDAL.Get(id));
        }

        public static ICollection<UserOutfit> MultiGet(ICollection<long> ids)
        {
            return EntityHelper.MultiGetEntity<long, UserOutfitDAL, UserOutfit>(ids, EntityCacheInfo, UserOutfitDAL.MultiGet);
        }

        public static ICollection<UserOutfit> GetUserOutfitsByUserIDPaged(long userId, int startRowIndex, int maximumRows)
        {
            string collectionId = $"GetUserOutfitIDsByUserIDPaged_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
            return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => UserOutfitDAL.GetUserOutfitIDsByUserIDPaged(userId, startRowIndex, maximumRows), MultiGet);
        }

        public static ICollection<UserOutfit> GetUserOutfitsByUserIDIsEditablePaged(long userId, bool isEditable, int startRowIndex, int maximumRows)
        {
            string collectionId = $"GetUserOutfitIDsByUserIDIsEditablePaged_UserID:{userId}_IsEditable:{isEditable}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
            return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => UserOutfitDAL.GetUserOutfitIDsByUserIDIsEditablePaged(userId, isEditable, startRowIndex, maximumRows), MultiGet);
        }

        public static int GetTotalNumberOfUserOutfitsByUserID(long userId)
        {
            string countId = $"GetTotalNumberOfUserOutfitsByUserID_UserID:{userId}";
            return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countId, () => UserOutfitDAL.GetTotalNumberOfUserOutfitsByUserID(userId));
        }

        public static int GetTotalNumberOfEditableUserOutfitsByUserID(long userId)
        {
            string countId = $"GetTotalNumberOfEditableUserOutfitsByUserID_UserID:{userId}";
            return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), countId, () => UserOutfitDAL.GetTotalNumberOfEditableUserOutfitsByUserID(userId));
        }

        public object GetSerializable()
        {
            return _EntityDAL;
        }

        public void Construct(UserOutfitDAL dal)
        {
            _EntityDAL = dal;
        }

        public IEnumerable<string> BuildEntityIDLookups()
        {
            yield break;
        }

        public IEnumerable<StateToken> BuildStateTokenCollection()
        {
            yield return new StateToken($"UserID:{UserID}");
        }
    }
}
