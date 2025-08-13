using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class PlaceChatStyleType : IRobloxEntity<byte, PlaceChatStyleTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private PlaceChatStyleTypeDAL _EntityDAL;

	public static readonly string ClassicChatValue;

	public static readonly byte ClassicChatID;

	public static readonly string BubbleAndClassicChatValue;

	public static readonly byte BubbleAndClassicChatID;

	public static readonly string BubbleChatValue;

	public static readonly byte BubbleChatID;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		private set
		{
			_EntityDAL.Name = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	static PlaceChatStyleType()
	{
		ClassicChatValue = "Classic Chat";
		BubbleAndClassicChatValue = "Bubble And Classic Chat";
		BubbleChatValue = "Bubble Chat";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.PlaceChatStyleType", isNullCacheable: true);
		ClassicChatID = Get(ClassicChatValue).ID;
		BubbleAndClassicChatID = Get(BubbleAndClassicChatValue).ID;
		BubbleChatID = Get(BubbleChatValue).ID;
	}

	public PlaceChatStyleType()
	{
		_EntityDAL = new PlaceChatStyleTypeDAL();
	}

	public static PlaceChatStyleType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, PlaceChatStyleTypeDAL, PlaceChatStyleType>(EntityCacheInfo, id, () => PlaceChatStyleTypeDAL.Get(id));
	}

	public static PlaceChatStyleType Get(string name)
	{
		return EntityHelper.GetEntityByLookup<byte, PlaceChatStyleTypeDAL, PlaceChatStyleType>(EntityCacheInfo, $"Name:{name}", () => PlaceChatStyleTypeDAL.Get(name));
	}

	public void Construct(PlaceChatStyleTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
