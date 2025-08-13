using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership;

internal class Guest : Visitor, IGuest, IVisitor, IVisitorIdentifier, IGuestIdentifier
{
	internal Guest(long id)
		: base(id)
	{
		if (id >= 0)
		{
			throw new ArgumentException("Guest ids must be negative.");
		}
	}
}
