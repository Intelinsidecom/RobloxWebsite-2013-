using System;
using System.Collections.Generic;

namespace Roblox.RestClientBase;

internal class UrlBuilder : UrlBuilderBase
{
	private readonly string _BaseUrl;

	private readonly Func<IEnumerable<KeyValuePair<string, object>>> _QueryStringParametersGetter;

	protected override string BaseUrl => _BaseUrl;

	protected override IEnumerable<KeyValuePair<string, object>> QueryStringParameters => _QueryStringParametersGetter();

	public UrlBuilder(string baseUrl, Func<IEnumerable<KeyValuePair<string, object>>> queryStringParametersGetter)
	{
		_BaseUrl = baseUrl;
		_QueryStringParametersGetter = queryStringParametersGetter;
	}
}
