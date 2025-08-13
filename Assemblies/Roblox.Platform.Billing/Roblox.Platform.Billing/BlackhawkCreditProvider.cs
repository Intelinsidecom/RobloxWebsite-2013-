using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.Billing;
using Roblox.Billing.Client;
using Roblox.Billing.Client.Enums;
using Roblox.Billing.Client.Model;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Locking;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Billing.Interface;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

internal class BlackhawkCreditProvider : BaseCreditProvider
{
	protected new readonly ISettings Settings;

	protected readonly IBillingClient BillingClient;

	protected new readonly ILogger Logger;

	protected new readonly ICounter AddPrepaidCreditFailureCounter;

	protected readonly IReadOnlyDictionary<RedeemXsollaBlackhawkErrorCode, ICounter> BlackhawkStatusCounters;

	protected new readonly IAssetOwnershipAuthority AssetOwnershipAuthority;

	protected const string FloodCheckerCategory = "Roblox.Platform.Billing.BlackhawkCreditProvider";

	public BlackhawkCreditProvider(ISettings settings, IBillingClient billingClient, ILogger logger, IEphemeralCounterFactory counterFactory, IThrowingLeasedLockFactory leasedLockFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IAssetOwnershipAuthority assetOwnershipAuthority)
		: base("XsollaBlackhawk", settings, logger, counterFactory, leasedLockFactory, floodCheckerFactory, assetOwnershipAuthority)
	{
		BillingClient = billingClient.AssignOrThrowIfNull<IBillingClient>("billingClient");
		Logger = logger.AssignOrThrowIfNull("logger");
		Settings = settings.AssignOrThrowIfNull("settings");
	}

	protected override ICreditRedemptionResult ExecuteRedeem(IUser user, string ip, string pinCode)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		XsollaBlackhawkRedemptionModel result = BillingClient.ProcessXsollaBlackhawkRedemption(user.Id.ToString(), ip, pinCode);
		XsollaBlackhawkRedemptionErrorModel error;
		if ((error = (XsollaBlackhawkRedemptionErrorModel)(object)((result is XsollaBlackhawkRedemptionErrorModel) ? result : null)) == null)
		{
			return GetCreditRedemptionSuccessResult(result.AmountRedeemed, result.TransactionId, result.MerchantId);
		}
		return GetCreditRedemptionFailureResult(MapBlackhawkFailureReason(error.ErrorCode));
	}

	protected override async Task<ICreditRedemptionResult> ExecuteRedeemAsync(IUser user, string ip, string pinCode)
	{
		XsollaBlackhawkRedemptionModel result = await BillingClient.ProcessXsollaBlackhawkRedemptionAsync(user.Id.ToString(), ip, pinCode).ConfigureAwait(continueOnCapturedContext: false);
		XsollaBlackhawkRedemptionErrorModel error;
		return ((error = (XsollaBlackhawkRedemptionErrorModel)(object)((result is XsollaBlackhawkRedemptionErrorModel) ? result : null)) != null) ? GetCreditRedemptionFailureResult(MapBlackhawkFailureReason(error.ErrorCode)) : GetCreditRedemptionSuccessResult(result.AmountRedeemed, result.TransactionId, result.MerchantId);
	}

	protected override ICreditReversalResult ExecuteReverseRedemption(IUser user, string pinCode)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		ReverseXsollaBlackhawkModel result = BillingClient.ProcessXsollaBlackhawkReversal(user.Id.ToString(), pinCode);
		ReverseXsollaBlackhawkErrorModel error;
		if ((error = (ReverseXsollaBlackhawkErrorModel)(object)((result is ReverseXsollaBlackhawkErrorModel) ? result : null)) == null)
		{
			return GetCreditReversalSuccessResult(result.TransactionId);
		}
		return GetCreditReversalFailureResult(MapBlackhawkReversalFailureReason(error.ErrorCode));
	}

	protected override async Task<ICreditReversalResult> ExecuteReverseRedemptionAsync(IUser user, string pinCode)
	{
		ReverseXsollaBlackhawkModel result = await BillingClient.ProcessXsollaBlackhawkReversalAsync(user.Id.ToString(), pinCode).ConfigureAwait(continueOnCapturedContext: false);
		ReverseXsollaBlackhawkErrorModel error;
		return ((error = (ReverseXsollaBlackhawkErrorModel)(object)((result is ReverseXsollaBlackhawkErrorModel) ? result : null)) != null) ? GetCreditReversalFailureResult(MapBlackhawkReversalFailureReason(error.ErrorCode)) : GetCreditReversalSuccessResult(result.TransactionId);
	}

	protected override ICreditStatusResult ExecuteBlachawkStatusLookup(IUser user, string pinCode)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		XsollaBlackhawkStatusModel result = BillingClient.ProcessXsollaBlackhawkStatusLookup(user.Id.ToString(), pinCode);
		XsollaBlackhawkStatusErrorModel error;
		if ((error = (XsollaBlackhawkStatusErrorModel)(object)((result is XsollaBlackhawkStatusErrorModel) ? result : null)) == null)
		{
			return GetStatusLookupSuccessResult(result);
		}
		return GetStatusLookupFailureResult(MapBlackhawkStatusFailureReason(error.ErrorCode));
	}

	protected override async Task<ICreditStatusResult> ExecuteBlachawkStatusLookupAsync(IUser user, string pinCode)
	{
		XsollaBlackhawkStatusModel result = await BillingClient.ProcessXsollaBlackhawkStatusLookupAsync(user.Id.ToString(), pinCode).ConfigureAwait(continueOnCapturedContext: false);
		XsollaBlackhawkStatusErrorModel error;
		return ((error = (XsollaBlackhawkStatusErrorModel)(object)((result is XsollaBlackhawkStatusErrorModel) ? result : null)) != null) ? GetStatusLookupFailureResult(MapBlackhawkStatusFailureReason(error.ErrorCode)) : GetStatusLookupSuccessResult(result);
	}

	protected override IAddPrepaidCreditResult ExecuteAddPrepaidCredit(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId)
	{
		decimal newBalance;
		try
		{
			CreditBalance orCreate = CreditBalance.GetOrCreate(user.AccountId);
			orCreate.Credit(creditAmount);
			CreditTransactionHistory.Submit(user.AccountId, CreditTransactionType.CreditID, refNumber, CreditTransactionOriginType.InCommID, creditAmount);
			newBalance = orCreate.Balance;
		}
		catch (Exception e)
		{
			Logger.Error($"Unable to update user {user.AccountId}'s credit Balance for card '{pinCode}': {e}");
			AddPrepaidCreditFailureCounter.IncrementInBackground();
			return GetAddCreditFailureResult(CreditRedemptionFailureReason.AddCreditFailed);
		}
		return GetAddCreditSuccessResult(newBalance);
	}

	protected override async Task<IAddPrepaidCreditResult> ExecuteAddPrepaidCreditAsync(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId)
	{
		return ExecuteAddPrepaidCredit(user, creditAmount, refNumber, pinCode, merchantId);
	}

	protected override IGrantMerchantAssetsResult ExecuteGrantMerchantAssets(IUser user, Merchant merchant, decimal creditAmount)
	{
		IEnumerable<long> assetsToGrant = (from assetAwardList in AssetAwardList.GetAssetAwardListsByMerchantIDActivationDateBefore(merchant.ID, DateTime.Now)
			orderby assetAwardList.ActivationDate descending
			select assetAwardList).First().AssetAwardListItems.Select((AssetAwardListItem li) => li.AssetID);
		return AwardAssetsToUser(user, assetsToGrant);
	}

	private IAddPrepaidCreditResult GetAddCreditSuccessResult(decimal newBalance)
	{
		return new AddPrepaidCreditResult
		{
			IsSuccess = true,
			NewBalance = newBalance,
			FailureReason = CreditRedemptionFailureReason.None
		};
	}

	private IAddPrepaidCreditResult GetAddCreditFailureResult(CreditRedemptionFailureReason reason)
	{
		return new AddPrepaidCreditResult
		{
			IsSuccess = false,
			FailureReason = reason
		};
	}

	private CreditReversalFailureReason MapBlackhawkReversalFailureReason(ReverseXsollaBlackhawkErrorCode error)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if ((int)error <= 20)
		{
			if ((int)error == 0)
			{
				return CreditReversalFailureReason.None;
			}
			if ((int)error == 10)
			{
				return CreditReversalFailureReason.CardNotRedeemed;
			}
			if ((int)error == 20)
			{
				return CreditReversalFailureReason.InvalidPin;
			}
		}
		else if ((int)error <= 40)
		{
			if ((int)error == 30)
			{
				return CreditReversalFailureReason.NetworkFailure;
			}
			if ((int)error == 40)
			{
			}
		}
		else
		{
			if ((int)error == 50)
			{
				return CreditReversalFailureReason.ConfigurationError;
			}
			if ((int)error == int.MaxValue)
			{
			}
		}
		return CreditReversalFailureReason.Unknown;
	}

	private CreditRedemptionFailureReason MapBlackhawkFailureReason(RedeemXsollaBlackhawkErrorCode error)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if ((int)error <= 20)
		{
			if ((int)error == 0)
			{
				return CreditRedemptionFailureReason.None;
			}
			if ((int)error == 10)
			{
				return CreditRedemptionFailureReason.CardAlreadyRedeemed;
			}
			if ((int)error == 20)
			{
				return CreditRedemptionFailureReason.InvalidPin;
			}
		}
		else if ((int)error <= 40)
		{
			if ((int)error == 30)
			{
				return CreditRedemptionFailureReason.NetworkFailure;
			}
			if ((int)error == 40)
			{
			}
		}
		else
		{
			if ((int)error == 50)
			{
				return CreditRedemptionFailureReason.ConfigurationError;
			}
			if ((int)error == int.MaxValue)
			{
			}
		}
		return CreditRedemptionFailureReason.Unknown;
	}

	private CreditStatusFailureReason MapBlackhawkStatusFailureReason(XsollaBlackhawkStatusErrorCode error)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		if ((int)error <= 20)
		{
			if ((int)error == 0)
			{
				return CreditStatusFailureReason.None;
			}
			if ((int)error == 10)
			{
				return CreditStatusFailureReason.CardNotRedeemed;
			}
			if ((int)error == 20)
			{
				return CreditStatusFailureReason.InvalidPin;
			}
		}
		else if ((int)error <= 40)
		{
			if ((int)error == 30)
			{
				return CreditStatusFailureReason.NetworkFailure;
			}
			if ((int)error == 40)
			{
			}
		}
		else
		{
			if ((int)error == 50)
			{
				return CreditStatusFailureReason.ConfigurationError;
			}
			if ((int)error == int.MaxValue)
			{
			}
		}
		return CreditStatusFailureReason.Unknown;
	}
}
