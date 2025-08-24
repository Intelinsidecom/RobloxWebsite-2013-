using System.Runtime.Serialization;

namespace Roblox.Platform.Chat;

[DataContract]
internal class Participant : IParticipant
{
	private readonly int _TypeId;

	private readonly long _TargetId;

	[DataMember]
	public int TypeId => _TypeId;

	[DataMember]
	public long TargetId => _TargetId;

	public Participant(int typeId, long targetId)
	{
		_TypeId = typeId;
		_TargetId = targetId;
	}
}
