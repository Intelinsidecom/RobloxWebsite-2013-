using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class BadgeTypeFactory : IBadgeTypeFactory
{
	public BadgeType GetBadgeTypeByName(string name)
	{
		if (name == null)
		{
			throw new PlatformArgumentNullException("Badge name is null");
		}
		Roblox.BadgeType badgeType = Roblox.BadgeType.Get(name);
		if (badgeType == null)
		{
			throw new PlatformArgumentException("No badge named " + name + " found");
		}
		return badgeType.Value switch
		{
			"Builders Club" => BadgeType.BuildersClub, 
			"Turbo Builders Club" => BadgeType.TurboBuildersClub, 
			"Outrageous Builders Club" => BadgeType.OutrageousBuildersClub, 
			"Official Model Maker" => BadgeType.OfficialModelMaker, 
			"Welcome To The Club" => BadgeType.WelcomeToTheClub, 
			"Administrator" => BadgeType.Administrator, 
			"Friendship" => BadgeType.Friendship, 
			"Homestead" => BadgeType.Homestead, 
			"Bricksmith" => BadgeType.Bricksmith, 
			"Veteran" => BadgeType.Veteran, 
			_ => throw new PlatformDataIntegrityException("Badge type does not exist"), 
		};
	}

	public int GetBadgeTypeIdByBadgeType(BadgeType assetBadgeType)
	{
		return assetBadgeType switch
		{
			BadgeType.BuildersClub => Roblox.BadgeType.BuildersClubID, 
			BadgeType.TurboBuildersClub => Roblox.BadgeType.TurboBuildersClubID, 
			BadgeType.OutrageousBuildersClub => Roblox.BadgeType.OutrageousBuildersClubID, 
			BadgeType.OfficialModelMaker => Roblox.BadgeType.OfficialModelMakerID, 
			BadgeType.WelcomeToTheClub => Roblox.BadgeType.WelcomeToTheClubID, 
			BadgeType.Administrator => Roblox.BadgeType.AdministratorID, 
			BadgeType.Friendship => Roblox.BadgeType.FriendshipID, 
			BadgeType.Homestead => Roblox.BadgeType.HomesteadID, 
			BadgeType.Bricksmith => Roblox.BadgeType.BricksmithID, 
			BadgeType.Veteran => Roblox.BadgeType.VeteranID, 
			_ => throw new PlatformArgumentException("Invalid badge type"), 
		};
	}

	public BadgeType GetBadgeTypeByBadgeTypeId(int badgeTypeId)
	{
		if (badgeTypeId == Roblox.BadgeType.BuildersClubID)
		{
			return BadgeType.BuildersClub;
		}
		if (badgeTypeId == Roblox.BadgeType.TurboBuildersClubID)
		{
			return BadgeType.TurboBuildersClub;
		}
		if (badgeTypeId == Roblox.BadgeType.OutrageousBuildersClubID)
		{
			return BadgeType.OutrageousBuildersClub;
		}
		if (badgeTypeId == Roblox.BadgeType.WelcomeToTheClubID)
		{
			return BadgeType.WelcomeToTheClub;
		}
		if (badgeTypeId == Roblox.BadgeType.AdministratorID)
		{
			return BadgeType.Administrator;
		}
		if (badgeTypeId == Roblox.BadgeType.FriendshipID)
		{
			return BadgeType.Friendship;
		}
		if (badgeTypeId == Roblox.BadgeType.HomesteadID)
		{
			return BadgeType.Homestead;
		}
		if (badgeTypeId == Roblox.BadgeType.BricksmithID)
		{
			return BadgeType.Bricksmith;
		}
		if (badgeTypeId == Roblox.BadgeType.VeteranID)
		{
			return BadgeType.Veteran;
		}
		throw new PlatformArgumentException("Invalid badge type id");
	}
}
