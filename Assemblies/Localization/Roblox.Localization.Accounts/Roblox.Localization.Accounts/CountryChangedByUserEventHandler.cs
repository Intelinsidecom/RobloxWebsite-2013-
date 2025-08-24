namespace Roblox.Platform.Localization.Accounts;

/// <summary>
/// The CountryChangedByUserEventHandler definition.
/// </summary>
/// <param name="accountId">The account Id of the user whose country setting was changed.</param>
/// <param name="previousCountryId">The Id of the user's old country setting.</param>
/// <param name="newCountryId">The Id of the user's new country setting.</param>
/// <param name="actorId">The Id of the user initiating the change of one's country setting.</param>
public delegate void CountryChangedByUserEventHandler(long accountId, int? previousCountryId, int newCountryId, long actorId);
