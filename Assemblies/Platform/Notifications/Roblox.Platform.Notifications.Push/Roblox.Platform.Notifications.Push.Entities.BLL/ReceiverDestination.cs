using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Push.Entities.BLL;

internal class ReceiverDestination : IRobloxEntity<long, ReceiverDestinationDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReceiverDestinationDAL _EntityDAL;

	private long? _OriginalDestinationID;

	private bool? _OriginalIsAuthorizedByReceiver;

	private bool? _OriginalIsActive;

	private int? _OriginalAuthenticationTypeID;

	private string _OriginalAuthenticationValue;

	private bool _AuthenticationValueIsDirty;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReceiverDestination).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal int ReceiverTypeID
	{
		get
		{
			return _EntityDAL.ReceiverTypeID;
		}
		set
		{
			_EntityDAL.ReceiverTypeID = value;
		}
	}

	internal long ReceiverTargetID
	{
		get
		{
			return _EntityDAL.ReceiverTargetID;
		}
		set
		{
			_EntityDAL.ReceiverTargetID = value;
		}
	}

	internal long DestinationID
	{
		get
		{
			return _EntityDAL.DestinationID;
		}
		set
		{
			if (!_OriginalDestinationID.HasValue)
			{
				_OriginalDestinationID = _EntityDAL.DestinationID;
			}
			_EntityDAL.DestinationID = value;
		}
	}

	internal bool IsAuthorizedByReceiver
	{
		get
		{
			return _EntityDAL.IsAuthorizedByReceiver;
		}
		set
		{
			if (!_OriginalIsAuthorizedByReceiver.HasValue)
			{
				_OriginalIsAuthorizedByReceiver = _EntityDAL.IsAuthorizedByReceiver;
			}
			_EntityDAL.IsAuthorizedByReceiver = value;
		}
	}

	internal bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			if (!_OriginalIsActive.HasValue)
			{
				_OriginalIsActive = _EntityDAL.IsActive;
			}
			_EntityDAL.IsActive = value;
		}
	}

	internal int AuthenticationTypeID
	{
		get
		{
			return _EntityDAL.AuthenticationTypeID;
		}
		set
		{
			if (!_OriginalAuthenticationTypeID.HasValue)
			{
				_OriginalAuthenticationTypeID = _EntityDAL.AuthenticationTypeID;
			}
			_EntityDAL.AuthenticationTypeID = value;
		}
	}

	internal string AuthenticationValue
	{
		get
		{
			return _EntityDAL.AuthenticationValue;
		}
		set
		{
			if (!_AuthenticationValueIsDirty)
			{
				_AuthenticationValueIsDirty = true;
				_OriginalAuthenticationValue = _EntityDAL.AuthenticationValue;
			}
			_EntityDAL.AuthenticationValue = value;
		}
	}

	internal string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
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

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReceiverDestination()
	{
		_EntityDAL = new ReceiverDestinationDAL();
	}

	public static ReceiverDestination Create(int receiverTypeId, long receiverTargetId, long destinationId, int authenticationTypeId, string authenticationValue, string name, bool isActive, bool isAuthorizedByReceiver)
	{
		ReceiverDestination receiverDestination = new ReceiverDestination();
		receiverDestination.ReceiverTypeID = receiverTypeId;
		receiverDestination.ReceiverTargetID = receiverTargetId;
		receiverDestination.DestinationID = destinationId;
		receiverDestination.AuthenticationTypeID = authenticationTypeId;
		receiverDestination.AuthenticationValue = authenticationValue;
		receiverDestination.Name = name;
		receiverDestination.IsActive = isActive;
		receiverDestination.IsAuthorizedByReceiver = isAuthorizedByReceiver;
		receiverDestination.Save();
		return receiverDestination;
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
		_OriginalDestinationID = null;
		_OriginalIsActive = null;
		_OriginalIsAuthorizedByReceiver = null;
		_OriginalAuthenticationTypeID = null;
		_AuthenticationValueIsDirty = false;
	}

	internal static ReceiverDestination Get(long id)
	{
		return EntityHelper.GetEntity<long, ReceiverDestinationDAL, ReceiverDestination>(EntityCacheInfo, id, () => ReceiverDestinationDAL.Get(id));
	}

	private static ICollection<ReceiverDestination> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, ReceiverDestinationDAL, ReceiverDestination>(ids, EntityCacheInfo, ReceiverDestinationDAL.MultiGet);
	}

	public static ReceiverDestination GetByReceiverTypeIDReceiverTargetIDAndDestinationID(int receiverTypeID, long receiverTargetID, long destinationID)
	{
		return EntityHelper.GetEntityByLookup<long, ReceiverDestinationDAL, ReceiverDestination>(EntityCacheInfo, GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDDestinationID(receiverTypeID, receiverTargetID, destinationID), () => ReceiverDestinationDAL.GetReceiverDestinationByReceiverTypeIDReceiverTargetIDAndDestinationID(receiverTypeID, receiverTargetID, destinationID));
	}

	internal static ICollection<ReceiverDestination> GetReceiverDestinationsByDestinationIDAndIsActivePaged(long destinationID, bool isActive, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationsByDestinationIDAndIsActivePaged_DestinationID:{destinationID}_IsActive:{isActive}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByDestinationIDIsActive(destinationID, isActive)), collectionId, () => ReceiverDestinationDAL.GetReceiverDestinationIDsByDestinationIDAndIsActivePaged(destinationID, isActive, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<ReceiverDestination> GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAndIsActivePaged(int receiverTypeID, long receiverTargetID, bool isActive, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAndIsActivePaged_ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_IsActive:{isActive}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsActive(receiverTypeID, receiverTargetID, isActive)), collectionId, () => ReceiverDestinationDAL.GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAndIsActivePaged(receiverTypeID, receiverTargetID, isActive, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<ReceiverDestination> GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActivePaged(int receiverTypeID, long receiverTargetID, bool isAuthorizedByReceiver, bool isActive, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActivePaged_ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_IsAuthorizedByReceiver:{isAuthorizedByReceiver}_IsActive:{isActive}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverIsActive(receiverTypeID, receiverTargetID, isAuthorizedByReceiver, isActive)), collectionId, () => ReceiverDestinationDAL.GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActivePaged(receiverTypeID, receiverTargetID, isAuthorizedByReceiver, isActive, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<ReceiverDestination> GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValuePaged(int receiverTypeID, long receiverTargetID, int authenticationTypeID, string authenticationValue, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValuePaged_ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_AuthenticationTypeID:{authenticationTypeID}_AuthenticationValue:{authenticationValue}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAuthenticationValue(receiverTypeID, receiverTargetID, authenticationTypeID, authenticationValue)), collectionId, () => ReceiverDestinationDAL.GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValuePaged(receiverTypeID, receiverTargetID, authenticationTypeID, authenticationValue, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(ReceiverDestinationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDDestinationID(ReceiverTypeID, ReceiverTargetID, DestinationID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByDestinationIDIsActive(DestinationID, IsActive));
		if (_OriginalDestinationID.HasValue || _OriginalIsActive.HasValue)
		{
			yield return new StateToken(GetLookupCacheKeysByDestinationIDIsActive(_OriginalDestinationID ?? DestinationID, _OriginalIsActive ?? IsActive));
		}
		yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsActive(ReceiverTypeID, ReceiverTargetID, IsActive));
		if (_OriginalIsActive.HasValue)
		{
			yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsActive(ReceiverTypeID, ReceiverTargetID, _OriginalIsActive.Value));
		}
		yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverIsActive(ReceiverTypeID, ReceiverTargetID, IsAuthorizedByReceiver, IsActive));
		if (_OriginalIsActive.HasValue || _OriginalIsAuthorizedByReceiver.HasValue)
		{
			yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverIsActive(ReceiverTypeID, ReceiverTargetID, _OriginalIsAuthorizedByReceiver ?? IsAuthorizedByReceiver, _OriginalIsActive ?? IsActive));
		}
		yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAuthenticationValue(ReceiverTypeID, ReceiverTargetID, AuthenticationTypeID, AuthenticationValue));
		if (_OriginalAuthenticationTypeID.HasValue || _AuthenticationValueIsDirty)
		{
			yield return new StateToken(GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAuthenticationValue(ReceiverTypeID, ReceiverTargetID, _OriginalAuthenticationTypeID ?? AuthenticationTypeID, _AuthenticationValueIsDirty ? _OriginalAuthenticationValue : AuthenticationValue));
		}
	}

	private static string GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDDestinationID(int receiverTypeID, long receiverTargetID, long destinationID)
	{
		return $"ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_DestinationID:{destinationID}";
	}

	private static string GetLookupCacheKeysByDestinationIDIsActive(long destinationID, bool isActive)
	{
		return $"DestinationID:{destinationID}_IsActive:{isActive}";
	}

	private static string GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsActive(int receiverTypeID, long receiverTargetID, bool isActive)
	{
		return $"ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_IsActive:{isActive}";
	}

	private static string GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverIsActive(int receiverTypeID, long receiverTargetID, bool isAuthorizedByReceiver, bool isActive)
	{
		return $"ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_IsAuthorizedByReceiver:{isAuthorizedByReceiver}_IsActive:{isActive}";
	}

	private static string GetLookupCacheKeysByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAuthenticationValue(int receiverTypeID, long receiverTargetID, int authenticationTypeID, string authenticationValue)
	{
		return $"ReceiverTypeID:{receiverTypeID}_ReceiverTargetID:{receiverTargetID}_AuthenticationTypeID:{authenticationTypeID}_AuthenticationValue:{authenticationValue}";
	}
}
