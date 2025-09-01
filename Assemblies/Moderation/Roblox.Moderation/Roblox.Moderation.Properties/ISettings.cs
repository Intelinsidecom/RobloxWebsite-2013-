namespace Roblox.Moderation.Properties
{
    public interface ISettings
    {
        int GetOrCreateUnexpiredEntityAttempts { get; }
    }
}
