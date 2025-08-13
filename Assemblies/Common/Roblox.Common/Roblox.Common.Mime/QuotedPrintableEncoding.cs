using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Roblox.Common.Mime;

/// <summary>
/// This class is based on the QuotedPrintable class written by Bill Gearhart
/// found at http://www.aspemporium.com/classes.aspx?cid=6
/// </summary>
public class QuotedPrintableEncoding
{
	private static string HexDecoderEvaluator(Match m)
	{
		return ((char)Convert.ToInt32(m.Groups[2].Value, 16)).ToString();
	}

	private static string HexDecoder(string line)
	{
		if (line == null)
		{
			throw new ArgumentNullException();
		}
		return new Regex("(\\=([0-9A-F][0-9A-F]))", RegexOptions.IgnoreCase).Replace(line, HexDecoderEvaluator);
	}

	public static string DecodeFile(string filepath)
	{
		if (filepath == null)
		{
			throw new ArgumentNullException();
		}
		string decodedHtml = "";
		FileInfo fileInfo = new FileInfo(filepath);
		if (!fileInfo.Exists)
		{
			throw new FileNotFoundException();
		}
		StreamReader sr = fileInfo.OpenText();
		try
		{
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				decodedHtml += Decode(line);
			}
			return decodedHtml;
		}
		finally
		{
			sr.Close();
			sr = null;
		}
	}

	public static string Decode(string encoded)
	{
		if (encoded == null)
		{
			throw new ArgumentNullException();
		}
		using StringWriter sw = new StringWriter();
		using (StringReader sr = new StringReader(encoded))
		{
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				if (line.EndsWith("="))
				{
					sw.Write(HexDecoder(line.Substring(0, line.Length - 1)));
				}
				else
				{
					sw.WriteLine(HexDecoder(line));
				}
				sw.Flush();
			}
		}
		return sw.ToString();
	}
}
