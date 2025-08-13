using Roblox.Platform.Communication.Behavior;

namespace Roblox.Platform.Chat;

internal interface IMessageContentValidationResult
{
	bool IsAllowedToBeSent { get; }

	CommunicationBehaviorGuardStatus CommunicationGuardStatus { get; }

	bool IsMoreStrictlyModeratedForSomeRecipients { get; }

	string Under13Content { get; }

	string Over13Content { get; }
}
