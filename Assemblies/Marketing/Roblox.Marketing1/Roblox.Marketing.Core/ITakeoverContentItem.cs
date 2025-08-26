using System;
namespace Roblox.Marketing.Corepublic {
    interface ITakeoverContentItem

{
	int Id { get; }

	int TakeoverId { get; }

	ContentItemType ContentItemType { get; }

	long ContentItemTargetId { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	void Delete();
}


}
