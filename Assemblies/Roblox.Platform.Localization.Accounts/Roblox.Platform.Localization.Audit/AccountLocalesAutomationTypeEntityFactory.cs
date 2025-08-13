using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAutomationTypeEntityFactory : IAccountLocalesAutomationTypeEntityFactory
{
	public IAccountLocalesAutomationTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountLocalesAutomationTypeCAL.Get(id));
	}

	public IAccountLocalesAutomationTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountLocalesAutomationTypeCAL.GetByValue(value));
	}

	public IAccountLocalesAutomationTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountLocalesAutomationTypeCAL.GetOrCreate(value));
	}

	private static IAccountLocalesAutomationTypeEntity CalToCachedMssql(AccountLocalesAutomationTypeCAL cal)
	{
		if (cal != null)
		{
			return new AccountLocalesAutomationTypeCachedMssqlEntity
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
