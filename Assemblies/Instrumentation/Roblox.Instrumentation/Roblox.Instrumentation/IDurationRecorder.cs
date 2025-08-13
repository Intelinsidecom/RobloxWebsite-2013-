using System;

namespace Roblox.Instrumentation;

public interface IDurationRecorder
{
	void RecordDuration(Action operation, IAverageValueCounter counter);

	T RecordDuration<T>(Func<T> operation, IAverageValueCounter counter);

	void RecordDuration(Action operation, IPercentileCounter counter);

	T RecordDuration<T>(Func<T> operation, IPercentileCounter counter);
}
