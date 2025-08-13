namespace Roblox.Platform.Chat;

internal interface IDecoratorValidator
{
	bool Validate(long conversationId, IParticipant senderParticipant);
}
