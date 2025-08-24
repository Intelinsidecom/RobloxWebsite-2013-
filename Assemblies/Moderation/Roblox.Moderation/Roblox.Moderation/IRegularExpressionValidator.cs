using System.Collections.Generic;

namespace Roblox.Platform.Moderation;

/// <summary>
/// Provides a common interface for a regular expression validator.
/// </summary>
public interface IRegularExpressionValidator
{
	/// <summary>
	/// Check if an expression is a valid regular expression for blacklist, which means it shouldn't match words in white list.
	/// Also check if the performance of the regular expression is within threshold
	/// </summary>
	/// <param name="regularExpression">The regular expression to be checked</param>
	/// <param name="message">error message</param>
	/// <param name="matchedWords">matched words in white list</param>
	/// <returns>True if it's a valid regular expression for blacklist, otherwise false</returns>
	bool IsValidBlacklistRegularExpression(string regularExpression, out string message, out IEnumerable<string> matchedWords);
}
