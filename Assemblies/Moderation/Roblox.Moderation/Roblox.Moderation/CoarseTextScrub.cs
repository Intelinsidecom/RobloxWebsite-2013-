namespace Roblox.Moderation;

/// <summary>
/// Implements <see cref="T:Roblox.Moderation.IUtteranceTextScrub" />.
/// </summary>
/// <remarks>
/// This is called "coarse" primarily because it supports the <see cref="T:Roblox.Moderation.CoarseUtteranceSource" />. 
/// Additionally there are other text (prose) scrubs that include an ID
/// or other information from an <seealso cref="T:Roblox.Moderation.IUtteranceSource" /> such as 
/// <see cref="!:GroupNameSource" />. It is also a way to reduce the surface area of IUtteranceSource
/// which doesn't need to know about the ScrubText property.
///
/// Those custom implementations don't use the old ScrubText property and instead provide a
/// finer scrubbed text in the <see cref="T:Roblox.Moderation.IUtteranceScrubber" /> implementation itself.
///
/// It's not clear if it makes sense to continue the IUtteranceTextScrub pattern or how to 
/// better handle scrubbed text. There will probably eventually be concerns about how to 
/// localize moderated text too.
/// </remarks>
public class CoarseTextScrub : IUtteranceTextScrub
{
	/// <inheritdoc cref="P:Roblox.Moderation.IUtteranceTextScrub.ScrubText" />
	public string ScrubText => "[ Content Deleted ]";
}
