using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Chat;

internal class OneToOneConversationHelper
{
	private readonly IParticipant _Participant1;

	private readonly IParticipant _Participant2;

	public IParticipant Participant1 => _Participant1;

	public IParticipant Participant2 => _Participant2;

	public OneToOneConversationHelper(IParticipant unorderedParticipant1, IParticipant unorderedParticipant2)
	{
		IParticipant[] sorted = (from x in new List<IParticipant> { unorderedParticipant1, unorderedParticipant2 }
			orderby x.TypeId, x.TargetId
			select x).ToArray();
		_Participant1 = sorted[0];
		_Participant2 = sorted[1];
	}

	public string GetKey()
	{
		return $"{_Participant1.TypeId}_{_Participant1.TargetId}_{_Participant2.TypeId}_{_Participant2.TargetId}";
	}
}
