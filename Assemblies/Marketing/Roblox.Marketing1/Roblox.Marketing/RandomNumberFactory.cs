using System;
namespace Roblox.Marketingpublic {
    class RandomNumberFactory

{
	public int GetRandomNumberBetween0AndN(int n)
	{
		return new Random(new object().GetHashCode()).Next(n + 1);
	}
}


}
