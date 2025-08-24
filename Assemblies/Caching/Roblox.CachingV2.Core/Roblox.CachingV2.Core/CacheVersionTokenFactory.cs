using System;

namespace Roblox.CachingV2.Core;

public class CacheVersionTokenFactory : ICacheVersionTokenFactory
{
	private readonly Func<Guid> _GuidGeneratorFunc;

	public CacheVersionTokenFactory(Func<Guid> guidGeneratorFunc)
	{
		if (guidGeneratorFunc == null)
		{
			throw new ArgumentNullException("guidGeneratorFunc");
		}
		_GuidGeneratorFunc = guidGeneratorFunc;
	}

	public CacheVersionToken Create()
	{
		return new CacheVersionToken(_GuidGeneratorFunc());
	}
}
