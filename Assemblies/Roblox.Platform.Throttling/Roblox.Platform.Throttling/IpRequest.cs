namespace Roblox.Platform.Throttling;

internal class IpRequest : ThrottleRequestBase
{
	internal override string ActionSuffix => RequestType.IpAddress.ToString();

	public override bool IsEnabled()
	{
		return GetRateLimitEntity() != null;
	}

	public IpRequest(string ipAddress, string nameSpace, string actionType)
		: base(ipAddress, nameSpace, actionType)
	{
	}
}
