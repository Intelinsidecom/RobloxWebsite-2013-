using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Chat;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Party.Interface;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Party.Events;

public class ChatEventsPartyHandler
{
	private readonly IPlayTogetherPartyBuilder _PlayTogetherPartyBuilder;

	private readonly IPlayTogetherPartyFactory _PlayTogetherPartyFactory;

	private readonly IConversationBuilder _ConversationBuilder;

	public ChatEventsPartyHandler(IPlayTogetherPartyBuilder playTogetherPartyBuilder, IPlayTogetherPartyFactory playTogetherPartyFactory, IConversationBuilder conversationBuilder)
	{
		_PlayTogetherPartyBuilder = playTogetherPartyBuilder;
		_PlayTogetherPartyFactory = playTogetherPartyFactory;
		_ConversationBuilder = conversationBuilder;
	}

	private void OnUsersAddedToConversation(IUser currentUser, IConversationWithParticipants conversation, IReadOnlyCollection<IParticipant> addedParticipants, IReadOnlyCollection<IParticipant> existingParticipants, IParticipantUtilities participantUtilities, IPlatform platform)
	{
		IReadOnlyCollection<IParty> parties = _PlayTogetherPartyFactory.GetPartiesForConversationIds(currentUser, new long[1] { conversation.Id }, platform);
		if (parties == null || parties.Count != 1)
		{
			return;
		}
		foreach (IParticipant addedParticipant in addedParticipants)
		{
			IUser addeduser = participantUtilities.ToUser(addedParticipant);
			_PlayTogetherPartyBuilder.InviteUser(platform, parties.First().Id, currentUser, addeduser);
		}
	}

	private void OnConversationUniverseChanged(IUser currentUser, IConversationWithParticipants conversation, IUniverse universe, IPlatform platform, IParticipantUtilities participantUtilities, DateTime? conversationUniverseChangedDateTime)
	{
		IReadOnlyCollection<IParty> parties = _PlayTogetherPartyFactory.GetPartiesForConversationIds(currentUser, new long[1] { conversation.Id }, platform);
		if (parties != null && parties.Count == 1)
		{
			_PlayTogetherPartyBuilder.RemoveAllPartyMembers(platform, parties.First().Id);
		}
	}

	public void Register()
	{
		_ConversationBuilder.OnUsersAddedToConversation += OnUsersAddedToConversation;
		_ConversationBuilder.OnConversationUniverseChanged += OnConversationUniverseChanged;
	}
}
