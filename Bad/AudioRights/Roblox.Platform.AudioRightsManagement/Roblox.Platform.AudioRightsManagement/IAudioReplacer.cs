using System;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// Provides the functionalty to deterministically replace audio.
/// </summary>
public interface IAudioReplacer
{
	/// <summary>
	/// Fired whenever an audio <see cref="T:Roblox.Platform.Assets.IRawContent" /> has been replaced.
	/// </summary>
	event Action<IRawContent> OnRawContentHasBeenReplaced;

	/// <summary>
	/// Returns a replacment audio raw content to replace blocked audio with.
	/// </summary>
	/// <param name="rawContent">The <see cref="T:Roblox.Platform.Assets.IRawContent" /> to replace.</param>
	/// <returns>The replacement <see cref="T:Roblox.Platform.Assets.IRawContent" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="rawContent" /></exception>
	/// <exception cref="T:System.InvalidOperationException">invalid configuration.</exception>
	IRawContent ReplaceAudio(IRawContent rawContent);
}
