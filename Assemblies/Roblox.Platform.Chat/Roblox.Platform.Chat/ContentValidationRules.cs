using System.Linq;
using Roblox.Platform.Membership;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Chat;

internal class ContentValidationRules : IContentValidationRules
{
	private readonly IParticipantUtilities _ParticipantUtilities;

	public ContentValidationRules(IParticipantUtilities participantUtilities)
	{
		_ParticipantUtilities = participantUtilities;
	}

	public bool IsTextAppropriateToSend(FilterLiveTextResult filterLiveTextResult, IUser sender, IConversationWithParticipants conversation)
	{
		if (sender.IsUnder13())
		{
			return filterLiveTextResult.FilteredResultUnderage.ModerationLevel == 1;
		}
		if (conversation.ConversationType == ConversationType.OneToOneConversation && conversation.Participants.Any((IParticipant p) => _ParticipantUtilities.IsUserUnder13(p)))
		{
			return filterLiveTextResult.FilteredResultUnderage.ModerationLevel == 1;
		}
		return filterLiveTextResult.FilteredResult.ModerationLevel != 3;
	}

	public bool IsTextMoreStrictlyFilteredForOtherViewers(FilterLiveTextResult filterLiveTextResult, IUser sender, IConversationWithParticipants conversation)
	{
		if (!sender.IsUnder13() && conversation.Participants.Any((IParticipant p) => _ParticipantUtilities.IsUserUnder13(p)))
		{
			return filterLiveTextResult.FilteredResultUnderage.ModerationLevel != 1;
		}
		return false;
	}

	public string GetTextForOver13Viewers(FilterLiveTextResult filterLiveTextResult, IUser sender)
	{
		if (sender.IsUnder13())
		{
			return filterLiveTextResult.FilteredResultUnderage.FilteredText;
		}
		return filterLiveTextResult.FilteredResult.FilteredText;
	}

	public string GetTextForUnder13Viewers(FilterLiveTextResult filterLiveTextResult)
	{
		string under13Text = filterLiveTextResult.FilteredResultUnderage.FilteredText ?? string.Empty;
		if (filterLiveTextResult.FilteredResultUnderage.ModerationLevel == 1)
		{
			return under13Text;
		}
		return string.Concat(under13Text.Select((char c) => (!char.IsWhiteSpace(c)) ? '#' : c));
	}
}
