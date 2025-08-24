using System;

namespace BeIT.MemCached;

public class MemcachedClientException : ApplicationException
{
	public MemcachedClientException(string host, string message)
		: base($"{message} for server {host}")
	{
	}

	public MemcachedClientException(string host, string message, Exception innerException)
		: base($"{message} for server {host}", innerException)
	{
	}
}
