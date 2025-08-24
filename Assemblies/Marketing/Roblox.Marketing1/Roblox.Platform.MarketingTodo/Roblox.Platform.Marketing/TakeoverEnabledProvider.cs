using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching.Shared;
using Roblox.Marketing;
using Roblox.Platform.Marketing.Core;
using Roblox.Platform.Marketing.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

/// <summary>
/// Provides methods for determining whether or not a takeover is enabled.
/// </summary>
public class TakeoverEnabledProvider : ITakeoverEnabledProvider
{
	private const string _CacheKeyPrefix = "TakeoverUserViews_";

	private readonly ITakeoverContentItemFactory _TakeoverContentItemFactory;

	private readonly ISharedCacheClient _SharedCache;

	public TakeoverEnabledProvider(ITakeoverContentItemFactory takeoverContentItemFactory, ISharedCacheClient sharedCache)
	{
		_TakeoverContentItemFactory = takeoverContentItemFactory;
		_SharedCache = sharedCache;
	}

	/// <summary>
	/// Determines whether or not a takeover of the given takeover type is enabled
	/// for the given user in the given country.
	/// </summary>
	/// <param name="takeoverTypeId">The ID of the takeover type.</param>
	/// <param name="user">The user that the takeover would be presented to.</param>
	/// <param name="isApp">Whether or not this is the app.</param>
	/// <param name="userCountryId">The ID of the user's country.</param>
	/// <param name="contentTypeValue">The type of content to limit the takeover to</param>
	/// <param name="contentItemTargetId">The id of the content to limit the takeover to</param>
	/// <returns>Whether or not a takeover of the given takeover type is enabled for
	/// the given user in the given country.</returns>
	public bool TakeoverEnabled(byte takeoverTypeId, IUser user, bool isApp, int? userCountryId, ContentItemType? contentTypeValue, long? contentItemTargetId)
	{
		if (isApp)
		{
			return false;
		}
		if (user == null || user.IsBCMember())
		{
			return false;
		}
		int? userAge = GetUserAge(user);
		return (from takeover in GetActiveTakeovers()
			where takeover.TakeoverTypeID == takeoverTypeId
			select takeover).Any((Takeover takeover) => TakeoverByAgeEnabled(takeover, userAge) && TakeoverByCountryEnabled(takeover, userCountryId) && TakeoverByGenderEnabled(takeover.ID, user) && TakeoverByContentItemEnabled(takeover, ContentItemType.Asset, contentItemTargetId) && TakeoverViewedLessThanFrequencyCap(takeover, user.Id));
	}

	private bool TakeoverByGenderEnabled(int takeoverId, IUser user)
	{
		TakeoverGender takeoverGender = TakeoverGender.GetByTakeoverID(takeoverId);
		if (takeoverGender == null)
		{
			return true;
		}
		return (uint)takeoverGender.GenderTypeID == (uint)user.GenderType;
	}

	protected TakeoverAge GetTakeoverAgeByTakeoverId(int takeoverId)
	{
		return TakeoverAge.GetByTakeoverID(takeoverId);
	}

	protected IEnumerable<TakeoverCountry> GetTakeoverCountriesByTakeoverId(int takeoverId, int startIndex, int maxRows)
	{
		return TakeoverCountry.GetTakeoverCountriesByTakeoverID(takeoverId, startIndex, maxRows);
	}

	/// <summary>
	/// Determines whether or not a takeover is enabled in a country.
	/// </summary>
	/// <param name="takeover">The takeover.</param>
	/// <param name="userCountryId">The country.</param>
	/// <returns>Whether or not a takeover is enabled in a country.</returns>
	private bool TakeoverByCountryEnabled(Takeover takeover, int? userCountryId)
	{
		IEnumerable<TakeoverCountry> takeoverCountries = GetTakeoverCountriesByTakeoverId(takeover.ID, 0, 100);
		if (!userCountryId.HasValue)
		{
			return true;
		}
		return takeoverCountries.Any((TakeoverCountry country) => country.CountryID == userCountryId.Value);
	}

	/// <summary>
	/// Determines whether or not a takeover is enabled for a particular piece of content.
	/// </summary>
	/// <param name="takeover">The takeover.</param>
	/// <param name="userCountryId">The country.</param>
	/// <param name="contentType">The type of content to check for.</param>
	/// <param name="conentTargetId">The content Id to check for.</param>
	/// <returns>Whether or not a takeover is enabled in a country.</returns>
	private bool TakeoverByContentItemEnabled(Takeover takeover, ContentItemType? contentType, long? contentTargetId)
	{
		if (!contentType.HasValue || !contentTargetId.HasValue)
		{
			return true;
		}
		IEnumerable<ITakeoverContentItem> contentItems = _TakeoverContentItemFactory.GetTakeoverContentItemsByTakeoverId(takeover.ID);
		if (contentItems == null || contentItems.Count() == 0)
		{
			return true;
		}
		return contentItems.Any((ITakeoverContentItem item) => item.ContentItemType == contentType && item.ContentItemTargetId == contentTargetId.Value);
	}

	/// <summary>
	/// Check that this user has viewed this takeover less than the defined Frequency Cap.
	/// If the Frequency Cap is not set or is 0 then this always returns true.
	/// </summary>
	/// <param name="takeover">The takeover.</param>
	/// <param name="userId">The unique id of the user who's views to count.</param>
	/// <returns>true if isVewCounted is null or false or the takeover has no Frequency Cap or the view count for this user is less than the Frequency Cap for this takeover. False otherwise.</returns>
	private bool TakeoverViewedLessThanFrequencyCap(Takeover takeover, long userId)
	{
		if (!Settings.Default.TakeoverFrequencyCapEnabled || !takeover.FrequencyCap.HasValue || takeover.FrequencyCap.Value == 0)
		{
			return true;
		}
		string key = string.Format("{0}{1}_{2}", "TakeoverUserViews_", takeover.ID, userId);
		ulong? count = _SharedCache.GetCounter(key);
		if (count.HasValue)
		{
			if (count.Value >= (ulong)takeover.FrequencyCap.Value)
			{
				return false;
			}
			_SharedCache.Increment(key, 1uL);
			return true;
		}
		TimeSpan untilMidnight = DateTime.Today.AddDays(1.0) - DateTime.Now;
		_SharedCache.SetCounter(key, 1uL, untilMidnight);
		return true;
	}

	/// <summary>
	/// Determines whether or not a takeover is enabled for a user based on the user's age.
	/// </summary>
	/// <param name="takeover">The takeover.</param>
	/// <param name="userAge">The age of the user in years.</param>
	/// <returns>Whether or not a takeover is enabled for a user based on the user's age.</returns>
	private bool TakeoverByAgeEnabled(Takeover takeover, int? userAge)
	{
		if (!userAge.HasValue)
		{
			return true;
		}
		_ = DateTime.Now;
		TakeoverAge takeoverAge = GetTakeoverAgeByTakeoverId(takeover.ID);
		if (takeoverAge == null)
		{
			return true;
		}
		if (!takeoverAge.MinAgeInYears.HasValue || userAge.Value > takeoverAge.MinAgeInYears.Value)
		{
			if (takeoverAge.MaxAgeInYears.HasValue)
			{
				return userAge.Value < takeoverAge.MaxAgeInYears.Value;
			}
			return true;
		}
		return false;
	}

	/// <summary>
	/// Gets all active takeovers.
	/// </summary>
	/// <returns>All active takeovers.</returns>
	internal virtual IEnumerable<Takeover> GetActiveTakeovers()
	{
		return Takeover.GetActiveTakeovers(DateTime.Now);
	}

	/// <summary>
	/// Gets a user's age.
	/// </summary>
	/// <param name="user">The user to get the age of.</param>
	/// <returns>The user's age in years or null if the user doesn't have an age.</returns>
	private int? GetUserAge(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		DateTime now = DateTime.Now;
		DateTime? birthdate = user.Birthdate;
		TimeSpan? userAge = now - birthdate;
		if (!userAge.HasValue)
		{
			return null;
		}
		return userAge.GetValueOrDefault().Days / 365;
	}
}
