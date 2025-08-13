using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.Billing;
using Roblox.Billing.Client.Model;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Locking;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Billing.Implementation;
using Roblox.Platform.Billing.Interface;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Billing;

internal abstract class BaseCreditProvider : ICreditProvider
{
	private const string _FloodCheckerCategory = "Roblox.Platform.Billing.BaseCreditProvider";

	protected readonly ISettings Settings;

	protected readonly ILogger Logger;

	protected readonly IFloodCheckerFactory<IFloodChecker> FloodCheckerFactory;

	protected readonly IThrowingLeasedLockFactory LeasedLockFactory;

	protected readonly IAssetOwnershipAuthority AssetOwnershipAuthority;

	protected readonly ICounter GamecardRedemptionLogWriteFailureCounter;

	protected readonly ICounter RedemptionFailureCounter;

	protected readonly ICounter ReversalFailureCounter;

	protected readonly ICounter RedemptionFloodcheckFailureCounter;

	protected readonly ICounter AddPrepaidCreditFailureCounter;

	protected readonly ICounter RedemptionSuccessCounter;

	protected readonly ICounter RedemptionAttemptCounter;

	protected readonly ICounter RedemptionFailureNoExceptionThrown;

	protected readonly ICounter GrantAssetSuccessCounter;

	protected readonly ICounter GrantAssetAttemptCounter;

	protected readonly ICounter GrantAssetFailureCounter;

	protected BaseCreditProvider(string providerName, ISettings settings, ILogger logger, IEphemeralCounterFactory counterFactory, IThrowingLeasedLockFactory leasedLockFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		Settings = settings.AssignOrThrowIfNull("settings");
		Logger = logger.AssignOrThrowIfNull("logger");
		FloodCheckerFactory = floodCheckerFactory.AssignOrThrowIfNull("floodCheckerFactory");
		LeasedLockFactory = leasedLockFactory.AssignOrThrowIfNull("leasedLockFactory");
		AssetOwnershipAuthority = assetOwnershipAuthority.AssignOrThrowIfNull("assetOwnershipAuthority");
		RedemptionFailureCounter = counterFactory.GetCounter($"{providerName}_CreditRedemptionFailure");
		ReversalFailureCounter = counterFactory.GetCounter($"{providerName}_CreditReversalFailure");
		GamecardRedemptionLogWriteFailureCounter = counterFactory.GetCounter($"{providerName}_GamecardRedemptionLogWriteFailure");
		RedemptionFloodcheckFailureCounter = counterFactory.GetCounter($"{providerName}_CreditRedemptionFloodcheckFailure");
		AddPrepaidCreditFailureCounter = counterFactory.GetCounter($"{providerName}_AddPrepaidCreditFailure");
		RedemptionSuccessCounter = counterFactory.GetCounter($"{providerName}_CreditRedemptionSuccess");
		RedemptionAttemptCounter = counterFactory.GetCounter($"{providerName}_CreditRedemptionAttempt");
		RedemptionFailureNoExceptionThrown = counterFactory.GetCounter($"{providerName}_CreditRedemptionFailureNoExceptionThrown");
		GrantAssetAttemptCounter = counterFactory.GetCounter($"{providerName}_GrantAssetAttemptCounter");
		GrantAssetSuccessCounter = counterFactory.GetCounter($"{providerName}_GrantAssetSuccessCounter");
		GrantAssetFailureCounter = counterFactory.GetCounter($"{providerName}_GrantAssetFailureCounter");
	}

	public ICreditRedemptionResult Redeem(IUser user, string ip, string pinCode)
	{
		RedemptionAttemptCounter.IncrementInBackground();
		IFloodChecker floodChecker = GetFloodCheckerForUser(user);
		floodChecker.UpdateCount();
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				ICreditRedemptionResult floodCheckResult = GetFloodCheckError(floodChecker, user);
				if (floodCheckResult != null)
				{
					return floodCheckResult;
				}
				ICreditRedemptionResult creditRedemptionResult = ExecuteRedeem(user, ip, pinCode);
				if (creditRedemptionResult.IsSuccess)
				{
					RedemptionSuccessCounter.IncrementInBackground();
				}
				else
				{
					RedemptionFailureNoExceptionThrown.IncrementInBackground();
				}
				return creditRedemptionResult;
			}
		}
		catch (LeasedLockException e2)
		{
			return GetCreditRedemptionFailureResult(CreditRedemptionFailureReason.LeasedLockCollision, e2);
		}
		catch (Exception e)
		{
			return GetCreditRedemptionFailureResult(CreditRedemptionFailureReason.Unknown, e);
		}
	}

	public async Task<ICreditRedemptionResult> RedeemAsync(IUser user, string ip, string pinCode)
	{
		RedemptionAttemptCounter.IncrementInBackground();
		IFloodChecker floodChecker = GetFloodCheckerForUser(user);
		floodChecker.UpdateCount();
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				ICreditRedemptionResult floodCheckResult = GetFloodCheckError(floodChecker, user);
				if (floodCheckResult != null)
				{
					return floodCheckResult;
				}
				ICreditRedemptionResult obj = await ExecuteRedeemAsync(user, ip, pinCode).ConfigureAwait(continueOnCapturedContext: false);
				if (obj.IsSuccess)
				{
					RedemptionSuccessCounter.IncrementInBackground();
				}
				else
				{
					RedemptionFailureNoExceptionThrown.IncrementInBackground();
				}
				return obj;
			}
		}
		catch (LeasedLockException e2)
		{
			return GetCreditRedemptionFailureResult(CreditRedemptionFailureReason.LeasedLockCollision, e2);
		}
		catch (Exception e)
		{
			return GetCreditRedemptionFailureResult(CreditRedemptionFailureReason.Unknown, e);
		}
	}

	public ICreditReversalResult ReverseRedemption(IUser user, string pinCode)
	{
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				return ExecuteReverseRedemption(user, pinCode);
			}
		}
		catch (LeasedLockException e2)
		{
			return GetCreditReversalFailureResult(CreditReversalFailureReason.LeasedLockCollision, e2);
		}
		catch (Exception e)
		{
			return GetCreditReversalFailureResult(CreditReversalFailureReason.Unknown, e);
		}
	}

	public async Task<ICreditReversalResult> ReverseRedemptionAsync(IUser user, string pinCode)
	{
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				return await ExecuteReverseRedemptionAsync(user, pinCode);
			}
		}
		catch (LeasedLockException e)
		{
			return GetCreditReversalFailureResult(CreditReversalFailureReason.LeasedLockCollision, e);
		}
		catch (Exception e2)
		{
			return GetCreditReversalFailureResult(CreditReversalFailureReason.Unknown, e2);
		}
	}

	public ICreditStatusResult StatusLookup(IUser user, string pinCode)
	{
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				return ExecuteBlachawkStatusLookup(user, pinCode);
			}
		}
		catch (LeasedLockException e2)
		{
			return GetStatusLookupFailureResult(CreditStatusFailureReason.LeasedLockCollision, e2);
		}
		catch (Exception e)
		{
			return GetStatusLookupFailureResult(CreditStatusFailureReason.Unknown, e);
		}
	}

	public async Task<ICreditStatusResult> StatusLookupAsync(IUser user, string pinCode)
	{
		try
		{
			using (TryAcquireSqlLeasedLock(pinCode))
			{
				return await ExecuteBlachawkStatusLookupAsync(user, pinCode);
			}
		}
		catch (LeasedLockException e)
		{
			return GetStatusLookupFailureResult(CreditStatusFailureReason.LeasedLockCollision, e);
		}
		catch (Exception e2)
		{
			return GetStatusLookupFailureResult(CreditStatusFailureReason.Unknown, e2);
		}
	}

	public IAddPrepaidCreditResult AddPrepaidCredit(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId)
	{
		IAddPrepaidCreditResult addPrepaidCreditResult = ExecuteAddPrepaidCredit(user, creditAmount, refNumber, pinCode, merchantId);
		if (addPrepaidCreditResult.IsSuccess)
		{
			LogRedemption(user, merchantId, creditAmount, pinCode);
			return addPrepaidCreditResult;
		}
		AddPrepaidCreditFailureCounter.IncrementInBackground();
		return addPrepaidCreditResult;
	}

	public async Task<IAddPrepaidCreditResult> AddPrepaidCreditAsync(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId)
	{
		IAddPrepaidCreditResult obj = await ExecuteAddPrepaidCreditAsync(user, creditAmount, refNumber, pinCode, merchantId).ConfigureAwait(continueOnCapturedContext: false);
		if (obj.IsSuccess)
		{
			LogRedemption(user, merchantId, creditAmount, pinCode);
		}
		else
		{
			AddPrepaidCreditFailureCounter.IncrementInBackground();
		}
		return obj;
	}

	public IGrantMerchantAssetsResult GrantMerchantAssets(IUser user, byte merchantId, decimal creditAmount)
	{
		GrantAssetAttemptCounter.IncrementInBackground();
		Merchant merchant = Merchant.Get(merchantId);
		IGrantMerchantAssetsResult grantMerchantAssetsResult = ExecuteGrantMerchantAssets(user, merchant, creditAmount);
		if (grantMerchantAssetsResult.IsSuccess)
		{
			GrantAssetSuccessCounter.IncrementInBackground();
			return grantMerchantAssetsResult;
		}
		GrantAssetFailureCounter.IncrementInBackground();
		return grantMerchantAssetsResult;
	}

	public async Task<IGrantMerchantAssetsResult> GrantMerchantAssetsAsync(IUser user, byte merchantId, decimal creditAmount)
	{
		GrantAssetAttemptCounter.IncrementInBackground();
		Merchant merchant = Merchant.Get(merchantId);
		IGrantMerchantAssetsResult obj = await ExecuteGrantMerchantAssetsAsync(user, merchant, creditAmount);
		if (obj.IsSuccess)
		{
			GrantAssetSuccessCounter.IncrementInBackground();
		}
		else
		{
			GrantAssetFailureCounter.IncrementInBackground();
		}
		return obj;
	}

	protected abstract ICreditRedemptionResult ExecuteRedeem(IUser user, string ip, string pinCode);

	protected abstract Task<ICreditRedemptionResult> ExecuteRedeemAsync(IUser user, string ip, string pinCode);

	protected abstract ICreditReversalResult ExecuteReverseRedemption(IUser user, string pinCode);

	protected abstract Task<ICreditReversalResult> ExecuteReverseRedemptionAsync(IUser user, string pinCode);

	protected abstract ICreditStatusResult ExecuteBlachawkStatusLookup(IUser user, string pinCode);

	protected abstract Task<ICreditStatusResult> ExecuteBlachawkStatusLookupAsync(IUser user, string pinCode);

	protected abstract IAddPrepaidCreditResult ExecuteAddPrepaidCredit(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId);

	protected abstract Task<IAddPrepaidCreditResult> ExecuteAddPrepaidCreditAsync(IUser user, decimal creditAmount, string refNumber, string pinCode, byte merchantId);

	protected virtual IGrantMerchantAssetsResult ExecuteGrantMerchantAssets(IUser user, Merchant merchant, decimal creditAmount)
	{
		List<long> assetsToGrant = (from li in AssetAwardList.GetAssetAwardListsByMerchantID(merchant.ID).SelectMany((AssetAwardList assetAwardList) => assetAwardList.AssetAwardListItems)
			select li.AssetID).ToList();
		return AwardAssetsToUser(user, assetsToGrant);
	}

	protected virtual async Task<IGrantMerchantAssetsResult> ExecuteGrantMerchantAssetsAsync(IUser user, Merchant merchant, decimal creditAmount)
	{
		return ExecuteGrantMerchantAssets(user, merchant, creditAmount);
	}

	protected IGrantMerchantAssetsResult AwardAssetsToUser(IUser user, IEnumerable<long> assetIdsToGrant)
	{
		List<long> grantedAssets = new List<long>();
		GrantMerchantAssetsResult result = new GrantMerchantAssetsResult
		{
			FailureReason = CreditRedemptionFailureReason.None,
			IsSuccess = true
		};
		foreach (long asset in assetIdsToGrant)
		{
			try
			{
				AssetOwnershipAuthority.AwardAsset(asset, user.Id, out var newAssetGranted);
				if (newAssetGranted)
				{
					grantedAssets.Add(asset);
				}
			}
			catch (Exception e)
			{
				result.FailureReason = CreditRedemptionFailureReason.UnableToGrantAllAssets;
				result.IsSuccess = false;
				Logger.Error(e);
			}
		}
		result.GrantedAssets = grantedAssets;
		return result;
	}

	protected ICreditRedemptionResult GetCreditRedemptionFailureResult(CreditRedemptionFailureReason failureReason, Exception e = null)
	{
		RedemptionFailureCounter.IncrementInBackground();
		Logger.Error(e ?? new Exception(failureReason.ToString()));
		return new CreditRedemptionResult
		{
			IsSuccess = false,
			FailureReason = failureReason
		};
	}

	protected ICreditRedemptionResult GetCreditRedemptionSuccessResult(decimal amount, string transactionId, int merchantId)
	{
		return new CreditRedemptionResult
		{
			IsSuccess = true,
			FailureReason = CreditRedemptionFailureReason.None,
			AmountRedeemed = amount,
			TransactionId = transactionId,
			MerchantId = merchantId
		};
	}

	protected ICreditReversalResult GetCreditReversalFailureResult(CreditReversalFailureReason failureReason, Exception e = null)
	{
		ReversalFailureCounter.IncrementInBackground();
		Logger.Error(e ?? new Exception(failureReason.ToString()));
		return new CreditReversalResult
		{
			IsSuccess = false,
			FailureReason = failureReason
		};
	}

	protected ICreditReversalResult GetCreditReversalSuccessResult(string transactionId)
	{
		return new CreditReversalResult
		{
			IsSuccess = true,
			TransactionId = transactionId
		};
	}

	protected ICreditStatusResult GetStatusLookupFailureResult(CreditStatusFailureReason failureReason, Exception e = null)
	{
		Logger.Error(e ?? new Exception(failureReason.ToString()));
		return new CreditStatusResult
		{
			IsSuccess = false,
			FailureReason = failureReason,
			Status = null
		};
	}

	protected ICreditStatusResult GetStatusLookupSuccessResult(XsollaBlackhawkStatusModel result)
	{
		return new CreditStatusResult
		{
			IsSuccess = true,
			TransactionId = result.TransactionId,
			Status = result.Status
		};
	}

	private IFloodChecker GetFloodCheckerForUser(IVisitorIdentifier user)
	{
		return FloodCheckerFactory.GetFloodChecker("Roblox.Platform.Billing.BaseCreditProvider", string.Format("{0}:RedeemFloodCheckByUserId_{1}", "Roblox.Platform.Billing.BaseCreditProvider", user.Id), () => Settings.CreditRedemptionFloodCheckLimit, () => Settings.CreditRedemptionFloodCheckExpiry, () => true, () => true, Logger);
	}

	private string GetFloodCheckErrorForUser(IVisitorIdentifier user)
	{
		return $"Credit redemption FloodCheck limit {Settings.CreditRedemptionFloodCheckLimit} exceeded for user ${user.Id}";
	}

	private ICreditRedemptionResult GetFloodCheckError(IFloodChecker floodChecker, IVisitorIdentifier user)
	{
		if (!floodChecker.Check().IsFlooded)
		{
			return null;
		}
		string message = GetFloodCheckErrorForUser(user);
		Logger.Error(message);
		RedemptionFloodcheckFailureCounter.IncrementInBackground();
		return GetCreditRedemptionFailureResult(CreditRedemptionFailureReason.FloodcheckFailed);
	}

	private ILeasedLock TryAcquireSqlLeasedLock(string pinCode)
	{
		return LeasedLockFactory.CreateLeasedLockAndThrowOnFailure($"PinLock_{pinCode}", Settings.CreditRedemptionLeasedLockTimeSpan);
	}

	private void LogRedemption(IUser user, byte merchantId, decimal creditAmount, string pin)
	{
		try
		{
			GamecardRedemptionLog.CreateNew(user.AccountId, merchantId, creditAmount, pin);
		}
		catch (Exception e)
		{
			Logger.Error($"Unable to create user {user.AccountId}'s credit redemption log entry for card '{pin}': {e}");
			GamecardRedemptionLogWriteFailureCounter.IncrementInBackground();
		}
	}
}
