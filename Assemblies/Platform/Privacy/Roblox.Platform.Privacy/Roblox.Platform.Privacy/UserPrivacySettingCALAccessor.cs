using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching.Shared;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

internal class UserPrivacySettingCALAccessor : IUserPrivacySettingCALAccessor
{
	internal virtual ISharedCacheClient _CacheClient { get; private set; }

	internal virtual IUserPrivacyAccessor _UserPrivacyAccessor { get; private set; }

	internal virtual ILogger _Logger { get; private set; }

	[ExcludeFromCodeCoverage]
	internal virtual TimeSpan _MemcachedExpiration => Settings.Default.MemcachedExpirationTime;

	public UserPrivacySettingCALAccessor(IUserPrivacyAccessor userPrivacyAccessor, ISharedCacheClient cacheClient, ILogger logger)
	{
		if (userPrivacyAccessor == null)
		{
			throw new PlatformArgumentNullException("userPrivacyAccessor");
		}
		if (cacheClient == null)
		{
			throw new PlatformArgumentNullException("cacheClient");
		}
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		_UserPrivacyAccessor = userPrivacyAccessor;
		_CacheClient = cacheClient;
		_Logger = logger;
	}

	internal string GetMemcachedKey(UserPrivacySettingType userPrivacySettingType, long userId)
	{
		return $"PrivacySetting:{userPrivacySettingType}:{userId}";
	}

	internal virtual void SaveToCache(UserPrivacySettingType userPrivacySettingType, long userId, UserPrivacyLevelType val)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Cannot have null userId in cache save");
		}
		string key = GetMemcachedKey(userPrivacySettingType, userId);
		_CacheClient.Set(key, val.ToString(), _MemcachedExpiration);
	}

	internal UserPrivacyLevelType? GetFromCache(UserPrivacySettingType userPrivacySettingType, long userId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Cannot have null userId in cache lookup");
		}
		string key = GetMemcachedKey(userPrivacySettingType, userId);
		try
		{
			string res = "";
			if (_CacheClient.Query(key, out res))
			{
				UserPrivacyLevelType? parsed = EnumUtils.StrictTryParseEnum<UserPrivacyLevelType>(res);
				if (parsed.HasValue)
				{
					return parsed;
				}
				_CacheClient.Delete(key);
				return null;
			}
			return null;
		}
		catch (Exception e)
		{
			_Logger.Error($"Memcached exception: {e}");
			_CacheClient.Delete(key);
			return null;
		}
	}

	public IUserPrivacySetting GetOrCreate(UserPrivacySettingType userPrivacySettingType, IUser user, UserPrivacyLevelType defaultPrivacyLevel)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		UserPrivacyLevelType? permissionFromCache = GetFromCache(userPrivacySettingType, user.Id);
		if (permissionFromCache.HasValue)
		{
			return new UserPrivacySettingBase(userPrivacySettingType, user, permissionFromCache.Value);
		}
		IUserPrivacySetting setting;
		try
		{
			setting = _UserPrivacyAccessor.GetOrCreatePrivacyLevelForUserPrivacySetting(userPrivacySettingType, user, defaultPrivacyLevel);
		}
		catch (Exception e)
		{
			_CacheClient.Delete(GetMemcachedKey(userPrivacySettingType, user.Id));
			_Logger.Error(e);
			return new UserPrivacySettingBase(userPrivacySettingType, user, UserPrivacyLevelType.NoOne);
		}
		SaveToCache(userPrivacySettingType, user.Id, setting.PrivacyLevel);
		return setting;
	}

	public void SaveUserPrivacySetting(IUserPrivacySetting newSetting)
	{
		if (newSetting == null)
		{
			throw new ArgumentNullException("newSetting");
		}
		try
		{
			_UserPrivacyAccessor.SetPrivacyLevelForUserPrivacySetting(newSetting);
		}
		catch (Exception ex)
		{
			_CacheClient.Delete(GetMemcachedKey(newSetting.SettingType, newSetting.User.Id));
			throw ex;
		}
		SaveToCache(newSetting.SettingType, newSetting.User.Id, newSetting.PrivacyLevel);
	}
}
