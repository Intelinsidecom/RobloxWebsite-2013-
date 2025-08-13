using System;
using System.Collections;
using Roblox.Caching.Interfaces;

namespace Roblox.Caching.DotNet;

public class RequestCache : IRequestCache
{
	private readonly Func<IDictionary> _RequestContextDictionaryGetter;

	private IDictionary CurrentContextDictionary => _RequestContextDictionaryGetter();

	public RequestCache(Func<IDictionary> requestContextDictionaryGetter)
	{
		_RequestContextDictionaryGetter = requestContextDictionaryGetter;
	}

	public bool Get<T>(string key, out T value)
	{
		value = default(T);
		if (CurrentContextDictionary == null)
		{
			return false;
		}
		if (CurrentContextDictionary.Contains(key))
		{
			value = (T)CurrentContextDictionary[key];
			return true;
		}
		return false;
	}

	public T Get<T>(string key, Func<T> getter)
	{
		if (Get<T>(key, out var value))
		{
			return value;
		}
		value = getter();
		Set(key, value);
		return value;
	}

	public void Remove(string key)
	{
		if (CurrentContextDictionary != null)
		{
			CurrentContextDictionary.Remove(key);
		}
	}

	public void Set<T>(string key, T value)
	{
		if (CurrentContextDictionary != null)
		{
			CurrentContextDictionary[key] = value;
		}
	}
}
