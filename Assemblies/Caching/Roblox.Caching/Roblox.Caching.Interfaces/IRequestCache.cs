using System;

namespace Roblox.Caching.Interfaces;

public interface IRequestCache
{
	bool Get<T>(string key, out T value);

	T Get<T>(string key, Func<T> getter);

	void Remove(string key);

	void Set<T>(string key, T value);
}
