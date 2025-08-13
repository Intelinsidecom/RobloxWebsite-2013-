using Roblox.Platform.Captcha.Interfaces;

namespace Roblox.Platform.Captcha.Implementations;

/// <summary>
/// Provides factory methods to retrive Captcha actions
/// </summary>
public class ActionFactory : IActionFactory
{
	private readonly ActionType _ActionType;

	private readonly Factories _Factories;

	/// <summary>
	/// Create a new instance of <see cref="T:Roblox.Platform.Captcha.Implementations.ActionFactory" />
	/// </summary>
	/// <param name="actionType"></param>
	/// <param name="factories"></param>
	public ActionFactory(ActionType actionType, Factories factories)
	{
		_ActionType = actionType;
		_Factories = factories;
	}

	/// <summary>
	/// Gets a Captcha action based on username
	/// </summary>
	/// <param name="username">Username to be used as identifier of the action</param>
	/// <returns></returns>
	public Action GetUserCaptchaAction(string username)
	{
		Identifier identifier2 = default(Identifier);
		identifier2.TargetType = IdentifierTargetType.Username;
		identifier2.Value = username;
		Identifier identifier = identifier2;
		return GetCaptchaAction(identifier, _ActionType);
	}

	/// <summary>
	/// Gets a Captcha action based on ipAddress
	/// </summary>
	/// <param name="ipAddress">IP address to be used as identifier of the action</param>
	/// <returns></returns>
	public Action GetIpCaptchaAction(string ipAddress)
	{
		Identifier identifier2 = default(Identifier);
		identifier2.TargetType = IdentifierTargetType.IpAddress;
		identifier2.Value = ipAddress;
		Identifier identifier = identifier2;
		return GetCaptchaAction(identifier, _ActionType);
	}

	private Action GetCaptchaAction(Identifier identifier, ActionType actionType)
	{
		return new Action(identifier, actionType, _Factories);
	}
}
