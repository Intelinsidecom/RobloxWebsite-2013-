using System;

namespace Roblox.Platform.Marketing.Core;

public interface ITakeoverContentItem
{
	int Id { get; }

	int TakeoverId { get; }

	ContentItemType ContentItemType { get; }

	long ContentItemTargetId { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	void Delete();
}
