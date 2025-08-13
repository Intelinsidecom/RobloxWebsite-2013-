using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesChangeAgentTypeEntityFactory : IAccountCountriesChangeAgentTypeEntityFactory
{
	public IAccountCountriesChangeAgentTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountCountriesChangeAgentTypeCAL.Get(id));
	}

	public IAccountCountriesChangeAgentTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountCountriesChangeAgentTypeCAL.GetByValue(value));
	}

	public IAccountCountriesChangeAgentTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountCountriesChangeAgentTypeCAL.GetOrCreate(value));
	}

	private static IAccountCountriesChangeAgentTypeEntity CalToCachedMssql(AccountCountriesChangeAgentTypeCAL cal)
	{
		if (cal != null)
		{
			return new AccountCountriesChangeAgentTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Description = cal.Description,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
