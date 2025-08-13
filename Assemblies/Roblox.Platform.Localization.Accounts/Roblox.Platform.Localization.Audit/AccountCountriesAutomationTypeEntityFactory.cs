using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAutomationTypeEntityFactory : IAccountCountriesAutomationTypeEntityFactory
{
	public IAccountCountriesAutomationTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountCountriesAutomationType.Get(id));
	}

	public IAccountCountriesAutomationTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountCountriesAutomationType.GetByValue(value));
	}

	public IAccountCountriesAutomationTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountCountriesAutomationType.GetOrCreate(value));
	}

	private static IAccountCountriesAutomationTypeEntity CalToCachedMssql(AccountCountriesAutomationType cal)
	{
		if (cal != null)
		{
			return new AccountCountriesAutomationTypeCachedMssqlEntity
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
