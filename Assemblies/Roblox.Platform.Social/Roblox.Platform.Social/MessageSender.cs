using System;
using Roblox.FloodCheckers;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Extensions;
using Roblox.Platform.Membership.Properties;
using Roblox.Platform.Social.Events;
using Roblox.Platform.Social.Messages;
using Roblox.Platform.Social.Properties;
using Roblox.TextFilter.Client;
using Roblox.TextFilter.Client.Models.Common;

namespace Roblox.Platform.Social;

/// <summary>
/// Provides methods for sending a message.
/// </summary>
public class MessageSender
{
	/// <summary>
	/// Represents a set of information relevant to message moderation.
	/// </summary>
	protected class MessageModerationInfo
	{
		/// <summary>
		/// The body of the message.
		/// </summary>
		public string Body;

		/// <summary>
		/// The subject of the message.
		/// </summary>
		public string Subject;

		/// <summary>
		/// The user ID of the author of the message.
		/// </summary>
		public int AuthorId;

		/// <summary>
		/// The user ID of the recipient of the message.
		/// </summary>
		public int RecipientId;

		/// <summary>
		/// Whether or not the message is a system message.
		/// </summary>
		public bool IsSystemMessage;

		/// <summary>
		/// The message type ID of the message's message type.
		/// </summary>
		public int MessageTypeId;
	}

	private readonly IMessagePrivacyAuthority _MessagePrivacyAuthority;

	private readonly MessageCounter _MessageCounter;

	/// <summary>
	/// The IMessageDataAccessor used to access message data.
	/// </summary>
	private readonly IMessageDataAccessor _MessageDataAccessor;

	/// <summary>
	/// The IMessageEventPublisher used to publish message event to AWS Sns.
	/// </summary>
	private readonly IMessageEventPublisher _MessageEventPublisher;

	private readonly ITextFilterClientV2 _TextFilterClientV2;

	private readonly IUserFactory _UserFactory;

	/// <summary>
	/// Gets the character limit of the body of a message.
	/// </summary>
	internal virtual int BodyCharacterLimit => Roblox.Platform.Social.Properties.Settings.Default.MessageBodyCharacterLimit;

	/// <summary>
	/// Gets the character limit of the subject of a message.
	/// </summary>
	internal virtual int SubjectCharacterLimit => Roblox.Platform.Social.Properties.Settings.Default.MessageSubjectCharacterLimit;

	/// <summary>
	/// Constructs a new MessageSender.
	/// </summary>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" /> for loading related users.</param>
	/// <param name="textFilterClientV2">The <see cref="T:Roblox.TextFilter.Client.ITextFilterClientV2" /> to use to filter a message's body and subject.</param>
	/// <param name="messagePrivacyAuthority">Used <see cref="T:Roblox.Platform.Social.Messages.IMessagePrivacyAuthority" /> for identifying if the Message can be sent between the users.</param>
	/// <param name="messageEventPublisher">The <see cref="T:Roblox.Platform.Social.Events.IMessageEventPublisher" /> to use to publish message events. 
	/// Uses a <see cref="T:Roblox.Platform.Social.Events.MessageEventPublisher" /> if left null</param>
	/// <param name="messageDataAccessor">The IMessageDataAccessor used to access message data. Uses 
	/// a <see cref="T:Roblox.Platform.Social.MessageDataAccessor" /> if left null.</param>
	public MessageSender(IUserFactory userFactory, ITextFilterClientV2 textFilterClientV2, IMessagePrivacyAuthority messagePrivacyAuthority, IMessageEventPublisher messageEventPublisher, IMessageDataAccessor messageDataAccessor = null)
	{
		_MessageDataAccessor = messageDataAccessor ?? new MessageDataAccessor();
		_MessageEventPublisher = messageEventPublisher;
		_MessagePrivacyAuthority = messagePrivacyAuthority;
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_TextFilterClientV2 = textFilterClientV2 ?? throw new ArgumentNullException("textFilterClientV2");
		_MessageCounter = new MessageCounter(_MessageDataAccessor);
	}

	/// <summary>
	/// Gets a user by their user ID.
	/// </summary>
	/// <param name="userId">The user ID of the user to get.</param>
	/// <returns>The user.</returns>
	protected virtual IUser GetUserByUserId(long userId)
	{
		return _UserFactory.GetUser(userId);
	}

	/// <summary>
	/// Determines whether or not the given IUser has a verified email.
	/// Explicitly here for unit testing
	/// </summary>
	/// <param name="user">The user to check for a verified email.</param>
	/// <returns>Whether or not the user has a verified email.</returns>
	protected internal virtual bool UserHasVerifiedEmail(IUser user)
	{
		return user.HasVerifiedEmail();
	}

	internal virtual IFloodChecker GetSenderFloodChecker(IUser sender, string ipAddress)
	{
		return new SendMessageFloodChecker(sender.Id, ipAddress);
	}

	internal virtual IFloodChecker GetRecipientFloodChecker(IUser recipient, string ipAddress)
	{
		return new SendMessageToUserFloodChecker(ipAddress, recipient.Id);
	}

	/// <summary>
	/// Sends a message.
	/// </summary>
	/// <param name="subject">The subject of the message.</param>
	/// <param name="body">The body of the message.</param>
	/// <param name="senderUser">The IUser that is sending the message. Assumed to be valid</param>
	/// <param name="recipientUser">The IUser that should receive the message. Assumed to be valid.</param>
	/// <param name="ipAddress">IP Address of the sender</param>
	/// <returns>The result of the send attempt.</returns>
	public SendResult Send(string subject, string body, IUser senderUser, IUser recipientUser, string ipAddress)
	{
		return Send(body, subject, null, senderUser, recipientUser, ipAddress);
	}

	/// <summary>
	/// Sends a message as a reply from one user to another.
	/// </summary>
	/// <param name="body">The body of the message.</param>
	/// <param name="senderUser">The user that is sending the message.</param>
	/// <param name="recipientUser">The user that will receive the message.</param>
	/// <param name="replyMessageId">The message ID of the message being replied to.</param>
	/// <param name="includePreviousMessage">Whether or not to include the previous message in the body of the message being sent.</param>
	/// <param name="ipAddress">IP Address of the sender.</param>
	/// <returns>A SendResult indicating the result of the request.</returns>
	public SendResult SendAsReply(string body, IUser senderUser, IUser recipientUser, long replyMessageId, bool includePreviousMessage, string ipAddress)
	{
		Message originalMessage = _MessageDataAccessor.GetByMessageId(replyMessageId);
		if (originalMessage == null || originalMessage.RecipientId != senderUser.Id)
		{
			return SendResult.UnauthorizedReply;
		}
		if (originalMessage.AuthorId != recipientUser.Id)
		{
			return SendResult.UnauthorizedReply;
		}
		string subject = "RE: " + originalMessage.Subject;
		string previousBody = null;
		if (includePreviousMessage)
		{
			previousBody = $"\n\n\n------------------------------\nOn {originalMessage.Created.ToShortDateString()} at {originalMessage.Created.ToShortTimeString()}, {GetUserByUserId(originalMessage.AuthorId).Name} wrote:\n{originalMessage.Body}";
		}
		return Send(body, subject, previousBody, senderUser, recipientUser, ipAddress);
	}

	/// <summary>
	/// Sends a message from one user to another.
	/// </summary>
	/// <param name="body">The body of the message.</param>
	/// <param name="subject">The subject of the message.</param>
	/// <param name="previousBody">The body of the message being replied to. Leave null if the previous body should not
	/// be included or this is not a reply.</param>
	/// <param name="senderUser">The user that is sending the message.</param>
	/// <param name="recipientUser">The user that will receive the message.</param>
	/// <param name="ipAddress">IP Address of the sender.</param>
	/// <returns>A SendResult indicating the result of the request.</returns>
	private SendResult Send(string body, string subject, string previousBody, IUser senderUser, IUser recipientUser, string ipAddress)
	{
		if (senderUser == null)
		{
			return SendResult.BadSender;
		}
		if (recipientUser == null)
		{
			return SendResult.BadRecipient;
		}
		IFloodChecker senderFloodChecker = GetSenderFloodChecker(senderUser, ipAddress);
		IFloodChecker recipientFloodChecker = GetRecipientFloodChecker(recipientUser, ipAddress);
		if (senderFloodChecker.IsFlooded())
		{
			return SendResult.SenderFlooded;
		}
		if (recipientFloodChecker.IsFlooded())
		{
			return SendResult.RecipientFlooded;
		}
		if (senderUser.Id == recipientUser.Id)
		{
			return SendResult.SentToSelf;
		}
		if (string.IsNullOrEmpty(body))
		{
			return SendResult.BodyIsBlank;
		}
		if (string.IsNullOrEmpty(subject))
		{
			return SendResult.SubjectIsBlank;
		}
		switch (_MessagePrivacyAuthority.CanSendMessage(senderUser, recipientUser))
		{
		case PrivacySettingsCheckResult.BadRecipient:
			return SendResult.BadRecipient;
		case PrivacySettingsCheckResult.BadSender:
			return SendResult.BadSender;
		case PrivacySettingsCheckResult.Login:
			return SendResult.Login;
		case PrivacySettingsCheckResult.RecipientPrivacySettingsTooHigh:
			return SendResult.RecipientPrivacySettingsTooHigh;
		case PrivacySettingsCheckResult.SenderPrivacySettingsTooHigh:
			return SendResult.SenderPrivacySettingsTooHigh;
		case PrivacySettingsCheckResult.SentToSelf:
			return SendResult.SentToSelf;
		default:
		{
			if (senderUser.Id != Roblox.Platform.Membership.Properties.Settings.Default.RobloxUserId && !UserHasVerifiedEmail(senderUser))
			{
				return SendResult.VerifySenderEmail;
			}
			Guid roomId = Guid.NewGuid();
			FilterLiveTextResult liveBodyTextResult = _TextFilterClientV2.FilterLiveText(body, senderUser.ToClientTextAuthor(), "PrivateMessage", TextFilterServerType.WebPm, roomId.ToString());
			string fullBody = ((senderUser.AgeBracket != 0 || recipientUser.AgeBracket != 0) ? liveBodyTextResult.FilteredResultUnderage.FilteredText : liveBodyTextResult.FilteredResult.FilteredText) + previousBody;
			if (fullBody.Length > BodyCharacterLimit)
			{
				return SendResult.BodyTooLong;
			}
			FilterLiveTextResult liveSubjectTextResult = _TextFilterClientV2.FilterLiveText(subject, senderUser.ToClientTextAuthor(), "PrivateMessage", TextFilterServerType.WebPm, roomId.ToString());
			string filteredSubjectText = ((senderUser.AgeBracket != 0 || recipientUser.AgeBracket != 0) ? liveSubjectTextResult.FilteredResultUnderage.FilteredText : liveSubjectTextResult.FilteredResult.FilteredText);
			string truncatedSubject = ((filteredSubjectText.Length > SubjectCharacterLimit) ? filteredSubjectText.Substring(0, SubjectCharacterLimit) : filteredSubjectText).Trim();
			senderFloodChecker.UpdateCount();
			recipientFloodChecker.UpdateCount();
			Message message = new Message
			{
				AuthorId = senderUser.Id,
				Body = fullBody,
				Created = DateTime.Now,
				IsArchived = false,
				IsBroadcastMessage = false,
				IsRead = false,
				IsSystemMessage = false,
				MessageTypeId = 1,
				RecipientId = recipientUser.Id,
				Subject = truncatedSubject,
				Updated = DateTime.Now
			};
			_MessageDataAccessor.Save(message);
			_MessageCounter.IncrementUnreadMessageCountUserCounter(recipientUser.Id);
			_MessageEventPublisher.Publish(MessageEventType.Created, message.Id, recipientUser.Id);
			return SendResult.Success;
		}
		}
	}
}
