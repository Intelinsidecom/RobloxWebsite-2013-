namespace Roblox.Localization.Accountsinternal {
    interface IAccountCountryEntityFactory

{
	IAccountCountryEntity Get(long id);

	IAccountCountryEntity GetByAccountId(long accountId);

	IAccountCountryEntity GetOrCreate(long accountId, out bool entityWasCreated);
}


}
