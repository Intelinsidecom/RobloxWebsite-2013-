using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Caching;
using Roblox.Platform.Assets;
using Roblox.Platform.AudioRightsManagement.Properties;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// An <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache" /> backed by an <see cref="T:System.Runtime.Caching.MemoryCache" />.
/// </summary>
public class AudioCopyrightStatusMemoryCache : IAudioCopyrightStatusCache
{
	private readonly MemoryCache _MemoryCache;

	private readonly ISettings _Settings;

	private readonly Func<DateTime> _NowGetter;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusMemoryCache" />.
	/// </summary>
	/// <param name="memoryCache"><see cref="T:System.Runtime.Caching.MemoryCache" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="memoryCache" /></exception>
	[ExcludeFromCodeCoverage]
	public AudioCopyrightStatusMemoryCache(MemoryCache memoryCache)
		: this(Settings.Default, () => DateTime.UtcNow, memoryCache)
	{
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusMemoryCache" />.
	/// </summary>
	/// <param name="settings"><see cref="T:Roblox.Platform.AudioRightsManagement.Properties.ISettings" /></param>
	/// <param name="nowGetter"><see cref="T:System.Func`1" /> returning the current local time.</param>
	/// <param name="memoryCache"><see cref="T:System.Runtime.Caching.MemoryCache" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="nowGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="memoryCache" /></exception>
	internal AudioCopyrightStatusMemoryCache(ISettings settings, Func<DateTime> nowGetter, MemoryCache memoryCache)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_NowGetter = nowGetter ?? throw new ArgumentNullException("nowGetter");
		_MemoryCache = memoryCache ?? throw new ArgumentNullException("memoryCache");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache.Cache(Roblox.Platform.Assets.IRawContent,System.Boolean)" />
	public void Cache(IRawContent rawContent, bool isProtected)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		_MemoryCache.Set(rawContent.Md5Hash, isProtected, new CacheItemPolicy
		{
			AbsoluteExpiration = new DateTimeOffset(_NowGetter().Add(_Settings.AudioCopyrightStatusCacheExpiration))
		});
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache.IsProtected(Roblox.Platform.Assets.IRawContent)" />
	public bool? IsProtected(IRawContent rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		return _MemoryCache.Get(rawContent.Md5Hash) as bool?;
	}

	/// <inheritdoc cref="M:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusCache.GetStatuses(System.Collections.Generic.IReadOnlyCollection{Roblox.Platform.Assets.IRawContent})" />
	public IDictionary<IRawContent, bool?> GetStatuses(IReadOnlyCollection<IRawContent> rawContent)
	{
		if (rawContent == null)
		{
			throw new ArgumentNullException("rawContent");
		}
		IEnumerable<string> hashes = rawContent.Select((IRawContent r) => r.Md5Hash);
		Dictionary<string, IRawContent> rawContentLookup = rawContent.ToDictionary((IRawContent r) => r.Md5Hash, (IRawContent r) => r);
		return _MemoryCache.GetValues(hashes).ToDictionary((KeyValuePair<string, object> k) => rawContentLookup[k.Key], (KeyValuePair<string, object> k) => k.Value as bool?);
	}
}
