namespace Roblox.Web.ElevatedActions.Base;

public interface IRobloxElevatedAction
{
	/// <summary>
	/// IsAuthorized checks to see if a user's roleset allows the user to perform the elevated
	/// action at all. This is independent of target or instance specific variables.
	/// </summary>
	/// <returns>True if the current user has the correct role to execute the elevated action, false otherwise.</returns>
	bool IsAuthorized();

	/// <summary>
	/// IsAuthorized checks to see if a user's roleset allows the user to perform the elevated
	/// action at all. This is independent of target or instance specific variables.
	/// </summary>
	/// <param name="message">Error messages produced are stored here</param>
	/// <returns>True if the current user has the correct role to execute the elevated action, false otherwise.</returns>
	bool IsAuthorized(out string message);

	/// <summary>
	/// CanPerformAction checks to see if a user can perform an elevated action based on the
	/// rank of the user they are performing an action on.
	/// </summary>
	/// <param name="message">Error messages produced are stored here</param>
	/// <returns>True if the current user can perform the elevated action on another target and passes custom
	/// rules defined in the elevated action, if any. False otherwise.</returns>
	bool _CanPerformAction(out string message);

	/// <summary>
	/// Produces a generated display message that can be tied to the user Id
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="useAdminIdentifier"></param>
	/// <returns></returns>
	string GetUserDisplayText(long? userId, bool useAdminIdentifier = false);

	/// <summary>
	/// Execute the ElevatedAction, it will return true if execution was successful.
	/// </summary>
	/// <returns>True if the EA executed successfully.</returns>
	bool ExecuteAction();

	/// <summary>
	/// Execute the ElevatedAction, it will return true if execution was successful.
	/// </summary>
	/// <param name="errorMessage">Error messages produced, are stored here</param>
	/// <returns>True if the EA executed successfully.</returns>
	bool ExecuteAction(out string errorMessage);
}
