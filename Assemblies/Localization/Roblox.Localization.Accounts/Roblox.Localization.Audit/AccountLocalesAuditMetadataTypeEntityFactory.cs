using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataTypeEntityFactory : IAccountLocalesAuditMetadataTypeEntityFactory
{
	public IAccountLocalesAuditMetadataTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountLocalesAuditMetadataTypeCAL.Get(id));
	}

	public IAccountLocalesAuditMetadataTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountLocalesAuditMetadataTypeCAL.GetByValue(value));
	}

	public IAccountLocalesAuditMetadataTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountLocalesAuditMetadataTypeCAL.GetOrCreate(value));
	}

	private static IAccountLocalesAuditMetadataTypeEntity CalToCachedMssql(AccountLocalesAuditMetadataTypeCAL cal)
	{
		if (cal != null)
		{
			return new AccountLocalesAuditMetadataTypeCachedMssqlEntity
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
