using System;
using System.Collections.Generic;
using System.Threading;

namespace Roblox.Configuration;

internal class ConfigurationServiceFetcher
{
	private const int _PageSize = 50;

	private const int _BackoffBaseMilliseconds = 100;

	private readonly ConfigurationServiceProvider _ConfigurationClient;

	public ConfigurationServiceFetcher(ConfigurationServiceProvider configurationClient)
	{
		_ConfigurationClient = configurationClient;
	}

	public IReadOnlyCollection<T> FetchWithRetries<T>(Func<string, IReadOnlyCollection<T>> getterFunc, string groupName, int maxAttempts)
	{
		for (int i = 0; i < maxAttempts; i++)
		{
			try
			{
				return getterFunc(groupName);
			}
			catch (Exception ex)
			{
				Utilities.LogError(ex.ToString());
				Thread.Sleep(i * 100);
			}
		}
		return (IReadOnlyCollection<T>)(object)new T[0];
	}

	public IReadOnlyCollection<ISetting> GetAllSettings(string groupName)
	{
		int num = 0;
		List<ISetting> list = new List<ISetting>();
		IReadOnlyCollection<ISetting> settings;
		do
		{
			settings = _ConfigurationClient.GetSettings(groupName, 50, num);
			list.AddRange(settings);
			num++;
		}
		while (settings.Count >= 50);
		return list;
	}

	public IReadOnlyCollection<IConnectionString> GetAllConnectionStrings(string groupName)
	{
		int num = 0;
		List<IConnectionString> list = new List<IConnectionString>();
		IReadOnlyCollection<IConnectionString> connectionStrings;
		do
		{
			connectionStrings = _ConfigurationClient.GetConnectionStrings(groupName, 50, num);
			list.AddRange(connectionStrings);
			num++;
		}
		while (connectionStrings.Count >= 50);
		return list;
	}
}
