using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Roblox.IpGeolocation.Client;

[GeneratedCode("NSwag", "13.1.6.0 (NJsonSchema v10.0.28.0 (Newtonsoft.Json v12.0.0.0))")]
public class SwaggerException : Exception
{
	public int StatusCode { get; private set; }

	public string Response { get; private set; }

	public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

	public SwaggerException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException)
		: base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, (response.Length >= 512) ? 512 : response.Length), innerException)
	{
		StatusCode = statusCode;
		Response = response;
		Headers = headers;
	}

	public override string ToString()
	{
		return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
	}
}
[GeneratedCode("NSwag", "13.1.6.0 (NJsonSchema v10.0.28.0 (Newtonsoft.Json v12.0.0.0))")]
public class SwaggerException<TResult> : SwaggerException
{
	public TResult Result { get; private set; }

	public SwaggerException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
		: base(message, statusCode, response, headers, innerException)
	{
		Result = result;
	}
}
