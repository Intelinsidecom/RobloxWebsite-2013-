using System;

namespace Roblox.ContentFilterApi.Client;

public interface IContentFilterClient
{
	Evaluation[] GetEvaluationSet(string text, byte[] categoryIds = null);
	Evaluation[] GetEvaluationSet(string text, ContentReviewType reviewType);
	double GetProbability(byte categoryId, string text);
	double GetGoodProbability(byte categoryId, string text);
	void LearnText(byte categoryId, string text, bool isBad);
}
