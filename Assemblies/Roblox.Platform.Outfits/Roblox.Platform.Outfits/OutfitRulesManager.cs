using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Outfits;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Outfits.IOutfitRulesManager" />
/// </summary>
public class OutfitRulesManager : IOutfitRulesManager
{
	private readonly Regex _ValidNameRegex = new Regex("^[a-zA-Z0-9 ]*$", RegexOptions.Compiled);

	private const int _MaxOutfitNameLength = 200;

	private readonly OutfitDomainFactories _DomainFactories;

	private static readonly HashSet<int> _ValidBodyColorIds = new HashSet<int>(from brickColor in BrickColor.GetAllValidColors()
		select brickColor.ID);

	internal virtual int OutfitsMaxPerUser => Settings.Default.OutfitsMaxPerUser;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Outfits.OutfitRulesManager" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal OutfitRulesManager(OutfitDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	/// For now rename, wear and delete are the same but update is limited to user created outfits only. 
	/// However, in the future we may change requirements e.g. when we start giving out Outfits when you buy a package, 
	/// we may want to allow you to delete an outfit or wear it, but not update or rename it
	public bool CanUpdateOutfit(IUser user, IUserOutfit userOutfit)
	{
		if (user.Id == userOutfit.UserId)
		{
			return userOutfit.IsEditable;
		}
		return false;
	}

	public bool CanRenameOutfit(IUser user, IUserOutfit userOutfit)
	{
		return user.Id == userOutfit.UserId;
	}

	public bool CanDeleteOutfit(IUser user, IUserOutfit userOutfit)
	{
		return user.Id == userOutfit.UserId;
	}

	public bool CanWearOutfit(IUser user, IUserOutfit userOutfit)
	{
		return user.Id == userOutfit.UserId;
	}

	public bool HasMaximumNumberOfOutfits(IUserIdentifier user)
	{
		return GetTotalNumberOfEditableUserOutfits(user.Id) >= OutfitsMaxPerUser;
	}

	private int GetTotalNumberOfEditableUserOutfits(long userId)
	{
		return _DomainFactories.UserOutfitEntityFactory.GetEditableCountByUserId(userId);
	}

	public bool IsValidName(string outfitName)
	{
		if (string.IsNullOrWhiteSpace(outfitName))
		{
			return false;
		}
		if (outfitName.Length > 200)
		{
			return false;
		}
		return _ValidNameRegex.Match(outfitName).Success;
	}

	/// <summary>
	/// The valid BrickColors that can be used for avatar body parts
	/// </summary>
	/// <returns></returns>
	public BrickColor[] GetValidBodyColors()
	{
		return BrickColor.GetAllValidColors();
	}

	public BrickColor[] GetAvatarPageV2ColorPalette()
	{
		return BrickColor.GetAvatarPageV2ColorPalette();
	}

	public BrickColor[] GetAdvancedColorPalette()
	{
		return BrickColor.GetAdvancedColorPalette();
	}

	/// <summary>
	/// Returns whether the BrickColor is valid for applying to a body part
	/// </summary>
	/// <param name="brickColorId"></param>
	/// <returns></returns>
	public bool IsValidBodyColor(int brickColorId)
	{
		return _ValidBodyColorIds.Contains(brickColorId);
	}

	public bool AreValidBodyColors(int headBrickColorId, int leftArmBrickColorId, int leftLegBrickColorId, int rightArmBrickColorId, int rightLegBrickColorId, int torsoBrickColorId)
	{
		int[] array = new int[6] { headBrickColorId, leftArmBrickColorId, leftLegBrickColorId, rightArmBrickColorId, rightLegBrickColorId, torsoBrickColorId };
		foreach (int brickColorId in array)
		{
			if (!IsValidBodyColor(brickColorId))
			{
				return false;
			}
		}
		return true;
	}

	/// <summary>
	/// Returns whether the RGB color is valid for applying to a body part
	/// </summary>
	/// <param name="r">Red</param>
	/// <param name="g">Green</param>
	/// <param name="b">Blue</param>
	/// <returns></returns>
	public bool IsValidBodyColor(byte r, byte g, byte b)
	{
		BrickColor brickColor = BrickColor.GetByRGB(r, g, b);
		return _ValidBodyColorIds.Contains(brickColor.ID);
	}

	public double MinimumDeltaEColorDifference()
	{
		return Settings.Default.MinimumDeltaEColorDifference;
	}
}
