using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Properties;

namespace Roblox;

/// <summary>
/// Do not use this class directly, use classes in Platform.Social instead.
/// </summary>
public class Message : IRobloxEntity<long, MessageDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum MessagesReceivedFilter
	{
		All,
		ExcludeInvitations,
		SystemMessages,
		Unread_ExcludeInvitations,
		Archived_ExcludeInvitations,
		Archived_ExcludeInvitationsAndSystem,
		Unarchived_ExcludeInvitations,
		Unarchived_ExcludeInvitationsAndSystem,
		Unread_Archived_ExcludeInvitations,
		Unread_Unarchived_ExcludeInvitations,
		Unread_Unarchived_ExcludeInvitationsAndSystem
	}

	public delegate void MessageCreatedEventHandler(long messageId, long recipientId);

	public delegate void MessageDeletedEventHandler(long messageId, long recipientId);

	private MessageDAL _EntityDAL;

	private const int _BuildermanUserID = 156;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false), "Roblox.Message", isNullCacheable: true);

	private bool _IsInteractionTrackable
	{
		get
		{
			if (MessageTypeID != MessageType.PrivateMessageID)
			{
				return false;
			}
			if (IsSystemMessage)
			{
				return false;
			}
			if (IsBroadcastMessage)
			{
				return false;
			}
			if (AuthorID == 156)
			{
				return false;
			}
			return true;
		}
	}

	private static bool _UseUnreadMessagesCounter => Settings.Default.UseUnreadMessagesCounter;

	private static double _UnreadMessagesCounterVerificationPercentage => Settings.Default.UnreadMessagesCounterVerificationPercentage;

	private static int _UnreadMessagesCounterAutoSyncThreshold => Settings.Default.UnreadMessagesCounterAutoSyncThreshold;

	public long ID
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

	public int MessageTypeID
	{
		get
		{
			return _EntityDAL.MessageTypeID;
		}
		set
		{
			_EntityDAL.MessageTypeID = value;
		}
	}

	public string Subject
	{
		get
		{
			return _EntityDAL.Subject;
		}
		set
		{
			_EntityDAL.Subject = value.Substring(0, (value.Length < 256) ? value.Length : 256);
		}
	}

	public string Body
	{
		get
		{
			return _EntityDAL.Body;
		}
		set
		{
			_EntityDAL.Body = value;
		}
	}

	public long AuthorID
	{
		get
		{
			return _EntityDAL.AuthorID;
		}
		set
		{
			_EntityDAL.AuthorID = value;
		}
	}

	public User Author
	{
		get
		{
			return User.Get(_EntityDAL.AuthorID);
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AuthorID = value.ID;
			}
			else
			{
				_EntityDAL.AuthorID = 0L;
			}
		}
	}

	public long RecipientID
	{
		get
		{
			return _EntityDAL.RecipientID;
		}
		set
		{
			_EntityDAL.RecipientID = value;
		}
	}

	public User Recipient
	{
		get
		{
			return User.Get(_EntityDAL.RecipientID);
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.RecipientID = value.ID;
			}
			else
			{
				_EntityDAL.RecipientID = 0L;
			}
		}
	}

	public bool IsSystemMessage
	{
		get
		{
			return _EntityDAL.IsSystemMessage;
		}
		set
		{
			_EntityDAL.IsSystemMessage = value;
		}
	}

	public bool IsBroadcastMessage
	{
		get
		{
			return _EntityDAL.IsBroadcastMessage;
		}
		set
		{
			_EntityDAL.IsBroadcastMessage = value;
		}
	}

	public bool IsRead
	{
		get
		{
			return _EntityDAL.IsRead;
		}
		set
		{
			_EntityDAL.IsRead = value;
		}
	}

	public bool IsArchived
	{
		get
		{
			return _EntityDAL.IsArchived;
		}
		set
		{
			_EntityDAL.IsArchived = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	[Obsolete("The event is only for Message Created directly by SCL Message")]
	public static event MessageCreatedEventHandler OnMessageCreated;

	public static event MessageDeletedEventHandler OnMessageDeleted;

	public Message(MessageDAL dal)
	{
		_EntityDAL = dal;
	}

	public Message()
	{
		_EntityDAL = new MessageDAL();
	}

	private void DecrementUnreadMessagesCount()
	{
		if (_UseUnreadMessagesCounter && MessageTypeID == MessageType.PrivateMessageID)
		{
			bool wasSynced;
			UserCounter counter = UserCounter.GetOrCreate((int)RecipientID, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
			if (!wasSynced)
			{
				counter.Decrement();
			}
		}
	}

	private void IncrementUnreadMessagesCount()
	{
		if (_UseUnreadMessagesCounter && MessageTypeID == MessageType.PrivateMessageID)
		{
			bool wasSynced;
			UserCounter counter = UserCounter.GetOrCreate((int)RecipientID, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
			if (!wasSynced)
			{
				counter.Increment();
			}
		}
	}

	private void TrackInteraction()
	{
		if (Settings.Default.InteractionTrackingIsEnabled && _IsInteractionTrackable)
		{
			InteractionCounter.GetOrCreate(InteractionCounterType.GetUltimateID_MessageSent(), (int)AuthorID, (int)RecipientID).IncrementResetting(InteractionCounter.ResetThreshold.BeginningOfTheCurrentMonth);
		}
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		bool isRead = IsRead;
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		if (!isRead)
		{
			DecrementUnreadMessagesCount();
		}
		Message.OnMessageDeleted?.Invoke(ID, RecipientID);
	}

	public void Save()
	{
		if (_EntityDAL == null)
		{
			throw new ApplicationException("Required object not provided: EntityDAL.");
		}
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

	public void Send()
	{
		if (IsSystemMessage || IsBroadcastMessage || MessageTypeID == MessageType.FriendshipInvitationID)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				DoSave(this);
			});
		}
		else if (MessageTypeID == MessageType.PrivateMessageID)
		{
			ExceptionHandler.LogException("SCL method used to send private message: " + AuthorID);
		}
		else
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				DoSave(this);
			});
		}
	}

	private static void DoSave(Message entity)
	{
		try
		{
			entity.Save();
			entity.IncrementUnreadMessagesCount();
			entity.TrackInteraction();
			Message.OnMessageCreated?.Invoke(entity.ID, entity.RecipientID);
		}
		catch (ThreadAbortException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException(ex2);
		}
	}

	private static void SynchronizeUnreadMessagesCounter(UserCounter unreadMessagesCounter)
	{
		int difference = GetTotalNumberOfUserMessagesReceived(unreadMessagesCounter.UserID, MessagesReceivedFilter.Unread_ExcludeInvitations) - (int)unreadMessagesCounter.Value;
		if (difference > 0)
		{
			unreadMessagesCounter.Increment(difference);
		}
		else if (difference < 0)
		{
			unreadMessagesCounter.Decrement(-1 * difference);
		}
	}

	private static void VerifyUnreadMessagesCounter(UserCounter unreadMessagesCounter)
	{
		if ((_UnreadMessagesCounterVerificationPercentage != 0.0 || unreadMessagesCounter.Value <= _UnreadMessagesCounterAutoSyncThreshold) && (new Random().NextDouble() <= _UnreadMessagesCounterVerificationPercentage || unreadMessagesCounter.Value <= _UnreadMessagesCounterAutoSyncThreshold))
		{
			SynchronizeUnreadMessagesCounter(unreadMessagesCounter);
		}
	}

	private static void SynchronizeUnreadArchivedMessagesCounter(UserCounter unreadMessagesCounter)
	{
		int difference = GetTotalNumberOfUserMessagesReceived(unreadMessagesCounter.UserID, MessagesReceivedFilter.Unread_Archived_ExcludeInvitations) - (int)unreadMessagesCounter.Value;
		if (difference > 0)
		{
			unreadMessagesCounter.Increment(difference);
		}
		else if (difference < 0)
		{
			unreadMessagesCounter.Decrement(-1 * difference);
		}
	}

	private static void SynchronizeUnreadUnarchivedMessagesCounter(UserCounter unreadMessagesCounter)
	{
		int difference = GetTotalNumberOfUserMessagesReceived(unreadMessagesCounter.UserID, MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations) - (int)unreadMessagesCounter.Value;
		if (difference > 0)
		{
			unreadMessagesCounter.Increment(difference);
		}
		else if (difference < 0)
		{
			unreadMessagesCounter.Decrement(-1 * difference);
		}
	}

	private static void VerifyUnreadUnarchivedMessagesCounter(UserCounter unreadMessagesCounter)
	{
		if ((_UnreadMessagesCounterVerificationPercentage != 0.0 || unreadMessagesCounter.Value <= _UnreadMessagesCounterAutoSyncThreshold) && (new Random().NextDouble() <= _UnreadMessagesCounterVerificationPercentage || unreadMessagesCounter.Value <= _UnreadMessagesCounterAutoSyncThreshold))
		{
			SynchronizeUnreadUnarchivedMessagesCounter(unreadMessagesCounter);
		}
	}

	public static Message Get(long id)
	{
		return EntityHelper.GetEntity<long, MessageDAL, Message>(EntityCacheInfo, id, () => MessageDAL.Get(id));
	}

	public static Message Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<Message> GetMessages(long exclusiveStartId, int maximumRows)
	{
		string collectionId = $"GetMessages:ExclusiveStartId:{exclusiveStartId}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(), collectionId, () => MessageDAL.GetMessageIDs(exclusiveStartId, maximumRows), MultiGet);
	}

	public static ICollection<Message> GetUserMessageSentPaged(long authorId, long startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserMessagesSentExcludingInvitationsPaged_AuthorID:{authorId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"AuthorID:{authorId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => MessageDAL.GetUserMessageIDsSentPaged(authorId, startRowIndex + 1, maximumRows), Get);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public static ICollection<Message> GetUserMessagesReceivedPagedAndSorted(long recipientId, MessagesReceivedFilter filter, string sortExpression, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserMessagesReceivedPagedAndSorted_RecipientID:{recipientId}_Filter:{filter}_SortExpression:{sortExpression}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"RecipientID:{recipientId}";
		MessageDAL.MessagesReceivedFilter dalFilter = MessageDAL.MessagesReceivedFilter.ExcludeInvitations;
		switch (filter)
		{
		case MessagesReceivedFilter.All:
			dalFilter = MessageDAL.MessagesReceivedFilter.All;
			break;
		case MessagesReceivedFilter.ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Archived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unarchived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_Archived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_Archived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.SystemMessages:
			dalFilter = MessageDAL.MessagesReceivedFilter.SystemMessages;
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem;
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem:
			dalFilter = MessageDAL.MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem;
			break;
		}
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => MessageDAL.GetUserMessageIDsReceivedPagedAndSorted(recipientId, dalFilter, sortExpression, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<Message> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, MessageDAL, Message>(ids, EntityCacheInfo, MessageDAL.MultiGet);
	}

	public static int GetTotalNumberOfUserMessagesReceived(long recipientId, MessagesReceivedFilter filter)
	{
		if (recipientId == 0L)
		{
			throw new ApplicationException("Required value not specified: RecipientID");
		}
		string countId = $"GetTotalNumberOfUserMessagesReceived_RecipientID:{recipientId}_Filter:{filter}";
		string cachedStateQualifier = $"RecipientID:{recipientId}";
		MessageDAL.MessagesReceivedFilter dalFilter = MessageDAL.MessagesReceivedFilter.ExcludeInvitations;
		switch (filter)
		{
		case MessagesReceivedFilter.All:
			dalFilter = MessageDAL.MessagesReceivedFilter.All;
			break;
		case MessagesReceivedFilter.ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Archived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unarchived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_Archived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_Archived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations;
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem:
			dalFilter = MessageDAL.MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem;
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem:
			dalFilter = MessageDAL.MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem;
			break;
		case MessagesReceivedFilter.SystemMessages:
			dalFilter = MessageDAL.MessagesReceivedFilter.SystemMessages;
			break;
		}
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => MessageDAL.GetTotalNumberOfUserMessagesReceived(recipientId, dalFilter));
	}

	public static int GetTotalNumberOfMessages(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.ExcludeInvitations);
	}

	public static int GetTotalNumberOfSentMessages(long authorId)
	{
		string countId = $"GetTotalNumberOfUserMessagesSent_AuthorID:{authorId}";
		string cachedStateQualifier = $"AuthorID:{authorId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => MessageDAL.GetTotalNumberOfSentUserMessages(authorId));
	}

	public static int GetTotalNumberOfUnreadMessages(long userId)
	{
		if (!_UseUnreadMessagesCounter)
		{
			return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Unread_ExcludeInvitations);
		}
		bool wasSynced;
		UserCounter unreadMessagesCounter = UserCounter.GetOrCreate(userId, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
		if (!wasSynced)
		{
			VerifyUnreadMessagesCounter(unreadMessagesCounter);
		}
		return (int)unreadMessagesCounter.Value;
	}

	public static int GetTotalNumberOfSystemMessages(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.SystemMessages);
	}

	public static int GetTotalNumberOfUnarchivedMessagesExcludingSystem(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem);
	}

	public static int GetTotalNumberOfArchivedMessagesExcludingSystem(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem);
	}

	public static int GetTotalNumberOfUnarchivedMessages(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Unarchived_ExcludeInvitations);
	}

	public static int GetTotalNumberOfArchivedMessages(long userId)
	{
		return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Archived_ExcludeInvitations);
	}

	public static int GetTotalNumberOfUnreadUnarchivedMessages(long userId)
	{
		if (!_UseUnreadMessagesCounter)
		{
			return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations);
		}
		bool wasSynced;
		UserCounter unreadMessagesCounter = UserCounter.GetOrCreate(userId, UserCounterType.UnreadMessagesID, SynchronizeUnreadUnarchivedMessagesCounter, out wasSynced);
		if (!wasSynced)
		{
			VerifyUnreadUnarchivedMessagesCounter(unreadMessagesCounter);
		}
		return (int)unreadMessagesCounter.Value;
	}

	public static int GetTotalNumberOfUnreadArchivedMessages(long userId)
	{
		if (!_UseUnreadMessagesCounter)
		{
			return GetTotalNumberOfUserMessagesReceived(userId, MessagesReceivedFilter.Unread_Archived_ExcludeInvitations);
		}
		bool wasSynced;
		UserCounter unreadMessagesCounter = UserCounter.GetOrCreate(userId, UserCounterType.UnreadMessagesID, SynchronizeUnreadArchivedMessagesCounter, out wasSynced);
		if (!wasSynced)
		{
			VerifyUnreadMessagesCounter(unreadMessagesCounter);
		}
		return (int)unreadMessagesCounter.Value;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(MessageDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"RecipientID:{RecipientID}");
		yield return new StateToken($"AuthorID:{AuthorID}");
	}
}
