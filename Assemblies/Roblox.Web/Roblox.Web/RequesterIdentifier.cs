using System;
using System.Web;

namespace Roblox.Web;

/// <inheritdoc cref="T:Roblox.Web.IRequestIdentifier" />
public class RequesterIdentifier : IRequestIdentifier
{
	private readonly IGameServerRequestValidator _GameServerRequestValidator;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.RequesterIdentifier" /> class.
	/// </summary>
	/// <param name="gameServerRequestValidator">The <see cref="T:Roblox.Web.IGameServerRequestValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Any argument is null.</exception>
	public RequesterIdentifier(IGameServerRequestValidator gameServerRequestValidator)
	{
		_GameServerRequestValidator = gameServerRequestValidator ?? throw new ArgumentNullException("gameServerRequestValidator");
	}

	/// <inheritdoc cref="M:Roblox.Web.IRequestIdentifier.GetRequester(System.Web.HttpContextBase)" />
	public RequesterType GetRequester(HttpContextBase context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (_GameServerRequestValidator.IsPotentialGameServer(context) && _GameServerRequestValidator.IsValidGameServerRequest(context))
		{
			return RequesterType.GameServer;
		}
		if (!context.Request.IsAuthenticated)
		{
			return RequesterType.UnauthenticatedUser;
		}
		return RequesterType.AuthenticatedUser;
	}
}
