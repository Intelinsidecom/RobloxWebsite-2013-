using Roblox.Platform.Core;

namespace Roblox.Platform.Marketing;

public class UnknownExperimentVariationException : PlatformException
{
	public UnknownExperimentVariationException()
		: base("Experiment Variation was null.")
	{
	}

	public UnknownExperimentVariationException(int id)
		: base("Experiment Variation " + id + " does not exist.")
	{
	}
}
