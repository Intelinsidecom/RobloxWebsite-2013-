using System;

namespace Roblox.Sentinels;

public static class ExponentialBackoff
{
	private const byte _CeilingForMaxAttempts = 10;

	private static ThreadLocalRandom _Random = new ThreadLocalRandom();

	public static TimeSpan CalculateBackoff(byte attempt, byte maxAttempts, TimeSpan baseDelay, TimeSpan maxDelay, Jitter jitter = Jitter.None)
	{
		return CalculateBackoff(attempt, maxAttempts, baseDelay, maxDelay, jitter, () => _Random.NextDouble());
	}

	internal static TimeSpan CalculateBackoff(byte attempt, byte maxAttempts, TimeSpan baseDelay, TimeSpan maxDelay, Jitter jitter, Func<double> nextRandomDouble)
	{
		if (maxAttempts > 10)
		{
			throw new ArgumentOutOfRangeException($"{maxAttempts} must be less than or equal to {(byte)10}");
		}
		if (attempt > maxAttempts)
		{
			attempt = maxAttempts;
		}
		TimeSpan timeSpan = TimeSpanExtensions.Multiply(baseDelay, Math.Pow(2.0, attempt - 1));
		if (timeSpan > maxDelay || timeSpan < TimeSpan.Zero)
		{
			timeSpan = maxDelay;
		}
		double num = nextRandomDouble();
		switch (jitter)
		{
		case Jitter.Full:
			timeSpan = TimeSpanExtensions.Multiply(timeSpan, num);
			break;
		case Jitter.Equal:
			timeSpan = TimeSpanExtensions.Multiply(timeSpan, 0.5 + num * 0.5);
			break;
		}
		return timeSpan;
	}
}
