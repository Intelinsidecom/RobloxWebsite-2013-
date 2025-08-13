using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Membership;

namespace Roblox.Web.ElevatedActions.Base;

public class RobloxElevatedActionAuthorizationChecker : IRobloxElevatedActionAuthorizationChecker
{
	private readonly IUserFactory _UserFactory;

	private readonly IRoleSetValidator _RoleSetValidator;

	private readonly IElevatedActionFactory _ElevatedActionFactory;

	private readonly IRoleSetElevatedActionFactory _RoleSetElevatedActionFactory;

	private readonly IRobloxElevatedActionAuthorizationCheckerPerformanceCounters _PerformanceCounters;

	private readonly ILogger _Logger;

	public RobloxElevatedActionAuthorizationChecker(ILogger logger, IUserFactory userFactory, IRoleSetValidator roleSetValidator, IElevatedActionFactory elevatedActionFactory, IRoleSetElevatedActionFactory roleSetElevatedActionFactory, IRobloxElevatedActionAuthorizationCheckerPerformanceCounters performanceCounters)
	{
		_PerformanceCounters = performanceCounters ?? throw new ArgumentNullException("performanceCounters");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
		_ElevatedActionFactory = elevatedActionFactory ?? throw new ArgumentNullException("elevatedActionFactory");
		_RoleSetElevatedActionFactory = roleSetElevatedActionFactory ?? throw new ArgumentNullException("roleSetElevatedActionFactory");
	}

	public RobloxElevatedActionAuthorizationChecker(IUserFactory userFactory, IRoleSetValidator roleSetValidator, IElevatedActionFactory elevatedActionFactory, IRoleSetElevatedActionFactory roleSetElevatedActionFactory, IRobloxElevatedActionAuthorizationCheckerPerformanceCounters performanceCounters)
		: this(new ConsoleLogger(() => LogLevel.Warning), userFactory, roleSetValidator, elevatedActionFactory, roleSetElevatedActionFactory, performanceCounters)
	{
	}

	/// <summary>
	/// Returns true if the user is a member of a roleset that has permission to perform the named elevated action
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="elevatedActionName"></param>
	/// <param name="errorAggregator"></param>
	/// <returns></returns>
	public bool IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction(long userId, string elevatedActionName, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		if (errorAggregator == null)
		{
			throw new ArgumentNullException("errorAggregator");
		}
		try
		{
			if (string.IsNullOrEmpty(elevatedActionName))
			{
				_PerformanceCounters.ElevatedActionNameNullOrEmptyOccurrencesPerSecond.Increment();
				_PerformanceCounters.AuthorizationFailureOccurrencesPerSecond.Increment();
				errorAggregator.Push("elevatedActionName was null in RobloxElevatedActionAuthorizationChecker.IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction");
				_Logger.Warning("elevatedActionName was null in RobloxElevatedActionAuthorizationChecker.IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction");
				return false;
			}
			IUser user = GetUser(userId, errorAggregator);
			if (user == null)
			{
				_PerformanceCounters.AuthorizationFailureOccurrencesPerSecond.Increment();
				return false;
			}
			ICollection<IRoleset> userRolesets = GetRolesets(user, errorAggregator);
			if (userRolesets == null)
			{
				_PerformanceCounters.AuthorizationFailureOccurrencesPerSecond.Increment();
				return false;
			}
			IElevatedAction elevatedAction = GetElevatedAction(elevatedActionName, errorAggregator);
			if (elevatedAction == null)
			{
				_PerformanceCounters.AuthorizationFailureOccurrencesPerSecond.Increment();
				return false;
			}
			if (userRolesets.Select((IRoleset userRoleset) => userRoleset.Id).Aggregate(seed: false, (bool acc, int roleSetId) => acc || _CanRoleSetExecuteElevatedAction(roleSetId, elevatedAction, errorAggregator)))
			{
				_PerformanceCounters.AuthorizationSuccessOccurrencesPerSecond.Increment();
				return true;
			}
			PerformNotPermittedSideEffects(elevatedAction, errorAggregator);
		}
		catch (Exception e)
		{
			_PerformanceCounters.IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedActionEncounteredUnhandledExceptionOccurrencesPerSecond.Increment();
			string msg = $"Encountered unhandled exception in RobloxElevatedActionAuthorizationChecker.IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction - {e}";
			_Logger.Error(msg);
			errorAggregator.Push(msg);
		}
		_PerformanceCounters.AuthorizationFailureOccurrencesPerSecond.Increment();
		return false;
	}

	private bool _CanRoleSetExecuteElevatedAction(int roleSetId, IElevatedAction elevatedAction, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		IRoleSetElevatedAction roleSetElevatedAction;
		return TryGetRoleSetElevatedAction(roleSetId, elevatedAction.ID, errorAggregator, out roleSetElevatedAction);
	}

	/// <summary>
	/// This method is specifically constructed so as to not throw or rethrow exceptions, as it is used in a functional manner to evaluate all relevant rolesets
	/// that a user has to determine if that user is authorized for some elevated action.
	///
	/// It is marked internal so that it can be unit tested independently
	/// </summary>
	/// <param name="roleSetId"></param>
	/// <param name="elevatedActionId"></param>
	/// <param name="errorAggregator"></param>
	/// <param name="roleSetElevatedAction"></param>
	/// <returns></returns>
	internal bool TryGetRoleSetElevatedAction(int roleSetId, int elevatedActionId, IErrorAggregator<string, IEnumerable<string>> errorAggregator, out IRoleSetElevatedAction roleSetElevatedAction)
	{
		try
		{
			roleSetElevatedAction = _RoleSetElevatedActionFactory.GetRoleSetElevatedAction(roleSetId, elevatedActionId);
		}
		catch (Exception e)
		{
			_PerformanceCounters.GetRoleSetElevatedActionByRoleSetIdElevatedActionIdThrewOccurrencesPerSecond.Increment();
			string msg2 = $"Encountered unhandled exception in RobloxElevatedActionAuthorizationChecker.TryGetRoleSetElevatedAction - {e}";
			errorAggregator.Push(msg2);
			_Logger.Error(msg2);
			roleSetElevatedAction = null;
			return false;
		}
		if (roleSetElevatedAction == null)
		{
			_PerformanceCounters.GetRoleSetElevatedActionByRoleSetIdElevatedActionIdReturnedNullOccurrencesPerSecond.Increment();
			string msg = "No such RoleSetElevatedAction was found.";
			errorAggregator.Push(msg);
			_Logger.Warning(msg);
			return false;
		}
		_PerformanceCounters.GetRoleSetElevatedActionByRoleSetIdElevatedActionIdSuccessfulOccurrencesPerSecond.Increment();
		return true;
	}

	internal IUser GetUser(long userId, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		if (errorAggregator == null)
		{
			throw new ArgumentNullException("errorAggregator");
		}
		IUser user = _UserFactory.GetUser(userId);
		if (user == null)
		{
			_PerformanceCounters.UserNotFoundForUserIdOccurrencesPerSecond.Increment();
			errorAggregator.Push("No user found for the specified userID");
			_Logger.Warning("No user found for the specified userID");
			return user;
		}
		_PerformanceCounters.UserFoundSuccessfullyOccurrencesPerSecond.Increment();
		return user;
	}

	internal ICollection<IRoleset> GetRolesets(IUser user, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (errorAggregator == null)
		{
			throw new ArgumentNullException("errorAggregator");
		}
		ICollection<IRoleset> roleSets = _RoleSetValidator.GetRoleSets(user);
		if (roleSets == null)
		{
			_PerformanceCounters.RoleSetValidatorReturnedNullWhenLookingUpRolesetsForUserOccurrencesPerSecond.Increment();
			errorAggregator.Push("null was returned from RoleSetValidator.GetRoleSets");
			_Logger.Warning("null was returned from RoleSetValidator.GetRoleSets");
			return roleSets;
		}
		_PerformanceCounters.RoleSetValidatorSuccessfullyRetrievedRolesetsForUserOccurrencesPerSecond.Increment();
		return roleSets;
	}

	internal IElevatedAction GetElevatedAction(string elevatedActionName, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		if (string.IsNullOrEmpty(elevatedActionName))
		{
			throw new ArgumentException("message", "elevatedActionName");
		}
		if (errorAggregator == null)
		{
			throw new ArgumentNullException("errorAggregator");
		}
		IElevatedAction elevatedAction = _ElevatedActionFactory.Get(elevatedActionName);
		if (elevatedAction == null)
		{
			_PerformanceCounters.ElevatedActionFactoryGetReturnedNullOccurrencesPerSecond.Increment();
			string msg = $"Could not locate elevated action named: {elevatedActionName}";
			errorAggregator.Push(msg);
			_Logger.Warning(msg);
			return elevatedAction;
		}
		_PerformanceCounters.TryGetElevatedActionSuccessOccurrencesPerSecond.Increment();
		return elevatedAction;
	}

	internal void PerformNotPermittedSideEffects(IElevatedAction elevatedAction, IErrorAggregator<string, IEnumerable<string>> errorAggregator)
	{
		if (elevatedAction == null)
		{
			string msg3 = "elevatedAction argument cannot be null in RobloxElevatedActionAuthorizationChecker.TryToPerformNotPermittedSideEffects";
			errorAggregator.Push(msg3);
			_Logger.Error(msg3);
			return;
		}
		if (errorAggregator == null)
		{
			string msg2 = "errorAggregator argument cannot be null in RobloxElevatedActionAuthorizationChecker.TryToPerformNotPermittedSideEffects";
			_Logger.Error(msg2);
			return;
		}
		try
		{
			string authorizedRoleSetList = string.Join(", ", from rs in _RoleSetElevatedActionFactory.GetRoleSetsAuthorizedToPerformElevatedActionID(elevatedAction.ID)
				select rs.Name);
			string message = $"User does not have roleset granting permission for \"{elevatedAction.Description}\".  RoleSets which can take this action are: {authorizedRoleSetList}.";
			errorAggregator.Push(message);
			_PerformanceCounters.PerformNotPermittedSideEffectsCompletedSuccessfullyOccurrencesPerSecond.Increment();
		}
		catch (Exception e)
		{
			_PerformanceCounters.PerformNotPermittedSideEffectsEncounteredUnhandledExceptionOccurrencesPerSecond.Increment();
			string msg = $"Unhandled exception encountered in RobloxElevatedActionAuthorizationChecker.TryToPerformNotPermittedSideEffects - {e}";
			_Logger.Error(msg);
			errorAggregator.Push(msg);
		}
	}
}
