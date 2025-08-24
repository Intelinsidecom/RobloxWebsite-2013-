using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Roblox.Platform.Moderation.Interfaces;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

public class RegularExpressionValidator : IRegularExpressionValidator
{
	private readonly IEnumerable<string> _WhitelistWords;

	private readonly int _PerformanceThresholdInMillisecond;

	private const string _InvalidRegularExpression = "The regular expression is not valid";

	private const string _MatchWordsInWhitelist = "The regular expression matches at least one word in whitelist";

	private const string _BadPerformance = "The regular expression takes too long to evaluate texts";

	public RegularExpressionValidator(IWhitelist whitelist, int performanceThresholdInMs)
	{
		_WhitelistWords = whitelist.GetAllTerms();
		_PerformanceThresholdInMillisecond = performanceThresholdInMs;
	}

	public RegularExpressionValidator(IWhitelist whitelist)
		: this(whitelist, Settings.Default.RegularExpressionPerformanceThresholdInMillisecond)
	{
	}

	public bool IsValidBlacklistRegularExpression(string regularExpression, out string message, out IEnumerable<string> matchedWords)
	{
		message = string.Empty;
		matchedWords = new List<string>();
		bool isValid = true;
		try
		{
			Regex regex = new Regex(regularExpression, RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Stopwatch watch = Stopwatch.StartNew();
			foreach (string word in _WhitelistWords)
			{
				if (regex.Match(word).Success)
				{
					isValid = false;
					((List<string>)matchedWords).Add(word);
					message = "The regular expression matches at least one word in whitelist";
				}
			}
			watch.Stop();
			if (watch.ElapsedMilliseconds >= _PerformanceThresholdInMillisecond)
			{
				message = "The regular expression takes too long to evaluate texts";
				return false;
			}
			return isValid;
		}
		catch (Exception)
		{
			message = "The regular expression is not valid";
			return false;
		}
	}
}
