using System.Collections.Generic;

namespace Roblox.Platform.Chat;

/// <summary>
/// Predicate used when querying conversation participants to prepare Chat Interactions, to control number of iterations 
/// </summary>
/// <param name="chatInteractionsList"><see cref="T:Roblox.Platform.Chat.ChatInteraction" />chat Interactions list</param>
/// <returns></returns>
internal delegate bool ShouldQueryMoreParticipantConversationsForChatInteractions(IReadOnlyCollection<ChatInteraction> chatInteractionsList);
