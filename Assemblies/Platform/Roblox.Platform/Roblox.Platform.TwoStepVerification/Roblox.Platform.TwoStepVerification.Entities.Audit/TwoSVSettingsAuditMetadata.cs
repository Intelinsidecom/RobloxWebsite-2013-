using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoSVSettingsAuditMetadata : IRobloxEntity<long, TwoSVSettingsAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private TwoSVSettingsAuditMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TwoSVSettingsAuditMetadata).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid TwoStepVerificationSettingsAuditEntriesPublicID
	{
		get
		{
			return _EntityDAL.TwoStepVerificationSettingsAuditEntriesPublicID;
		}
		set
		{
			_EntityDAL.TwoStepVerificationSettingsAuditEntriesPublicID = value;
		}
	}

	internal long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	internal long? ActorUserID
	{
		get
		{
			return _EntityDAL.ActorUserID;
		}
		set
		{
			_EntityDAL.ActorUserID = value;
		}
	}

	internal byte TwoStepVerificationChangeTypeID
	{
		get
		{
			return _EntityDAL.TwoStepVerificationChangeTypeID;
		}
		set
		{
			_EntityDAL.TwoStepVerificationChangeTypeID = value;
		}
	}

	internal bool IsLegacyValue
	{
		get
		{
			return _EntityDAL.IsLegacyValue;
		}
		set
		{
			_EntityDAL.IsLegacyValue = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TwoSVSettingsAuditMetadata()
	{
		_EntityDAL = new TwoSVSettingsAuditMetadataDAL();
	}

	public TwoSVSettingsAuditMetadata(TwoSVSettingsAuditMetadataDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static TwoSVSettingsAuditMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, TwoSVSettingsAuditMetadataDAL, TwoSVSettingsAuditMetadata>(EntityCacheInfo, id, () => TwoSVSettingsAuditMetadataDAL.Get(id));
	}

	private static ICollection<TwoSVSettingsAuditMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, TwoSVSettingsAuditMetadataDAL, TwoSVSettingsAuditMetadata>(ids, EntityCacheInfo, TwoSVSettingsAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<TwoSVSettingsAuditMetadata> GetTwoSVSettingsAuditMetadataByUserID(long userId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		string collectionId = $"GetTwoSVSettingsAuditMetadataByUserID_UserID:{userId}_Count:{count}_ExclusiveStartTwoSVSettingsAuditMetadataID:{exclusiveStartTwoSVSettingsAuditMetadataId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserID(userId)), collectionId, () => TwoSVSettingsAuditMetadataDAL.GetTwoSVSettingsAuditMetadataIDsByUserID(userId, count, exclusiveStartTwoSVSettingsAuditMetadataId), MultiGet);
	}

	internal static ICollection<TwoSVSettingsAuditMetadata> GetTwoSVSettingsAuditMetadataByUserIDAndTwoStepVerificationChangeTypeID(long userId, byte twoStepVerificationChangeTypeId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		string collectionId = $"GetTwoSVSettingsAuditMetadataByUserIDAndTwoStepVerificationChangeTypeID_UserID:{userId}_TwoStepVerificationChangeTypeID:{twoStepVerificationChangeTypeId}_Count:{count}_ExclusiveStartTwoSVSettingsAuditMetadataID:{exclusiveStartTwoSVSettingsAuditMetadataId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserIDTwoStepVerificationChangeTypeID(userId, twoStepVerificationChangeTypeId)), collectionId, () => TwoSVSettingsAuditMetadataDAL.GetTwoSVSettingsAuditMetadataIDsByUserIDAndTwoStepVerificationChangeTypeID(userId, twoStepVerificationChangeTypeId, count, exclusiveStartTwoSVSettingsAuditMetadataId), MultiGet);
	}

	public void Construct(TwoSVSettingsAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByUserID(UserID));
		yield return new StateToken(GetLookupCacheKeysByUserIDTwoStepVerificationChangeTypeID(UserID, TwoStepVerificationChangeTypeID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByUserID(long userId)
	{
		return $"UserID:{userId}";
	}

	private static string GetLookupCacheKeysByUserIDTwoStepVerificationChangeTypeID(long userId, byte twoStepVerificationChangeTypeId)
	{
		return $"UserID:{userId}_TwoStepVerificationChangeTypeID:{twoStepVerificationChangeTypeId}";
	}
}
