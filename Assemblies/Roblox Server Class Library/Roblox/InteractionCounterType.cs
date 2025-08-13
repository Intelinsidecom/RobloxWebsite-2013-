using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class InteractionCounterType : IRobloxEntity<byte, InteractionCounterTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private InteractionCounterTypeDAL _EntityDAL;

	public static readonly byte ChatConversation_Index0_ID;

	public static readonly string ChatConversation_Index0_Value;

	public static readonly byte ChatConversation_Index1_ID;

	public static readonly string ChatConversation_Index1_Value;

	public static readonly byte ChatConversation_Index2_ID;

	public static readonly string ChatConversation_Index2_Value;

	public static readonly byte MessageSent_Index0_ID;

	public static readonly string MessageSent_Index0_Value;

	public static readonly byte MessageSent_Index1_ID;

	public static readonly string MessageSent_Index1_Value;

	public static readonly byte MessageSent_Index2_ID;

	public static readonly string MessageSent_Index2_Value;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public byte GroupID
	{
		get
		{
			return _EntityDAL.GroupID;
		}
		set
		{
			_EntityDAL.GroupID = value;
		}
	}

	public byte GroupIndex
	{
		get
		{
			return _EntityDAL.GroupIndex;
		}
		set
		{
			_EntityDAL.GroupIndex = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public InteractionCounterType()
	{
		_EntityDAL = new InteractionCounterTypeDAL();
	}

	static InteractionCounterType()
	{
		ChatConversation_Index0_Value = "Chat Conversation 0";
		ChatConversation_Index1_Value = "Chat Conversation 1";
		ChatConversation_Index2_Value = "Chat Conversation 2";
		MessageSent_Index0_Value = "Message Sent 0";
		MessageSent_Index1_Value = "Message Sent 1";
		MessageSent_Index2_Value = "Message Sent 2";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "InteractionCounterType", isNullCacheable: true);
		ChatConversation_Index0_ID = GetByValue(ChatConversation_Index0_Value).ID;
		ChatConversation_Index1_ID = GetByValue(ChatConversation_Index1_Value).ID;
		ChatConversation_Index2_ID = GetByValue(ChatConversation_Index2_Value).ID;
		MessageSent_Index0_ID = GetByValue(MessageSent_Index0_Value).ID;
		MessageSent_Index1_ID = GetByValue(MessageSent_Index1_Value).ID;
		MessageSent_Index2_ID = GetByValue(MessageSent_Index2_Value).ID;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static InteractionCounterType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, InteractionCounterTypeDAL, InteractionCounterType>(EntityCacheInfo, id, () => InteractionCounterTypeDAL.Get(id));
	}

	public static InteractionCounterType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static byte GetUltimateID_ChatConversation()
	{
		return (DateTime.Now.Month % 3) switch
		{
			0 => ChatConversation_Index0_ID, 
			1 => ChatConversation_Index1_ID, 
			2 => ChatConversation_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static byte GetPenultimateID_ChatConversation()
	{
		return (DateTime.Now.AddMonths(-1).Month % 3) switch
		{
			0 => ChatConversation_Index0_ID, 
			1 => ChatConversation_Index1_ID, 
			2 => ChatConversation_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static byte GetAntepenultimateID_ChatConversation()
	{
		return (DateTime.Now.AddMonths(-2).Month % 3) switch
		{
			0 => ChatConversation_Index0_ID, 
			1 => ChatConversation_Index1_ID, 
			2 => ChatConversation_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static byte GetUltimateID_MessageSent()
	{
		return (DateTime.Now.Month % 3) switch
		{
			0 => MessageSent_Index0_ID, 
			1 => MessageSent_Index1_ID, 
			2 => MessageSent_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static byte GetPenultimateID_MessageSent()
	{
		return (DateTime.Now.AddMonths(-1).Month % 3) switch
		{
			0 => MessageSent_Index0_ID, 
			1 => MessageSent_Index1_ID, 
			2 => MessageSent_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static byte GetAntepenultimateID_MessageSent()
	{
		return (DateTime.Now.AddMonths(-2).Month % 3) switch
		{
			0 => MessageSent_Index0_ID, 
			1 => MessageSent_Index1_ID, 
			2 => MessageSent_Index2_ID, 
			_ => throw new ApplicationException("Maths fail."), 
		};
	}

	public static InteractionCounterType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, InteractionCounterTypeDAL, InteractionCounterType>(EntityCacheInfo, value, () => InteractionCounterTypeDAL.GetByValue(value));
	}

	public void Construct(InteractionCounterTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
