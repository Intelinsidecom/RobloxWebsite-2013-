using System;

namespace Roblox.Http.Client;

public class HttpRequestBuilderSettings : IHttpRequestBuilderSettings
{
	public string Endpoint { get; set; }

	public bool EncodeQueryParametersEnabled { get; set; } = true;


	public HttpRequestBuilderSettings(string endpoint)
	{
		if (string.IsNullOrWhiteSpace(endpoint))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "endpoint");
		}
		Endpoint = endpoint;
	}
}
