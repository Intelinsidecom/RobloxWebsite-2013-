using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public delegate void UsersAddedToConversationHandler(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> addedUsers, IReadOnlyCollection<IParticipant> existingUsers, IParticipantUtilities participantUtilities, IPlatform platform);
