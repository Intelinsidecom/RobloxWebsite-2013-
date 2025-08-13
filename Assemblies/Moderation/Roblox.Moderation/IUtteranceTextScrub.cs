namespace Roblox.Moderation;

/// <summary>
/// When an Utterance is scrubbable, it must implement this interface.
/// </summary>
public interface IUtteranceTextScrub
{
	/// <summary>
	/// The text used to replace bad text
	/// </summary>
	string ScrubText { get; }
}
