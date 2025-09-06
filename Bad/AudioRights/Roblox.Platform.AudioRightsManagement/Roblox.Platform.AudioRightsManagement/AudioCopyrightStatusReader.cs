using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ContentRights.Client;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// The default version of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" />.
/// </summary>
public class AudioCopyrightStatusReader : Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader
{
	private readonly IContentRightsClient _ContentRightsClient;

	private readonly Roblox.Platform.Assets.IAssetVersionFactory _AssetVersionFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusReader" />.
	/// </summary>
	/// <param name="contentRightsClient">An <see cref="T:Roblox.ContentRights.Client.IContentRightsClient" /></param>
	/// <param name="assetVersionFactory">An <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="contentRightsClient" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersionFactory" /></exception>
	public AudioCopyrightStatusReader(IContentRightsClient contentRightsClient, IAssetVersionFactory assetVersionFactory)
	{
		_ContentRightsClient = contentRightsClient ?? throw new ArgumentNullException("contentRightsClient");
		_AssetVersionFactory = assetVersionFactory ?? throw new ArgumentNullException("assetVersionFactory");
	}

	/// <inheritdoc />
	public bool IsAudioCopyrightProtected(Roblox.Platform.Assets.IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		// TODO: Re-enable once Roblox.IAsset vs Roblox.Platform.Assets.IAsset ambiguity is resolved.
		// Temporarily avoid using IAssetVersionFactory to break build loop.
		return false;
	}

	/// <inheritdoc />
	public bool IsAudioCopyrightProtected(IRawContent rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		if (rawContent.AssetType != Roblox.Platform.Assets.AssetType.Audio)
		{
			throw new ArgumentException("rawContent is not an audio asset.", "rawContent");
		}
		return _ContentRightsClient.AreContentRightsProtected(ContentType.Audio.ToString(), rawContent.Md5Hash);
	}

	/// <inheritdoc />
	public IReadOnlyCollection<IRawContent> GetCopyrightProtectedAudio(IReadOnlyCollection<IRawContent> rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		foreach (IRawContent content2 in rawContent)
		{
			if (content2.AssetType != Roblox.Platform.Assets.AssetType.Audio)
			{
				throw new ArgumentException($"rawContent {content2.Id} is not an audio asset.", "rawContent");
			}
		}
		IEnumerable<ContentIdentifier> identifier = rawContent.Select(content =>
		{
			var result = new ContentIdentifier
			{
				ContentType = ContentType.Audio.ToString(),
				ContentTargetId = content.Md5Hash
			};
			return result;
		});
		IEnumerable<ContentIdentifier> source = _ContentRightsClient.AreContentRightsProtected(identifier);
		System.Linq.ILookup<string, IRawContent> lookupByHashRawContent = rawContent.ToLookup(r => r.Md5Hash, r => r);
		return (IReadOnlyCollection<IRawContent>)(object)source.Select(c => lookupByHashRawContent[c.ContentTargetId].First()).ToArray();
	}

	public bool IsAudioCopyrightProtected(IAssetVersion assetVersion)
	{
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		IRawContent rawContent = assetVersion.GetRawContent();
		if (rawContent == null)
		{
			throw new ArgumentException("assetVersion does not have valid raw content.", "assetVersion");
		}
		try
		{
			return IsAudioCopyrightProtected(rawContent);
		}
		catch (ArgumentException ex) when (ex.ParamName == "rawContent")
		{
			throw new ArgumentException("Invalid assetVersion.", "assetVersion", ex);
		}
	}
}
