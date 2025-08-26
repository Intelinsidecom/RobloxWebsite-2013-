using System;
using System.Net;

namespace Roblox.Configuration.Client;

internal sealed class ExtendedWebClient : WebClient
{
	private static readonly TimeSpan _DefaultTimeout = TimeSpan.FromSeconds(20.0);

	private readonly TimeSpan _Timeout;

	public ExtendedWebClient(TimeSpan? timeout)
	{
		_Timeout = timeout ?? _DefaultTimeout;
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest webRequest = base.GetWebRequest(uri);
		if (webRequest != null)
		{
			TimeSpan timeout = _Timeout;
			webRequest.Timeout = (int)timeout.TotalMilliseconds;
		}
		return webRequest;
	}
}
