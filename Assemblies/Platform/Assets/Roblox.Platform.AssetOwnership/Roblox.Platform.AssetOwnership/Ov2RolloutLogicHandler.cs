using System;
using System.Threading;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Ownership.Client;
using Roblox.Platform.AssetOwnership.Properties;

namespace Roblox.Platform.AssetOwnership;

internal class Ov2RolloutLogicHandler
{
	private long _RequestCounter;

	public IRemediationRequestRecorder RemediationRequestRecorder { get; }

	private Func<long, int> _AssetTypeGetter { get; }

	private IDualCompatibleOwnershipFactory _Ov1UserAssetFactory { get; }

	private IOwnershipV2UserAssetFactory _Ov2UserAssetFactory { get; }

	private string _LastWriteStrategy { get; set; }

	private OwnershipWriteStrategy _ActiveWriteStrategy { get; set; }

	private ISettings _Settings { get; }

	private ILocker _Locker { get; }

	private IUnlocker _Unlocker { get; }

	private IAssetOwnershipObserver _Observer { get; }

	private ILogger _Logger { get; }

	/// <summary>
	/// The handler shouldn't throw, but consumers of it which used to throw when they'd interact directly with ov1UserAssetFactory should now detect the various types of failures and throw if necessary.
	/// </summary>
	internal Ov2RolloutLogicHandler(Func<long, int> assetTypeGetter, ILocker locker, IUnlocker unlocker, IDualCompatibleOwnershipFactory ov1UserAssetFactory, IOwnershipV2UserAssetFactory ov2UserAssetFactory, ISettings settings, IRemediationRequestRecorder remediationRequestRecorder, IAssetOwnershipObserver observer, ILogger logger)
	{
		_AssetTypeGetter = assetTypeGetter ?? throw new ArgumentNullException("assetTypeGetter");
		_Locker = locker ?? throw new ArgumentNullException("locker");
		_Unlocker = unlocker ?? throw new ArgumentNullException("unlocker");
		_Ov1UserAssetFactory = ov1UserAssetFactory ?? throw new ArgumentNullException("ov1UserAssetFactory");
		_Ov2UserAssetFactory = ov2UserAssetFactory ?? throw new ArgumentNullException("ov2UserAssetFactory");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		RemediationRequestRecorder = remediationRequestRecorder ?? throw new ArgumentNullException("remediationRequestRecorder");
		_Observer = observer ?? throw new ArgumentNullException("observer");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	internal OwnershipWriteStrategy GetWriteStrategy()
	{
		string settingValue = _Settings.TeeShirtWriteStrategy;
		if (settingValue != _LastWriteStrategy)
		{
			_LastWriteStrategy = settingValue;
			_ActiveWriteStrategy = InterpretTeeShirtWriteStrategyValue(_LastWriteStrategy);
		}
		return _ActiveWriteStrategy;
	}

	internal DualAwardResult DoPossibleDualAward(string actionName, long assetId, long userId, bool allowDuplicates)
	{
		long requestCounter = Interlocked.Increment(ref _RequestCounter);
		AssetOwnershipActionEventArgs eventArgs = new AssetOwnershipActionEventArgs(actionName, requestCounter);
		_Observer.OnExecutionStarted(eventArgs);
		CheckAwardPreconditions(assetId, userId, eventArgs);
		DualAwardResult dualAwardResult = null;
		try
		{
			dualAwardResult = InnerPossibleDualAward(assetId, userId, allowDuplicates);
			eventArgs.Result = dualAwardResult.AwardStatus.ToString();
			CheckAwardResult(dualAwardResult.AwardStatus, eventArgs);
			return dualAwardResult;
		}
		catch (Exception ex)
		{
			eventArgs.Result = dualAwardResult?.AwardStatus.ToString() ?? ex.GetType().Name;
			throw;
		}
		finally
		{
			_Observer.OnExecutionFinished(eventArgs);
		}
	}

	internal TransferResult DoPossibleDualTransferWithLock(string actionName, long userAssetId, long assetId, long oldOwnerId, long newOwnerId, Guid token)
	{
		long requestCounter = Interlocked.Increment(ref _RequestCounter);
		AssetOwnershipActionEventArgs eventArgs = new AssetOwnershipActionEventArgs(actionName, requestCounter);
		_Observer.OnExecutionStarted(eventArgs);
		CheckTransferPreconditions(userAssetId, assetId, oldOwnerId, newOwnerId, token, eventArgs);
		TransferResult transferResult = null;
		try
		{
			transferResult = DoInnerTransfer(userAssetId, assetId, oldOwnerId, newOwnerId, token);
			eventArgs.Result = transferResult.TransferStatus.ToString();
			CheckTransferResult(transferResult.TransferStatus, eventArgs);
			return transferResult;
		}
		catch (Exception ex)
		{
			eventArgs.Result = transferResult?.TransferStatus.ToString() ?? ex.GetType().Name;
			throw;
		}
		finally
		{
			_Observer.OnExecutionFinished(eventArgs);
		}
	}

	internal RevokeStatus DoPossibleDualRevoke(string actionName, long userAssetId, long assetId, long userId)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		long requestCounter = Interlocked.Increment(ref _RequestCounter);
		AssetOwnershipActionEventArgs eventArgs = new AssetOwnershipActionEventArgs(actionName, requestCounter);
		_Observer.OnExecutionStarted(eventArgs);
		ILockResult obj = _Locker.Lock(userAssetId);
		if (!((IOwnershipResult)obj).IsSuccess)
		{
			throw new LockException();
		}
		Guid token = obj.Token;
		CheckRevokePreconditions(userAssetId, assetId, userId, token, eventArgs);
		RevokeStatus revokeStatus = (RevokeStatus)0;
		try
		{
			revokeStatus = DoInnerRevoke(userAssetId, assetId, userId, token);
			eventArgs.Result = revokeStatus.ToString();
			CheckRevokeResult(revokeStatus, eventArgs);
			return revokeStatus;
		}
		catch (Exception ex)
		{
			eventArgs.Result = ex.Message;
			eventArgs.Result = ((revokeStatus == (RevokeStatus)0) ? ex.GetType().Name : revokeStatus.ToString());
			throw;
		}
		finally
		{
			_Observer.OnExecutionFinished(eventArgs);
			_Unlocker.Unlock(token);
		}
	}

	private DualAwardResult InnerPossibleDualAward(long assetId, long userId, bool allowDuplicates)
	{
		long userAssetId = 0L;
		OwnershipWriteTarget target = GetTarget(assetId);
		switch (target)
		{
		case OwnershipWriteTarget.Ov1:
		{
			bool awardedInOv1;
			if (allowDuplicates)
			{
				userAssetId = _Ov1UserAssetFactory.AwardAssetAllowingDuplicates(assetId, userId);
				awardedInOv1 = true;
			}
			else
			{
				userAssetId = _Ov1UserAssetFactory.AwardAsset(assetId, userId, out awardedInOv1);
			}
			AwardStatus awardStatus = (awardedInOv1 ? AwardStatus.Ov1Success : AwardStatus.AlreadyOwnedInOv1NothingDone);
			return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2: false, awardStatus);
		}
		case OwnershipWriteTarget.Ov2:
			throw new NotImplementedException();
		case OwnershipWriteTarget.Both:
			return DoOv1Ov2AwardTransaction(assetId, userId, out userAssetId, allowDuplicates);
		default:
			throw new Exception($"Invalid write target: {target}");
		}
	}

	private DualAwardResult DoOv1Ov2AwardTransaction(long assetId, long userId, out long userAssetId, bool allowDuplicates)
	{
		userAssetId = 0L;
		bool awardedInOv1 = false;
		bool awardedInOv2 = false;
		if (allowDuplicates)
		{
			try
			{
				userAssetId = _Ov1UserAssetFactory.AwardAssetAllowingDuplicates(assetId, userId);
				awardedInOv1 = true;
			}
			catch (Exception ov1Exception)
			{
				_Logger.Error($"Ov1 failure granting allowing duplicates: AssetId:{assetId} UserId:{userId} {ov1Exception}");
				return new DualAwardResult(0L, awardedInOv1, awardedInOv2, AwardStatus.Ov1Failure);
			}
		}
		else
		{
			try
			{
				userAssetId = _Ov1UserAssetFactory.AwardAsset(assetId, userId, out awardedInOv1);
			}
			catch (UserAssetDisappearedException ex)
			{
				_Logger.Error($"owned UserAsset disappeared while we were attempting to grant one, and found one already existed, so tried to get that one's userAssetId. AssetId:{assetId} UserId:{userId}. {ex}");
				throw;
			}
			catch (Exception)
			{
				return new DualAwardResult(0L, awardedInOv1, awardedInOv2, AwardStatus.Ov1Failure);
			}
		}
		try
		{
			if (allowDuplicates)
			{
				_Ov2UserAssetFactory.AwardAssetSpecifyingUserAssetIdAllowingDuplicates(assetId, userAssetId, userId);
				awardedInOv2 = true;
			}
			else
			{
				awardedInOv2 = _Ov2UserAssetFactory.AwardAssetSpecifyingUserAssetId(assetId, userAssetId, userId);
			}
		}
		catch (Exception ov2Exception)
		{
			_Logger.Error($"Failed awarding userAssetId in ov2: {userAssetId}. {ov2Exception}");
			if (awardedInOv1)
			{
				ILockResult lockResult;
				try
				{
					lockResult = _Locker.Lock(userAssetId);
				}
				catch (Exception lockException)
				{
					_Logger.Error($"Failed locking ov1 item for rollback in award of userAssetId: {userAssetId}. {lockException}");
					RemediationRequestRecorder.RecordUserAssetIdForRemediation(userAssetId, $"Failed to lock {userAssetId} in ov1 for rollback; it was never awarded in ov2.");
					return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2OutOfSync);
				}
				if (!((IOwnershipResult)lockResult).IsSuccess)
				{
					RemediationRequestRecorder.RecordUserAssetIdForRemediation(userAssetId, $"Could not lock userAssetId {userAssetId} in ov1 to rollback.");
					return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2OutOfSync);
				}
				try
				{
					IAssetOwnershipResult assetOwnershipResult = _Ov1UserAssetFactory.RevokeWithExistingLock(lockResult.Token, userAssetId, userId, assetId);
					awardedInOv1 = false;
					if (assetOwnershipResult.IsSuccess)
					{
						userAssetId = 0L;
						return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2FailureRolledBackOv1);
					}
					return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2OutOfSync);
				}
				catch (Exception ov1RollbackException)
				{
					_Logger.Error($"Failed rolling back ov1 award of userAssetId: {userAssetId}. {ov1RollbackException}");
					RemediationRequestRecorder.RecordUserAssetIdForRemediation(userAssetId, $"Failed to revoke {userAssetId} in ov1 for rollback; it was never awarded in ov2.");
					return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2OutOfSync);
				}
			}
			return new DualAwardResult(userAssetId, awardedInOv1, awardedInOv2, AwardStatus.Ov2OutOfSync);
		}
		return new DualAwardResult(awardStatus: awardedInOv1 ? ((!awardedInOv2) ? AwardStatus.AlreadyOwnedInOv2ButGrantedInOv1 : AwardStatus.DualAwarded) : ((!awardedInOv2) ? AwardStatus.AlreadyOwnedInOv1AndOv2 : AwardStatus.AlreadyOwnedInOv1ButGrantedInOv2), userAssetId: userAssetId, awardedInOv1: awardedInOv1, awardedInOv2: awardedInOv2);
	}

	private TransferResult DoInnerTransfer(long userAssetId, long assetId, long oldOwnerId, long newOwnerId, Guid guid)
	{
		OwnershipWriteTarget target = GetTarget(assetId);
		string message = string.Empty;
		switch (target)
		{
		case OwnershipWriteTarget.Ov1:
			if (_Ov1UserAssetFactory.TransferWithExistingLock(assetId, userAssetId, oldOwnerId, newOwnerId, guid, out message))
			{
				return new TransferResult(TransferStatus.Ov1Success, message);
			}
			return new TransferResult(TransferStatus.Ov1Failure, message);
		case OwnershipWriteTarget.Ov2:
			throw new NotImplementedException();
		case OwnershipWriteTarget.Both:
			try
			{
				if (!_Ov1UserAssetFactory.TransferWithExistingLock(assetId, userAssetId, oldOwnerId, newOwnerId, guid, out var ov1Message))
				{
					message = ov1Message;
					return new TransferResult(TransferStatus.Ov1Failure, message);
				}
			}
			catch (Exception ov1ex)
			{
				_Logger.Error($"Error transferring userAssetId in ov1: {userAssetId}. {ov1ex}");
				message = ov1ex.Message;
				return new TransferResult(TransferStatus.Ov1Failure, message);
			}
			try
			{
				if (_Ov2UserAssetFactory.TransferWithExistingLock(assetId, userAssetId, oldOwnerId, newOwnerId, guid, out var ov2Message))
				{
					message = $"Ov1:{message} Ov2:{ov2Message}";
					return new TransferResult(TransferStatus.DualTransferred, message);
				}
				throw new Exception("Ov2 failed;");
			}
			catch (Exception ov2ex)
			{
				_Logger.Error($"Error transferring userAssetId in ov2: {userAssetId}. {ov2ex}");
				try
				{
					if (_Ov1UserAssetFactory.TransferWithExistingLock(assetId, userAssetId, newOwnerId, oldOwnerId, guid, out var _))
					{
						return new TransferResult(TransferStatus.Ov2FailureRolledBackOv1, message);
					}
					throw new Exception("Transfer back failed");
				}
				catch (Exception ex)
				{
					_Logger.Error($"Error rolling back transfer of userAssetId in ov1: {userAssetId}. {ex}");
					RemediationRequestRecorder.RecordUserAssetIdForRemediation(userAssetId, $"Failed to rollback the transfer of {userAssetId} in ov1; it couldn't be completed in ov2.");
					return new TransferResult(TransferStatus.Ov2OutOfSync, message);
				}
			}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	/// <summary>
	/// Strategy for this: rather than attempting to rollback ov1, immediately create a remediation task.
	/// That's because it doesn't seem easy to restore a userAsset from ov1 once it's deleted.
	/// </summary>
	private RevokeStatus DoInnerRevoke(long userAssetId, long assetId, long userId, Guid token)
	{
		switch (GetTarget(assetId))
		{
		case OwnershipWriteTarget.Ov1:
			if (_Ov1UserAssetFactory.RevokeWithExistingLock(token, userAssetId, userId, assetId).IsSuccess)
			{
				return RevokeStatus.Ov1Success;
			}
			return RevokeStatus.Ov1Failure;
		case OwnershipWriteTarget.Ov2:
			throw new NotImplementedException();
		case OwnershipWriteTarget.Both:
			try
			{
				IAssetOwnershipResult ov1ResultForDual = _Ov1UserAssetFactory.RevokeWithExistingLock(token, userAssetId, userId, assetId);
				if (!ov1ResultForDual.IsSuccess)
				{
					_Logger.Error($"Error revoking userAssetId from ov1: {userAssetId}. {ov1ResultForDual.Message}");
					return RevokeStatus.Ov1Failure;
				}
			}
			catch (Exception ov1ex)
			{
				_Logger.Error($"Error revoking userAssetId from ov1: {userAssetId}. {ov1ex}");
				return RevokeStatus.Ov1Failure;
			}
			try
			{
				if (_Ov2UserAssetFactory.RevokeWithExistingLock(token, userAssetId, userId, assetId).IsSuccess)
				{
					return RevokeStatus.DualRevoked;
				}
				return RevokeStatus.RevokedInOv1Ov2OutOfSync;
			}
			catch (RevokeFailedDueToNotOwnedException)
			{
				return RevokeStatus.DualRevoked;
			}
			catch (Exception ov2ex)
			{
				_Logger.Error($"Error revoking userAssetId from ov2: {userAssetId}. {ov2ex}");
				RemediationRequestRecorder.RecordUserAssetIdForRemediation(userAssetId, $"Failed to revoke userAssetId in ov2: {userAssetId}.");
				return RevokeStatus.RevokedInOv1Ov2OutOfSync;
			}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private void CheckAwardPreconditions(long assetId, long userId, AssetOwnershipActionEventArgs eventArgs)
	{
		if (assetId == 0L)
		{
			eventArgs.Result = "Precondition Failed: AssetId";
			throw new PreconditionFailedException($"Required value not specified for award. AssetId={assetId}");
		}
		if (userId == 0L)
		{
			eventArgs.Result = "Precondition Failed: AssetId";
			throw new PreconditionFailedException($"Required value not specified for award. UserId={userId}");
		}
	}

	private void CheckTransferPreconditions(long userAssetId, long assetId, long oldOwnerId, long newOwnerId, Guid token, AssetOwnershipActionEventArgs eventArgs)
	{
		if (userAssetId == 0L || assetId == 0L || oldOwnerId == 0L || newOwnerId == 0L || token == default(Guid))
		{
			eventArgs.Result = "Precondition Failed";
			throw new PreconditionFailedException($"Required value not specified for transfer. userAssetId={userAssetId} assetId={assetId} oldOwnerId={oldOwnerId} newOwnerId={newOwnerId} token={token}");
		}
	}

	private void CheckRevokePreconditions(long userAssetId, long assetId, long userId, Guid token, AssetOwnershipActionEventArgs eventArgs)
	{
		if (userId == 0L || userAssetId == 0L || assetId == 0L || token == default(Guid))
		{
			eventArgs.Result = "Revoke Precondition Failed";
			throw new PreconditionFailedException($"Required value not specified for revoke. userAssetId={userAssetId} assetId={assetId} userId={userId} token={token}");
		}
	}

	private void CheckAwardResult(AwardStatus awardStatus, AssetOwnershipActionEventArgs eventArgs)
	{
		switch (awardStatus)
		{
		case AwardStatus.Ov1Failure:
			eventArgs.Result = awardStatus.ToString();
			throw new Ov1Exception("Ov1Failure");
		case AwardStatus.Ov2FailureRolledBackOv1:
			eventArgs.Result = awardStatus.ToString();
			throw new Ov1Ov2TransactionException("Ov2FailureRolledBackOv1");
		}
	}

	private void CheckTransferResult(TransferStatus transferStatus, AssetOwnershipActionEventArgs eventArgs)
	{
		switch (transferStatus)
		{
		case TransferStatus.Ov1Failure:
			eventArgs.Result = transferStatus.ToString();
			throw new Ov1Exception("Ov1Failure");
		case TransferStatus.Ov2FailureRolledBackOv1:
			eventArgs.Result = transferStatus.ToString();
			throw new Ov1Ov2TransactionException("Ov2FailureRolledBackOv1");
		}
	}

	private void CheckRevokeResult(RevokeStatus revokeStatus, AssetOwnershipActionEventArgs eventArgs)
	{
		switch (revokeStatus)
		{
		case RevokeStatus.Ov1Failure:
			eventArgs.Result = revokeStatus.ToString();
			throw new Ov1Exception("Ov1Failure");
		case RevokeStatus.RevokedInOv1Ov2OutOfSync:
			eventArgs.Result = revokeStatus.ToString();
			throw new Ov1Ov2TransactionException("RevokedInOv1Ov2OutOfSync");
		}
	}

	private OwnershipWriteTarget GetTarget(long assetId)
	{
		if (!_Settings.UsingOv2AtAllEnabled)
		{
			return OwnershipWriteTarget.Ov1;
		}
		if (!IsAssetATeeShirt(assetId))
		{
			return OwnershipWriteTarget.Ov1;
		}
		switch (GetWriteStrategy())
		{
		case OwnershipWriteStrategy.Ov1:
			return OwnershipWriteTarget.Ov1;
		case OwnershipWriteStrategy.Ov2:
			return OwnershipWriteTarget.Ov2;
		case OwnershipWriteStrategy.DoubleWriteAtPercentage:
			if (CheckOv2Percentage(assetId))
			{
				return OwnershipWriteTarget.Both;
			}
			return OwnershipWriteTarget.Ov1;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private bool IsAssetATeeShirt(long assetId)
	{
		int assetTypeId = _AssetTypeGetter(assetId);
		return IsTeeShirtAssetTypeId(assetTypeId);
	}

	private bool IsTeeShirtAssetTypeId(int assetTypeId)
	{
		return assetTypeId == 2;
	}

	private bool CheckOv2Percentage(long assetId)
	{
		if (_Settings.TeeShirtOv2WritePercentage != 100)
		{
			return assetId % 100 < _Settings.TeeShirtOv2WritePercentage;
		}
		return true;
	}

	private OwnershipWriteStrategy InterpretTeeShirtWriteStrategyValue(string value)
	{
		OwnershipWriteStrategy? strategy = EnumUtils.StrictTryParseEnum<OwnershipWriteStrategy>(value);
		if (strategy.HasValue)
		{
			return strategy.Value;
		}
		return OwnershipWriteStrategy.Ov1;
	}
}
