namespace Roblox.Caching.Interfaces;

public interface IRawMessageConsumer
{
	void ReadMessage(string topic, string key);
}
