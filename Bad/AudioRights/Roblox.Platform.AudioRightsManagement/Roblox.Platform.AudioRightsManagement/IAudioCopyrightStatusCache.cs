using System.Collections.Generic;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// Provides a cache for the copyright status for audio <see cref="T:Roblox.Platform.Assets.IRawContent" />s.
/// </summary>
public interface IAudioCopyrightStatusCache
{
	/// <summary>
	/// Caches the isProtected status of a single audio <see cref="T:Roblox.Platform.Assets.IRawContent" />.
	/// </summary>
	/// <param name="rawContent">The <see cref="T:Roblox.Platform.Assets.IRawContent" /> the status belongs to.</param>
	/// <param name="isProtected">Whether someone protected his rights on this audio.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContent" /></exception>
	void Cache(IRawContent rawContent, bool isProtected);

	/// <summary>
	/// Whether an audio <see cref="T:Roblox.Platform.Assets.IRawContent" /> is protected.
	/// </summary>
	/// <param name="rawContent">The <see cref="T:Roblox.Platform.Assets.IRawContent" /> we are interested in.</param>
	/// <returns>Whether the rights to this audio are protected.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContent" /></exception>
	bool? IsProtected(IRawContent rawContent);

	/// <summary>
	/// Gets the cached statuses for all <see cref="T:Roblox.Platform.Assets.IRawContent" />s in <paramref name="rawContent" />.
	/// </summary>
	/// <param name="rawContent"></param>
	/// <returns>A lookup dictionary containing all requested <see cref="T:Roblox.Platform.Assets.IRawContent" />s with their cached status, or <c>null</c>.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContent" /></exception>
	IDictionary<IRawContent, bool?> GetStatuses(IReadOnlyCollection<IRawContent> rawContent);
}
