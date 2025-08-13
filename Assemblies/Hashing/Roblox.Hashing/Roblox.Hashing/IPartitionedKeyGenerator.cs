using System.Collections.Generic;

namespace Roblox.Hashing;

public interface IPartitionedKeyGenerator
{
	string GetPartitionKey(string keyToBePartitioned);

	IReadOnlyCollection<string> GetAllPartitionKeys();
}
