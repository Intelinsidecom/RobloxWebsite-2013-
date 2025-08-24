using System;
using Roblox.EventLog;

namespace Roblox.PremiumFeatures;

public class MigrationStateConverter
{
	private ILogger _Logger;

	private IMembershipMigrationStateEntityFactory _MembershipMigrationStateEntityFactory { get; }

	public MigrationStateConverter(IMembershipMigrationStateEntityFactory membershipMigrationStateEntityFactory, ILogger logger)
	{
		_MembershipMigrationStateEntityFactory = membershipMigrationStateEntityFactory ?? throw new ArgumentNullException("membershipMigrationStateEntityFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <summary>
	/// Gets the ID associated with the <see cref="T:Roblox.PremiumFeatures.MembershipMigrationStateEntity" />
	/// </summary>
	/// <param name="migrationState"></param>
	/// <returns></returns>
	public int GetIdByEnum(MembershipMigrationState migrationState)
	{
		string stateValue = migrationState.GetValue();
		IMembershipMigrationStateEntity byValue = _MembershipMigrationStateEntityFactory.GetByValue(stateValue);
		if (byValue == null)
		{
			Exception ex = new Exception($"Attempted lookup of unpersisted MembershipMigrationStateEntity '{migrationState}'");
			_Logger.Error(ex);
			throw ex;
		}
		return byValue.Id;
	}
}
