using System;

namespace Roblox.Platform.Groups;

public interface IClanInvitation
{
	long Id { get; }

	long GroupId { get; }

	long UserId { get; }

	DateTime Created { get; }

	void Accept();

	void Cancel(IGroupMembership groupAdmin);

	void Delete();
}
