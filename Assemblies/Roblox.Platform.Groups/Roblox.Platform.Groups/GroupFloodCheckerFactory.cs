using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups;

public class GroupFloodCheckerFactory : IGroupFloodCheckerFactory
{
	private const string _GroupFloodCheckerCategory = "Roblox.Platform.Groups";

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	public GroupFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ISettings settings, ILogger logger)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IFloodChecker GetJoinGroupFloodChecker(long userId)
	{
		return _FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Groups.JoinGroup", $"JoinGroupFloodChecker_UserId:{userId}", () => _Settings.JoinGroupFloodCheckerLimit, () => _Settings.JoinGroupFloodCheckerExpiry, () => _Settings.JoinGroupFloodCheckerEnabled, () => false, _Logger);
	}

	public IFloodChecker GetClaimOwnershipFloodChecker(long userId)
	{
		return _FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Groups.ClaimOwnership", $"ClaimOwnershipFloodChecker_UserId:{userId}", () => _Settings.ClaimOwnershipFloodCheckerLimit, () => _Settings.ClaimOwnershipFloodCheckerExpiry, () => _Settings.ClaimOwnershipFloodCheckerEnabled, () => false, _Logger);
	}
}
