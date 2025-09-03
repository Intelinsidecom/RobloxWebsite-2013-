using System;
namespace Roblox.Marketing {
    class RandomNumberFactory

{
	public int GetRandomNumberBetween0AndN(int n)
	{
		return new global::System.Random(new object().GetHashCode()).Next(n + 1);
	}
}


}
