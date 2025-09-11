namespace Roblox.WebsiteSettings.Properties;

public interface IGameLaunchSettings
{
	bool IsGameJoinEnabled { get; }

	bool UseSessionIdToVerifyUserPresenceDuringTeleport { get; }

	bool BlockTeleportsIfUserSessionInvalid { get; }

	bool BlockTeleportsIfSessionIdHeaderAbsent { get; }

	bool UseTeleportValidationHelper { get; }

	bool StreamIllegalTeleportEvent { get; }

	bool AreWarningLogsEnabledForClbPlaceLaunchCheck { get; }

	bool IsPlayTogetherJoinPrivateGameEnabled { get; }
}
