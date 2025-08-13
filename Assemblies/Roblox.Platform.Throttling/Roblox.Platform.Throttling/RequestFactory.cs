namespace Roblox.Platform.Throttling;

public class RequestFactory : IRequestFactory
{
	public IRequest GetGameServerRequest(string gameInstanceId, int currentNumberOfPlayers, string nameSpace, string actionType)
	{
		return new GameServerRequest(gameInstanceId, currentNumberOfPlayers, nameSpace, actionType);
	}

	public IRequest GetUserRequestByUserId(long userId, string nameSpace, string actionType)
	{
		return new UserRequest(userId, nameSpace, actionType);
	}

	public IRequest GetUserRequestByIpAddress(string ipAddress, string nameSpace, string actionType)
	{
		return new UserRequest(ipAddress, nameSpace, actionType);
	}

	public IRequest GetIpRequestByIpAddress(string ipAddress, string nameSpace, string actionType)
	{
		return new IpRequest(ipAddress, nameSpace, actionType);
	}

	public IRequest GetFlaggedIpRangesRequest(string nameSpace, string actionType)
	{
		return new FlaggedIpRangesRequest(nameSpace, actionType);
	}
}
