using System;
using Roblox.Billing.Interface;
using Roblox.PremiumFeatures.Models;
using Roblox.PremiumFeatures.Models.Core;
using Roblox.PremiumFeatures.Models.Enums;

namespace Roblox.Billing.Factories;

public class MembershipMigrationAuditLogFactory
{
	private readonly ICurrencyTypeFactory _CurrencyTypeFactory;

	public MembershipMigrationAuditLogFactory(ICurrencyTypeFactory currencyTypeFactory)
	{
		_CurrencyTypeFactory = currencyTypeFactory ?? throw new ArgumentNullException("currencyTypeFactory");
	}

	public MembershipMigrationAuditLogModel GetMembershipMigrationAuditLogByAccountId(long accountId)
	{
		return EntityToModel(MembershipMigrationAuditLog.GetByAccountId(accountId));
	}

	public MembershipMigrationAuditLogModel CreateOrUpdateMembershipMigrationAuditLog(long accountId, byte currencyTypeId, DateTime lastRobuxDistrubtionDate, int originalPremiumFeatureId, int updatedPremiumFeatureId, decimal originalPrice, decimal updatedPrice, int originalProductId, int updatedProductId, int robuxGrantAmount, long saleId, DateTime updatedMembershipStartDate)
	{
		if (accountId == 0L)
		{
			throw new ApplicationException("Account ID not specified.");
		}
		MembershipMigrationAuditLog entity = MembershipMigrationAuditLog.GetByAccountId(accountId);
		if (entity == null)
		{
			entity = MembershipMigrationAuditLog.CreateNew(accountId, currencyTypeId, lastRobuxDistrubtionDate, originalPremiumFeatureId, updatedPremiumFeatureId, originalPrice, updatedPrice, originalProductId, updatedProductId, robuxGrantAmount, saleId, updatedMembershipStartDate);
		}
		else
		{
			entity.CurrencyTypeID = currencyTypeId;
			entity.LastRobuxDistributionDate = lastRobuxDistrubtionDate;
			entity.OriginalPremiumFeatureID = originalPremiumFeatureId;
			entity.UpdatedPremiumFeatureID = updatedPremiumFeatureId;
			entity.OriginalPrice = originalPrice;
			entity.UpdatedPrice = updatedPrice;
			entity.OriginalProductID = originalProductId;
			entity.UpdatedProductID = updatedProductId;
			entity.RobuxGrantAmount = robuxGrantAmount;
			entity.SaleID = saleId;
			entity.UpdatedMembershipStartDate = updatedMembershipStartDate;
			entity.Save();
		}
		return EntityToModel(entity);
	}

	private MembershipMigrationAuditLogModel EntityToModel(MembershipMigrationAuditLog auditLog)
	{
		ICurrencyTypeModel priceCurrency = _CurrencyTypeFactory.Get(auditLog.CurrencyTypeID);
		Enum.TryParse<CurrencyType>(priceCurrency.Code, ignoreCase: true, out var originalPriceCurrencyType);
		Currency priceCurrencyModel = new Currency(priceCurrency.ID, priceCurrency.Name, originalPriceCurrencyType, priceCurrency.Symbol);
		return new MembershipMigrationAuditLogModel
		{
			Id = auditLog.ID,
			AccountId = auditLog.AccountID,
			Created = auditLog.Created,
			Updated = auditLog.Updated,
			CurrencyTypeId = auditLog.CurrencyTypeID,
			LastRobuxDistributionDate = auditLog.LastRobuxDistributionDate,
			OriginalPremiumFeatureId = auditLog.OriginalPremiumFeatureID,
			UpdatedPremiumFeatureId = auditLog.UpdatedPremiumFeatureID,
			OriginalPrice = new Money
			{
				Amount = auditLog.OriginalPrice,
				Currency = priceCurrencyModel
			},
			UpdatedPrice = new Money
			{
				Amount = auditLog.UpdatedPrice,
				Currency = priceCurrencyModel
			},
			OriginalProductId = auditLog.OriginalProductID,
			UpdatedProductId = auditLog.UpdatedProductID,
			RobuxGrantAmount = auditLog.RobuxGrantAmount,
			SaleID = auditLog.SaleID,
			UpdatedMembershipStartDate = auditLog.UpdatedMembershipStartDate
		};
	}
}
