using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Games.Exceptions;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Games;

public class ReservedServerPermissionsFactory : IReservedServerPermissionsFactory
{
	private const int _HashLength = 16;

	private const int _GuidLength = 16;

	private const int _SignedAccessCodeLength = 40;

	private readonly ILogger _Logger;

	private readonly ISharedCacheClient _MemcachedClient;

	private readonly IUniverseFactory _UniverseFactory;

	public ReservedServerPermissionsFactory(ISharedCacheClient memcachedClient, IUniverseFactory universeFactory, ILogger logger)
	{
		_MemcachedClient = memcachedClient;
		_UniverseFactory = universeFactory;
		_Logger = logger;
	}

	public (string AccessCode, Guid GameCode) GenerateAccessCodeAndGameCode(long originPlaceId, long reservedServerPlaceId)
	{
		ValidateUniverseMembership(originPlaceId, reservedServerPlaceId);
		byte[] bytes = Encoding.UTF8.GetBytes(Settings.Default.ReservedServerSignatureKey);
		Guid gameCode = Guid.NewGuid();
		byte[] first = gameCode.ToByteArray();
		byte[] reservedServerPlaceIdBytes = BitConverter.GetBytes(reservedServerPlaceId);
		byte[] contentBytes = first.Concat(reservedServerPlaceIdBytes).ToArray();
		return (HttpServerUtility.UrlTokenEncode(Sign(bytes, contentBytes)), gameCode);
	}

	public IReservedServerConfiguration ParseAccessCode(string reservedServerAccessCode)
	{
		byte[] signedData;
		try
		{
			signedData = HttpServerUtility.UrlTokenDecode(reservedServerAccessCode);
		}
		catch (ArgumentNullException ex3)
		{
			_Logger?.Error($"Reserved server access code was null {ex3}");
			throw new InvalidReservedServerAccessCodeException(reservedServerAccessCode);
		}
		if (signedData == null || signedData.Length != 40)
		{
			_Logger?.Error("Decoded reservedServerAccessCode null or not of valid length");
			throw new InvalidReservedServerAccessCodeException(reservedServerAccessCode);
		}
		byte[] keyBytes;
		try
		{
			keyBytes = Encoding.UTF8.GetBytes(Settings.Default.ReservedServerSignatureKey);
		}
		catch (Exception ex2)
		{
			_Logger?.Error($"There was an exception in getting keyBytes: {ex2}");
			throw new InvalidReservedServerAccessCodeException(reservedServerAccessCode);
		}
		if (!Verify(keyBytes, signedData, out var content))
		{
			_Logger?.Error($"Unable to verify reservedServerAccessCode: {reservedServerAccessCode}");
			throw new InvalidReservedServerAccessCodeException(reservedServerAccessCode);
		}
		try
		{
			byte[] gameCodeBytes = content.Take(16).ToArray();
			return new ReservedServerConfiguration
			{
				GameCode = new Guid(gameCodeBytes),
				PlaceId = BitConverter.ToInt64(content, 16)
			};
		}
		catch (Exception ex)
		{
			_Logger?.Error($"There was an exception: {ex}");
			throw new InvalidReservedServerAccessCodeException(reservedServerAccessCode);
		}
	}

	public bool CheckAccess(string reservedServerAccessCode, long playerId)
	{
		string key = GenerateKey(reservedServerAccessCode, playerId);
		string value;
		return _MemcachedClient.Query(key, out value);
	}

	public IDictionary<long, bool> CheckAccess(string reservedServerAccessCode, long[] playerIds)
	{
		ValidatePlayers(playerIds);
		return playerIds.ToDictionary((long p) => p, (long p) => CheckAccess(reservedServerAccessCode, p));
	}

	public void GrantAccess(string reservedServerAccessCode, long[] playerIds)
	{
		ValidatePlayers(playerIds);
		foreach (long playerId in playerIds)
		{
			string key = GenerateKey(reservedServerAccessCode, playerId);
			_MemcachedClient.Set(key, "1", Settings.Default.ReservedServerAccessExpiration);
		}
	}

	public void RevokeAccess(string reservedServerAccessCode, long[] playerIds)
	{
		ValidatePlayers(playerIds);
		foreach (long playerId in playerIds)
		{
			string key = GenerateKey(reservedServerAccessCode, playerId);
			_MemcachedClient.Remove(key);
		}
	}

	internal virtual void ValidateUniverseMembership(long originPlaceId, long reservedServerPlaceId)
	{
		IPlace place = Roblox.Platform.Assets.Factories.PlaceFactory.Get(originPlaceId);
		IPlace reservedServerPlace = Roblox.Platform.Assets.Factories.PlaceFactory.Get(reservedServerPlaceId);
		if (!place.CanCreateReservedServer(reservedServerPlace, _UniverseFactory))
		{
			throw new PlatformInvalidOperationException("Unable to generate access code.  Verify that origin and reservedServer places are in the same Universe");
		}
	}

	private static string GenerateKey(string reservedServerId, long playerId)
	{
		return "ReservedServerTicket_ServerId:" + reservedServerId + "_PlayerID:" + playerId;
	}

	private static void ValidatePlayers(long[] playerIds)
	{
		if (playerIds == null || playerIds.Length == 0)
		{
			throw new ArgumentException("PlayerIds cannot be null or empty", "playerIds");
		}
		if (playerIds.Any((long playerId) => playerId == 0))
		{
			throw new ArgumentException("PlayerIds cannot contain 0", "playerIds");
		}
	}

	private static byte[] Sign(byte[] key, byte[] content)
	{
		using HMACMD5 hmac = new HMACMD5(key);
		return hmac.ComputeHash(content).Concat(content).ToArray();
	}

	private static bool Verify(byte[] key, byte[] signedData, out byte[] content)
	{
		using HMACMD5 hmac = new HMACMD5(key);
		byte[] first = signedData.Take(16).ToArray();
		content = signedData.Skip(16).ToArray();
		byte[] computedHash = hmac.ComputeHash(content);
		return first.SequenceEqual(computedHash);
	}
}
