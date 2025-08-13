namespace Roblox.Platform.Privacy;

/// <summary>
/// Represents a user's in-Game chat privacy level. Note that unlike all other privacy settings, game chat can have a null user,
/// since guests can participate in in-game chat.
/// </summary>
public interface IGameChatPrivacySetting : IUserPrivacySetting
{
}
