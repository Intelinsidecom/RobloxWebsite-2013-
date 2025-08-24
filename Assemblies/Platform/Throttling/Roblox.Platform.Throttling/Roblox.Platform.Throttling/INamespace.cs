using System;

namespace Roblox.Platform.Throttling;

public interface INamespace
{
	long Id { get; }

	string Value { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
