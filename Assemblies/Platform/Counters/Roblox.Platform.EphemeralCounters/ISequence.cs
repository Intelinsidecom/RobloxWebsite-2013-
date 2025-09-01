using System;
namespace Roblox.Platform.EphemeralCounters
{
    public interface ISequence
    {
        void Add(double value);

        void AddInBackground(double value, Action<Exception> exceptionHandler = null);

        ISequenceStatistics GetStatistics();

        ISequenceStatistics FlushStatistics();
    }
}
