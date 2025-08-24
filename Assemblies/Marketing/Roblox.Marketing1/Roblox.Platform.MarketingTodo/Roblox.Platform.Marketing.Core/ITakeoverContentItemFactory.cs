using System.Collections.Generic;

namespace Roblox.Platform.Marketing.Core;

/// <summary>
/// Creates and Gets TakeoverContentItems which are used to target specific content for takeover ads.
///  </summary>
public interface ITakeoverContentItemFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" /> with the given ID, or null if none exists.</returns>
	ITakeoverContentItem GetById(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" /> by its takeoverID, contentItemTypeID and contentItemTargetID properties.
	/// </summary>
	/// <param name="takeoverId">The ID of the <see cref="!:Takeover" /> property to get.</param>
	/// <param name="contentItemType">The enum value of <see cref="T:Roblox.Platform.Marketing.ContentItemType" /> to get.</param>
	/// <param name="contentItemTargetId">The ID of the contentItemTargetID property to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" /> with the given values, or null if none exists.</returns>
	ITakeoverContentItem GetByTakeoverIdContentItemTypeAndContentItemTargetId(int takeoverId, ContentItemType contentItemType, long contentItemTargetId);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />s with the given takeoverID.
	/// </summary>
	/// <param name="takeoverId">The ID of the <see cref="!:Takeover" />s to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />s with the given takeoverID.</returns>
	IEnumerable<ITakeoverContentItem> GetTakeoverContentItemsByTakeoverId(int takeoverId);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />s with the given contentItemTypeID and contentItemTargetID.
	/// </summary>
	/// <param name="contentItemType">The enum value of <see cref="T:Roblox.Platform.Marketing.ContentItemType" /> to get.</param>
	/// <param name="contentItemTargetID">The ID of the contentItemTargetID property to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />s with the given values.</returns>
	IEnumerable<ITakeoverContentItem> GetTakeoverContentItemsByContentItemTypeAndContentItemTargetId(ContentItemType contentItemType, long contentItemTargetID);

	/// <summary>
	/// Create a new <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />
	/// </summary>
	/// <param name="takeoverId">The ID of the <see cref="!:Takeover" /> property to set.</param>
	/// <param name="contentItemType">The enum value of <see cref="T:Roblox.Platform.Marketing.ContentItemType" /> to set.</param>
	/// <param name="contentItemTargetId">The ID of the contentItemTargetID property to set.</param>
	/// <returns>The new <see cref="T:Roblox.Platform.Marketing.Core.ITakeoverContentItem" />.</returns>
	ITakeoverContentItem CreateTakeoverContentItem(int takeoverId, ContentItemType contentItemType, long contentItemTargetId);
}
