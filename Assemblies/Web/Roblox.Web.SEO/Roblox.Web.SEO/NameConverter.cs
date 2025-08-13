using System.Text;

namespace Roblox.Web.SEO;

public static class NameConverter
{
	private const int _AsciiMax = 127;

	/// <summary>
	///             Converts Name into an SEO friendly string.  Concatenates substrings of alphanumeric
	///             characters via dashes.  Custom algorithm for speed.
	///             </summary>
	public static string ConvertToSEO(string input)
	{
		StringBuilder sb = new StringBuilder(input.Length);
		for (int i = 0; i < input.Length; i++)
		{
			if (!char.IsLetterOrDigit(input[i]) || input[i] >= '\u007f')
			{
				continue;
			}
			int start = i;
			for (; i < input.Length; i++)
			{
				if (input[i] == '\'')
				{
					sb.Append(input.Substring(start, i - start));
					start = i + 1;
				}
				else if (!char.IsLetterOrDigit(input[i]) || input[i] > '\u007f')
				{
					break;
				}
			}
			sb.Append(input.Substring(start, i - start));
			sb.Append("-");
		}
		if (sb.Length == 0)
		{
			return "unnamed";
		}
		sb.Length--;
		return sb.ToString();
	}
}
