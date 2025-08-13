namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountLocaleEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleEntity" /> with the given ID, or null if none existed.</returns>
	IAccountLocaleEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleEntity" /> with the given accountId
	/// </summary>
	/// <param name="accountId">The accountId associated with AccountLocale.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleEntity" /> with given accountId, or null if none existed.</returns>
	IAccountLocaleEntity GetByAccountId(long accountId);

	/// <summary>
	/// Create instance of <see cref="T:Roblox.Platform.Localization.Accounts.IAccountLocaleEntity" /> with the given account id, observed locale id and supported locale id
	/// </summary>
	/// <param name="accountId">account id of user</param>
	/// <param name="observedLocaleId"> observed locale id associated with account, must be positive.</param>
	/// <param name="supportedLocaleId">supported locale id associated with account, if not null then it must be positive and should present in valid list of supported locales.</param>
	/// <returns></returns>
	IAccountLocaleEntity Create(long accountId, int observedLocaleId, int? supportedLocaleId);
}
