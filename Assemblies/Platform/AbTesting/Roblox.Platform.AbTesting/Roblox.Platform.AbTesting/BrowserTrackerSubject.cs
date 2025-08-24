using Roblox.Platform.Core;
using Roblox.Platform.Marketing;

namespace Roblox.Platform.AbTesting;

/// <summary>
/// Represents a subject whose type is <see cref="F:Roblox.Platform.AbTesting.SubjectType.BrowserTracker" />.
/// </summary>
public sealed class BrowserTrackerSubject : TranslatedSubjectBase
{
	private const SubjectType _BrowserTrackerSubjectType = SubjectType.BrowserTracker;

	private readonly long _TargetId;

	/// <summary>
	/// Gets the subject's target ID.
	/// </summary>
	public override long TargetId => _TargetId;

	/// <summary>
	/// Gets the subject's type.
	/// </summary>
	public override string Type => SubjectType.BrowserTracker.ToString();

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.BrowserTrackerSubject" /> class from the given <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" />.
	/// </summary>
	/// <param name="browserTracker">The <see cref="T:Roblox.Platform.Marketing.IBrowserTracker" /> to construct the <see cref="T:Roblox.Platform.AbTesting.BrowserTrackerSubject" /> from.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="browserTracker" /> is null.</exception>
	public BrowserTrackerSubject(IBrowserTracker browserTracker)
	{
		if (browserTracker == null)
		{
			throw new PlatformArgumentNullException("browserTracker");
		}
		_TargetId = browserTracker.Id;
	}
}
