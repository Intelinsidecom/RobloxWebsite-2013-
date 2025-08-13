namespace Roblox.Moderation;

/// <summary>
/// When an Utterance is scrubbable, it must implement this interface.
/// </summary>
public interface IUtteranceScrubber
{
	/// <summary>
	/// Calling this method should scrub the utterance. For example, if this is a FooNameUtterance,
	/// the name of Foo would be scrubbed. For text scrubbing, it should use the value from <see cref="P:Roblox.Moderation.IUtteranceTextScrub.ScrubText" />
	///
	/// This is the write side. An <see cref="T:Roblox.Moderation.IUtteranceSource" /> is the utterance reader.
	/// </summary>
	/// <remarks>Legacy SCL UtteranceSources implement both IUtteranceScrubber and IUtteranceSource. This is an anti-pattern.</remarks>
	void Scrub();
}
