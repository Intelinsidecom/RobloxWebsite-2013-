using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Notifications.Push.Entities.BLL;

internal class AuthenticationType : IRobloxEntity<int, AuthenticationTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private AuthenticationTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AuthenticationType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
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

	public AuthenticationType()
	{
		_EntityDAL = new AuthenticationTypeDAL();
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
	}

	internal static AuthenticationType Get(int id)
	{
		return EntityHelper.GetEntity<int, AuthenticationTypeDAL, AuthenticationType>(EntityCacheInfo, id, () => AuthenticationTypeDAL.Get(id));
	}

	public static AuthenticationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, AuthenticationTypeDAL, AuthenticationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => AuthenticationTypeDAL.GetAuthenticationTypeByValue(value));
	}

	public static AuthenticationType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, AuthenticationType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => DoGetOrCreate(value));
	}

	private static AuthenticationType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, AuthenticationTypeDAL, AuthenticationType>(() => AuthenticationTypeDAL.GetOrCreateAuthenticationType(value));
	}

	public void Construct(AuthenticationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
