using System;
using Amazon;
using Amazon.DynamoDBv2;
using Roblox.Amazon.DynamoDb;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat;

public class ChatDynamoDbClientProvider
{
	private const string _ClientInstanceName = "PlatformChat";

	private static object _Sync = new object();

	private static string _AccessKey = string.Empty;

	private static string _SecretKey = string.Empty;

	private static IAmazonDynamoDB _DynamoDbClient;

	public static IAmazonDynamoDB GetDynamoDbClient(ILogger errorLogger)
	{
		if (_DynamoDbClient != null)
		{
			return _DynamoDbClient;
		}
		try
		{
			string chatDynamoDbAccessKeyAndSecret = Settings.Default.ChatDynamoDbAccessKeyAndSecret;
			if (string.IsNullOrEmpty(chatDynamoDbAccessKeyAndSecret))
			{
				return null;
			}
			string[] awsAccessKeyAndSecretKey = chatDynamoDbAccessKeyAndSecret.Split(',');
			if (awsAccessKeyAndSecretKey.Length != 2)
			{
				return null;
			}
			if (!_AccessKey.Equals(awsAccessKeyAndSecretKey[0]) || !_SecretKey.Equals(awsAccessKeyAndSecretKey[1]))
			{
				lock (_Sync)
				{
					if (!_AccessKey.Equals(awsAccessKeyAndSecretKey[0]) || !_SecretKey.Equals(awsAccessKeyAndSecretKey[1]))
					{
						IRobloxDynamoDbClientFactory instance = RobloxDynamoDbClientFactory.Instance;
						_AccessKey = awsAccessKeyAndSecretKey[0];
						_SecretKey = awsAccessKeyAndSecretKey[1];
						_DynamoDbClient = instance.Create(_AccessKey, _SecretKey, RegionEndpoint.USEast1, "PlatformChat");
					}
				}
			}
		}
		catch (Exception ex)
		{
			errorLogger?.Error(ex);
		}
		return _DynamoDbClient;
	}
}
