using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditMetadataTypeEntityFactory : IAccountCountriesAuditMetadataTypeEntityFactory
{
	public IAccountCountriesAuditMetadataTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountCountriesAuditMetadataTypeCAL.Get(id));
	}

	public IAccountCountriesAuditMetadataTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountCountriesAuditMetadataTypeCAL.GetByValue(value));
	}

	public IAccountCountriesAuditMetadataTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountCountriesAuditMetadataTypeCAL.GetOrCreate(value));
	}

	private static IAccountCountriesAuditMetadataTypeEntity CalToCachedMssql(AccountCountriesAuditMetadataTypeCAL cal)
	{
		if (cal != null)
		{
			return new AccountCountriesAuditMetadataTypeCachedMssqlEntity
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
