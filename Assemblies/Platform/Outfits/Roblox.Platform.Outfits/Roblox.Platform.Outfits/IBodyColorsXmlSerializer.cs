using System.Xml;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Handles serialization/deserialization of the Body Colors XML document
/// This is uploaded as a document to S3 and the md5 hash is stored in UserAvatar.AvatarHash
/// </summary>
public interface IBodyColorsXmlSerializer
{
	/// <summary>
	/// Moved from BodyColorSet.cs
	/// Creates a BodyColors XML document in memory from brickColorIds
	/// Format of the XML document should be the same as UserAvatar.AvatarHash
	/// When we migrate UserAvatar.AvatarHash over to UserAvatar.BodyColorSetId, we will need to look up bodyColorSets by the hash of this file on S3
	/// </summary>
	/// <returns></returns>
	XmlDocument GenerateBodyColorsXmlDocument(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId);

	/// <summary>
	/// If the user does not have any body colors, update with a default set of colors
	/// </summary>
	/// <param name="userAvatar"></param>
	void AddDefaultColorsIfMissing(IUserAvatar userAvatar);

	/// <summary>
	/// Moved from UserAvatar in Server Class Library
	/// </summary>
	void PersistAvatar(IUserAvatar userAvatar, XmlDocument bodyColorsXmlDocument);

	/// <summary>
	/// Moved from UserAvatar in Server Class Library
	/// </summary>
	/// <param name="property">The string property of the XML to update</param>
	/// <param name="brickColor">The BrickColor the property is being changed to</param>
	/// <param name="avatarDocument">The avatar XML document</param>
	void SetBodyColor(string property, BrickColor brickColor, XmlDocument avatarDocument);

	/// <summary>
	/// For use when we want to create a new BodyColorSetHash, but aren't creating it from a user who has these body colors
	/// </summary>
	string GetOrCreateAssetHashFromBrickColorIds(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId);

	/// <summary>
	/// Given a hash, downloads the XML document from S3
	/// </summary>
	/// <param name="bodyColorsHash">The hash of the body colors document</param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Outfits.PlatformFailedToRetrieveBodyColorsException"></exception>
	XmlDocument DownloadXmlDocumentFromBodyColorsHash(string bodyColorsHash);

	string UploadXmlDocument(XmlDocument bodyColorsXmlDocument);

	/// <summary>
	/// Retrieves the body colors XML document for a UserAvatar.
	/// If body colors are missing, they are filled in with defaults.
	/// Also removes any t-shirts from the XML document.
	/// </summary>
	/// <param name="userAvatar"></param>
	/// <param name="avatarHash"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Outfits.PlatformFailedToRetrieveBodyColorsException"></exception>
	XmlDocument GetBodyColorsXmlDocumentFromUserAvatar(IUserAvatar userAvatar, out string avatarHash);

	IBrickBodyColorSet ParseBodyColorsFromXmlDocument(XmlDocument avatarXmlDocument);

	/// <summary>
	/// Retrieves the XML body colors from a UserAvatar.
	/// If the body colors contain illegal brickColorIds, try once to reset the colors to defaults.
	/// </summary>
	/// <param name="userAvatar"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Outfits.PlatformFailedToRetrieveBodyColorsException"></exception>
	IBrickBodyColorSet GetBrickColorSetFromAvatarHash(IUserAvatar userAvatar);
}
