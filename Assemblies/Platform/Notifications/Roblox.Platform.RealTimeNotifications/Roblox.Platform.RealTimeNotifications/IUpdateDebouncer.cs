using System;
namespace Roblox.Platform.RealTimeNotifications
{
    public interface IUpdateDebouncer<T>
    {
        void AddToDebouncedSet(T updateIdentifier);

        void RemoveFromDebouncedSet(T updateIdentifier);

        void ExecuteWithDebounce(T updateIdentifier, Action actionToExecute);

        long GetNumberOfAttemptsToDebounce();
    }
}
