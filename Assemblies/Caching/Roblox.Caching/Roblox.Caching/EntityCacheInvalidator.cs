using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Interfaces;

namespace Roblox.Caching;

public static class EntityCacheInvalidator
{
	private static readonly object _AddListenerLock = new object();

	private static readonly ICacheInvalidator _GlobalInvalidator = CacheInvalidatorFactory.CreateCacheInvalidator(GetCacheInvalidationListeners);

	private static IRemoteCacheInvalidationSink[] _ListenerArray = new IRemoteCacheInvalidationSink[0];

	public static void AddReplicationPort(string entityType)
	{
		_GlobalInvalidator.RegisterEntity(entityType);
	}

	public static void RemoveRemoteKey(IRemoteCacheInvalidationSink sink, string entityType, string key)
	{
		_GlobalInvalidator.RemoveRemoteKey(sink, key, entityType);
	}

	public static void AddListener(IRemoteCacheInvalidationSink sink)
	{
		lock (_AddListenerLock)
		{
			_ListenerArray = new HashSet<IRemoteCacheInvalidationSink>(_ListenerArray) { sink }.ToArray();
		}
	}

	public static double GetMessagesReceivedPerSecond()
	{
		return _GlobalInvalidator.GetMessagesReceivedPerSecond();
	}

	private static IEnumerable<IRemoteCacheInvalidationSink> GetCacheInvalidationListeners()
	{
		return _ListenerArray;
	}
}
