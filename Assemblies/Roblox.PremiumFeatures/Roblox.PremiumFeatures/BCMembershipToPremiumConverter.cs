using System;
using System.Collections.Generic;
using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures;

public class BCMembershipToPremiumConverter : IBCMembershipToPremiumConverter
{
	private readonly IPremiumFeatureFactory _PremiumFeatureFactory;

	private readonly IPremiumFeatureModel _RobloxPremium450;

	private readonly IPremiumFeatureModel _RobloxPremium1000;

	private readonly IPremiumFeatureModel _RobloxPremium2200;

	private readonly IPremiumFeatureModel _RobloxPremium450OneMonth;

	private readonly IPremiumFeatureModel _RobloxPremium1000OneMonth;

	private readonly IPremiumFeatureModel _RobloxPremium2200OneMonth;

	private static readonly IDictionary<string, IPremiumFeatureModel> _BCToPremiumMap = new Dictionary<string, IPremiumFeatureModel>();

	public BCMembershipToPremiumConverter(IPremiumFeatureFactory premiumFeatureFactory)
	{
		_PremiumFeatureFactory = premiumFeatureFactory ?? throw new ArgumentNullException("premiumFeatureFactory");
		_RobloxPremium450 = _PremiumFeatureFactory.GetByName("Roblox Premium 450");
		_RobloxPremium1000 = _PremiumFeatureFactory.GetByName("Roblox Premium 1000");
		_RobloxPremium2200 = _PremiumFeatureFactory.GetByName("Roblox Premium 2200");
		_RobloxPremium450OneMonth = _PremiumFeatureFactory.GetByName("Roblox Premium 450 One Month");
		_RobloxPremium1000OneMonth = _PremiumFeatureFactory.GetByName("Roblox Premium 1000 One Month");
		_RobloxPremium2200OneMonth = _PremiumFeatureFactory.GetByName("Roblox Premium 2200 One Month");
		InitializeBCToPremiumMap();
	}

	public IPremiumFeatureModel MapBCToPremiumProduct(IPremiumFeatureModel bcPremiumFeature)
	{
		string name = bcPremiumFeature.Name;
		return _BCToPremiumMap[name];
	}

	private void InitializeBCToPremiumMap()
	{
		_BCToPremiumMap.Add("Builders Club Monthly", _RobloxPremium450);
		_BCToPremiumMap.Add("Builders Club 6 Months Renewing", _RobloxPremium450);
		_BCToPremiumMap.Add("Builders Club 12 Months Renewing", _RobloxPremium450);
		_BCToPremiumMap.Add("Turbo Builders Club Monthly", _RobloxPremium1000);
		_BCToPremiumMap.Add("Turbo Builders Club 6 Months Renewing", _RobloxPremium1000);
		_BCToPremiumMap.Add("Turbo Builders Club 12 Months Renewing", _RobloxPremium1000);
		_BCToPremiumMap.Add("Outrageous Builders Club Monthly", _RobloxPremium2200);
		_BCToPremiumMap.Add("Outrageous Builders Club 6 Months Renewing", _RobloxPremium2200);
		_BCToPremiumMap.Add("Outrageous Builders Club 12 Months Renewing", _RobloxPremium2200);
		_BCToPremiumMap.Add("Builders Club Lifetime", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 12 Months", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 6 Months", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 1 Month", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 45 Days", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 30 Days", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Builders Club 90 Days", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Gift 12 Months Builders Club", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Gift 6 Months Builders Club", _RobloxPremium450OneMonth);
		_BCToPremiumMap.Add("Turbo Builders Club Lifetime", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Turbo Builders Club 12 Months", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Turbo Builders Club 6 Months", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Turbo Builders Club 3 Months", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Turbo Builders Club 1 Month", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Gift 12 Months Turbo Builders Club", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Gift 6 Months Turbo Builders Club", _RobloxPremium1000OneMonth);
		_BCToPremiumMap.Add("Outrageous Builders Club Lifetime", _RobloxPremium2200OneMonth);
		_BCToPremiumMap.Add("Outrageous Builders Club 12 Months", _RobloxPremium2200OneMonth);
		_BCToPremiumMap.Add("Outrageous Builders Club 6 Months", _RobloxPremium2200OneMonth);
		_BCToPremiumMap.Add("Outrageous Builders Club 3 Months", _RobloxPremium2200OneMonth);
		_BCToPremiumMap.Add("Outrageous Builders Club 1 Month", _RobloxPremium2200OneMonth);
		_BCToPremiumMap.Add("Gift 12 Months Outrageous Builders Club", _RobloxPremium2200OneMonth);
	}
}
