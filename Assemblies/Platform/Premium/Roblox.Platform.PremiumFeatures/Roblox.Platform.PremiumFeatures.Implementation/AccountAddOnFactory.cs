using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.PremiumFeatures.Interfaces;
using Roblox.PremiumFeatures.Properties;

namespace Roblox.PremiumFeatures.Implementation;

/// <summary>
/// Factory for AccountAddOns
/// </summary>
public class AccountAddOnFactory : IAccountAddOnFactory
{
	private bool _IsPremiumCheckEnabled => Settings.Default.IsPremiumCheckEnabled;

	/// <inheritdoc />
	public IAccountAddOnModel GetSubscriptionAccountAddOnForAccountId(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Invalid accountId");
		}
		return EntityToModel(GetSubscriptionAccountAddOn(accountId));
	}

	/// <inheritdoc />
	public ICollection<IAccountAddOnModel> GetAccountAddOnsByPremiumFeatureIDRenewalIsNullAndExpirationRange(int premiumFeatureId, DateTime minimumExpiration, DateTime maximumExpiration, bool isRenewal, int startRowIndex, int maximumRows)
	{
		return AccountAddOn.GetAccountAddOnsByPremiumFeatureIDRenewalIsNullAndExpirationRange(premiumFeatureId, minimumExpiration, maximumExpiration, isRenewal, startRowIndex, maximumRows).Select(EntityToModel).ToList();
	}

	/// <inheritdoc />
	public ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int leaseDurationInMinutes, int numberOfItems)
	{
		return AccountAddOnExpirationTask.LeaseWorkItems(workerId, leaseDurationInMinutes, numberOfItems);
	}

	/// <inheritdoc />
	public AccountAddOn LeaseAccountAddOnToMigrate(int id, Guid workerId, int leaseDurationInMinutes)
	{
		return AccountAddOn.LeaseAccountAddOnToMigrate(id, workerId, leaseDurationInMinutes);
	}

	/// <inheritdoc />
	public IAccountAddOnModel UpdateAddOnToUsePremiumFeatureId(AccountAddOn accountAddOn, int premiumFeatureId)
	{
		accountAddOn.PremiumFeatureID = premiumFeatureId;
		accountAddOn.Save();
		return EntityToModel(accountAddOn);
	}

	/// <inheritdoc />
	public IAccountAddOnModel GetBuildersClubMembershipAccountAddOn(long accountId)
	{
		AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(accountId);
		return EntityToModel(accountAddOn);
	}

	/// <inheritdoc />
	public IAccountAddOnModel CancelMembershipForAccountId(long accountId, bool isImmediate = false)
	{
		AccountAddOn accountAddOn = GetSubscriptionAccountAddOn(accountId);
		IAccountAddOnModel result = EntityToModel(accountAddOn);
		DateTime now = DateTime.Now;
		if (isImmediate)
		{
			accountAddOn.Expiration = now;
		}
		accountAddOn.Renewal = null;
		accountAddOn.Save();
		AccountFeatureSet accountFeatureSet = GetAccountFeatureSet(accountId);
		if (accountFeatureSet != null && accountFeatureSet.CanSellContent)
		{
			accountFeatureSet.CanSellContent = false;
			accountFeatureSet.Save();
		}
		return result;
	}

	/// <inheritdoc />
	public IAccountAddOnModel ReverseBuildersClubCancellationMembershipForAccountId(long accountId, IAccountAddOnModel originalAccountAddOnModel)
	{
		AccountAddOn accountAddOn = AccountAddOn.Get(originalAccountAddOnModel.Id);
		accountAddOn.Expiration = originalAccountAddOnModel.Expiration;
		accountAddOn.Renewal = originalAccountAddOnModel.Renewal;
		accountAddOn.Save();
		AccountFeatureSet accountFeatureSet = GetAccountFeatureSet(accountId);
		if (accountFeatureSet != null && !accountFeatureSet.CanSellContent)
		{
			accountFeatureSet.CanSellContent = true;
			accountFeatureSet.Save();
		}
		return EntityToModel(accountAddOn);
	}

	/// <inheritdoc />
	public IAccountAddOnModel UpdateSubscriptionForAccountId(long accountId, int premiumFeatureId, bool isRecurring = true)
	{
		return UpdateSubscriptionForAccountId(Convert.ToInt32(accountId), premiumFeatureId, isRecurring);
	}

	/// <inheritdoc />
	public IAccountAddOnModel UpdateSubscriptionForAccountId(int accountId, int premiumFeatureId, bool isRecurring = true)
	{
		PremiumFeature premiumFeature = PremiumFeature.Get(premiumFeatureId);
		if (premiumFeature == null)
		{
			throw new ArgumentException("Invalid Premium Feature Id.");
		}
		if (isRecurring && !premiumFeature.IsRenewal)
		{
			throw new ArgumentException("Premium Feature Id must be for a valid renewal product.");
		}
		if (!isRecurring && premiumFeature.IsRenewal)
		{
			throw new ArgumentException("Premium Feature Id must be for a valid non-renewal product.");
		}
		if (premiumFeature.IsAnyBuildersClub)
		{
			throw new ArgumentException("Cannot update subscription to BC membership.");
		}
		AccountAddOn accountAddOn = GetSubscriptionAccountAddOn(accountId);
		accountAddOn.PremiumFeatureID = premiumFeatureId;
		accountAddOn.Save();
		return EntityToModel(accountAddOn);
	}

	/// <inheritdoc />
	public bool IsPremiumAccount(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentOutOfRangeException("accountId");
		}
		if (_IsPremiumCheckEnabled)
		{
			return GetSubscriptionAccountAddOn(accountId) != null;
		}
		return _IsPremiumCheckEnabled;
	}

	public long GetRobuxStipendAmount(long accountId)
	{
		return GetSubscriptionAccountAddOn(accountId)?.GetStipendAmount() ?? 0;
	}

	private IAccountAddOnModel EntityToModel(AccountAddOn accountAddOn)
	{
		if (accountAddOn != null)
		{
			return new AccountAddOnModel(accountAddOn.ID, accountAddOn.AccountID, accountAddOn.PremiumFeatureID, accountAddOn.Renewal, accountAddOn.Expiration, accountAddOn.RobuxStipendID, accountAddOn.Created, accountAddOn.RenewedSince, accountAddOn.Name, accountAddOn.AccountAddOnTypeName, accountAddOn.IsLifetime);
		}
		return null;
	}

	private AccountAddOn GetSubscriptionAccountAddOn(long accountId)
	{
		return (from a in AccountAddOn.GetAccountAddOnsByAccountID(accountId)?.Where((AccountAddOn a) => a.Expiration > DateTime.Now)
			orderby a.Expiration descending
			select a).FirstOrDefault();
	}

	private AccountFeatureSet GetAccountFeatureSet(long accountId)
	{
		return AccountFeatureSet.GetByAccountId(accountId);
	}
}
