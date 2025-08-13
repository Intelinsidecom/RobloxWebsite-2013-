using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Provides a common interface for an object that represents Outfit Rules Manager
/// </summary>
public interface IOutfitRulesManager
{
	/// <summary>
	/// Check if an <see cref="T:Roblox.Platform.Membership.IUser" /> can update an <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to be checked</param>
	/// <param name="userOutfit">The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> to be checked against</param>
	/// <returns>True if the user can update the outfit, False otherwise</returns>
	bool CanUpdateOutfit(IUser user, IUserOutfit userOutfit);

	/// <summary>
	/// Check if an <see cref="T:Roblox.Platform.Membership.IUser" /> can rename an <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to be checked</param>
	/// <param name="userOutfit">The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> to be checked against</param>
	/// <returns>True if the user can rename the outfit, False otherwise</returns>
	bool CanRenameOutfit(IUser user, IUserOutfit userOutfit);

	/// <summary>
	/// Check if an <see cref="T:Roblox.Platform.Membership.IUser" /> can delete an <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to be checked</param>
	/// <param name="userOutfit">The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> to be checked against</param>
	/// <returns>True if the user can delete the outfit, False otherwise</returns>
	bool CanDeleteOutfit(IUser user, IUserOutfit userOutfit);

	/// <summary>
	/// Check if an <see cref="T:Roblox.Platform.Membership.IUser" /> can wear an <see cref="T:Roblox.Platform.Outfits.IUserOutfit" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to be checked</param>
	/// <param name="userOutfit">The <see cref="T:Roblox.Platform.Outfits.IUserOutfit" /> to be checked against</param>
	/// <returns>True if the user can wear the outfit, False otherwise</returns>
	bool CanWearOutfit(IUser user, IUserOutfit userOutfit);

	/// <summary>
	/// Check if an <see cref="T:Roblox.Platform.Membership.IUser" /> has maximum number of outfits allowed.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to be checked</param>
	/// <returns>True if the user has maximum number of outfits allowed, False otherwise.</returns>
	bool HasMaximumNumberOfOutfits(IUserIdentifier user);

	/// <summary>
	/// Check if a given outfit name is valid.
	/// </summary>
	/// <param name="outfitName">The name of the outfit to be checked against</param>
	/// <returns>True if the input is a valid outfit name, False otherwise.</returns>
	bool IsValidName(string outfitName);

	bool AreValidBodyColors(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId);

	bool IsValidBodyColor(int brickColorId);

	BrickColor[] GetValidBodyColors();

	BrickColor[] GetAvatarPageV2ColorPalette();

	BrickColor[] GetAdvancedColorPalette();

	double MinimumDeltaEColorDifference();
}
