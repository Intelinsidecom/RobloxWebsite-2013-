using System;
using System.IO;
using System.Net;
using System.Text;
using Roblox.EventLog;
using Roblox.WebsiteSettings.Properties;

namespace Roblox;

public class RobloxContentValidator
{
	private readonly ILogger _Logger;

	private int _Bad;

	private int _Total;

	/// <summary>
	/// Instantiates a <see cref="T:Roblox.RobloxContentValidator" />
	/// </summary>
	/// <param name="logger"></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="logger" /> is null</exception>
	public RobloxContentValidator(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public bool ValidateRobloxContent(bool raiseExceptions, Stream content, DecompressionMethods decompressionMethod, int? expectedContentSize, string expectedContentHash, out string xml)
	{
		byte[] dummy;
		return ValidateRobloxContent(raiseExceptions, content, decompressionMethod, expectedContentSize, expectedContentHash, out dummy, out xml, isOutTypeString: true);
	}

	public bool ValidateRobloxContent(bool raiseExceptions, Stream content, DecompressionMethods decompressionMethod, int? expectedContentSize, string expectedContentHash, out byte[] compressedData)
	{
		string dummy;
		return ValidateRobloxContent(raiseExceptions, content, decompressionMethod, expectedContentSize, expectedContentHash, out compressedData, out dummy, isOutTypeString: false);
	}

	private bool ValidateRobloxContent(bool raiseExceptions, Stream content, DecompressionMethods decompressionMethod, int? expectedContentSize, string expectedContentHash, out byte[] compressedData, out string xml, bool isOutTypeString)
	{
		bool isValid = true;
		if (expectedContentSize.HasValue && content.Length != expectedContentSize)
		{
			isValid = false;
			if (raiseExceptions)
			{
				throw new ApplicationException($"Expected {expectedContentSize.Value} bytes, received {content.Length}.");
			}
		}
		_Total++;
		string computedHash;
		if (!isOutTypeString)
		{
			compressedData = new byte[content.Length];
			content.Read(compressedData, 0, (int)content.Length);
			using (MemoryStream compressedStream = new MemoryStream(compressedData))
			{
				using (MemoryStream uncompressedStream = new MemoryStream())
				{
					StreamUtilities.Uncompress(compressedStream, decompressionMethod, uncompressedStream);
					string xmlData = Encoding.UTF8.GetString(uncompressedStream.ToArray());
					isValid = ValidateRobloxContentHelper(xmlData, isValid, raiseExceptions);
				}
				computedHash = HashFunctions.ComputeHashString(compressedData);
			}
			xml = null;
		}
		else
		{
			xml = StreamUtilities.StreamToString(content, decompressionMethod);
			isValid = ValidateRobloxContentHelper(xml, isValid, raiseExceptions);
			long initialPosition = content.Position;
			byte[] compressedDataForString = new byte[content.Length];
			content.Read(compressedDataForString, 0, (int)content.Length);
			content.Position = initialPosition;
			computedHash = HashFunctions.ComputeHashString(compressedDataForString);
			compressedData = null;
		}
		if (!string.IsNullOrEmpty(expectedContentHash) && computedHash != expectedContentHash)
		{
			isValid = false;
			if (raiseExceptions)
			{
				throw new ApplicationException("Content hashes don't match.");
			}
		}
		if (decompressionMethod == DecompressionMethods.None)
		{
			_Logger.Verbose(() => $"Possibly bad gzip for {expectedContentHash}.");
		}
		return isValid;
	}

	private bool ValidateRobloxContentHelper(string xml, bool isValid, bool raiseExceptions)
	{
		if (!xml.StartsWith("<roblox"))
		{
			_Bad++;
			string message3 = $"Xml starts with '{xml.Substring(0, 10)}'.  {_Bad * 100 / _Total}% bad so far.";
			_Logger.Verbose(message3);
			isValid = false;
			if (raiseExceptions)
			{
				throw new ApplicationException(message3);
			}
		}
		else if (!xml.EndsWith("</roblox>"))
		{
			_Bad++;
			string message2 = $"Xml ends with '{xml.Substring(xml.Length - 10)}'.  {_Bad * 100 / _Total}% bad so far.";
			_Logger.Verbose(message2);
			isValid = false;
			if (raiseExceptions)
			{
				throw new ApplicationException(message2);
			}
		}
		if (Settings.Default.BlockXmlCommentsInAssetUploads && (xml.Contains("<!--") || xml.Contains("-->")))
		{
			_Bad++;
			string message = $"Xml contains comments. {_Bad * 100 / _Total}% bad so far.";
			_Logger.Verbose(message);
			isValid = false;
			if (raiseExceptions)
			{
				throw new ApplicationException(message);
			}
		}
		return isValid;
	}
}
