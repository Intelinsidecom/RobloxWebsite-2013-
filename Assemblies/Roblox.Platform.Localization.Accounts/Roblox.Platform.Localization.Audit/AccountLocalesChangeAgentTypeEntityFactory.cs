using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesChangeAgentTypeEntityFactory : IAccountLocalesChangeAgentTypeEntityFactory
{
	public IAccountLocalesChangeAgentTypeEntity Get(byte id)
	{
		return CalToCachedMssql(AccountLocalesChangeAgentTypeCAL.Get(id));
	}

	public IAccountLocalesChangeAgentTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(AccountLocalesChangeAgentTypeCAL.GetByValue(value));
	}

	public IAccountLocalesChangeAgentTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(AccountLocalesChangeAgentTypeCAL.GetOrCreate(value));
	}

	private static IAccountLocalesChangeAgentTypeEntity CalToCachedMssql(AccountLocalesChangeAgentTypeCAL cal)
	{
		if (cal != null)
		{
			return new AccountLocalesChangeAgentTypeCachedMssqlEntity
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
