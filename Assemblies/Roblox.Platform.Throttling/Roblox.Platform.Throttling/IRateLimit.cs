using System;

namespace Roblox.Platform.Throttling;

public interface IRateLimit
{
	long Id { get; }

	INamespace Namespace { get; }

	IActionType ActionType { get; }

	long NumberOfRequests { get; }

	TimeSpan Interval { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
