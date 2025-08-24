using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Membership.Properties;
using Roblox.Platform.Social.Events;
using Roblox.Platform.Social.Messages;
using Roblox.Platform.Social.Properties;

namespace Roblox.Platform.Social;

/// <inheritdoc cref="T:Roblox.Platform.Social.Messages.ISystemMessageSender" />
public class SystemMessageSender : ISystemMessageSender
{
	private readonly IMessageEventPublisher _MessageEventPublisher;

	private readonly IMessageDataAccessor _MessageDataAccessor;

	private readonly IMessageCounter _MessageCounter;

	private readonly Roblox.Platform.Social.Properties.ISettings _Settings;

	private readonly Roblox.Platform.Membership.Properties.ISettings _MembershipSettings;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Social.SystemMessageSender" /> class.
	/// </summary>
	/// <remarks>
	/// If <paramref name="messageDataAccessor" /> is left <c>null</c> a new one will be initialized.
	/// </remarks>
	/// <param name="messageEventPublisher">An <see cref="T:Roblox.Platform.Social.Events.IMessageEventPublisher" />.</param>
	/// <param name="messageDataAccessor">An <see cref="T:Roblox.Platform.Social.IMessageDataAccessor" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="messageEventPublisher" />
	/// </exception>
	public SystemMessageSender(IMessageEventPublisher messageEventPublisher, IMessageDataAccessor messageDataAccessor = null)
		: this(messageEventPublisher, messageDataAccessor ?? new MessageDataAccessor(), Roblox.Platform.Social.Properties.Settings.Default)
	{
	}

	internal SystemMessageSender(IMessageEventPublisher messageEventPublisher, IMessageDataAccessor messageDataAccessor, Roblox.Platform.Social.Properties.ISettings settings)
		: this(messageEventPublisher, messageDataAccessor, new MessageCounter(messageDataAccessor), settings, Roblox.Platform.Membership.Properties.Settings.Default)
	{
	}

	internal SystemMessageSender(IMessageEventPublisher messageEventPublisher, IMessageDataAccessor messageDataAccessor, IMessageCounter messageCounter, Roblox.Platform.Social.Properties.ISettings settings, Roblox.Platform.Membership.Properties.ISettings membershipSettings)
	{
		_MessageEventPublisher = messageEventPublisher ?? throw new ArgumentNullException("messageEventPublisher");
		_MessageDataAccessor = messageDataAccessor ?? throw new ArgumentNullException("messageDataAccessor");
		_MessageCounter = messageCounter ?? throw new ArgumentNullException("messageCounter");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_MembershipSettings = membershipSettings ?? throw new ArgumentNullException("membershipSettings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Social.Messages.ISystemMessageSender.Send(System.String,System.String,Roblox.Platform.Membership.IUser)" />
	public SendResult Send(string subject, string body, IUser recipientUser)
	{
		return Send(subject, body, recipientUser, SystemMessageSenderType.Roblox);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Social.Messages.ISystemMessageSender.Send(System.String,System.String,Roblox.Platform.Membership.IUser,Roblox.Platform.Social.Messages.SystemMessageSenderType)" />
	public SendResult Send(string subject, string body, IUser recipientUser, SystemMessageSenderType systemMessageSenderType)
	{
		if (recipientUser == null)
		{
			return SendResult.BadRecipient;
		}
		long authorId = GetAuthorId(systemMessageSenderType);
		if (recipientUser.Id == authorId)
		{
			return SendResult.SentToSelf;
		}
		if (string.IsNullOrEmpty(body))
		{
			return SendResult.BodyIsBlank;
		}
		body = body.Trim();
		if (body.Length > _Settings.MessageBodyCharacterLimit)
		{
			return SendResult.BodyTooLong;
		}
		if (string.IsNullOrEmpty(subject))
		{
			return SendResult.SubjectIsBlank;
		}
		subject = subject.Trim();
		subject = ((subject.Length > _Settings.MessageSubjectCharacterLimit) ? subject.Substring(0, _Settings.MessageSubjectCharacterLimit) : subject).Trim();
		Message message = new Message
		{
			AuthorId = authorId,
			Body = body,
			Created = DateTime.Now,
			IsArchived = false,
			IsBroadcastMessage = false,
			IsRead = false,
			IsSystemMessage = true,
			MessageTypeId = 1,
			RecipientId = recipientUser.Id,
			Subject = subject,
			Updated = DateTime.Now
		};
		_MessageDataAccessor.Save(message);
		_MessageCounter.IncrementUnreadMessageCountUserCounter(recipientUser.Id);
		_MessageEventPublisher.Publish(MessageEventType.Created, message.Id, recipientUser.Id);
		return SendResult.Success;
	}

	private long GetAuthorId(SystemMessageSenderType systemMessageSenderType)
	{
		if (systemMessageSenderType != 0 && systemMessageSenderType == SystemMessageSenderType.Builderman)
		{
			return _Settings.BuildermanUserId;
		}
		return _MembershipSettings.RobloxUserId;
	}
}
