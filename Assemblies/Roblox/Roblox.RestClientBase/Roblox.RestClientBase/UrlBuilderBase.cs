using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Roblox.RestClientBase;

internal abstract class UrlBuilderBase
{
	protected abstract string BaseUrl { get; }

	protected abstract IEnumerable<KeyValuePair<string, object>> QueryStringParameters { get; }

	public override string ToString()
	{
		StringBuilder queryStringBuilder = null;
		if (QueryStringParameters != null)
		{
			bool isFirstIteration = true;
			foreach (KeyValuePair<string, string> queryStringParameter in PrepareQueryStringParameters(QueryStringParameters))
			{
				if (isFirstIteration)
				{
					queryStringBuilder = new StringBuilder("?");
					isFirstIteration = false;
				}
				else
				{
					queryStringBuilder.Append("&");
				}
				queryStringBuilder.Append(queryStringParameter.Key);
				queryStringBuilder.Append('=');
				queryStringBuilder.Append(queryStringParameter.Value);
			}
		}
		if (queryStringBuilder == null)
		{
			return BaseUrl;
		}
		string queryString = queryStringBuilder.ToString();
		return BaseUrl + queryString;
	}

	private static IEnumerable<KeyValuePair<string, string>> PrepareQueryStringParameters(IEnumerable<KeyValuePair<string, object>> parameters)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		foreach (KeyValuePair<string, object> kvp in parameters)
		{
			object parameterValue = kvp.Value;
			string parameterKey = kvp.Key;
			IEnumerable enumerableValue = ((parameterValue is string) ? null : (parameterValue as IEnumerable));
			if (enumerableValue != null)
			{
				foreach (object rawValue in enumerableValue)
				{
					string encodedValue2 = ((rawValue != null) ? HttpUtility.UrlEncode(rawValue.ToString()) : string.Empty);
					list.Add(new KeyValuePair<string, string>(parameterKey, encodedValue2));
				}
			}
			else
			{
				string encodedValue = ((parameterValue != null) ? HttpUtility.UrlEncode(parameterValue.ToString()) : string.Empty);
				list.Add(new KeyValuePair<string, string>(parameterKey, encodedValue));
			}
		}
		return list;
	}
}
