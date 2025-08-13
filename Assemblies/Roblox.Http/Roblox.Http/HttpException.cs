using System;

namespace Roblox.Http;

public class HttpException : Exception
{
	public HttpException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
