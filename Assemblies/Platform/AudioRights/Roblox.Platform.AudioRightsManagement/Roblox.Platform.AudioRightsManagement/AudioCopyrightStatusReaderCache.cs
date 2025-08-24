using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Assets;
using Roblox.Platform.AudioRightsManagement.Properties;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// A <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" /> cache descriptor which uses an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache" /> to cache results from an underlying <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" />.
/// </summary>
public class AudioCopyrightStatusReaderCache : IAudioCopyrightStatusReader
{
	private readonly ISettings _Settings;

	private readonly IAudioCopyrightStatusReader _AudioCopyrightStatusReader;

	private readonly IAudioCopyrightStatusCache _AudioCopyrightStatusCache;

	private readonly IAssetVersionFactory _AssetVersionFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusReader" />.
	/// </summary>
	/// <param name="statusReader">THe underlying <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" /></param>
	/// <param name="statusCache">The <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache" /></param>
	/// <param name="assetVersionFactory">An <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="statusReader" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="statusCache" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersionFactory" /></exception>
	[ExcludeFromCodeCoverage]
	public AudioCopyrightStatusReaderCache(IAudioCopyrightStatusReader statusReader, IAudioCopyrightStatusCache statusCache, IAssetVersionFactory assetVersionFactory)
		: this(Settings.Default, statusReader, statusCache, assetVersionFactory)
	{
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusReader" />.
	/// </summary>
	/// <param name="settings">The <see cref="T:Roblox.Platform.AudioRightsManagement.Properties.ISettings" /></param>
	/// <param name="statusReader">THe underlying <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader" /></param>
	/// <param name="statusCache">The <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache" /></param>
	/// <param name="assetVersionFactory">An <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="statusReader" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="statusCache" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersionFactory" /></exception>
	internal AudioCopyrightStatusReaderCache(ISettings settings, IAudioCopyrightStatusReader statusReader, IAudioCopyrightStatusCache statusCache, IAssetVersionFactory assetVersionFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_AudioCopyrightStatusReader = statusReader ?? throw new ArgumentNullException("statusReader");
		_AudioCopyrightStatusCache = statusCache ?? throw new ArgumentNullException("statusCache");
		_AssetVersionFactory = assetVersionFactory ?? throw new ArgumentNullException("assetVersionFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader.IsAudioCopyrightProtected(Roblox.Platform.Assets.IAsset)" />
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
		catch (ArgumentException e)
		{
			throw new ArgumentException(e.Message, "asset", e);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader.IsAudioCopyrightProtected(Roblox.Platform.Assets.IAssetVersion)" />
	public bool IsAudioCopyrightProtected(IAssetVersion assetVersion)
	{
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		IRawContent rawContent = assetVersion.GetRawContent();
		if (rawContent == null)
		{
			throw new ArgumentException($"assetVersion {assetVersion.Id} does not have valid raw content.", "assetVersion");
		}
		return IsAudioCopyrightProtected(rawContent);
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader.IsAudioCopyrightProtected(Roblox.Platform.Assets.IRawContent)" />
	public bool IsAudioCopyrightProtected(IRawContent rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		bool? status = _AudioCopyrightStatusCache.IsProtected(rawContent);
		if (status.HasValue)
		{
			return status.Value;
		}
		bool retrievedStatus = _AudioCopyrightStatusReader.IsAudioCopyrightProtected(rawContent);
		_AudioCopyrightStatusCache.Cache(rawContent, retrievedStatus);
		return retrievedStatus;
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusReader.GetCopyrightProtectedAudio(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Assets.IRawContent})" />
	public IReadOnlyCollection<IRawContent> GetCopyrightProtectedAudio(IReadOnlyCollection<IRawContent> rawContents)
	{
		if (rawContents == null)
		{
			throw new ArgumentNullException("rawContents");
		}
		IDictionary<IRawContent, bool?> cachedStatuses = _AudioCopyrightStatusCache.GetStatuses(rawContents);
		HashSet<IRawContent> audioContentsWithoutCachedStatus = new HashSet<IRawContent>(rawContents);
		audioContentsWithoutCachedStatus.ExceptWith(cachedStatuses.Keys);
		IReadOnlyCollection<IRawContent> uncachedBlockedAudios = _AudioCopyrightStatusReader.GetCopyrightProtectedAudio(audioContentsWithoutCachedStatus);
		foreach (IRawContent blockedAudio in uncachedBlockedAudios)
		{
			_AudioCopyrightStatusCache.Cache(blockedAudio, isProtected: true);
		}
		foreach (IRawContent notProtectedAudio in audioContentsWithoutCachedStatus.Except(uncachedBlockedAudios))
		{
			_AudioCopyrightStatusCache.Cache(notProtectedAudio, isProtected: false);
		}
		IEnumerable<IRawContent> cachedProtectedAudios = from t in cachedStatuses
			where t.Value == true
			select t.Key;
		return (IReadOnlyCollection<IRawContent>)(object)uncachedBlockedAudios.Concat(cachedProtectedAudios).ToArray();
	}
}
