using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class MembershipMigrationStatusEntityFactory : IMembershipMigrationStatusEntityFactory
{
	private MigrationStateConverter _MigrationStateConverter;

	public MembershipMigrationStatusEntityFactory(MigrationStateConverter migrationStateConverter)
	{
		_MigrationStateConverter = migrationStateConverter ?? throw new ArgumentNullException("migrationStateConverter");
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity Get(long id)
	{
		return CalToCachedMssql(MembershipMigrationStatusEntity.Get(id));
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity GetOrCreate(long accountId, int originalPremiumFeatureId = 0, int updatedPremiumFeatureId = 0, DateTime? premiumStartDate = null, int robuxDistributionAmount = 0, MembershipMigrationState migrationState = MembershipMigrationState.Unknown)
	{
		if (!Enum.IsDefined(typeof(MembershipMigrationState), migrationState))
		{
			return null;
		}
		int migrationStateId = _MigrationStateConverter.GetIdByEnum(migrationState);
		return CalToCachedMssql(MembershipMigrationStatusEntity.GetOrCreate(accountId, originalPremiumFeatureId, updatedPremiumFeatureId, premiumStartDate, robuxDistributionAmount, migrationStateId));
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity GetByAccountId(long accountId)
	{
		return CalToCachedMssql(MembershipMigrationStatusEntity.GetByAccountId(accountId));
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity Create(long accountId, MembershipMigrationState migrationState = MembershipMigrationState.Unknown)
	{
		if (!Enum.IsDefined(typeof(MembershipMigrationState), migrationState))
		{
			return null;
		}
		int migrationStateId = _MigrationStateConverter.GetIdByEnum(migrationState);
		return CalToCachedMssql(MembershipMigrationStatusEntity.CreateNew(accountId, migrationStateId));
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateMembershipMigrationStateById(long id, MembershipMigrationState migrationState)
	{
		if (!Enum.IsDefined(typeof(MembershipMigrationState), migrationState))
		{
			return null;
		}
		int migrationStateId = _MigrationStateConverter.GetIdByEnum(migrationState);
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = MembershipMigrationStatusEntity.Get(id);
		membershipMigrationStatusEntity.MigrationStateID = migrationStateId;
		membershipMigrationStatusEntity.Save();
		return CalToCachedMssql(membershipMigrationStatusEntity);
	}

	public IMembershipMigrationStatusEntity UpdateMembershipMigrationStateByAccountId(long accountId, MembershipMigrationState migrationState)
	{
		if (!Enum.IsDefined(typeof(MembershipMigrationState), migrationState))
		{
			return null;
		}
		int migrationStateId = _MigrationStateConverter.GetIdByEnum(migrationState);
		MembershipMigrationStatusEntity byAccountId = MembershipMigrationStatusEntity.GetByAccountId(accountId);
		byAccountId.MigrationStateID = migrationStateId;
		byAccountId.Save();
		return CalToCachedMssql(byAccountId);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateOriginalPremiumFeatureIdById(long id, int premiumFeatureId)
	{
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = MembershipMigrationStatusEntity.Get(id);
		membershipMigrationStatusEntity.OriginalPremiumFeatureID = premiumFeatureId;
		membershipMigrationStatusEntity.Save();
		return CalToCachedMssql(membershipMigrationStatusEntity);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateOriginalPremiumFeatureIdByAccountId(long accountId, int premiumFeatureId)
	{
		MembershipMigrationStatusEntity byAccountId = MembershipMigrationStatusEntity.GetByAccountId(accountId);
		byAccountId.OriginalPremiumFeatureID = premiumFeatureId;
		byAccountId.Save();
		return CalToCachedMssql(byAccountId);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateUpdatedPremiumFeatureIdById(long id, int premiumFeatureId)
	{
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = MembershipMigrationStatusEntity.Get(id);
		membershipMigrationStatusEntity.UpdatedPremiumFeatureID = premiumFeatureId;
		membershipMigrationStatusEntity.Save();
		return CalToCachedMssql(membershipMigrationStatusEntity);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateUpdatedPremiumFeatureIdByAccountId(long accountId, int premiumFeatureId)
	{
		MembershipMigrationStatusEntity byAccountId = MembershipMigrationStatusEntity.GetByAccountId(accountId);
		byAccountId.UpdatedPremiumFeatureID = premiumFeatureId;
		byAccountId.Save();
		return CalToCachedMssql(byAccountId);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdatePremiumStartDateById(long id, DateTime premiumStartDate)
	{
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = MembershipMigrationStatusEntity.Get(id);
		membershipMigrationStatusEntity.PremiumStartDate = premiumStartDate;
		membershipMigrationStatusEntity.Save();
		return CalToCachedMssql(membershipMigrationStatusEntity);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdatePremiumStartDateByAccountId(long accountId, DateTime premiumStartDate)
	{
		MembershipMigrationStatusEntity byAccountId = MembershipMigrationStatusEntity.GetByAccountId(accountId);
		byAccountId.PremiumStartDate = premiumStartDate;
		byAccountId.Save();
		return CalToCachedMssql(byAccountId);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateRobuxDistributionAmountById(long id, int robuxDistributionAmount)
	{
		MembershipMigrationStatusEntity membershipMigrationStatusEntity = MembershipMigrationStatusEntity.Get(id);
		membershipMigrationStatusEntity.RobuxDistributionAmount = robuxDistributionAmount;
		membershipMigrationStatusEntity.Save();
		return CalToCachedMssql(membershipMigrationStatusEntity);
	}

	/// <inheritdoc />
	public IMembershipMigrationStatusEntity UpdateRobuxDistributionAmountByAccountId(long accountId, int robuxDistributionAmount)
	{
		MembershipMigrationStatusEntity byAccountId = MembershipMigrationStatusEntity.GetByAccountId(accountId);
		byAccountId.RobuxDistributionAmount = robuxDistributionAmount;
		byAccountId.Save();
		return CalToCachedMssql(byAccountId);
	}

	private static IMembershipMigrationStatusEntity CalToCachedMssql(MembershipMigrationStatusEntity cal)
	{
		if (cal != null)
		{
			return new MembershipMigrationStatusCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				OriginalPremiumFeatureId = cal.OriginalPremiumFeatureID,
				UpdatedPremiumFeatureId = cal.UpdatedPremiumFeatureID,
				PremiumStartDate = cal.PremiumStartDate,
				RobuxDistributionAmount = cal.RobuxDistributionAmount,
				MigrationStateID = cal.MigrationStateID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
