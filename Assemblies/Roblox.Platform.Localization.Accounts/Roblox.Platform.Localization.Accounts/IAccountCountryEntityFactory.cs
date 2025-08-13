namespace Roblox.Platform.Localization.Accounts;

internal interface IAccountCountryEntityFactory
{
	IAccountCountryEntity Get(long id);

	IAccountCountryEntity GetByAccountId(long accountId);

	IAccountCountryEntity GetOrCreate(long accountId, out bool entityWasCreated);
}
