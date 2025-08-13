using System.Collections.Generic;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Chat;

public interface IConversationBuilder
{
	event UsersAddedToConversationHandler OnUsersAddedToConversation;

	event ConversationUniverseChangedHandler OnConversationUniverseChanged;

	IGroupConversationActionResponse CreateGroupConversation(IUser initiator, IReadOnlyCollection<IUser> participantUsers, string title);

	IConversation CreateOneToOneConversation(IUser firstUser, IUser secondUser);

	IConversation GetOrCreateCloudEditConversation(IUser currentUser, IPlace place);

	IGroupConversationActionResponse AddUsersToConversation(long conversationId, IUser currentUser, IUser[] newUsers, IPlatform platform);

	IConversation RemoveUserFromConversation(long conversationId, IUser currentUser, IUser userToBeRemoved);

	bool IsConversationTitleTooLong(string title);

	IConversationRenameResponse RenameGroupConversation(long conversationId, IUser currentUser, string newTitle);

	void UpdateUserTypingStatus(IUser initiator, long conversationId, bool isTyping);

	void SetConversationUniverse(IUser currentUser, long conversationId, IUniverse universe, IPlatform platform);

	void ResetConversationUniverse(IUser currentUser, long conversationId, IPlatform platform);
}
