using System;
using System.Linq;
using Roblox.ContentFilterApi.Client;
using Roblox.TextFilter.Properties;

namespace Roblox.TextFilter;

internal class UsernameFilter : IUsernameFilter
{
	/// <summary>
	/// Settings for the library.
	/// </summary>
	private readonly ITextFilterSettings _Settings;

	/// <summary>
	/// Client to communicate with Roblox's ContentFilter service
	/// </summary>
	private readonly IContentFilterClient _ContentFilterClient;

	internal readonly byte[] GeneralCategoryIds = new byte[10] { 2, 3, 4, 5, 6, 7, 8, 9, 20, 50 };

	internal readonly byte[] U13CategoryIds = new byte[14]
	{
		2, 3, 4, 5, 6, 7, 8, 9, 20, 50,
		51, 52, 53, 54
	};

	public readonly byte[] PiiCategoryIds = new byte[4] { 51, 52, 53, 54 };

	public UsernameFilter(ITextFilterSettings settings, IContentFilterClient contentFilterClient)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ContentFilterClient = contentFilterClient ?? throw new ArgumentNullException("contentFilterClient");
	}

	public IUsernameValidationResult Evaluate13OUsername(string username)
	{
		Evaluation[] evaluationSet = _ContentFilterClient.GetEvaluationSet(username, GeneralCategoryIds);
		UsernameValidationResult result = new UsernameValidationResult
		{
			IsValid = true,
			IsPotentialPiiViolation = false
		};
		if (evaluationSet.Any((Evaluation e) => e.Probability >= _Settings.UsernameGeneralProbabilityThreshold))
		{
			result.IsValid = false;
		}
		return result;
	}

	public IUsernameValidationResult EvaluateU13Username(string username)
	{
		Evaluation[] evaluationSet = _ContentFilterClient.GetEvaluationSet(username, U13CategoryIds);
		UsernameValidationResult result = new UsernameValidationResult
		{
			IsValid = true,
			IsPotentialPiiViolation = false
		};
		Evaluation[] array = evaluationSet;
		foreach (Evaluation evaluation in array)
		{
			if (PiiCategoryIds.Contains(evaluation.CategoryID))
			{
				if (evaluation.Probability >= _Settings.UsernamePiiProbabilityThreshold)
				{
					result.IsValid = false;
					result.IsPotentialPiiViolation = true;
					return result;
				}
			}
			else if (evaluation.Probability >= _Settings.UsernameGeneralProbabilityThreshold)
			{
				result.IsValid = false;
			}
		}
		return result;
	}
}
