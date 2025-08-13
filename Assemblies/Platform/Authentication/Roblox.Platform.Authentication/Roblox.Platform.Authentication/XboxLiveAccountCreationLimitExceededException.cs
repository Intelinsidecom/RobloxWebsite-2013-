using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

public class XboxLiveAccountCreationLimitExceededException : PlatformException
{
	public XboxLiveAccountCreationLimitExceededException(string pairwiseId)
		: base($"Too many accounts created on PairwiseId: {pairwiseId}")
	{
	}
}
