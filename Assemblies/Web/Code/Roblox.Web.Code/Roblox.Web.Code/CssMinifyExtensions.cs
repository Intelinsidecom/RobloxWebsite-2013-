using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Roblox.Web.Code;

/// <summary>
/// Copyright (c) 2008, Yahoo! Inc.
/// All rights reserved.
/// </summary>
public static class CssMinifyExtensions
{
	public static int AppendReplacement(this Match match, StringBuilder sb, string input, string replacement, int index)
	{
		string preceding = input.Substring(index, match.Index - index);
		sb.Append(preceding);
		sb.Append(replacement);
		return match.Index + match.Length;
	}

	public static void AppendTail(this Match match, StringBuilder sb, string input, int index)
	{
		sb.Append(input.Substring(index));
	}

	public static uint ToUInt32(this ValueType instance)
	{
		return Convert.ToUInt32(instance);
	}

	public static string RegexReplace(this string input, string pattern, string replacement)
	{
		return Regex.Replace(input, pattern, replacement);
	}

	public static string RegexReplace(this string input, string pattern, string replacement, RegexOptions options)
	{
		return Regex.Replace(input, pattern, replacement, options);
	}

	public static string Fill(this string format, params object[] args)
	{
		return string.Format(format, args);
	}

	public static string RemoveRange(this string input, int startIndex, int endIndex)
	{
		return input.Remove(startIndex, endIndex - startIndex);
	}

	public static bool EqualsIgnoreCase(this string left, string right)
	{
		return string.Compare(left, right, ignoreCase: true) == 0;
	}

	public static string ToHexString(this int value)
	{
		StringBuilder sb = new StringBuilder();
		string text = value.ToString();
		foreach (char digit in text)
		{
			sb.Append("{0:x2}".Fill(digit.ToUInt32()));
		}
		return sb.ToString();
	}

	/// <summary>
	/// Minifies CSS.
	/// </summary>
	/// <param name="css">The CSS content to minify.</param>
	/// <returns>Minified CSS content.</returns>
	public static string CssMinify(string css)
	{
		return css.CssMinify(0);
	}

	/// <summary>
	/// Minifies CSS with a column width maximum.
	/// </summary>
	/// <param name="css">The CSS content to minify.</param>
	/// <param name="columnWidth">The maximum column width.</param>
	/// <returns>Minified CSS content.</returns>
	public static string CssMinify(this string css, int columnWidth)
	{
		css = css.RemoveCommentBlocks();
		css = css.RegexReplace("\\s+", " ");
		css = css.RegexReplace("\"\\\\\"}\\\\\"\"", "___PSEUDOCLASSBMH___");
		css = css.RemovePrecedingSpaces();
		css = css.RegexReplace("([!{}:;>+\\(\\[,])\\s+", "$1");
		css = css.RegexReplace("([^;\\}])}", "$1;}");
		css = css.RegexReplace("([\\s:])(0)(px|em|%|in|cm|mm|pc|pt|ex)", "$1$2");
		css = css.RegexReplace(":0 0 0 0;", ":0;");
		css = css.RegexReplace(":0 0 0;", ":0;");
		css = css.RegexReplace(":0 0;", ":0;");
		css = css.RegexReplace("background-position:0;", "background-position:0 0;");
		css = css.RegexReplace("(:|\\s)0+\\.(\\d+)", "$1.$2");
		css = css.ShortenRgbColors();
		css = css.ShortenHexColors();
		css = Regex.Replace(css, "[^\\}]+\\{;\\}", "", RegexOptions.RightToLeft);
		css = css.RegexReplace("(?i)\\band\\(", "and (");
		if (columnWidth > 0)
		{
			css = css.BreakLines(columnWidth);
		}
		css = css.RegexReplace("___PSEUDOCLASSBMH___", "\"\\\\\"}\\\\\"\"");
		css = css.Trim();
		return css;
	}

	private static string RemoveCommentBlocks(this string input)
	{
		int startIndex = 0;
		int endIndex = 0;
		bool iemac = false;
		for (startIndex = input.IndexOf("/*", startIndex); startIndex >= 0; startIndex = input.IndexOf("/*", startIndex))
		{
			endIndex = input.IndexOf("*/", startIndex + 2);
			if (endIndex >= startIndex + 2)
			{
				if (input[endIndex - 1] == '\\')
				{
					startIndex = endIndex + 2;
					iemac = true;
				}
				else if (iemac)
				{
					startIndex = endIndex + 2;
					iemac = false;
				}
				else
				{
					input = input.RemoveRange(startIndex, endIndex + 2);
				}
			}
		}
		return input;
	}

	private static string ShortenRgbColors(this string css)
	{
		StringBuilder sb = new StringBuilder();
		Match i = new Regex("rgb\\s*\\(\\s*([0-9,\\s]+)\\s*\\)").Match(css);
		int index = 0;
		while (i.Success)
		{
			string[] array = i.Groups[1].Value.Split(',');
			StringBuilder hexcolor = new StringBuilder("#");
			string[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				int val = int.Parse(array2[j]);
				hexcolor.Append($"{val:x2}");
			}
			index = i.AppendReplacement(sb, css, hexcolor.ToString(), index);
			i = i.NextMatch();
		}
		i.AppendTail(sb, css, index);
		return sb.ToString();
	}

	private static string ShortenHexColors(this string css)
	{
		StringBuilder sb = new StringBuilder();
		Match i = new Regex("([^\"'=\\s])(\\s*)#([0-9a-fA-F])([0-9a-fA-F])([0-9a-fA-F])([0-9a-fA-F])([0-9a-fA-F])([0-9a-fA-F])").Match(css);
		int index = 0;
		while (i.Success)
		{
			if (i.Groups[3].Value.EqualsIgnoreCase(i.Groups[4].Value) && i.Groups[5].Value.EqualsIgnoreCase(i.Groups[6].Value) && i.Groups[7].Value.EqualsIgnoreCase(i.Groups[8].Value))
			{
				string replacement = i.Groups[1].Value + i.Groups[2].Value + "#" + i.Groups[3].Value + i.Groups[5].Value + i.Groups[7].Value;
				index = i.AppendReplacement(sb, css, replacement, index);
			}
			else
			{
				index = i.AppendReplacement(sb, css, i.Value, index);
			}
			i = i.NextMatch();
		}
		i.AppendTail(sb, css, index);
		return sb.ToString();
	}

	private static string RemovePrecedingSpaces(this string css)
	{
		StringBuilder sb = new StringBuilder();
		Match i = new Regex("(^|\\})(([^\\{:])+:)+([^\\{]*\\{)").Match(css);
		int index = 0;
		while (i.Success)
		{
			string s = i.Value;
			s = s.RegexReplace(":", "___PSEUDOCLASSCOLON___");
			index = i.AppendReplacement(sb, css, s, index);
			i = i.NextMatch();
		}
		i.AppendTail(sb, css, index);
		return sb.ToString().RegexReplace("\\s+([!{};:>+\\(\\)\\],])", "$1").RegexReplace("___PSEUDOCLASSCOLON___", ":");
	}

	private static string BreakLines(this string css, int columnWidth)
	{
		int i = 0;
		int start = 0;
		StringBuilder sb = new StringBuilder(css);
		while (i < sb.Length)
		{
			if (sb[i++] == '}' && i - start > columnWidth)
			{
				sb.Insert(i, '\n');
				start = i;
			}
		}
		return sb.ToString();
	}
}
