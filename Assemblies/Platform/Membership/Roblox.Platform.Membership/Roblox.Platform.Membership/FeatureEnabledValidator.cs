using System;

namespace Roblox.Platform.Membership;

public class FeatureEnabledValidator : IFeatureEnabledValidator
{
	private readonly Func<bool> _GetEnabledForSoothsayer;

	private readonly Func<bool> _GetEnabledForBetaTester;

	private readonly Func<bool> _GetEnabledForGuest;

	private readonly Func<bool> _GetEnabledForAll;

	private readonly Func<int> _GetRolloutPercentage;

	private readonly Func<IUser, bool> _IsUserSoothsayer;

	private readonly Func<IUser, bool> _IsUserBetaTester;

	public FeatureEnabledValidator(Func<bool> getEnabledForSoothsayer = null, Func<bool> getEnabledForBetaTester = null, Func<bool> getEnabledForGuest = null, Func<bool> getEnabledForAll = null, Func<int> getRolloutPercentage = null)
		: this(null, null, getEnabledForSoothsayer, getEnabledForBetaTester, getEnabledForGuest, getEnabledForAll, getRolloutPercentage)
	{
	}

	internal FeatureEnabledValidator(Func<IUser, bool> isUserSoothsayer, Func<IUser, bool> isUserBetaTester, Func<bool> getEnabledForSoothsayer = null, Func<bool> getEnabledForBetaTester = null, Func<bool> getEnabledForGuest = null, Func<bool> getEnabledForAll = null, Func<int> getRolloutPercentage = null)
	{
		_GetEnabledForSoothsayer = getEnabledForSoothsayer ?? ((Func<bool>)(() => false));
		_GetEnabledForBetaTester = getEnabledForBetaTester ?? ((Func<bool>)(() => false));
		_GetEnabledForGuest = getEnabledForGuest ?? ((Func<bool>)(() => false));
		_GetEnabledForAll = getEnabledForAll ?? ((Func<bool>)(() => false));
		_GetRolloutPercentage = getRolloutPercentage ?? ((Func<int>)(() => 0));
		_IsUserSoothsayer = isUserSoothsayer ?? ((Func<IUser, bool>)((IUser user) => user.IsSoothSayer()));
		_IsUserBetaTester = isUserBetaTester ?? ((Func<IUser, bool>)((IUser user) => user.IsBetaTester()));
	}

	public bool IsFeatureEnabled(IUser user)
	{
		if (_GetEnabledForAll())
		{
			return true;
		}
		if (user == null)
		{
			if (_GetEnabledForGuest())
			{
				return _GetRolloutPercentage() == 100;
			}
			return false;
		}
		if (_GetRolloutPercentage() <= user.Id % 100 && (!_GetEnabledForSoothsayer() || !_IsUserSoothsayer(user)))
		{
			if (_GetEnabledForBetaTester())
			{
				return _IsUserBetaTester(user);
			}
			return false;
		}
		return true;
	}
}
