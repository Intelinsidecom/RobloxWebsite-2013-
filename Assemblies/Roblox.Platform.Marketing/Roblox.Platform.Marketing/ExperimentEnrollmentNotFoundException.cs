using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

public class ExperimentEnrollmentNotFoundException : PlatformException
{
	public ExperimentEnrollmentNotFoundException(IUser user, int experimentId)
		: base("No enrollment found for account " + user.AccountId + " in experiment " + experimentId)
	{
	}

	public ExperimentEnrollmentNotFoundException(IBrowserTracker browserTracker, int experimentId)
		: base("No enrollment found for browser tracker " + browserTracker.Id + " in experiment " + experimentId)
	{
	}
}
