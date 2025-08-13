namespace Roblox.Platform.Moderation.Properties;

public interface ISettings
{
	int GetOrCreateUnexpiredEntityAttempts { get; }
}
