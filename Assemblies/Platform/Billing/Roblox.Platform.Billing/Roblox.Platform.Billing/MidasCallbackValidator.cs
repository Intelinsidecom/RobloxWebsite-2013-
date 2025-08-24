using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Roblox.Platform.Billing.Properties;

namespace Roblox.Platform.Billing;

public class MidasCallbackValidator : IMidasCallbackValidator
{
	private readonly string _SigKey = "sig";

	private string _MidasAdditionalEncodeCharacters => Settings.Default.MidasAdditionalEncodeCharacters;

	private string _MidasEncodeExemptedCharacters => Settings.Default.MidasEncodeExemptedCharacters;

	public bool VerifyCallbackRequest(IDictionary<string, string> query, string url, string midasAppkey)
	{
		SortedDictionary<string, string> sortedMap = GetSortedMapForQuery(query);
		if (!sortedMap.ContainsKey(_SigKey))
		{
			return false;
		}
		string targetSig = sortedMap[_SigKey];
		sortedMap.Remove(_SigKey);
		return SignSourceStringWithAppKey(ConstructSourceString(EncodeString(url), sortedMap), midasAppkey).Equals(targetSig);
	}

	private static SortedDictionary<string, string> GetSortedMapForQuery(IDictionary<string, string> query)
	{
		return new SortedDictionary<string, string>(query);
	}

	private string ConstructSourceString(string encodedUri, SortedDictionary<string, string> sortedParams)
	{
		string encodeValues = "";
		foreach (string key in sortedParams.Keys)
		{
			if (sortedParams.ContainsKey(key) && sortedParams[key] != null)
			{
				if (!string.IsNullOrEmpty(encodeValues))
				{
					encodeValues += "&";
				}
				encodeValues = encodeValues + key + "=" + MidasEncoding(sortedParams[key]);
			}
		}
		string encodeParams = EncodeString(encodeValues);
		return "GET&" + encodedUri + "&" + encodeParams;
	}

	private static string SignSourceStringWithAppKey(string sourceString, string midasAppkey)
	{
		string sigKey = midasAppkey + "&";
		HMACSHA1 hMACSHA = new HMACSHA1(Encoding.UTF8.GetBytes(sigKey));
		byte[] dataBytes = Encoding.UTF8.GetBytes(sourceString);
		return Convert.ToBase64String(hMACSHA.ComputeHash(dataBytes));
	}

	private static string EncodeString(string sEncode)
	{
		return Uri.EscapeDataString(sEncode);
	}

	private string MidasEncoding(string sDotUnderscoreHyphen)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < sDotUnderscoreHyphen.Length; i++)
		{
			string current = sDotUnderscoreHyphen[i].ToString();
			if (_MidasAdditionalEncodeCharacters.Contains(current))
			{
				sb.Append(current.Replace("-", "%2D").Replace(".", "%2E").Replace("_", "%5F"));
			}
			else if (_MidasEncodeExemptedCharacters.Contains(current.ToString()))
			{
				sb.Append(current);
			}
			else
			{
				sb.Append(EncodeString(current));
			}
		}
		return sb.ToString();
	}
}
