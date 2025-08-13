namespace Roblox.Moderation;

/// <summary>
/// Creates instances of <see cref="T:Roblox.Moderation.IUtteranceSource" />.
/// </summary>
public interface IUtteranceSourceFactory
{
	/// <summary>
	/// Creates instances of <see cref="T:Roblox.Moderation.IUtteranceSource" />.
	/// </summary>
	/// <remarks>
	/// Currently this depends on <see cref="T:Roblox.Moderation.UtteranceSourceType" /> which 
	/// is an entity DAL. :(
	/// </remarks>
	/// <param name="utteranceSourceType"><see cref="T:Roblox.Moderation.UtteranceSourceType" /> of the utterance's source.</param>
	/// <param name="sourceId">Nullable ID of the Asset, Badge, etc.</param>
	IUtteranceSource Create(UtteranceSourceType utteranceSourceType, long? sourceId);
}
