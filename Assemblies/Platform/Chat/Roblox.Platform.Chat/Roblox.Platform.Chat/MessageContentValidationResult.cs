using Roblox.Platform.Communication.Behavior;

namespace Roblox.Platform.Chat;

internal class MessageContentValidationResult : IMessageContentValidationResult
{
	public bool IsAllowedToBeSent { get; set; }

	public CommunicationBehaviorGuardStatus CommunicationGuardStatus { get; set; }

	public bool IsMoreStrictlyModeratedForSomeRecipients { get; set; }

	public string Under13Content { get; set; }

	public string Over13Content { get; set; }
}
