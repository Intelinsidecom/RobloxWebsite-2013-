using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Roblox.EventLog;
using StackExchange.Redis;

namespace Roblox.Redis;

public class RedisListBufferConsumer
{
	private readonly IRedisListConfigurationBuffer _RedisConfigurationBuffer;

	private readonly Func<bool> _IsSenderEnabledGetter;

	private readonly ILogger _BackupLogger;

	private ConfigurationOptions _ConfigurationOptions;

	internal IConnectionMultiplexer Redis;

	public RedisListBufferConsumer(Func<bool> isSenderEnabledGetter, ILogger backupLogger, INotifyPropertyChanged settings, IRedisListConfigurationBuffer redisConfigurationBuffer)
	{
		_RedisConfigurationBuffer = redisConfigurationBuffer;
		_IsSenderEnabledGetter = isSenderEnabledGetter;
		_BackupLogger = backupLogger;
		settings.PropertyChanged += SettingsOnPropertyChanged;
		_ConfigurationOptions = _RedisConfigurationBuffer.GetConfigurationOptions();
		Redis = ConnectionMultiplexer.Connect(_ConfigurationOptions);
	}

	private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
		if (!_RedisConfigurationBuffer.NeedsReCreation(propertyChangedEventArgs.PropertyName))
		{
			return;
		}
		if (_IsSenderEnabledGetter())
		{
			_BackupLogger.Error("Changes to RedisListBufferSender while Sender is enabled are not possible. First disable Sender.");
			return;
		}
		try
		{
			Redis?.Dispose();
			_ConfigurationOptions = _RedisConfigurationBuffer.GetConfigurationOptions();
			Redis = ConnectionMultiplexer.Connect(_ConfigurationOptions);
			if (!Redis.IsConnected)
			{
				_BackupLogger.Error($"Redis was not able to connect after \"detecting\" a change to property: {propertyChangedEventArgs.PropertyName}");
			}
		}
		catch (Exception arg)
		{
			_BackupLogger.Error($"There was an exception while trying to change Redis Configuration at runtime: {arg}");
		}
	}

	public async Task SendAsync(string buffer)
	{
		if (!_IsSenderEnabledGetter())
		{
			return;
		}
		if (Redis == null || !Redis.IsConnected)
		{
			_BackupLogger.Error($"Redis Buffer Sender is disconnected, the following message was not sent: {buffer}");
			return;
		}
		try
		{
			await Redis.GetDatabase().ListLeftPushAsync(_RedisConfigurationBuffer.RedisListKey, buffer).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception arg)
		{
			_BackupLogger.Error($"Redis Buffer Sender failed to send message: {buffer}  -- Exception: {arg}");
		}
	}
}
