using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Platform.TeamCreate;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Chat;

internal class ConversationParticipantValidator : IConversationParticipantValidator
{
	private readonly IFriendshipFactory _FriendshipFactory;

	private readonly IConversationDataAccessor _ConversationDataAccessor;

	private readonly ITeamCreatePermissionsVerifier _TeamCreatePermissionsVerifier;

	private readonly IUniverseFactory _UniverseFactory;

	public ConversationParticipantValidator(IFriendshipFactory friendshipFactory, IConversationDataAccessor conversationDataAccessor, ITeamCreatePermissionsVerifier teamCreatePermissionsVerifier, IUniverseFactory universeFactory)
	{
		_FriendshipFactory = friendshipFactory.AssignOrThrowIfNull("friendshipFactory");
		_ConversationDataAccessor = conversationDataAccessor.AssignOrThrowIfNull("conversationDataAccessor");
		_TeamCreatePermissionsVerifier = teamCreatePermissionsVerifier.AssignOrThrowIfNull("teamCreatePermissionsVerifier");
		_UniverseFactory = universeFactory.AssignOrThrowIfNull("universeFactory");
	}

	public ValidatedUsers GetValidatedParticipantsForSocialConversations(IUser currentUser, IReadOnlyCollection<IUser> newUsers, ConversationType conversationType)
	{
		if (newUsers == null || newUsers.Count == 0)
		{
			throw new PlatformArgumentException("Participants are needed to create a conversation");
		}
		int maxParticipantsInConversation = _ConversationDataAccessor.GetMaxParticipantsInConversation(conversationType);
		if (newUsers.Count > maxParticipantsInConversation)
		{
			throw new ChatParticipantLimitExceededException("Too many participants in the conversation");
		}
		List<IUser> acceptedUsers = new List<IUser>();
		List<RejectedUser> rejectedUsers = new List<RejectedUser>();
		IReadOnlyCollection<IFriend> allFriends = _FriendshipFactory.GetAllFriends(currentUser);
		foreach (IUser user in newUsers)
		{
			if (user == null)
			{
				throw new PlatformArgumentNullException("ParticipantUser cannot be null");
			}
			if (!allFriends.Any((IFriend friendUser) => friendUser != null && friendUser.UserId == user.Id))
			{
				throw new ChatPlatformAuthorizationException("The user is not your friend. User:" + user.Id);
			}
			UserRejectedReason? userRejectedReason = null;
			if (conversationType == ConversationType.MultiUserConversation && _ConversationDataAccessor.GetParticipantConversationCount(user.ToParticipant()) >= Settings.Default.MaxConversationsPerParticipant)
			{
				userRejectedReason = UserRejectedReason.InTooManyConversations;
			}
			if (userRejectedReason.HasValue)
			{
				rejectedUsers.Add(new RejectedUser
				{
					User = user,
					Reason = userRejectedReason.Value
				});
			}
			else
			{
				acceptedUsers.Add(user);
			}
		}
		return new ValidatedUsers
		{
			AcceptedUsers = (IReadOnlyCollection<IUser>)(object)acceptedUsers.ToArray(),
			RejectedUsers = (IReadOnlyCollection<IRejectedUser>)(object)rejectedUsers.ToArray()
		};
	}

	public ValidatedUsers GetValidatedParticipantsForCloudEditConversations(IPlace place, IUser currentUser, IReadOnlyCollection<IUser> newUsers, IGroupMembershipFactory groupMembershipFactory)
	{
		if (newUsers == null || newUsers.Count == 0)
		{
			throw new PlatformArgumentException("Participants are needed to create a conversation");
		}
		int maxParticipantsInConversation = _ConversationDataAccessor.GetMaxParticipantsInConversation(ConversationType.CloudEditConversation);
		if (newUsers.Count > maxParticipantsInConversation)
		{
			throw new ChatParticipantLimitExceededException("Too many participants in the conversation");
		}
		IConversationWithParticipants cloudEditConversation = _ConversationDataAccessor.GetCloudEditConversation(place.Id);
		if (cloudEditConversation != null && cloudEditConversation.Participants != null)
		{
			int currentParticipantCount = cloudEditConversation.Participants.Length;
			if (newUsers.Count + currentParticipantCount > maxParticipantsInConversation)
			{
				throw new ChatParticipantLimitExceededException("Too many participants in the conversation");
			}
		}
		List<IUser> acceptedUsers = new List<IUser>();
		IUniverse universe = _UniverseFactory.GetPlaceUniverse(place);
		if (universe == null)
		{
			throw new PlatformArgumentException("Place not a member of a universe");
		}
		foreach (IUser user in newUsers)
		{
			if (user == null)
			{
				throw new PlatformArgumentNullException("ParticipantUser cannot be null");
			}
			if (!_TeamCreatePermissionsVerifier.IsUserTeamCreateMember(user, universe))
			{
				throw new ChatPlatformAuthorizationException($"The user is not authorized to join the cloud edit chat {user.Name}");
			}
			acceptedUsers.Add(user);
		}
		return new ValidatedUsers
		{
			AcceptedUsers = (IReadOnlyCollection<IUser>)(object)acceptedUsers.ToArray(),
			RejectedUsers = new List<RejectedUser>()
		};
	}
}
