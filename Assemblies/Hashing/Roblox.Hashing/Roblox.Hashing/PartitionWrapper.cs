using System.Text;

namespace Roblox.Hashing;

public class PartitionWrapper
{
	private readonly int _Hash;

	public string PartitionKey { get; }

	public PartitionWrapper(string partitionKey)
	{
		PartitionKey = partitionKey;
		uint hash = MurmurHash2.Hash(Encoding.ASCII.GetBytes(PartitionKey));
		_Hash = (int)hash;
	}

	public override int GetHashCode()
	{
		return _Hash;
	}
}
