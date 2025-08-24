using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationType : IRobloxEntity<byte, ConversationTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ConversationTypeDAL _EntityDAL;

	public static readonly ConversationType OneToOne;

	public static readonly ConversationType MultiUser;

	public static readonly ConversationType CloudEdit;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	static ConversationType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ConversationType).ToString(), isNullCacheable: true);
		OneToOne = GetByValue("OneToOne");
		MultiUser = GetByValue("MultiUser");
		CloudEdit = GetByValue("CloudEdit");
	}

	public ConversationType()
	{
		_EntityDAL = new ConversationTypeDAL();
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

	internal static ConversationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ConversationTypeDAL, ConversationType>(EntityCacheInfo, id, () => ConversationTypeDAL.Get(id));
	}

	private static ICollection<ConversationType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, ConversationTypeDAL, ConversationType>(ids, EntityCacheInfo, ConversationTypeDAL.MultiGet);
	}

	public static ConversationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, ConversationTypeDAL, ConversationType>(EntityCacheInfo, $"Value:{value}", () => ConversationTypeDAL.GetConversationTypeByValue(value));
	}

	public void Construct(ConversationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
