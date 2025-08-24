using System;
using Roblox.ContentFilterApi.Client;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public static class ContentFilterWrapper
{
	private static object _Sync = new object();

	private static ContentFilterClient _Client;

	public static ContentFilterClient Client
	{
		get
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			if (_Client != null)
			{
				return _Client;
			}
			lock (_Sync)
			{
				if (_Client != null)
				{
					return _Client;
				}
				_Client = new ContentFilterClient((Func<string>)ApiKeyGetter);
			}
			return _Client;
		}
	}

	private static string ApiKeyGetter()
	{
		return Settings.Default.WebSiteApiKey;
	}

	public static Evaluation[] GetEvaluationSet(string text, byte[] categoryIds = null)
	{
		return Client.GetEvaluationSet(text, categoryIds);
	}

	public static Evaluation[] GetEvaluationSet(string text, ContentReviewType reviewType)
	{
		if (reviewType == ContentReviewType.Username)
		{
			byte[] categoryIds = new byte[1] { ContentFilterClient.UsernameFilterCategoryId };
			return GetEvaluationSet(text, categoryIds);
		}
		return GetEvaluationSet(text);
	}

	public static double GetBadProbability(byte categoryId, string text)
	{
		return Client.GetProbability(categoryId, text);
	}

	public static double GetGoodProbability(byte categoryId, string text)
	{
		return Client.GetGoodProbability(categoryId, text);
	}

	public static void LearnText(byte categoryId, string text, bool isBad)
	{
		Client.LearnText(categoryId, text, isBad);
	}
}
