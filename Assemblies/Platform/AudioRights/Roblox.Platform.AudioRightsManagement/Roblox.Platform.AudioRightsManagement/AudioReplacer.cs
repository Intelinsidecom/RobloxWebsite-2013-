using System;
using System.Collections.Generic;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.AudioRightsManagement.Properties;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacer" />.
/// </summary>
public class AudioReplacer : IAudioReplacer
{
	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly IAssetFactory _AssetFactory;

	private readonly IAssetVersionFactory _AssetVersionFactory;

	private readonly IRawContentFactory _RawContentFactory;

	private volatile IRawContent[] _ReplacementAudioSelection;

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioReplacer.ReplaceAudio(Roblox.Platform.Assets.IRawContent)" />
	public event Action<IRawContent> OnRawContentHasBeenReplaced;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioReplacer" />.
	/// </summary>
	/// <param name="logger">A <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetFactory">A <see cref="T:Roblox.Platform.Assets.IAssetFactory" /></param>
	/// <param name="assetVersionFactory">A <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory" /></param>
	/// <param name="rawContentFactory">A <see cref="T:Roblox.Platform.Assets.IRawContentFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersionFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContentFactory" /></exception>
	public AudioReplacer(ILogger logger, IAssetFactory assetFactory, IAssetVersionFactory assetVersionFactory, IRawContentFactory rawContentFactory)
		: this(Settings.Default, logger, assetFactory, assetVersionFactory, rawContentFactory)
	{
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioReplacer" />.
	/// </summary>
	/// <param name="settings">The <see cref="T:Roblox.Configuration.ISetting" />s to use.</param>
	/// <param name="logger">A <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="assetFactory">A <see cref="T:Roblox.Platform.Assets.IAssetFactory" /></param>
	/// <param name="assetVersionFactory">A <see cref="T:Roblox.Platform.Assets.IAssetVersionFactory" /></param>
	/// <param name="rawContentFactory">A <see cref="T:Roblox.Platform.Assets.IRawContentFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="assetVersionFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContentFactory" /></exception>
	internal AudioReplacer(ISettings settings, ILogger logger, IAssetFactory assetFactory, IAssetVersionFactory assetVersionFactory, IRawContentFactory rawContentFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AssetFactory = assetFactory ?? throw new ArgumentNullException("assetFactory");
		_AssetVersionFactory = assetVersionFactory ?? throw new ArgumentNullException("assetVersionFactory");
		_RawContentFactory = rawContentFactory ?? throw new ArgumentNullException("rawContentFactory");
		_Settings.ReadValueAndMonitorChanges((ISettings s) => s.ReplacementAudioAssetIds, delegate(string value)
		{
			BuildRawContentCache(value);
		});
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioReplacer.ReplaceAudio(Roblox.Platform.Assets.IRawContent)" />
	public IRawContent ReplaceAudio(IRawContent rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		if (_ReplacementAudioSelection == null)
		{
			throw new InvalidOperationException("Setting did not contain valid ids.");
		}
		if (!_Settings.IsAudioReplacingEnabled)
		{
			return rawContent;
		}
		this.OnRawContentHasBeenReplaced?.Invoke(rawContent);
		int replacementContentIndex = Math.Abs(rawContent.Md5Hash.GetHashCode()) % _ReplacementAudioSelection.Length;
		return _ReplacementAudioSelection[replacementContentIndex];
	}

	private void BuildRawContentCache(string assetIdsCsv)
	{
		HashSet<string> ids = MultiValueSettingParser.ParseCommaDelimitedListString(assetIdsCsv);
		if (ids.Count == 0)
		{
			_Logger.Error($"Failed to parse ReplacementAudioAssetIds. {assetIdsCsv}");
			return;
		}
		List<IRawContent> result = new List<IRawContent>();
		foreach (string stringId in ids)
		{
			if (!long.TryParse(stringId, out var id))
			{
				_Logger.Error($"Replacement audio asset contained id {stringId} which is not a valid long.");
				return;
			}
			IAsset asset = _AssetFactory.GetAsset(id);
			if (asset == null)
			{
				_Logger.Error($"Replacement audio asset contained id {id} which is not valid.");
				return;
			}
			IAssetVersion assetVersion = _AssetVersionFactory.GetCurrentAssetVersion(asset);
			if (assetVersion == null)
			{
				_Logger.Error($"Replacement audio asset contained id {id} which does not have a valid current version.");
				return;
			}
			IRawContent rawContent = _RawContentFactory.Get(assetVersion.RawContentId);
			if (rawContent == null)
			{
				_Logger.Error($"Replacement audio asset contained id {id} whose current version does not have a raw content.");
				return;
			}
			result.Add(rawContent);
		}
		_ReplacementAudioSelection = result.ToArray();
	}
}
