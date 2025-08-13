using Roblox.Games.Client;

namespace Roblox.Platform.Games.PrivateServer;

internal interface IPrivateServerGameManager
{
	void CloseRunningGameForPrivateServer(IPrivateServer privateServer, CloseGameReasonType closeGameReasonType);
}
