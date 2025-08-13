using System;
using System.Web;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Web.ElevatedActions.BLL;
using Roblox.Web.ElevatedActions.Properties;

namespace Roblox.Web.ElevatedActions.Base;

public abstract class RobloxElevatedActionBase : IRobloxElevatedAction
{
	public enum AllowedTargetRank
	{
		Below,
		EqualAndBelow,
		All
	}

	private const string _EmailType = "ElevatedActionLogFailed";

	private const string _FloodCheckerCategory = "Roblox.Web.ElevatedActions";

	private const int LogDataMaximumSize = 250;

	private const string _NoUserDisplayText = "(no user)";

	private readonly IRobloxElevatedActionAuthorizationChecker _UserIsInRoleSetThatCanExecuteElevatedActionChecker;

	private readonly IFloodChecker _FloodChecker;

	private readonly ElevatedActionAlert _Alert;

	private readonly IEmailSender _EmailSender;

	private readonly IHttpRequestKeyInfoExtractor _HttpRequestKeyInfoExtractor;

	private readonly IRobloxElevatedActionPerformanceCounters _PerformanceCounters;

	protected virtual int _DefaultFloodCheckerLimit => Settings.Default.ElevatedActionFloodCheckerLimit;

	protected virtual TimeSpan _DefaultFloodCheckerExpiry => Settings.Default.ElevatedActionFloodCheckerExpiry;

	protected abstract ElevatedAction ElevatedAction { get; }

	protected virtual AllowedTargetRank _AllowedTargetRank => AllowedTargetRank.Below;

	protected virtual bool _CanTargetSelf => true;

	protected virtual string FloodCheckerString => $"Action:{ElevatedAction.Name}_User:{_CurrentUserID}";

	protected long? _TargetUserID { get; set; }

	protected long _CurrentUserID { get; set; }

	private void _LogAction(string logData, bool success)
	{
		HttpRequest request = HttpContext.Current.Request;
		string ipAddress = _HttpRequestKeyInfoExtractor.GetIpAddress(request);
		int browserTrackerId = _HttpRequestKeyInfoExtractor.GetBrowserTrackerId(request);
		string logDataTruncated = logData;
		if (logDataTruncated != null && logDataTruncated.Length > 250)
		{
			logDataTruncated = $"{logDataTruncated.Substring(0, 245)}...";
		}
		ElevatedActionLog.CreateNew(ElevatedAction.ID, _CurrentUserID, GetRoleSetForUser(_CurrentUserID).ID, logDataTruncated, success, ipAddress, browserTrackerId);
	}

	private bool _IsThrottled()
	{
		bool num = _FloodChecker.IsFlooded();
		if (num)
		{
			_PerformanceCounters.ElevatedActionIsThrottledOccurrencesPerSecond.Increment();
		}
		return num;
	}

	public bool IsAuthorized()
	{
		string dummy;
		return IsAuthorized(out dummy);
	}

	/// <inheritdoc cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedAction" />
	public bool IsAuthorized(out string message)
	{
		_PerformanceCounters.ElevatedActionIsAuthorizedCallsPerSecond.Increment();
		StringErrorAggregator errorAggregator = new StringErrorAggregator();
		bool result = _UserIsInRoleSetThatCanExecuteElevatedActionChecker.IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction(_CurrentUserID, ElevatedAction.Name, errorAggregator);
		message = string.Join(", ", errorAggregator.Errors);
		return result;
	}

	/// <inheritdoc cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedAction" />
	public bool _CanPerformAction(out string message)
	{
		_PerformanceCounters.ElevatedActionCanPerformActionCallsPerSecond.Increment();
		message = string.Empty;
		Account currentAccount = User.Get(_CurrentUserID).GetAccount();
		if (_TargetUserID.HasValue)
		{
			RoleSet targetUserRoleSet = GetRoleSetForUser(_TargetUserID.Value);
			if (_TargetUserID != _CurrentUserID)
			{
				switch (_AllowedTargetRank)
				{
				case AllowedTargetRank.Below:
					if (targetUserRoleSet.Rank >= currentAccount.GetHighestRoleSet().Rank)
					{
						message = "This action can only target users of lower rank.";
						return false;
					}
					break;
				case AllowedTargetRank.EqualAndBelow:
					if (targetUserRoleSet.Rank > currentAccount.GetHighestRoleSet().Rank)
					{
						message = "This action can only target users of equal or lower rank.";
						return false;
					}
					break;
				default:
					throw new NotImplementedException("This enum type is not supported!");
				case AllowedTargetRank.All:
					break;
				}
			}
			else if (!_CanTargetSelf)
			{
				message = "You cannot perform this action on your own account.";
				return false;
			}
		}
		return _DoCanPerformAction(out message);
	}

	protected abstract string _DoExecuteAction();

	/// <summary>
	/// Can be overridden by derived classes to check rules specific to the elevated action instance
	/// </summary>
	/// <returns>True always unless overridden</returns>
	protected virtual bool _DoCanPerformAction()
	{
		return true;
	}

	/// <summary>
	/// Can be overridden by derived classes to check rules specific to the elevated action instance
	/// </summary>
	/// <returns>True always unless overridden</returns>
	protected virtual bool _DoCanPerformAction(out string msg)
	{
		msg = string.Empty;
		return _DoCanPerformAction();
	}

	/// <inheritdoc cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedAction" />
	public string GetUserDisplayText(long? userId, bool useAdminIdentifier = false)
	{
		if (userId.HasValue)
		{
			User user = User.Get(userId);
			if (user != null)
			{
				if (!useAdminIdentifier)
				{
					return $"{user.Name} ({userId})";
				}
				AccountEmailAddress accountEmailAddress = AccountEmailAddress.GetCurrent(user.AccountID);
				string emailString = "No email";
				if (accountEmailAddress != null)
				{
					emailString = EmailAddress.Get(accountEmailAddress.EmailAddressID)?.Address ?? "Missing email!";
				}
				return $"{user.Name} ({emailString})";
			}
		}
		return "(no user)";
	}

	internal RobloxElevatedActionBase(IElevatedActionFactories factories)
	{
		if (factories == null)
		{
			throw new ArgumentNullException("factories");
		}
		if (factories.CounterRegistry == null)
		{
			throw new ArgumentException("factories.CounterRegistry must not be null", "factories");
		}
		_EmailSender = factories.EmailSender;
		_Alert = new ElevatedActionAlert(() => ElevatedAction, ExceptionHandler.LogException, factories);
		_UserIsInRoleSetThatCanExecuteElevatedActionChecker = new RobloxElevatedActionAuthorizationChecker(factories.UserFactory, factories.RoleSetValidator, factories.ElevatedActionFactory, factories.RoleSetElevatedActionFactory, factories.RobloxElevatedActionPerformanceCounterFactory.GetRobloxElevatedActionAuthorizationCheckerPerformanceCounters());
		_HttpRequestKeyInfoExtractor = factories.HttpRequestKeyInfoExtractor;
		_PerformanceCounters = factories.RobloxElevatedActionPerformanceCounterFactory.GetRobloxElevatedActionPerformanceCounters(GetType());
		_PerformanceCounters.ElevatedActionInstancesCreatedPerSecond.Increment();
	}

	public RobloxElevatedActionBase(IElevatedActionFactories factories, long currentUserId)
		: this(factories)
	{
		_CurrentUserID = currentUserId;
		_TargetUserID = null;
		_FloodChecker = new FloodChecker("Roblox.Web.ElevatedActions", FloodCheckerString, _DefaultFloodCheckerLimit, _DefaultFloodCheckerExpiry);
	}

	public RobloxElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long targetUserId)
		: this(factories)
	{
		_CurrentUserID = currentUserId;
		_TargetUserID = targetUserId;
		_FloodChecker = new FloodChecker("Roblox.Web.ElevatedActions", FloodCheckerString, _DefaultFloodCheckerLimit, _DefaultFloodCheckerExpiry);
	}

	public RobloxElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long? targetUserId = null, bool floodCheckEnabled = true, int? floodCheckLimit = null, TimeSpan? floodCheckExpiry = null)
		: this(factories)
	{
		_CurrentUserID = currentUserId;
		_TargetUserID = targetUserId;
		_FloodChecker = new FloodChecker("Roblox.Web.ElevatedActions", FloodCheckerString, floodCheckLimit ?? _DefaultFloodCheckerLimit, floodCheckExpiry ?? _DefaultFloodCheckerExpiry, floodCheckEnabled);
	}

	public RobloxElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long? targetUserId, IFloodChecker floodChecker)
		: this(factories)
	{
		_CurrentUserID = currentUserId;
		_TargetUserID = targetUserId;
		_FloodChecker = floodChecker ?? new FloodChecker("Roblox.Web.ElevatedActions", FloodCheckerString, _DefaultFloodCheckerLimit, _DefaultFloodCheckerExpiry);
	}

	public RobloxElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long targetUserId, IFloodChecker floodChecker)
		: this(factories)
	{
		_CurrentUserID = currentUserId;
		_TargetUserID = targetUserId;
		_FloodChecker = floodChecker ?? new FloodChecker("Roblox.Web.ElevatedActions", FloodCheckerString, _DefaultFloodCheckerLimit, _DefaultFloodCheckerExpiry);
	}

	/// <inheritdoc cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedAction" />
	public bool ExecuteAction()
	{
		string dummy;
		return ExecuteAction(out dummy);
	}

	/// <inheritdoc cref="T:Roblox.Web.ElevatedActions.Base.IRobloxElevatedAction" />
	public bool ExecuteAction(out string errorMessage)
	{
		_PerformanceCounters.ElevatedActionExecuteActionCallsPerSecond.Increment();
		errorMessage = string.Empty;
		if (_IsThrottled())
		{
			_PerformanceCounters.ElevatedActionExecutionFailuresPerSecond.Increment();
			errorMessage = "ElevatedAction error code F.";
			return false;
		}
		if (!IsAuthorized(out var authorizedErrorMsg))
		{
			_PerformanceCounters.ElevatedActionExecutionFailuresPerSecond.Increment();
			errorMessage = "ElevatedAction error code A: " + authorizedErrorMsg;
			return false;
		}
		if (!_CanPerformAction(out var permissionsMsg))
		{
			_PerformanceCounters.ElevatedActionExecutionFailuresPerSecond.Increment();
			errorMessage = "ElevatedAction error code CP: " + permissionsMsg;
			return false;
		}
		if (Settings.Default.AlertsEnabled && TriggersAlert())
		{
			Account currentAccount = User.Get(_CurrentUserID).GetAccount();
			_Alert.Send(currentAccount, ActionForAlert(), DescriptionForAlert());
		}
		bool success = true;
		string logData = string.Empty;
		try
		{
			logData = _DoExecuteAction();
		}
		catch (Exception ex3)
		{
			ExceptionHandler.LogException($"Unable to execute elevated action {ElevatedAction.Name}: {ex3}");
			errorMessage = ex3.Message;
			success = false;
		}
		try
		{
			_FloodChecker.UpdateCount();
		}
		catch (Exception ex2)
		{
			ExceptionHandler.LogException($"Unable to update floodcheck for elevated action {ElevatedAction.Name}: {ex2}");
			errorMessage = "An exception occured when updating floodcheck.";
			success = false;
		}
		try
		{
			_LogAction(logData, success);
		}
		catch (Exception ex)
		{
			Email email = new Email("alerts@roblox.com", Settings.Default.Wak3m3upWarningEmailTarget, "Failed to log ADMIN Action!", EmailBodyType.Plain, "ElevatedActionLogFailed", $"Failed to log an ElevatedAction. CurrentUserName: {User.Get(_CurrentUserID).Name}, CurrentUserID:{_CurrentUserID}, TargetUserName:{User.Get(_TargetUserID).Name}, TargetUserID: {_TargetUserID.Value.ToString()}, Action: {ElevatedAction.Name}, Exception: {ex.Message}");
			_EmailSender.SendEmail(email);
			errorMessage = "Failed to log admin action.";
			success = false;
		}
		if (success)
		{
			_PerformanceCounters.ElevatedActionExecutionSuccessesPerSecond.Increment();
		}
		else
		{
			_PerformanceCounters.ElevatedActionExecutionFailuresPerSecond.Increment();
		}
		return success;
	}

	protected virtual bool TriggersAlert()
	{
		return true;
	}

	protected virtual string ActionForAlert()
	{
		return ElevatedAction.Name;
	}

	protected virtual string DescriptionForAlert()
	{
		return string.Empty;
	}

	public static RoleSet GetRoleSetForUser(long userId)
	{
		return User.Get(userId).GetAccount().GetHighestRoleSet();
	}
}
