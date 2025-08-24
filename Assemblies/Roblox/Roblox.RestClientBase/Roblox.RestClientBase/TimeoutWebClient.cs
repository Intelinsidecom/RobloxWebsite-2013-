using System;
using System.Net;

namespace Roblox.RestClientBase;

public class TimeoutWebClient : WebClient
{
	private TimeSpan _Timeout;

	public TimeoutWebClient(TimeSpan timeout)
	{
		_Timeout = timeout;
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest request = base.GetWebRequest(uri);
		if (request != null)
		{
			request.Timeout = (int)_Timeout.TotalMilliseconds;
		}
		return request;
	}
}
