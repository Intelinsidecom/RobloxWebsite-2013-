using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.ContentRights.Client;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// The default version of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" />.
/// </summary>
public class AudioCopyrightStatusReader : IAudioCopyrightStatusReader
{
	private readonly IContentRightsClient _ContentRightsClient;

	private readonly IAssetVersionFactory _AssetVersionFactory;

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
	public bool IsAudioCopyrightProtected(IRawContent rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		if (rawContent.AssetType != AssetType.Audio)
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
			if (content2.AssetType != AssetType.Audio)
			{
				throw new ArgumentException($"rawContent {content2.Id} is not an audio asset.", "rawContent");
			}
		}
		IEnumerable<ContentIdentifier> identifier = rawContent.Select(delegate(IRawContent content)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			ContentIdentifier result = default(ContentIdentifier);
			((ContentIdentifier)(ref result)).ContentType = ContentType.Audio.ToString();
			((ContentIdentifier)(ref result)).ContentTargetId = content.Md5Hash;
			return result;
		});
		IEnumerable<ContentIdentifier> source = _ContentRightsClient.AreContentRightsProtected(identifier);
		ILookup<string, IRawContent> lookupByHashRawContent = rawContent.ToLookup((IRawContent r) => r.Md5Hash, (IRawContent r) => r);
		return (IReadOnlyCollection<IRawContent>)(object)source.Select((ContentIdentifier c) => lookupByHashRawContent[((ContentIdentifier)(ref c)).ContentTargetId].First()).ToArray();
	}

	/// <inheritdoc />
	public bool IsAudioCopyrightProtected(IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IAssetVersion currentAssetVersion = _AssetVersionFactory.GetCurrentAssetVersion(asset);
		if (currentAssetVersion == null)
		{
			throw new ArgumentException("asset does not have a current version.", "asset");
		}
		try
		{
			return IsAudioCopyrightProtected(currentAssetVersion);
		}
		catch (ArgumentException ex) when (ex.ParamName == "rawContent" || ex.ParamName == "assetVersion")
		{
			throw new ArgumentException("Invalid asset.", "asset", ex);
		}
	}

	/// <inheritdoc />
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
