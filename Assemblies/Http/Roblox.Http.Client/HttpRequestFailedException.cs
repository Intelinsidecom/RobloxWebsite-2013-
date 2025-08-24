using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roblox.Http.Client;

public class HttpRequestFailedException : Exception
{
	private const string _ReplacementQueryValue = "$1=********";

	private static readonly string[] _SensitiveQueryParameterNames;

	private static readonly IDictionary<string, Regex> _SensitiveQueryParameterRegexes;

	public IHttpResponse Response { get; }

	public HttpRequestFailedException(IHttpResponse response, string message = null)
		: base(message ?? BuildExceptionMessage(response))
	{
		Response = response ?? throw new ArgumentNullException("response");
	}

	public HttpRequestFailedException(Exception innerException)
		: base("An exception was thrown when attempting to send the request.", innerException)
	{
	}

	static HttpRequestFailedException()
	{
		_SensitiveQueryParameterNames = new string[3] { "apikey", "accesskey", "password" };
		_SensitiveQueryParameterRegexes = _SensitiveQueryParameterNames.ToDictionary((string q) => q, (string q) => new Regex($"({q})=[^&]+", RegexOptions.IgnoreCase));
	}

	protected static string BuildExceptionMessage(IHttpResponse response)
	{
		return "An error has occurred with your request." + $"\n\tStatus code: {response?.StatusCode} ({response?.StatusText})" + $"\n\tUrl: {GetUrlForDisplay(response?.Url)}";
	}

	private static string GetUrlForDisplay(Uri url)
	{
		string text = url?.ToString();
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		if (_SensitiveQueryParameterNames.Any(text.ToLower().Contains))
		{
			foreach (KeyValuePair<string, Regex> sensitiveQueryParameterRegex in _SensitiveQueryParameterRegexes)
			{
				text = sensitiveQueryParameterRegex.Value.Replace(text, "$1=********");
			}
		}
		return text;
	}
}
