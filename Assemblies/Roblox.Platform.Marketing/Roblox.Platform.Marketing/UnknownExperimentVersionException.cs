using Roblox.Platform.Core;

namespace Roblox.Platform.Marketing;

public class UnknownExperimentVersionException : PlatformException
{
	public UnknownExperimentVersionException()
		: base("ExperimentVersion is null.")
	{
	}

	public UnknownExperimentVersionException(int id)
		: base("ExperimentVersion with id " + id + " does not exist.")
	{
	}
}
