using System;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Avatar;

/// <summary>
/// An object which can be used to wear and remove things for a user.
/// </summary>
public interface IAvatarFactory
{
	/// <summary>
	/// An event raised when an avatar changes.
	/// </summary>
	event Action<AvatarChangedEventArgs> AppearanceChangedEvent;

	/// <summary>
	/// Invokes the <see cref="E:Roblox.Platform.Avatar.IAvatarFactory.AppearanceChangedEvent" /> with the specified args.
	/// </summary>
	void InvokeAppearanceChangeEvent(AvatarChangedEventArgs args);

	IAvatar GetAvatar(IUser user);

	IAvatar GetAvatar(long userId);
}
