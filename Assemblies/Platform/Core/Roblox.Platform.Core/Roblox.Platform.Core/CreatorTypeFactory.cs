namespace Roblox.Platform.Core;

public class CreatorTypeFactory : ICreatorTypeFactory
{
	public CreatorType Get(byte creatorId)
	{
		return (CreatorType)creatorId;
	}
}
