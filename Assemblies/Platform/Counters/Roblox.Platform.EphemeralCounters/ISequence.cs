using System;
namespace Roblox.Platform.EphemeralCounterspublic {
    interface ISequence

{
	void Add(double value);

	void AddInBackground(double value, Action<Exception> exceptionHandler = null);

	ISequenceStatistics GetStatistics();

	ISequenceStatistics FlushStatistics();
}


}
