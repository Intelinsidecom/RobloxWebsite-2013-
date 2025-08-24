using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class MembershipMigrationStateEntityFactory : IMembershipMigrationStateEntityFactory
{
	public IMembershipMigrationStateEntity Get(int id)
	{
		return CalToCachedMssql(MembershipMigrationStateEntity.Get(id));
	}

	/// <summary>
	/// Gets a <see cref="T:Roblox.PremiumFeatures.MembershipMigrationStateEntity" /> by value
	/// </summary>
	public IMembershipMigrationStateEntity GetByValue(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return CalToCachedMssql(MembershipMigrationStateEntity.GetByValue(value));
	}

	private static IMembershipMigrationStateEntity CalToCachedMssql(MembershipMigrationStateEntity cal)
	{
		if (cal != null)
		{
			return new MembershipMigrationStateCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
