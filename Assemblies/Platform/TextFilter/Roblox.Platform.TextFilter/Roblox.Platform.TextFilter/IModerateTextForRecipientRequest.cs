namespace Roblox.TextFilter;

/// <summary>
/// A <see cref="T:Roblox.TextFilter.IModeratedTextRequest" /> that also includes recipient information in
/// a <see cref="T:Roblox.TextFilter.ITextRecipient" />
/// </summary>
public interface IModerateTextForRecipientRequest : IModeratedTextRequest
{
	/// <summary>
	/// Information on the recipient of the text to be filtered.
	/// For cases when the final result depends on the recipient.
	/// </summary>
	ITextRecipient Recipient { get; }
}
