namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TextFilter.IModerateTextForRecipientRequest" />
/// </summary>
public class ModerateTextForRecipientRequest : ModeratedTextRequest, IModerateTextForRecipientRequest, IModeratedTextRequest
{
	public ITextRecipient Recipient { get; }

	/// <summary>
	/// Default constructor
	/// </summary>
	/// <param name="user"></param>
	/// <param name="text"></param>
	/// <param name="recipient"></param>
	/// <param name="server"></param>
	/// <param name="room"></param>
	public ModerateTextForRecipientRequest(ITextAuthor user, string text, ITextRecipient recipient, string server = null, string room = null)
		: base(user, text, server, room)
	{
		Recipient = recipient;
	}
}
