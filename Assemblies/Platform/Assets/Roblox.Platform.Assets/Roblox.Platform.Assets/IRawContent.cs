using System;

namespace Roblox.Platform.Assets;

/// <summary>
/// RawContent for Assets that are stored in the sytem.
/// These are a thin layer over the underlying AssetHash object in the DB, this is effectively the Platform version.
/// </summary>
public interface IRawContent
{
	/// <summary>
	/// ID of the AssetHash
	/// </summary>
	long Id { get; }

	/// <summary>
	/// Hash value of the given object.
	/// </summary>
	string Md5Hash { get; }

	/// <summary>
	/// Has this AssetHash been reviewed by the moderation system?
	/// </summary>
	bool IsReviewed { get; }

	/// <summary>
	/// Has this AssetHash been approved?
	/// </summary>
	bool IsApproved { get; }

	/// <summary>
	/// The <see cref="P:Roblox.Platform.Assets.IRawContent.CreatorType" /> of the first User/Group to upload this object.
	/// </summary>
	CreatorType CreatorType { get; }

	/// <summary>
	/// The Id of the first User/Group to upload this object.
	/// </summary>
	long CreatorTargetId { get; }

	/// <summary>
	/// When was the object uploaded.
	/// </summary>
	DateTime Created { get; }

	/// <summary>
	/// When was the object last updated?
	/// Likely for review.
	/// </summary>
	DateTime Updated { get; }

	/// <summary>
	/// The type of Asset does represented by this hash.
	/// </summary>
	AssetType AssetType { get; }

	/// <summary>
	/// Sets the IsApproved and IsReviewed status of this object.
	/// </summary>
	void SetApproval(bool isApproved, bool isReviewed);
}
