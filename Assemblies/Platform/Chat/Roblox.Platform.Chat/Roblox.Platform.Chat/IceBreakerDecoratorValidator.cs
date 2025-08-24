using System.Linq;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat;

internal class IceBreakerDecoratorValidator : IDecoratorValidator
{
	private readonly IMessageDataAccessor _MessageDataAccessor;

	public IceBreakerDecoratorValidator(IMessageDataAccessor messageDataAccessor)
	{
		_MessageDataAccessor = messageDataAccessor;
	}

	public bool Validate(long conversationId, IParticipant senderParticipant)
	{
		if (!Settings.Default.AreIceBreakersEnabled)
		{
			return false;
		}
		if (senderParticipant == null)
		{
			return false;
		}
		if (!senderParticipant.IsUser())
		{
			return false;
		}
		if (_MessageDataAccessor.GetMessages(senderParticipant.TargetId, conversationId, null, 1).Any())
		{
			return false;
		}
		return true;
	}
}
