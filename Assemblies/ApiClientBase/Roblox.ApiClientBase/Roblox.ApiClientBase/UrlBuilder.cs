using System;
using System.Collections.Generic;

namespace Roblox.ApiClientBase;

internal class UrlBuilder : UrlBuilderBase
{
	private readonly Func<IEnumerable<KeyValuePair<string, object>>> _QueryStringParametersGetter;

	protected override string BaseUrl { get; }

	protected override IEnumerable<KeyValuePair<string, object>> QueryStringParameters => _QueryStringParametersGetter();

	public UrlBuilder(string baseUrl, Func<IEnumerable<KeyValuePair<string, object>>> queryStringParametersGetter)
	{
		BaseUrl = baseUrl;
		_QueryStringParametersGetter = queryStringParametersGetter;
	}
}
