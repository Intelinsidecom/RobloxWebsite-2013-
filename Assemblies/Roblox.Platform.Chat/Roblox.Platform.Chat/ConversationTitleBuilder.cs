using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;
using Roblox.Redis;

namespace Roblox.Platform.Chat;

internal class ConversationTitleBuilder : IConversationTitleBuilder
{
	private readonly IConversationTitleCache _ConversationTitleCache;

	private readonly IContentValidator _ContentValidator;

	private readonly IParticipantUtilities _ParticipantUtilities;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	public ConversationTitleBuilder(IRedisClient redisClient, IContentValidator contentValidator, IParticipantUtilities participantUtilities, ILogger logger)
		: this(new RedisConversationTitleCache(redisClient, logger), contentValidator, participantUtilities, Settings.Default, logger)
	{
	}

	internal ConversationTitleBuilder(IConversationTitleCache conversationTitleCache, IContentValidator contentValidator, IParticipantUtilities participantUtilities, ISettings settings, ILogger logger)
	{
		_ConversationTitleCache = conversationTitleCache;
		_ContentValidator = contentValidator;
		_ParticipantUtilities = participantUtilities;
		_Settings = settings;
		_Logger = logger;
	}

	public IConversationTitle BuildConversationTitleForViewer(IConversationWithParticipants conversation, IUser viewer)
	{
		if (!string.IsNullOrWhiteSpace(conversation.Title))
		{
			return new ConversationTitle
			{
				TitleForViewer = GetAppropriateCustomTitle(conversation, viewer),
				IsDefaultTitle = false
			};
		}
		return new ConversationTitle
		{
			TitleForViewer = BuildDefaultConversationTitle(conversation, viewer),
			IsDefaultTitle = true
		};
	}

	private string GetAppropriateCustomTitle(IConversationWithParticipants conversation, IUser viewer)
	{
		if (viewer != null && viewer.IsUnder13())
		{
			string cachedUnder13Version = _ConversationTitleCache.GetConversationTitleForUnder13(conversation.Id);
			if (!string.IsNullOrEmpty(cachedUnder13Version))
			{
				return cachedUnder13Version;
			}
			string under13Content;
			try
			{
				IMessageContentValidationResult validationResult = _ContentValidator.Validate(_ParticipantUtilities.ToParticipant(viewer), conversation, ChatContentType.ConversationTitle, conversation.Title, isRevalidation: true);
				under13Content = ((!string.IsNullOrEmpty(validationResult.Under13Content)) ? validationResult.Under13Content : _Settings.FallbackTextForUnavailableUnder13Content);
				_ConversationTitleCache.CacheConversationTitleForUnder13(conversation.Id, under13Content);
			}
			catch (Exception exception)
			{
				_Logger.Error(exception);
				under13Content = _Settings.FallbackTextForUnavailableUnder13Content;
			}
			return under13Content;
		}
		return conversation.Title;
	}

	private string BuildDefaultConversationTitle(IConversationWithParticipants conversation, IUser viewer)
	{
		List<string> participantsNamesInTitle = (from user in (from p in conversation.Participants
				where _ParticipantUtilities.IsUser(p)
				select _ParticipantUtilities.ToUser(p)).ToList()
			where user.Id != viewer?.Id
			select user into pa
			select pa.Name into name
			orderby name
			select name).ToList();
		if (participantsNamesInTitle.Any())
		{
			return string.Join(", ", participantsNamesInTitle);
		}
		if (viewer != null)
		{
			return viewer.Name;
		}
		return string.Empty;
	}
}
