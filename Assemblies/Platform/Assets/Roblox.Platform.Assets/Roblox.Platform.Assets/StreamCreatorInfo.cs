using System.IO;
using System.Net;

namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting data for an Asset Stream.
/// </summary>
public class StreamCreatorInfo
{
	public Stream Content { get; }

	public DecompressionMethods DecompressionMethod { get; }

	public int? ExpectedContentSize { get; }

	public string ExpectedContentHash { get; }

	public string MimeType { get; }

	public StreamCreatorInfo(Stream content, DecompressionMethods decompressionMethod = DecompressionMethods.None, int? expectedContentSize = null, string expectedContentHash = null, string mimeType = null)
	{
		Content = content;
		DecompressionMethod = decompressionMethod;
		ExpectedContentSize = expectedContentSize;
		ExpectedContentHash = expectedContentHash;
		MimeType = mimeType;
	}
}
