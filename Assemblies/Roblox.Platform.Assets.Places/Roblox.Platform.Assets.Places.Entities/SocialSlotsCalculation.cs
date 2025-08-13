using System;
using Roblox.Platform.Assets.Places.Properties;

namespace Roblox.Platform.Assets.Places.Entities;

public class SocialSlotsCalculation
{
	public static int CalculateSocialSlots(int maxPlayers)
	{
		if (maxPlayers <= 10)
		{
			return CalculateSocialSlotsHelper(maxPlayers, Settings.Default.SocialSlotsRatio1to10);
		}
		if (maxPlayers <= 20)
		{
			return CalculateSocialSlotsHelper(maxPlayers, Settings.Default.SocialSlotsRatio11to20);
		}
		if (maxPlayers <= 30)
		{
			return CalculateSocialSlotsHelper(maxPlayers, Settings.Default.SocialSlotsRatio21to30);
		}
		if (maxPlayers <= 40)
		{
			return CalculateSocialSlotsHelper(maxPlayers, Settings.Default.SocialSlotsRatio31to40);
		}
		return CalculateSocialSlotsHelper(maxPlayers, Settings.Default.SocialSlotsRatio41andAbove);
	}

	public static int CalculateSocialSlotsHelper(int maxPlayers, double ratio)
	{
		if (ratio >= 1.0)
		{
			return 0;
		}
		return Convert.ToInt32(Math.Floor((double)maxPlayers * ratio));
	}
}
