namespace Roblox.Caching.Interfaces;

public interface IRemoteCacheInvalidationSink
{
	string NodeId { get; }

	string Topic { get; }

	string TopicNamespace { get; }

	void OnRemoteRemove(string key);
}
