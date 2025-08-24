namespace Roblox.TextFilter;

/// <summary>
/// Wrapper for features relevant to the recipient of the message.
/// </summary>
public interface ITextRecipient
{
	/// <summary>
	/// Is the recipient under 13?
	/// </summary>
	bool IsUnder13 { get; }
}
