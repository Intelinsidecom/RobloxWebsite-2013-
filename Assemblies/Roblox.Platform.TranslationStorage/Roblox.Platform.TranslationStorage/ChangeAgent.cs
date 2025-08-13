using Roblox.Platform.Core;

namespace Roblox.Platform.TranslationStorage;

internal class ChangeAgent : IChangeAgent
{
	public ChangeAgentType ChangeAgentType { get; }

	public long ChangeAgentTargetId { get; }

	public ChangeAgent(ChangeAgentType changeAgentType, long changeAgentTargetId)
	{
		if (changeAgentTargetId == 0L)
		{
			throw new PlatformArgumentNullException("changeAgentTargetId");
		}
		ChangeAgentType = changeAgentType;
		ChangeAgentTargetId = changeAgentTargetId;
	}
}
