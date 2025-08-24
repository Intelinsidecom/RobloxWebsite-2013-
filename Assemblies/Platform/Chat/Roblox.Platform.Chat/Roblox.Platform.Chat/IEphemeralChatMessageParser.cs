using Roblox.Platform.Chat.Entities;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

/// <summary>
/// Interface for parsing ephemeral chat messages to and from data storage
/// </summary>
internal interface IEphemeralChatMessageParser
{
	/// <summary>
	/// Converts the chat message entity into array of hash entries
	/// </summary>
	/// <param name="message">chat message entity to be converted to hash entries</param>
	/// <returns>Array of HashEntry from the chatMessage propersties relevant to the parser</returns>
	HashEntry[] GetHashEntries(IChatMessageEntity message);

	/// <summary>
	/// Creates a Chat Message Entity based on the hash Entries provided
	/// </summary>
	/// <param name="hashEntries">Array of HashEntry to be converted to the chat message entity properties</param>
	/// <returns>The Chat Message with the relevant properties set based on the hashEntries provided</returns>
	IChatMessageEntity GetMessageFromHashEntries(HashEntry[] hashEntries);

	/// <summary>
	/// Creates a chat message entiry based on the chat message send request
	/// </summary>
	/// <param name="rawChatMessage">The chat message send request consisting of relevant properties to create, store and send a chat message</param>
	/// <returns>The Chat messahe with the relevant properties set based on the chat message send request</returns>
	IChatMessageEntity Translate(IRawChatMessage rawChatMessage);
}
