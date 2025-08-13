namespace Roblox.Platform.Core.ExclusiveStartPaging;

public class ExclusiveStartKeyContainer<TExclusiveStartKey>
{
	public TExclusiveStartKey ExclusiveStartKey { get; }

	public ExclusiveStartKeyContainer(TExclusiveStartKey exclusiveStartKey)
	{
		ExclusiveStartKey = exclusiveStartKey;
	}
}
