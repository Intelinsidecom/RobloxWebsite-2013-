using System;
using Roblox.Http;
using Roblox.Platform.Communication.Behavior;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.TextFilter.Client;
using Roblox.TextFilter.Client.Models.Common;

namespace Roblox.Platform.Chat;

internal class ContentValidator : IContentValidator
{
	private const string _TextFilterClientNameMessageContent = "AppChat";

	private const string _TextFilterClientNameConversationTitle = "AppChatConversationTitle";

	private const string _TextFilterClientNameRevalidationSuffix = "Revalidation";

	private readonly IContentValidationRules _ContentValidationRules;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	public ContentValidator(IContentValidationRules contentValidationRules, ITextFilterClientV2 textFilterClientV2, IParticipantUtilities participantUtilities)
	{
		_ContentValidationRules = contentValidationRules ?? throw new ArgumentNullException("contentValidationRules");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new ArgumentNullException("textFilterClientV2");
		_ParticipantUtilities = participantUtilities ?? throw new ArgumentNullException("participantUtilities");
	}

	public virtual IMessageContentValidationResult Validate(IParticipant sender, IConversationWithParticipants conversation, ChatContentType contentType, string rawContent, bool isRevalidation = false)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (conversation == null)
		{
			throw new ArgumentNullException("conversation");
		}
		if (string.IsNullOrEmpty(rawContent))
		{
			throw new ArgumentException("rawContent cannot be null or empty");
		}
		if (_ParticipantUtilities.IsUser(sender))
		{
			IUser user = _ParticipantUtilities.ToUser(sender);
			return GetValidationResultFromService(user, conversation, contentType, rawContent, isRevalidation);
		}
		throw new NotSupportedException("Only User Participants are currently able to send messages");
	}

	/// <summary> Retrieves the Text Validation result from the Text Filter Service</summary>
	public virtual IMessageContentValidationResult GetValidationResultFromService(IUser sender, IConversationWithParticipants conversation, ChatContentType contentType, string rawContent, bool isRevalidation)
	{
		string client = GetTextFilterClientName(contentType, isRevalidation);
		try
		{
			ITextFilterClientV2 textFilterClientV = _TextFilterClientV2;
			TextAuthor obj = new TextAuthor
			{
				Id = (sender?.Id ?? 0)
			};
			int isUnder;
			if (sender != null)
			{
				_ = sender.AgeBracket;
				if (0 == 0)
				{
					isUnder = ((sender.AgeBracket == AgeBracket.AgeUnder13) ? 1 : 0);
					goto IL_0047;
				}
			}
			isUnder = 1;
			goto IL_0047;
			IL_0047:
			obj.IsUnder13 = (byte)isUnder != 0;
			obj.Name = sender?.Name ?? string.Empty;
			FilterLiveTextResult filterLiveTextResult = textFilterClientV.FilterLiveText(rawContent, (IClientTextAuthor)obj, client, TextFilterServerType.WebChat, conversation.Id.ToString());
			if (filterLiveTextResult == null || filterLiveTextResult.FilteredResult == null || filterLiveTextResult.FilteredResultUnderage == null || !_ContentValidationRules.IsTextAppropriateToSend(filterLiveTextResult, sender, conversation))
			{
				return new MessageContentValidationResult
				{
					IsAllowedToBeSent = false,
					CommunicationGuardStatus = CommunicationBehaviorGuardStatus.Unenforced,
					IsMoreStrictlyModeratedForSomeRecipients = true,
					Under13Content = null,
					Over13Content = null
				};
			}
			return new MessageContentValidationResult
			{
				IsAllowedToBeSent = true,
				CommunicationGuardStatus = CommunicationBehaviorGuardStatus.Unenforced,
				IsMoreStrictlyModeratedForSomeRecipients = _ContentValidationRules.IsTextMoreStrictlyFilteredForOtherViewers(filterLiveTextResult, sender, conversation),
				Under13Content = _ContentValidationRules.GetTextForUnder13Viewers(filterLiveTextResult),
				Over13Content = _ContentValidationRules.GetTextForOver13Viewers(filterLiveTextResult, sender)
			};
		}
		catch (HttpException ex)
		{
			throw new PlatformOperationUnavailableException("Failed to filter the given text.", ex);
		}
	}

	public virtual string GetTextFilterClientName(ChatContentType contentType, bool isRevalidation)
	{
		string clientName = string.Empty;
		switch (contentType)
		{
		case ChatContentType.Message:
			clientName = "AppChat";
			break;
		case ChatContentType.ConversationTitle:
			clientName = "AppChatConversationTitle";
			break;
		}
		if (isRevalidation)
		{
			clientName += "Revalidation";
		}
		return clientName;
	}
}
