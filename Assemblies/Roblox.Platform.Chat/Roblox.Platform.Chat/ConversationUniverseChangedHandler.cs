using System;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Chat;

public delegate void ConversationUniverseChangedHandler(IUser currentUser, IConversationWithParticipants conversation, IUniverse universe, IPlatform platform, IParticipantUtilities participantUtilities, DateTime? conversationUniverseChangedDateTime);
