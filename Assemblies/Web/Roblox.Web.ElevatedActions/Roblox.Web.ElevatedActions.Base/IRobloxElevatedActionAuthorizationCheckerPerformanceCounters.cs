using Roblox.Instrumentation;

namespace Roblox.Web.ElevatedActions.Base;

public interface IRobloxElevatedActionAuthorizationCheckerPerformanceCounters
{
	/// <summary>
	/// A counter that tracks the rate at which calls to RobloxElevatedActionAuthorizationChecker happen to send null or empty
	/// strings to the method IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction per second.
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionNameNullOrEmptyOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the UserFactory is unable to find IUsers for the specified
	/// userId argument.
	/// </summary>
	IRateOfCountsPerSecondCounter UserNotFoundForUserIdOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the UserFactory successfully retrieves the User for a userId
	/// </summary>
	IRateOfCountsPerSecondCounter UserFoundSuccessfullyOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the method RoleSetValidator.GetRoleSets returns null.
	/// </summary>
	IRateOfCountsPerSecondCounter RoleSetValidatorReturnedNullWhenLookingUpRolesetsForUserOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate of successful retrievals of Rolesets for user
	/// </summary>
	IRateOfCountsPerSecondCounter RoleSetValidatorSuccessfullyRetrievedRolesetsForUserOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which calls to IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction are successful
	/// </summary>
	IRateOfCountsPerSecondCounter AuthorizationSuccessOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate which calls to IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction are unsuccessful
	/// </summary>
	IRateOfCountsPerSecondCounter AuthorizationFailureOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the side effector that is run when authorization fails "normally" encountered an unhandled
	/// exception.
	/// </summary>
	IRateOfCountsPerSecondCounter PerformNotPermittedSideEffectsEncounteredUnhandledExceptionOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the side effector that is run when authorization fails "normally" runs to completion without issue
	/// </summary>
	IRateOfCountsPerSecondCounter PerformNotPermittedSideEffectsCompletedSuccessfullyOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which getting an elevated action by name is successful
	/// </summary>
	IRateOfCountsPerSecondCounter TryGetElevatedActionSuccessOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which the Get (by name) method of the ElevatedActionFactory returned null
	/// </summary>
	IRateOfCountsPerSecondCounter ElevatedActionFactoryGetReturnedNullOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which calls to get the RoleSetElevatedActions for a RoleSetId and elevated action id were successful
	/// </summary>
	IRateOfCountsPerSecondCounter GetRoleSetElevatedActionByRoleSetIdElevatedActionIdSuccessfulOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which calls to get the RoleSetElevatedActions for a RoleSetId and elevated action id  raised an exception
	/// </summary>
	IRateOfCountsPerSecondCounter GetRoleSetElevatedActionByRoleSetIdElevatedActionIdThrewOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which calls to get the RoleSetElevatedAction for a RoleSetId and elevated action id returned null
	/// </summary>
	IRateOfCountsPerSecondCounter GetRoleSetElevatedActionByRoleSetIdElevatedActionIdReturnedNullOccurrencesPerSecond { get; }

	/// <summary>
	/// A counter that tracks the rate at which unhandled exceptions are raised during the authorization check logic execution.
	/// </summary>
	IRateOfCountsPerSecondCounter IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedActionEncounteredUnhandledExceptionOccurrencesPerSecond { get; }
}
