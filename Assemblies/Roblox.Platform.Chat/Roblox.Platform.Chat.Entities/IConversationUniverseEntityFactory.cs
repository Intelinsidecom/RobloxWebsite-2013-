namespace Roblox.Platform.Chat.Entities;

internal interface IConversationUniverseEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Chat.Entities.IConversationUniverseEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Chat.Entities.IConversationUniverseEntity" /> with the given ID, or null if none existed.</returns>
	IConversationUniverseEntity Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Chat.Entities.IConversationUniverseEntity" /> with the given conversation Id
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Chat.Entities.IConversationUniverseEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IConversationUniverseEntity GetByConversationId(long conversationId);

	IConversationUniverseEntity Create(long conversationId, long universeId);
}
