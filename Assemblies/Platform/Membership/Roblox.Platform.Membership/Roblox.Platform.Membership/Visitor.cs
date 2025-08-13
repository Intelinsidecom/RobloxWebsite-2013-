using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Membership;

public abstract class Visitor : IVisitor, IVisitorIdentifier
{
	public long Id { get; private set; }

	protected Visitor(long id)
	{
		Id = id;
	}
}
