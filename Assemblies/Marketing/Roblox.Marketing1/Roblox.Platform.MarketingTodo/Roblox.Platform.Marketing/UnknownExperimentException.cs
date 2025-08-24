using Roblox.Platform.Core;

namespace Roblox.Platform.Marketing;

public class UnknownExperimentException : PlatformException
{
	public UnknownExperimentException()
		: base("Invalid experiment: experiment is null.")
	{
	}

	public UnknownExperimentException(string name)
		: base("Experiment " + name + " does not exist.")
	{
	}

	public UnknownExperimentException(int id)
		: base("Experiment with id " + id + " does not exist.")
	{
	}
}
