namespace Roblox.Platform.Games.Events;

public enum ServerConfigurationEventType
{
	ModifyWhiteList = 1,
	DeveloperDisallow,
	DeveloperAllow,
	OwnerDeactivate,
	OwnerActivate,
	OwnerAllowFriends,
	OwnerDisallowFriends,
	OwnerChangeAllowedClans,
	DeveloperChangePrice,
	OwnerCancel
}
