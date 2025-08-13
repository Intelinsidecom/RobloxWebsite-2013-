using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat;

internal class MessagePersister : PersistedMessageDataAccessor, IMessagePersister
{
	private readonly string _ChatMessagesTableName = RobloxEnvironment.Abbreviation + "_ChatMessages";

	protected const string _SenderPlatformTypeKey = "SenderPlatformType";

	private readonly IAmazonDynamoDB _DynamoDbClient;

	private readonly ILogger _Logger;

	private bool IsSenderPlatformTypePersistenceEnabled => Settings.Default.IsSenderPlatformTypePersistenceEnabled;

	public MessagePersister(IAmazonDynamoDB dynamoDbClient, ILogger logger)
		: base(logger)
	{
		_DynamoDbClient = dynamoDbClient ?? throw new PlatformArgumentNullException("dynamoDbClient");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public void Persist(long conversationId, ChatEventMessage chatEventMessage, PlatformType? senderPlatformType)
	{
		if (Settings.Default.MessagePersistenceEnabled)
		{
			PersistMessageToDynamo(conversationId, chatEventMessage, senderPlatformType);
		}
	}

	private void PersistMessageToDynamo(long conversationId, ChatEventMessage chatEventMessage, PlatformType? senderPlatformType)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c8: Expected O, but got Unknown
		Dictionary<string, AttributeValue> tableAttributes = GetChatMessageAttributes(conversationId, chatEventMessage);
		if (tableAttributes == null)
		{
			_Logger.Error($"Cannot persist message of type: {chatEventMessage.MessageType}");
			return;
		}
		if (IsSenderPlatformTypePersistenceEnabled)
		{
			AttributeValue senderPlatformTypeAttributeValue = ((!senderPlatformType.HasValue) ? new AttributeValue
			{
				NULL = true
			} : new AttributeValue
			{
				S = senderPlatformType.ToString()
			});
			tableAttributes["SenderPlatformType"] = senderPlatformTypeAttributeValue;
		}
		PutItemRequest chatMessagePersistenceRequest = new PutItemRequest
		{
			TableName = _ChatMessagesTableName,
			Item = tableAttributes,
			Expected = new Dictionary<string, ExpectedAttributeValue>
			{
				{
					"ConversationId",
					new ExpectedAttributeValue
					{
						Exists = false
					}
				},
				{
					"Id",
					new ExpectedAttributeValue
					{
						Exists = false
					}
				}
			}
		};
		try
		{
			_DynamoDbClient.PutItem(chatMessagePersistenceRequest);
		}
		catch (ConditionalCheckFailedException)
		{
		}
	}
}
