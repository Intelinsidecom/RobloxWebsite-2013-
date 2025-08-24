using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.Party.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Party.Entities;

public class Party
{
	private static readonly string _IdKey = "Id";

	private static readonly string _WalledGardenKey = "WalledGarden";

	private static readonly string _CreatorUserIdKey = "CreatorUserId";

	private static readonly string _LeaderUserIdKey = "LeaderUserId";

	private static readonly string _ConversationIdKey = "ConversationId";

	private static readonly string _GamePlaceIdKey = "GamePlaceId";

	private static readonly string _GameIdKey = "GameId";

	private static readonly string _GameSlotExpiry = "GameSlotExpiry";

	public Guid Id { get; private set; }

	public long CreatorUserId { get; private set; }

	public long LeaderUserId { get; private set; }

	public long? ConversationId { get; private set; }

	public long[] MemberUserIds { get; private set; }

	public long[] PendingUserIds { get; private set; }

	public long? GamePlaceId { get; private set; }

	public Guid? GameId { get; private set; }

	public DateTime? GameSlotExpiry { get; private set; }

	public WalledGarden WalledGarden { get; private set; }

	public static event Action<IRedisClient, Guid> OnPartyUpdated;

	private Party()
	{
	}

	public static void UpdatePartyExpiry(IRedisClient redisClient, Guid partyId, TimeSpan keyExpiry)
	{
		string partyKey = GetPartyKey(partyId);
		redisClient.Execute(partyKey, (IDatabase db) => db.KeyExpire(partyKey, keyExpiry));
	}

	public static void UpdatePartyMembersExpiry(IRedisClient redisClient, Guid partyId, TimeSpan keyExpiry)
	{
		string partyMembersKey = GetPartyMembersKey(partyId);
		redisClient.Execute(partyMembersKey, (IDatabase db) => db.KeyExpire(partyMembersKey, keyExpiry));
	}

	public static Party CreateNew(IRedisClient redisClient, WalledGarden walledGarden, long? conversationId, long creatorUserId, long leaderUserId, long[] confirmedUserIds, long[] pendingUserIds)
	{
		Guid partyId = Guid.NewGuid();
		string partyKey = GetPartyKey(partyId);
		Party party = new Party
		{
			WalledGarden = walledGarden,
			ConversationId = conversationId,
			CreatorUserId = creatorUserId,
			Id = partyId,
			LeaderUserId = leaderUserId
		};
		HashEntry[] hashEntries = GetHashEntriesFromParty(party);
		redisClient.Execute(partyKey, delegate(IDatabase db)
		{
			db.HashSet(partyKey, hashEntries);
		});
		DateTime utcNow = DateTime.UtcNow;
		long pendingUserScore = GetScoreForPendingUser(utcNow);
		long confirmedUserScore = GetScoreForConfirmedUser(utcNow);
		List<SortedSetEntry> allUsers = new List<SortedSetEntry>(confirmedUserIds.Length + pendingUserIds.Length);
		allUsers.AddRange(confirmedUserIds.Select((long confirmedUserId) => new SortedSetEntry(confirmedUserId, confirmedUserScore)));
		allUsers.AddRange(pendingUserIds.Select((long pendingUserId) => new SortedSetEntry(pendingUserId, pendingUserScore)));
		string partyMembersKey = GetPartyMembersKey(partyId);
		redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetAdd(partyMembersKey, allUsers.ToArray()));
		party.MemberUserIds = confirmedUserIds;
		party.PendingUserIds = pendingUserIds;
		return party;
	}

	public static bool DeleteParty(IRedisClient redisClient, Guid partyId)
	{
		string partyKey = GetPartyKey(partyId);
		bool num = redisClient.Execute(partyKey, (IDatabase db) => db.KeyDelete(partyKey));
		string partyMembersKey = GetPartyMembersKey(partyId);
		if (num)
		{
			return redisClient.Execute(partyMembersKey, (IDatabase db) => db.KeyDelete(partyMembersKey));
		}
		return false;
	}

	public static Party Get(IRedisClient redisClient, Guid partyId)
	{
		string partyKey = GetPartyKey(partyId);
		Party party = GetPartyFromHashEntries(redisClient.Execute(partyKey, (IDatabase db) => db.HashGetAll(partyKey)));
		if (party == null)
		{
			return null;
		}
		string partyMembersKey = GetPartyMembersKey(partyId);
		SortedSetEntry[] sortedSetEntries = redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetRangeByScoreWithScores(partyMembersKey, double.NegativeInfinity, double.PositiveInfinity, Exclude.None, Order.Descending, 0L, Settings.Default.PartyMemberLimit));
		party.MemberUserIds = (from sortedSetEntry in sortedSetEntries
			where sortedSetEntry.Score >= 0.0
			select (long)sortedSetEntry.Element).ToArray();
		party.PendingUserIds = (from sortedSetEntry in sortedSetEntries
			where sortedSetEntry.Score < 0.0
			select (long)sortedSetEntry.Element).ToArray();
		return party;
	}

	public static void AddGameDetails(IRedisClient redisClient, Guid partyId, long gamePlaceId, Guid gameId, DateTime gameSlotExpiry)
	{
		string partyKey = GetPartyKey(partyId);
		List<HashEntry> hashEntries = new List<HashEntry>
		{
			new HashEntry(_GamePlaceIdKey, gamePlaceId),
			new HashEntry(_GameIdKey, gameId.ToString()),
			new HashEntry(_GameSlotExpiry, gameSlotExpiry.Ticks)
		};
		redisClient.Execute(partyKey, delegate(IDatabase db)
		{
			db.HashSet(partyKey, hashEntries.ToArray());
		});
		Party.OnPartyUpdated?.Invoke(redisClient, partyId);
	}

	public static void RemoveGameDetails(IRedisClient redisClient, Guid partyId)
	{
		string partyKey = GetPartyKey(partyId);
		List<RedisValue> hashEntries = new List<RedisValue> { _GamePlaceIdKey, _GameIdKey, _GameSlotExpiry };
		redisClient.Execute(partyKey, (IDatabase db) => db.HashDelete(partyKey, hashEntries.ToArray()));
	}

	public static void AddConfirmedPartyMember(IRedisClient redisClient, Guid partyId, long userId)
	{
		DateTime utcNow = DateTime.UtcNow;
		long confirmedUserScore = GetScoreForConfirmedUser(utcNow);
		string partyMembersKey = GetPartyMembersKey(partyId);
		redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetAdd(partyMembersKey, userId, confirmedUserScore));
		Party.OnPartyUpdated?.Invoke(redisClient, partyId);
	}

	public static void AddPendingPartyMember(IRedisClient redisClient, Guid partyId, long userId)
	{
		DateTime utcNow = DateTime.UtcNow;
		long pendingUserScore = GetScoreForPendingUser(utcNow);
		string partyMembersKey = GetPartyMembersKey(partyId);
		redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetAdd(partyMembersKey, userId, pendingUserScore));
		Party.OnPartyUpdated?.Invoke(redisClient, partyId);
	}

	public static void MovePartyMemberFromConfirmedToPending(IRedisClient redisClient, Guid partyId, long userId)
	{
		AddPendingPartyMember(redisClient, partyId, userId);
	}

	public static bool RemovePartyMember(IRedisClient redisClient, Guid partyId, long userId)
	{
		string partyMembersKey = GetPartyMembersKey(partyId);
		return redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetRemove(partyMembersKey, userId));
	}

	public static void ChangePartyLeader(IRedisClient redisClient, Guid partyId, long newLeaderId)
	{
		string partyKey = GetPartyKey(partyId);
		redisClient.Execute(partyKey, (IDatabase db) => db.HashSet(partyKey, _LeaderUserIdKey, newLeaderId));
		Party.OnPartyUpdated?.Invoke(redisClient, partyId);
	}

	public static DateTime? GetPartyMemberJoinTime(IRedisClient redisClient, Guid partyId, long userId)
	{
		string partyMembersKey = GetPartyMembersKey(partyId);
		double? ticks = redisClient.Execute(partyMembersKey, (IDatabase db) => db.SortedSetScore(partyMembersKey, userId));
		if (!ticks.HasValue || ticks <= 0.0)
		{
			return null;
		}
		return new DateTime((long)ticks.Value);
	}

	public static IRedisLeasedLock GetPartyRedisLeasedLock(IRedisLeasedLockFactory redisLeasedLockFactory, ILogger logger, Guid partyId)
	{
		string partyKey = GetPartyKey(partyId);
		return redisLeasedLockFactory.CreateLeasedLock(partyKey, TimeSpan.FromSeconds(2.0), delegate(Exception exp)
		{
			logger.Error(exp);
		});
	}

	private static long GetScoreForPendingUser(DateTime dateAdded)
	{
		return dateAdded.Ticks * -1;
	}

	private static long GetScoreForConfirmedUser(DateTime dateConfirmed)
	{
		return dateConfirmed.Ticks;
	}

	private static Party GetPartyFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		if (!dictionary.ContainsKey(_IdKey) || !Guid.TryParse(dictionary[_IdKey], out var partyId))
		{
			return null;
		}
		Guid gameId = Guid.Empty;
		if (dictionary.ContainsKey(_GameIdKey))
		{
			Guid.TryParse(dictionary[_GameIdKey], out gameId);
		}
		long gameSlotExpiryInTicks = 0L;
		if (dictionary.ContainsKey(_GameSlotExpiry))
		{
			gameSlotExpiryInTicks = (long)dictionary[_GameSlotExpiry];
		}
		return new Party
		{
			Id = partyId,
			WalledGarden = (dictionary.ContainsKey(_WalledGardenKey) ? ((WalledGarden)(int)dictionary[_WalledGardenKey]) : WalledGarden.General),
			CreatorUserId = (int)dictionary[_CreatorUserIdKey],
			LeaderUserId = (int)dictionary[_LeaderUserIdKey],
			ConversationId = (dictionary.ContainsKey(_ConversationIdKey) ? ((long?)dictionary[_ConversationIdKey]) : null),
			GamePlaceId = (dictionary.ContainsKey(_GamePlaceIdKey) ? ((long?)dictionary[_GamePlaceIdKey]) : null),
			GameId = ((gameId != Guid.Empty) ? new Guid?(gameId) : null),
			GameSlotExpiry = ((gameSlotExpiryInTicks > 0) ? new DateTime?(new DateTime(gameSlotExpiryInTicks)) : null)
		};
	}

	private static HashEntry[] GetHashEntriesFromParty(Party party)
	{
		List<HashEntry> hashEntries = new List<HashEntry>
		{
			new HashEntry(_IdKey, party.Id.ToString()),
			new HashEntry(_WalledGardenKey, (int)party.WalledGarden),
			new HashEntry(_CreatorUserIdKey, party.CreatorUserId),
			new HashEntry(_LeaderUserIdKey, party.LeaderUserId)
		};
		if (party.GamePlaceId.HasValue)
		{
			hashEntries.Add(new HashEntry(_GamePlaceIdKey, party.GamePlaceId));
		}
		if (party.GameId.HasValue)
		{
			hashEntries.Add(new HashEntry(_GameIdKey, party.GameId.ToString()));
		}
		if (party.GameSlotExpiry.HasValue)
		{
			hashEntries.Add(new HashEntry(_GameSlotExpiry, party.GameSlotExpiry.Value.Ticks));
		}
		if (party.ConversationId.HasValue)
		{
			hashEntries.Add(new HashEntry(_ConversationIdKey, party.ConversationId.Value));
		}
		return hashEntries.ToArray();
	}

	private static string GetPartyMembersKey(Guid partyId)
	{
		return "PartyMembers_Id:" + partyId;
	}

	private static string GetPartyKey(Guid partyId)
	{
		return "Party_Id:" + partyId;
	}
}
