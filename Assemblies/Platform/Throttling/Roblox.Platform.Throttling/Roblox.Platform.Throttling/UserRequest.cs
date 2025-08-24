namespace Roblox.Platform.Throttling;

internal class UserRequest : ThrottleRequestBase
{
	internal override string ActionSuffix => RequestType.User.ToString();

	public UserRequest(long userId, string nameSpace, string actionType)
		: base(userId.ToString(), nameSpace, actionType)
	{
	}

	public UserRequest(string ipAddress, string nameSpace, string actionType)
		: base(ipAddress, nameSpace, actionType)
	{
	}
}
