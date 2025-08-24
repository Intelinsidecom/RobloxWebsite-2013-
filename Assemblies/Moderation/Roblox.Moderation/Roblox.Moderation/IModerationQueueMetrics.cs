namespace Roblox.Platform.Moderation;

/// <summary>
/// Provides metrics for the state of work in the given moderation queue(s).
/// </summary>
public interface IModerationQueueMetrics
{
	/// <summary>
	/// Find the age of the oldest item in the queues of all locales.
	/// </summary>
	int GetAgeOfOldestOpenTaskInSeconds();

	/// <summary>
	/// Find the age of the oldest item in the queue specified by the locale Id.
	/// </summary>
	/// <param name="localeId">The locale Id.</param>
	/// <exception cref="T:System.ArgumentException">Throws when the locale Id is not supported.</exception>
	int GetAgeOfOldestOpenTaskInSecondsByLocale(int localeId);

	/// <summary>
	/// Count of the total moderators with an active item in the queues of all locales.
	/// </summary>
	long GetTotalNumberOfActiveModerators();

	/// <summary>
	/// Count of the total moderators with an active item in the queue specified by the locale Id.
	/// </summary>
	/// <param name="localeId">The locale Id.</param>
	/// <exception cref="T:System.ArgumentException">Throws when the locale Id is not supported.</exception>
	long GetTotalNumberOfActiveModeratorsByLocale(int localeId);

	/// <summary>
	/// Count of the total number of open tasks in the queues of all locales.
	/// </summary>
	long GetTotalNumberOfOpenTasks();

	/// <summary>
	/// Count of the total number of open tasks in the queue specified by the locale Id.
	/// </summary>
	/// <param name="localeId">The locale Id.</param>
	/// <exception cref="T:System.ArgumentException">Throws when the locale Id is not supported.</exception>
	long GetTotalNumberOfOpenTasksByLocale(int localeId);
}
