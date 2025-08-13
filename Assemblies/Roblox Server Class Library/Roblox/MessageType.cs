using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

/// <summary>
/// Do not use this class directly, use classes in Platform.Social instead.
/// </summary>
[Serializable]
public class MessageType : IRobloxEntity<int, MessageTypeDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private MessageTypeDAL _EntityDAL;

	public static readonly int FriendshipInvitationID;

	public static readonly string FriendshipInvitationValue;

	public static readonly int PrivateMessageID;

	public static readonly string PrivateMessageValue;

	public static CacheInfo EntityCacheInfo;

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

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

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public string Abbreviation
	{
		get
		{
			return _EntityDAL.Abbreviation;
		}
		set
		{
			_EntityDAL.Abbreviation = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public MessageType(MessageTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public MessageType()
	{
		_EntityDAL = new MessageTypeDAL();
	}

	static MessageType()
	{
		FriendshipInvitationValue = "Friendship Invitation";
		PrivateMessageValue = "Private Message";
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "MessageType", isNullCacheable: true);
		FriendshipInvitationID = Get(FriendshipInvitationValue).ID;
		PrivateMessageID = Get(PrivateMessageValue).ID;
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

	public static MessageType Get(int id)
	{
		return EntityHelper.GetEntity<int, MessageTypeDAL, MessageType>(EntityCacheInfo, id, () => MessageTypeDAL.Get(id));
	}

	public static MessageType Get(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, MessageTypeDAL, MessageType>(EntityCacheInfo, "Value:" + value, () => MessageTypeDAL.Get(value));
	}

	public static MessageType Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<MessageType> GetMessageTypes()
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetMessageTypes", MessageTypeDAL.GetMessageTypeIDs, Get);
	}

	public static MessageType Register(string value, string description)
	{
		MessageType t;
		if (MessageTypeDAL.Get(value) != null)
		{
			t = Get(value);
		}
		else
		{
			t = new MessageType
			{
				Value = value,
				Description = description
			};
			t.Save();
		}
		return t;
	}

	public void Construct(MessageTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "Value:" + Value;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
