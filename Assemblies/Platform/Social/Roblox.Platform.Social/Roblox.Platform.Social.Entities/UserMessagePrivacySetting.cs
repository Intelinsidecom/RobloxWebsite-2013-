using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social.Entities;

internal class UserMessagePrivacySetting : IRobloxEntity<long, UserMessagePrivacySettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum MessagePrivacyType
	{
		All,
		TopFriends,
		Friends,
		Noone,
		Disabled,
		Following,
		Followers
	}

	private static List<MessagePrivacyType> MessagePrivacyTypeList;

	private UserMessagePrivacySettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

	public long ID => _EntityDAL.ID;

	public long UserID
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

	public MessagePrivacyType MessagePrivacyTypeID
	{
		get
		{
			return (MessagePrivacyType)_EntityDAL.MessagePrivacyTypeID;
		}
		set
		{
			if (MessagePrivacyTypeList.Contains(value))
			{
				_EntityDAL.MessagePrivacyTypeID = (byte)value;
			}
			else
			{
				_EntityDAL.MessagePrivacyTypeID = 0;
			}
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

	static UserMessagePrivacySetting()
	{
		MessagePrivacyTypeList = new List<MessagePrivacyType>();
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.UserMessagePrivacySetting", isNullCacheable: true);
		foreach (object enumVal in Enum.GetValues(typeof(MessagePrivacyType)))
		{
			MessagePrivacyTypeList.Add((MessagePrivacyType)enumVal);
		}
	}

	public UserMessagePrivacySetting()
	{
		_EntityDAL = new UserMessagePrivacySettingDAL();
	}

	public UserMessagePrivacySetting(UserMessagePrivacySettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static UserMessagePrivacySetting DoGetOrCreate(long userId)
	{
		byte messagePrivacy = Settings.Default.DefaultUnder13MessagePrivacySetting;
		return EntityHelper.DoGetOrCreate<long, UserMessagePrivacySettingDAL, UserMessagePrivacySetting>(() => UserMessagePrivacySettingDAL.GetOrCreate(userId, messagePrivacy));
	}

	public static UserMessagePrivacySetting GetOrCreate(long userId)
	{
		UserMessagePrivacySetting userMessagePrivacySetting = EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserMessagePrivacySetting>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId), Get);
		if (userMessagePrivacySetting.MessagePrivacyTypeID == MessagePrivacyType.TopFriends)
		{
			userMessagePrivacySetting.MessagePrivacyTypeID = MessagePrivacyType.Friends;
			userMessagePrivacySetting.Save();
		}
		return userMessagePrivacySetting;
	}

	private static bool AcceptsMessages(long senderUserId, long recipientUserId, Func<long, long, bool> areFriendsFunc)
	{
		switch (GetOrCreate(recipientUserId).MessagePrivacyTypeID)
		{
		case MessagePrivacyType.All:
			return true;
		case MessagePrivacyType.Noone:
		case MessagePrivacyType.Disabled:
			return false;
		case MessagePrivacyType.TopFriends:
		case MessagePrivacyType.Friends:
			return areFriendsFunc(recipientUserId, senderUserId);
		default:
			throw new NotImplementedException();
		}
	}

	public static bool CanSendMessage(User sender, User recipient, Func<long, long, bool> areFriendsFunc, out string reasonProhibited)
	{
		reasonProhibited = "";
		if (sender == null)
		{
			reasonProhibited = "User must be logged in to send messages.";
			return false;
		}
		if (recipient == null)
		{
			reasonProhibited = "Recipient does not exist.";
			return false;
		}
		if (recipient.ID == sender.ID)
		{
			reasonProhibited = "You can't message yourself.";
			return false;
		}
		if (!AcceptsMessages(sender.ID, recipient.ID, areFriendsFunc))
		{
			reasonProhibited = "Recipient's privacy settings are too high.";
			return false;
		}
		if (!AcceptsMessages(recipient.ID, sender.ID, areFriendsFunc))
		{
			reasonProhibited = "Sender's privacy settings are too high.";
			return false;
		}
		return true;
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

	public static UserMessagePrivacySetting Get(long id)
	{
		return EntityHelper.GetEntity<long, UserMessagePrivacySettingDAL, UserMessagePrivacySetting>(EntityCacheInfo, id, () => UserMessagePrivacySettingDAL.Get(id));
	}

	public void Construct(UserMessagePrivacySettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
