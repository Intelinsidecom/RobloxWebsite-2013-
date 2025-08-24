using System.Runtime.Serialization;

namespace Roblox.Paging;

/// <summary>
/// Base for cursor information models.
/// </summary>
[DataContract]
public class CursorBase
{
	/// <summary>
	/// The cursor discriminator.
	/// </summary>
	/// <remarks>
	/// The cursor discriminator is intended to make sure a cursor can only be
	/// parsed for the request it was intended to.
	///
	/// The discriminator should contain unique information about the request
	/// that is also common across all pages for the paged item.
	/// </remarks>
	/// <example>
	/// If paging through a users badges a valid discriminator would be the user id (e.g. "48103520")
	///     The user id will be the same across all pages of the users badges, but the cursor
	///     verification will fail if the same cursor is attempted to be used for another user.
	///
	/// - Second example -
	/// If paging through a users assets by asset type a valid discriminator 
	/// could be a comination of both the asset type and user id (e.g. "Hat_48103520")
	///     The user id and asset type will be the same across all pages of the users hat inventory
	///     but would fail verification if the same cursor was then used on the same users models.
	/// </example>
	[DataMember(Name = "discriminator")]
	public string Discriminator { get; set; }

	/// <summary>
	/// The number of items to be requested.
	/// </summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }
}
