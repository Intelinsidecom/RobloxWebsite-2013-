namespace Roblox.Platform.Avatar;

/// <summary>
/// For tracking changes made to avatars
/// </summary>
public interface IAvatarTracker
{
	/// <summary>
	/// Registers AppearanceChangedEvents to be funneled to diag via the injected AvatarFactory.
	/// </summary>
	void RegisterToDiag(IAvatarFactory avatarFactory);

	/// <summary>
	/// Registers AppearanceChangedEvents to be funneled to event stream via the injected AvatarFactory.
	/// </summary>
	void RegisterToEventStream(IAvatarFactory avatarFactory);

	/// <summary>
	/// Registers AppearanceChangedEvents to be funneled to diag via the injected TryOnFactory.
	/// </summary>
	void RegisterToDiag(ITryOnFactory tryOnFactory);

	/// <summary>
	/// Registers AppearanceChangedEvents to be funneled to event stream via the injected TryOnFactory.
	/// </summary>
	void RegisterToEventStream(ITryOnFactory tryOnFactory);

	/// <summary>
	/// Unregisters AppearanceChangedEvents to be funneled to diag via the injected AvatarFactory.
	/// </summary>
	void UnregisterFromDiag(IAvatarFactory avatarFactory);

	/// <summary>
	/// Unregisters AppearanceChangedEvents to be funneled to event stream via the injected AvatarFactory.
	/// </summary>
	void UnregisterFromEventStream(IAvatarFactory avatarFactory);

	void UnregisterFromDiag(ITryOnFactory tryOnFactory);

	/// <summary>
	/// Unregisters AppearanceChangedEvents to be funneled to event stream via the injected TryOnFactory.
	/// </summary>
	void UnregisterFromEventStream(ITryOnFactory tryOnFactory);
}
