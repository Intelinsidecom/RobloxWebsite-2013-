using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal interface IConversationParticipantValidator
{
	ValidatedUsers GetValidatedParticipantsForSocialConversations(IUser currentUser, IReadOnlyCollection<IUser> newUsers, ConversationType conversationType);

	ValidatedUsers GetValidatedParticipantsForCloudEditConversations(IPlace place, IUser currentUser, IReadOnlyCollection<IUser> newUsers, IGroupMembershipFactory groupMembershipFactory);
}
