namespace Roblox.Platform.Throttling;

internal class FlaggedIpRangesRequest : ThrottleRequestBase
{
	internal override string ActionSuffix => RequestType.FlaggedIpRanges.ToString();

	public FlaggedIpRangesRequest(string nameSpace, string actionType)
		: base(string.Empty, nameSpace, actionType)
	{
	}

	public override bool IsEnabled()
	{
		return GetRateLimitEntity() != null;
	}

	public override string GetKey()
	{
		return $"{Namespace}_{ActionType}_{ActionSuffix}";
	}
}
