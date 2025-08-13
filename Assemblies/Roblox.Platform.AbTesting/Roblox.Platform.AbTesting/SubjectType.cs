namespace Roblox.Platform.AbTesting;

/// <summary>
/// Represents a type of subject that can enroll in an experiment.
/// </summary>
public enum SubjectType
{
	/// <summary>
	/// The subject is a user.
	/// </summary>
	User = 1,
	/// <summary>
	/// The subject is a browser tracker.
	/// </summary>
	BrowserTracker
}
