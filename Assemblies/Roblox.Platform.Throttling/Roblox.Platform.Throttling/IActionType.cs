using System;

namespace Roblox.Platform.Throttling;

public interface IActionType
{
	long Id { get; }

	string Value { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
