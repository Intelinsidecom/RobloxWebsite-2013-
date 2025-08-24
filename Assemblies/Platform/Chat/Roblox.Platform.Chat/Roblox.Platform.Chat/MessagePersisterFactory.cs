using Amazon.DynamoDBv2;
using Roblox.EventLog;

namespace Roblox.Platform.Chat;

public class MessagePersisterFactory
{
	public static IMessagePersister GetMessagePersister(IAmazonDynamoDB amazonDynamoDb, ILogger logger)
	{
		return new MessagePersister(amazonDynamoDb, logger);
	}
}
