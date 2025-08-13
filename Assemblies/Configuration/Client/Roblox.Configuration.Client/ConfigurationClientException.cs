using System;

namespace Roblox.Configuration.Client;

public class ConfigurationClientException : Exception
{
	internal ConfigurationClientException(string errorMessage, Exception innerException)
		: base(errorMessage, innerException)
	{
	}
}
