using System;
using System.Security.Cryptography;
using Roblox.FloodCheckers;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerLinkFactory
{
	public const byte LinkCodeLength = 32;

	internal static string GenerateLinkCode(long privateServerId, IUser authenticatedUser)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateLinkFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = FetchAndValidatePrivateServerEntity(privateServerId, authenticatedUser, floodChecker);
		if (privateServerEntity == null)
		{
			return null;
		}
		privateServerEntity.LinkCode = GenerateCryptographicallyStrongString(32);
		privateServerEntity.Save();
		floodChecker.UpdateCount();
		return privateServerEntity.LinkCode;
	}

	internal static void RemoveLinkCode(long privateServerId, IUser authenticatedUser)
	{
		FloodChecker floodChecker = GetPrivateServerUpdateLinkFloodChecker(privateServerId);
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = FetchAndValidatePrivateServerEntity(privateServerId, authenticatedUser, floodChecker);
		if (privateServerEntity != null)
		{
			privateServerEntity.LinkCode = null;
			floodChecker.UpdateCount();
			privateServerEntity.Save();
		}
	}

	private static FloodChecker GetPrivateServerUpdateLinkFloodChecker(long privateServerId)
	{
		string floodCheckerKey = "PrivateServerLinkFactory:UpdateLink_PrivateServerId:" + privateServerId;
		return new FloodChecker("PrivateServerLinkFactory.UpdateLink", floodCheckerKey, Settings.Default.PrivateServersUpdateLinkFloodCheckerLimit, new TimeSpan(0, 1, 0));
	}

	private static Roblox.Platform.Games.Entities.PrivateServer FetchAndValidatePrivateServerEntity(long privateServerId, IUser authenticatedUser, FloodChecker floodChecker)
	{
		if (authenticatedUser == null)
		{
			return null;
		}
		if (floodChecker.IsFlooded())
		{
			throw new PrivateServersOperationUnavailableException("Please wait a few minutes before configuring your VIP Server again.");
		}
		Roblox.Platform.Games.Entities.PrivateServer privateServerEntity = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		if (privateServerEntity == null)
		{
			throw new UnknownPrivateServerException(privateServerId);
		}
		if (privateServerEntity.OwnerUserID != authenticatedUser.Id)
		{
			throw new InvalidOwnerException(privateServerEntity.Translate(), authenticatedUser.Id, "You are not the owner of this VIP Server.");
		}
		return privateServerEntity;
	}

	private static string GenerateCryptographicallyStrongString(byte length)
	{
		int num = (byte)Math.Ceiling((double)(int)length / 4.0) * 3;
		RNGCryptoServiceProvider prng = new RNGCryptoServiceProvider();
		byte[] randomBytes = new byte[num];
		prng.GetBytes(randomBytes);
		return Convert.ToBase64String(randomBytes).Substring(0, length).Replace('+', '-')
			.Replace('/', '_');
	}
}
