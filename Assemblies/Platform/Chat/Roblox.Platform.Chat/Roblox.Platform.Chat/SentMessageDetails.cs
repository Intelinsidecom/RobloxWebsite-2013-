namespace Roblox.Platform.Chat;

internal class SentMessageDetails : ISentMessageDetails
{
	public IChatMessage SentMessage { get; set; }

	public bool IsMoreStrictlyModeratedForSomeRecipients { get; set; }

	public SentMessageFailureType SentMessageFailureType { get; set; }
}
