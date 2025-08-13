namespace Roblox.Platform.Chat;

/// <summary>
/// Predicate to filter a conversation participant, used when querying participant conversations to prepare Chat Interactions 
/// </summary>
/// <param name="participant"><see cref="T:Roblox.Platform.Chat.IParticipant" />participant that should/not be included in chat Interactions result</param>
/// <returns></returns>
internal delegate bool ShouldParticipantBeIncludedInChatInteractions(IParticipant participant);
