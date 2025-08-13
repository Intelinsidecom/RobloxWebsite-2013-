using System;
using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Party.Entities;

public class UserParty
{
	private const string _HashFieldUserId = "UserId";

	private const string _HashFieldPartyId = "PartyId";

	private const string _HashFieldDeviceType = "DeviceType";

	private const string _HashFieldAutoFollowPartyLeader = "AutoFollowPartyLeader";

	public static Action<IRedisClient, long, WalledGarden> OnUserPartyUpdated;

	public long UserId { get; private set; }

	public Guid PartyId { get; private set; }

	public DeviceType DeviceType { get; private set; }

	public bool AutoFollowPartyLeader { get; private set; }

	public static void UpdateUserPartyExpiry(IRedisClient redisClient, Guid partyId, long userId, WalledGarden walledGarden, TimeSpan userPartyExpiry)
	{
		string partyIdLookupKey = GetUserWalledGardenPartyKey(userId, walledGarden);
		redisClient.Execute(partyIdLookupKey, (IDatabase db) => db.KeyExpire(partyIdLookupKey, userPartyExpiry));
	}

	public static UserParty GetUserPartyByUserIdAndWalledGarden(IRedisClient redisClient, long userId, WalledGarden walledGarden)
	{
		string userPartyLookup = GetUserWalledGardenPartyKey(userId, walledGarden);
		return GetUserPartyFromHashEntries(redisClient.Execute(userPartyLookup, (IDatabase db) => db.HashGetAll(userPartyLookup)));
	}

	public static void UpdateUserPartyDeviceType(IRedisClient redisClient, long userId, WalledGarden walledGarden, DeviceType newDeviceType)
	{
		string partyIdLookupKey = GetUserWalledGardenPartyKey(userId, walledGarden);
		redisClient.Execute(partyIdLookupKey, (IDatabase db) => db.HashSet(partyIdLookupKey, "DeviceType", (int)newDeviceType));
		OnUserPartyUpdated?.Invoke(redisClient, userId, walledGarden);
	}

	public static UserParty CreateNew(IRedisClient redisClient, long userId, WalledGarden walledGarden, Guid partyId, DeviceType deviceType, bool autoFollowPartyLeader)
	{
		UserParty userParty = new UserParty
		{
			AutoFollowPartyLeader = autoFollowPartyLeader,
			PartyId = partyId,
			UserId = userId,
			DeviceType = deviceType
		};
		HashEntry[] hashEntries = GetHashEntriesFromUserParty(userParty);
		string partyIdLookupKey = GetUserWalledGardenPartyKey(userId, walledGarden);
		redisClient.Execute(partyIdLookupKey, delegate(IDatabase db)
		{
			db.HashSet(partyIdLookupKey, hashEntries);
		});
		OnUserPartyUpdated?.Invoke(redisClient, userId, walledGarden);
		return userParty;
	}

	public static bool Remove(IRedisClient redisClient, long userId, WalledGarden walledGarden)
	{
		string partyIdLookupKey = GetUserWalledGardenPartyKey(userId, walledGarden);
		return redisClient.Execute(partyIdLookupKey, (IDatabase db) => db.KeyDelete(partyIdLookupKey));
	}

	private static HashEntry[] GetHashEntriesFromUserParty(UserParty userParty)
	{
		return new HashEntry[4]
		{
			new HashEntry("UserId", userParty.UserId),
			new HashEntry("PartyId", userParty.PartyId.ToString()),
			new HashEntry("DeviceType", (int)userParty.DeviceType),
			new HashEntry("AutoFollowPartyLeader", userParty.AutoFollowPartyLeader)
		};
	}

	private static UserParty GetUserPartyFromHashEntries(HashEntry[] hashEntries)
	{
		if (hashEntries == null || hashEntries.Length == 0)
		{
			return null;
		}
		Dictionary<RedisValue, RedisValue> dictionary = hashEntries.ToDictionary();
		if (!Guid.TryParse(dictionary["PartyId"], out var partyId))
		{
			return null;
		}
		return new UserParty
		{
			AutoFollowPartyLeader = (bool)dictionary["AutoFollowPartyLeader"],
			PartyId = partyId,
			DeviceType = ((!dictionary.ContainsKey("DeviceType")) ? DeviceType.Computer : ((DeviceType)(int)dictionary["DeviceType"])),
			UserId = (int)dictionary["UserId"]
		};
	}

	private static string GetUserWalledGardenPartyKey(long userId, WalledGarden walledGarden)
	{
		return "UserParty_UserId:" + userId + "_WalledGarden:" + walledGarden;
	}
}
