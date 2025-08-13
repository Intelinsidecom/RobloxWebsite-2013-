using Roblox.Caching.Interfaces;

namespace Roblox.Data.Interfaces;

public interface IRobloxEntity<TIndex, TDal> : ICacheableObject<TIndex>, ICacheableObject
{
	void Construct(TDal dal);
}
