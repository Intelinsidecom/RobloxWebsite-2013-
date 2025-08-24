using Roblox.Platform.Core;

namespace Roblox.Platform.Marketing;

public class UnknownExperimentEnrollmentException : PlatformException
{
	public UnknownExperimentEnrollmentException(long id)
		: base("Experiment enrollment with id " + id + " does not exist.")
	{
	}
}
