namespace Roblox.Caching.Interfaces;

public interface ICacheInvalidator
{
	void RegisterEntity(string entityType);

	void RemoveRemoteKey(IRemoteCacheInvalidationSink cache, string key, string entityType);

	void RemoveRemoteKeyRaw(string topic, string key, string entityType);

	double GetMessagesReceivedPerSecond();
}
