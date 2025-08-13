using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Roblox.ApiClientBase;

internal abstract class UrlBuilderBase
{
	protected abstract string BaseUrl { get; }

	protected abstract IEnumerable<KeyValuePair<string, object>> QueryStringParameters { get; }

	public override string ToString()
	{
		StringBuilder stringBuilder = null;
		if (QueryStringParameters != null)
		{
			bool flag = true;
			foreach (KeyValuePair<string, string> item in PrepareQueryStringParameters(QueryStringParameters))
			{
				if (flag)
				{
					stringBuilder = new StringBuilder("?");
					flag = false;
				}
				else
				{
					stringBuilder.Append("&");
				}
				stringBuilder.Append(item.Key);
				stringBuilder.Append('=');
				stringBuilder.Append(item.Value);
			}
		}
		if (stringBuilder == null)
		{
			return BaseUrl;
		}
		string text = stringBuilder.ToString();
		return BaseUrl + text;
	}

	private static IEnumerable<KeyValuePair<string, string>> PrepareQueryStringParameters(IEnumerable<KeyValuePair<string, object>> parameters)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		foreach (KeyValuePair<string, object> parameter in parameters)
		{
			object value = parameter.Value;
			string key = parameter.Key;
			IEnumerable enumerable = ((value is string) ? null : (value as IEnumerable));
			if (enumerable != null)
			{
				foreach (object? item in enumerable)
				{
					string value2 = ((item != null) ? HttpUtility.UrlEncode(item.ToString()) : string.Empty);
					list.Add(new KeyValuePair<string, string>(key, value2));
				}
			}
			else
			{
				string value3 = ((value != null) ? HttpUtility.UrlEncode(value.ToString()) : string.Empty);
				list.Add(new KeyValuePair<string, string>(key, value3));
			}
		}
		return list;
	}
}
