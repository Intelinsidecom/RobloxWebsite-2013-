using System.Collections.Generic;
using System.Linq;
using Roblox.Common.NetStandard;
using Roblox.Platform.Marketing.Core.Entities;

namespace Roblox.Platform.Marketing.Core;

public class TakeoverContentItemFactory : ITakeoverContentItemFactory
{
	private const int PageSize = 10;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Marketing.Core.TakeoverContentItemFactory" /> class with a standard ContentItemTypeFactory.
	/// </summary>
	public TakeoverContentItemFactory()
	{
	}

	public ITakeoverContentItem GetById(int id)
	{
		Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem entity = Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.Get(id);
		if (entity != null)
		{
			return new TakeoverContentItem(entity);
		}
		return null;
	}

	public ITakeoverContentItem GetByTakeoverIdContentItemTypeAndContentItemTargetId(int takeoverId, ContentItemType contentItemType, long contentItemTargetId)
	{
		Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem entity = Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.GetByTakeoverIDContentItemTypeIDAndContentItemTargetID(takeoverId, (byte)contentItemType, contentItemTargetId);
		if (entity != null)
		{
			return new TakeoverContentItem(entity);
		}
		return null;
	}

	public IEnumerable<ITakeoverContentItem> GetTakeoverContentItemsByTakeoverId(int takeoverId)
	{
		return from ent in CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.GetTakeoverContentItemsByTakeoverIDPaged(takeoverId, start, max), 10)
			select new TakeoverContentItem(ent);
	}

	public IEnumerable<ITakeoverContentItem> GetTakeoverContentItemsByContentItemTypeAndContentItemTargetId(ContentItemType contentItemType, long contentItemTargetId)
	{
		return from ent in CollectionsHelper.GetAllPaged((int start, int max) => Roblox.Platform.Marketing.Core.Entities.TakeoverContentItem.GetTakeoverContentItemsByContentItemTypeIDAndContentItemTargetIDPaged((byte)contentItemType, contentItemTargetId, start, max), 10)
			select new TakeoverContentItem(ent);
	}

	public ITakeoverContentItem CreateTakeoverContentItem(int takeoverId, ContentItemType contentItemType, long contentItemTargetId)
	{
		TakeoverContentItem takeoverContentItem = new TakeoverContentItem(takeoverId, contentItemType, contentItemTargetId);
		takeoverContentItem.Save();
		return takeoverContentItem;
	}
}
