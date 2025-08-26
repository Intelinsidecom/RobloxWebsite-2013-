using System;
namespace Roblox.Platform.RealTimeNotificationspublic {
    interface IUpdateDebouncer<T>

{
	void AddToDebouncedSet(T updateIdentifier);

	void RemoveFromDebouncedSet(T updateIdentifier);

	void ExecuteWithDebounce(T updateIdentifier, Action actionToExecute);

	long GetNumberOfAttemptsToDebounce();
}


}
