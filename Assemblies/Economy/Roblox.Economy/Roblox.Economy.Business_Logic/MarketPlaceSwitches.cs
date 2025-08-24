using Roblox.Economy.Properties;

namespace Roblox.Economy.Business_Logic;

/// <summary>
/// This class allows access to the settings for the market place.
/// Available settings are:
///  MarketPlaceEnabled - Enables/Disables all features involving exchange (items, currency, bonuses...)
///  ItemsXchangeEnabled - Enables/Disables the items exchange feature (sells/purchases)
///  LoginBonusEnabled - Enables/Disables the login bonus feature
///  TrafficBonusEnabled- Enables/Disables the traffic bonus feature
///  LoginBonusValue - Sets the amount of Tickets that will be given away for every login
///  TrafficBonusValue - Sets the amount of Tickets that will be given away for traffic into a player's site
/// </summary>
public static class MarketPlaceSwitches
{
	/// <summary>
	/// Gets a value indicating whether this instance is market place enabled.
	/// </summary>
	/// <value>
	///     <c>true</c> if this instance is market place enabled; otherwise, <c>false</c>.
	/// </value>
	public static bool IsMarketPlaceEnabled => Settings.Default.MarketPlaceEnabled;

	/// <summary>
	/// Gets a value indicating whether this instance is items xchange enabled.
	/// </summary>
	/// <value>
	///     <c>true</c> if this instance is items xchange enabled; otherwise, <c>false</c>.
	/// </value>
	public static bool IsItemsXchangeEnabled
	{
		get
		{
			if (IsMarketPlaceEnabled)
			{
				return Settings.Default.ItemsXchangeEnabled;
			}
			return false;
		}
	}

	/// <summary>
	/// Enables users to resell items
	/// </summary>
	public static bool IsItemResaleEnabled
	{
		get
		{
			if (IsMarketPlaceEnabled)
			{
				return Settings.Default.ItemResaleEnabled;
			}
			return false;
		}
	}

	public static bool IsNonRobloxSalesEnabled
	{
		get
		{
			if (IsMarketPlaceEnabled)
			{
				return Settings.Default.NonRobloxSalesEnabled;
			}
			return false;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance is login bonus enabled.
	/// </summary>
	/// <value>
	///     <c>true</c> if this instance is login bonus enabled; otherwise, <c>false</c>.
	/// </value>
	public static bool IsLoginBonusEnabled
	{
		get
		{
			if (IsMarketPlaceEnabled)
			{
				return Settings.Default.LoginBonusEnabled;
			}
			return false;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance is traffic bonus enabled.
	/// </summary>
	/// <value>
	///     <c>true</c> if this instance is traffic bonus enabled; otherwise, <c>false</c>.
	/// </value>
	public static bool IsTrafficBonusEnabled
	{
		get
		{
			if (IsMarketPlaceEnabled)
			{
				return Settings.Default.TrafficBonusEnabled;
			}
			return false;
		}
	}

	/// <summary>
	/// Gets the login bonus award.
	/// </summary>
	public static int LoginBonusAward => Settings.Default.DailyLoginBonusAward;
}
