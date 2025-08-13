using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

public class DoNotShareWarning
{
	/// <summary>
	/// The delimiter string used to signify the end of a comment. Everything before the delimiter should be
	/// disregarded when processing the cookie value.
	/// </summary>
	public const string CommentEndDelimiter = "|_";

	/// <summary>
	/// The delimiter string used to signify the start of a comment. This delimiter MUST be the first part of the string.
	/// </summary>
	public const string CommentBeginDelimiter = "_|";

	/// <summary>
	/// Gets the Do Not Share prefix.
	/// </summary>
	public static string DoNotSharePrefix => Settings.Default.AuthCookieDoNotShareWarning;

	/// <summary>
	/// Adds the do not share message to the begining of a string.
	/// </summary>
	/// <param name="originalValue"></param>
	/// <returns></returns>
	public static string AddWarning(string originalValue)
	{
		return "_|" + DoNotSharePrefix + "|_" + originalValue;
	}

	/// <summary>
	/// Removes the unwanted user warning from the beginning of the value.
	/// </summary>
	/// <param name="value">The string with the warning.</param>
	/// <param name="wasChanged">Whether or not the string was changed.</param>
	/// <returns>The string resulting from removing the warning.</returns>
	public static string RemoveWarning(string value, out bool wasChanged)
	{
		wasChanged = false;
		if (value.StartsWith("_|"))
		{
			int indexOfPrefix = value.IndexOf("|_");
			if (indexOfPrefix != -1)
			{
				wasChanged = true;
				return value.Substring(indexOfPrefix + "|_".Length);
			}
		}
		return value;
	}
}
