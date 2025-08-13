using System.Text;
using Roblox.Hashing;

namespace Roblox.Common;

public static class Counters
{
	private static readonly string _DefaultKey = "Roblox.Platform.Common.Counter";

	/// <summary>Remap any userid into a stable number from 0-99, 
	/// to be used for comparison against rollout switches. 
	/// We do the remap so users whose id ends in 00 do not always fall into the test group for 1% rollouts.
	/// <param name="userid">User ID to base the percentage on.</param>
	/// <param name="key">An arbitrarily unique key per component. Can be component name.</param>
	/// </summary>
	public static int GetStableRolloutPercentage(long userid, string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			key = _DefaultKey;
		}
		string input = userid + key;
		return (int)(MurmurHash2.Hash(Encoding.ASCII.GetBytes(input)) % 100u);
	}
}
