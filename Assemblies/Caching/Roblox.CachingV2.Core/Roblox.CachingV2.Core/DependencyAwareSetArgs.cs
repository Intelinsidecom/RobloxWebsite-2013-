using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.CachingV2.Core;

public class DependencyAwareSetArgs : BasicSetArgs
{
	public new static DependencyAwareSetArgs Default { get; } = new DependencyAwareSetArgs(null);


	public IReadOnlyCollection<DependencyInfo> Dependencies { get; }

	public DependencyAwareSetArgs(DateTime? expiration, IReadOnlyCollection<DependencyInfo> dependencies)
		: base(expiration)
	{
		if (dependencies == null || dependencies.Any((DependencyInfo d) => d == null))
		{
			throw new ArgumentNullException("dependencies");
		}
		Dependencies = new List<DependencyInfo>(dependencies);
	}

	public DependencyAwareSetArgs(DateTime? expiration)
		: base(expiration)
	{
		Dependencies = (IReadOnlyCollection<DependencyInfo>)(object)new DependencyInfo[0];
	}
}
