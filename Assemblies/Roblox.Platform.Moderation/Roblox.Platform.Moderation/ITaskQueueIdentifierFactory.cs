namespace Roblox.Platform.Moderation;

/// <summary>
/// A factory interface that is responsbile for creating <see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" /> from <see cref="T:Roblox.Platform.Moderation.SqsQueueSetting" />.
///
/// Note: Different types of moderation queue may have different implementations of this interface.
/// </summary>
public interface ITaskQueueIdentifierFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" /> from the specified <see cref="T:Roblox.Platform.Moderation.SqsQueueSetting" />.
	/// </summary>
	/// <param name="sqsQueueSetting"><see cref="T:Roblox.Platform.Moderation.SqsQueueSetting" />.</param>
	/// <returns><see cref="T:Roblox.Platform.Moderation.ITaskQueueIdentifier" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Throws when sqsQueueSetting is null.</exception>
	ITaskQueueIdentifier Create(SqsQueueSetting sqsQueueSetting);
}
