using System.Web;

namespace Roblox.Common;

public class TextTransforms
{
	public static string TransformString(string stringToTransform)
	{
		return PerformCarriageReturnSubstitution(HttpContext.Current.Server.HtmlEncode(stringToTransform));
	}

	public static string PerformCarriageReturnSubstitution(string text)
	{
		return text.Replace("\r\n", "<br />").Replace("\n", "<br />").Replace("\r", "<br />");
	}

	public static string QuotedXmlInLuaEscape(string toEscape)
	{
		return AsciiHtmlEscape(TransformString(toEscape).Replace("<br />", "\\n").Replace("\"", "&#34;").Replace("'", "&#39;")).Replace("]]>", "] ]>");
	}

	public static string AsciiHtmlEscape(string toEscape)
	{
		char[] array = toEscape.ToCharArray();
		string toReturn = "";
		char[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			char c = array2[i];
			int code = c;
			toReturn = ((code < 128) ? (toReturn + c) : (toReturn + "&#" + code + ";"));
		}
		return toReturn;
	}
}
