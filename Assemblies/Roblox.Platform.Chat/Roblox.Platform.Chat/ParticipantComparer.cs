using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class ParticipantComparer : IEqualityComparer<IParticipant>
{
	public static bool AreEqual(IParticipant x, IParticipant y)
	{
		if (x == null && y == null)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (x.TypeId == y.TypeId)
		{
			return x.TargetId == y.TargetId;
		}
		return false;
	}

	public bool Equals(IParticipant x, IParticipant y)
	{
		return AreEqual(x, y);
	}

	public int GetHashCode(IParticipant obj)
	{
		return (obj.TypeId + "_" + obj.TargetId).GetHashCode();
	}
}
