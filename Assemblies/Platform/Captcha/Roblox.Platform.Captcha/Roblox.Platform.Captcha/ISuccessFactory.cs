using System;
using Roblox.Captcha.Entities;

namespace Roblox.Platform.Captcha;

internal interface ISuccessFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Captcha.Entities.ISuccess" /> with the given identifier and <see cref="T:Roblox.Platform.Captcha.ActionType" />.
	/// </summary>
	/// <param name="identifier"></param>
	/// <param name="actionType"></param>
	/// <param name="expiration"></param>
	/// <returns>The <see cref="T:Roblox.Captcha.Entities.ISuccess" /> with the given identifier and <see cref="T:Roblox.Platform.Captcha.ActionType" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="identifier" />'s 'Value' property is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation was unavailable.</exception>
	ISuccess Get(Identifier identifier, ActionType actionType, TimeSpan expiration);

	/// <summary>
	/// Creates a new <see cref="T:Roblox.Captcha.Entities.ISuccess" />. The entity is not saved.
	/// </summary>
	/// <param name="expiration"></param>
	/// <returns>The created <see cref="T:Roblox.Captcha.Entities.ISuccess" />.</returns>
	ISuccess Create(TimeSpan expiration);
}
