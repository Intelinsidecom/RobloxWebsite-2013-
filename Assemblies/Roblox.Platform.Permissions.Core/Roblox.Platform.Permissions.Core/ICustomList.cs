using System.Collections.Generic;

namespace Roblox.Platform.Permissions.Core;

public interface ICustomList
{
	long Id { get; }

	string Name { get; }

	string CreatorType { get; }

	long CreatorTargetId { get; }

	void AddMember(long userId);

	void Delete();

	IEnumerable<long> GetMembers(int page);

	IEnumerable<long> GetMembers(int page, out long count);

	void Update(string name);

	void RemoveMember(long userId);
}
