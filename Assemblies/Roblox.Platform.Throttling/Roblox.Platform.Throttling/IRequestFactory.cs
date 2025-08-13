namespace Roblox.Platform.Throttling;

public interface IRequestFactory
{
	IRequest GetGameServerRequest(string gameInstanceId, int currentNumberOfPlayers, string nameSpace, string actionType);

	IRequest GetUserRequestByUserId(long userId, string nameSpace, string actionType);

	IRequest GetUserRequestByIpAddress(string ipAddress, string nameSpace, string actionType);

	IRequest GetIpRequestByIpAddress(string ipAddress, string nameSpace, string actionType);

	IRequest GetFlaggedIpRangesRequest(string nameSpace, string actionType);
}
