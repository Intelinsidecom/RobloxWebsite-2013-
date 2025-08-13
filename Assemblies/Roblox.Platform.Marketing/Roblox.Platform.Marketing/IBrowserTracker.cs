using System;

namespace Roblox.Platform.Marketing;

public interface IBrowserTracker
{
	long Id { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
