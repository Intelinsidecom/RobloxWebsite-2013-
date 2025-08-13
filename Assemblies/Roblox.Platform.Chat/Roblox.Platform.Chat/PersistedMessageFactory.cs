using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class PersistedMessageFactory : PersistedMessageDataAccessor, IPersistedMessageFactory
{
	private readonly string _ChatMessagesTableName = RobloxEnvironment.Abbreviation + "_ChatMessages";

	private readonly IAmazonDynamoDB _DynamoDbClient;

	private readonly IDynamoDBContext _DynamoDBContext;

	internal virtual bool IsDynamoDbContextQueryEnabled => Settings.Default.IsDynamoDbContextQueryEnabled;

	public PersistedMessageFactory(IAmazonDynamoDB dynamoDbClient, ILogger logger)
		: base(logger)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		_DynamoDbClient = dynamoDbClient ?? throw new PlatformArgumentNullException("dynamoDbClient");
		try
		{
			_DynamoDBContext = (IDynamoDBContext)new DynamoDBContext(dynamoDbClient);
		}
		catch (Exception ex)
		{
			logger?.Error(ex);
		}
	}

	public Guid? GetLatestMessageIdInConversation(long conversationId)
	{
		if (!Settings.Default.MessagePersistenceEnabled)
		{
			return null;
		}
		IReadOnlyCollection<Guid> messageIds = GetMessageIdsFromConversation(conversationId, 1);
		if (messageIds.Count <= 0)
		{
			return null;
		}
		return messageIds.ElementAt(0);
	}

	public Guid? GetOldestMessageIdInConversation(long conversationId)
	{
		if (!Settings.Default.MessagePersistenceEnabled)
		{
			return null;
		}
		IReadOnlyCollection<Guid> messageIds = GetMessageIdsFromConversation(conversationId, 1, null, null, sortByTimestampAsc: true);
		if (messageIds.Count <= 0)
		{
			return null;
		}
		return messageIds.ElementAt(0);
	}

	public IReadOnlyCollection<Guid> GetMessageIds(long conversationId, int pageSize, Guid? exclusiveStartKeyId = null, long? exclusiveStartKeyTimestampTicks = null)
	{
		if (!Settings.Default.MessagePersistenceEnabled)
		{
			return new List<Guid>();
		}
		return GetMessageIdsFromConversation(conversationId, pageSize, exclusiveStartKeyId, exclusiveStartKeyTimestampTicks);
	}

	public IReadOnlyCollection<IChatMessageEntity> GetChatMessages(IReadOnlyCollection<Guid> messageIds)
	{
		if (!Settings.Default.MessagePersistenceEnabled)
		{
			return new List<IChatMessageEntity>();
		}
		if (IsDynamoDbContextQueryEnabled)
		{
			return GetChatMessagesFromIdsViaDynamoDbContext(messageIds);
		}
		return GetChatMessagesFromIds(messageIds);
	}

	public IChatMessageEntity GetChatMessage(Guid messageId)
	{
		if (!Settings.Default.MessagePersistenceEnabled)
		{
			return null;
		}
		List<Guid> messageIds = new List<Guid> { messageId };
		IReadOnlyCollection<IChatMessageEntity> messages = (IsDynamoDbContextQueryEnabled ? GetChatMessagesFromIdsViaDynamoDbContext(messageIds) : GetChatMessagesFromIds(messageIds));
		if (messages.Count != 0)
		{
			return messages.First();
		}
		return null;
	}

	private IReadOnlyCollection<Guid> GetMessageIdsFromConversation(long conversationId, int pageSize, Guid? exclusiveStartKeyId = null, long? exclusiveStartKeyTimestampTicks = null, bool sortByTimestampAsc = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fe: Expected O, but got Unknown
		List<Guid> messageIds = new List<Guid>(pageSize);
		AttributeValue hashAttribute = new AttributeValue
		{
			N = conversationId.ToString()
		};
		QueryRequest readRequest = new QueryRequest
		{
			TableName = _ChatMessagesTableName,
			IndexName = "IX_ConversationIdSortOrder",
			Select = Select.op_Implicit("SPECIFIC_ATTRIBUTES"),
			AttributesToGet = new List<string> { "Id" },
			ScanIndexForward = sortByTimestampAsc,
			Limit = pageSize
		};
		Dictionary<string, Condition> conditions = new Dictionary<string, Condition> { 
		{
			"ConversationId",
			new Condition
			{
				ComparisonOperator = ComparisonOperator.op_Implicit("EQ"),
				AttributeValueList = { hashAttribute }
			}
		} };
		if (exclusiveStartKeyId.HasValue && exclusiveStartKeyTimestampTicks.HasValue)
		{
			string sortOrder = GetSortOrder(exclusiveStartKeyTimestampTicks.Value, exclusiveStartKeyId.Value);
			conditions.Add("SortOrder", new Condition
			{
				ComparisonOperator = ComparisonOperator.op_Implicit("LT"),
				AttributeValueList = 
				{
					new AttributeValue
					{
						S = sortOrder
					}
				}
			});
		}
		readRequest.KeyConditions = conditions;
		List<Dictionary<string, AttributeValue>> items = _DynamoDbClient.Query(readRequest).Items;
		if (items == null || items.Count == 0)
		{
			return new List<Guid>();
		}
		foreach (Dictionary<string, AttributeValue> item in items)
		{
			Guid.TryParse(item["Id"].S, out var messageId);
			messageIds.Add(messageId);
		}
		return messageIds;
	}

	private IReadOnlyCollection<IChatMessageEntity> GetChatMessagesFromIds(IReadOnlyCollection<Guid> messageIds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		BatchGetItemRequest batchGetItemRequest = new BatchGetItemRequest
		{
			RequestItems = new Dictionary<string, KeysAndAttributes> { 
			{
				_ChatMessagesTableName,
				new KeysAndAttributes
				{
					Keys = messageIds.Select((Guid messageId) => new Dictionary<string, AttributeValue> { 
					{
						"Id",
						new AttributeValue
						{
							S = messageId.ToString()
						}
					} }).ToList()
				}
			} },
			ReturnConsumedCapacity = ReturnConsumedCapacity.op_Implicit("TOTAL")
		};
		List<Dictionary<string, AttributeValue>> responses = _DynamoDbClient.BatchGetItem(batchGetItemRequest).Responses[_ChatMessagesTableName];
		return GetChatMessageFromDictionary(responses);
	}

	private IReadOnlyCollection<IChatMessageEntity> GetChatMessagesFromIdsViaDynamoDbContext(IReadOnlyCollection<Guid> messageIds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0085: Expected O, but got Unknown
		try
		{
			DynamoDBOperationConfig config = new DynamoDBOperationConfig
			{
				OverrideTableName = _ChatMessagesTableName
			};
			BatchGet<PersistentChatEventMessage> batches = _DynamoDBContext.CreateBatchGet<PersistentChatEventMessage>(config);
			if (batches == null)
			{
				throw new PlatformArgumentNullException("batches");
			}
			foreach (Guid messageId in messageIds)
			{
				batches.AddKey((object)messageId);
			}
			((BatchGet)batches).Execute();
			return batches.Results.Select(base.Translate).ToList();
		}
		catch (AmazonDynamoDBException val)
		{
			AmazonDynamoDBException ex = val;
			throw new MessagePersistenceException("Failed to get chat messages from DynamoDB.", (Exception)(object)ex);
		}
		catch (PlatformException)
		{
			throw;
		}
	}
}
