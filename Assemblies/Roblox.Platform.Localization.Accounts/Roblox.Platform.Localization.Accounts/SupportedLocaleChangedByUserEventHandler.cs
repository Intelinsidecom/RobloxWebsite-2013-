namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// The SupportedLocaleChangedByUserEventHandler definition.
/// </summary>
/// <param name="accountId">The account Id of the user whose supported locale was changed.</param>
/// <param name="previousSupportedLocaleId">The Id of the user's old supported locale setting.</param>
/// <param name="newSupportedLocaleId">The Id of the user's new supported locale setting.</param>
/// <param name="actorId">The Id of the user initiating the change of one's supported locale setting.</param>
public delegate void SupportedLocaleChangedByUserEventHandler(long accountId, int? previousSupportedLocaleId, int? newSupportedLocaleId, long actorId);
