using System;
using Roblox.Platform.Core;
using Roblox.Platform.Marketing.Core.Entities;

namespace Roblox.Platform.Marketing.Core;

internal class TakeoverContentItem : ITakeoverContentItem
{
	public int Id { get; internal set; }

	public int TakeoverId { get; internal set; }

	public ContentItemType ContentItemType { get; internal set; }

	public long ContentItemTargetId { get; internal set; }

	public DateTime Created { get; internal set; }

	public DateTime Updated { get; internal set; }

	internal TakeoverContentItem()
	{
	}

	internal TakeoverContentItem(int takeoverId, ContentItemType contentItemType, long contentItemTargetID)
	{
		TakeoverId = takeoverId;
		ContentItemType = contentItemType;
		ContentItemTargetId = contentItemTargetID;
	}

	internal TakeoverContentItem(Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("Null entity passed in to TakeoverContentItem constructor");
		}
		Id = entity.ID;
		TakeoverId = entity.TakeoverID;
		ContentItemType = (ContentItemType)Enum.Parse(typeof(ContentItemType), entity.ContentItemTypeID.ToString());
		ContentItemTargetId = entity.ContentItemTargetID;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public virtual void Save()
	{
		Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem entity = Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.Get(Id) ?? new Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem();
		entity.TakeoverID = TakeoverId;
		entity.ContentItemTypeID = (byte)ContentItemType;
		entity.ContentItemTargetID = ContentItemTargetId;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public virtual void Delete()
	{
		Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.Get(Id)?.Delete();
	}
}
