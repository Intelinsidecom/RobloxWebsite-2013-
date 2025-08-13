using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Roblox.Caching.Properties;
using Roblox.Configuration;
using Roblox.EventLog;

namespace Roblox.Caching.MemCached;

internal class EntityRampUpAuthority : IEntityRampUpAuthority
{
	private static EntityRampUpAuthority _Instance;

	private readonly ILogger _Logger;

	private readonly ConcurrentDictionary<string, DateTime> _TypeSpecificRampUpExpirations;

	private readonly Func<DateTime> _UtcNowGetter;

	private readonly ISettings _Settings;

	private readonly Func<bool> _IsTypeSpecificRampUpEnabledGetter;

	private DateTime _RampUpExpiration;

	private long _TypeSpecificRampUpExpirationCount;

	private string _LastRemoteCacheableEntities;

	private bool _LastRemoteCacheableEntitiesInitialized;

	private ISet<string> _RemoteCacheableEntities = new HashSet<string>();

	private static readonly object _InstanceLock = new object();

	internal EntityRampUpAuthority(ISettings settings, Func<DateTime> utcNowGetter, ILogger logger)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_UtcNowGetter = utcNowGetter ?? throw new ArgumentNullException("utcNowGetter");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_TypeSpecificRampUpExpirations = new ConcurrentDictionary<string, DateTime>();
		_TypeSpecificRampUpExpirationCount = 0L;
		_IsTypeSpecificRampUpEnabledGetter = () => settings.IsTypeSpecificRampUpEnabledV2;
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.RemoteCacheableEntities, UpdateRemoteCacheableEntities);
	}

	public static IEntityRampUpAuthority GetInstance()
	{
		if (_Instance == null)
		{
			lock (_InstanceLock)
			{
				if (_Instance == null)
				{
					_Instance = new EntityRampUpAuthority(Settings.Default, () => DateTime.UtcNow, StaticLoggerRegistry.Instance);
				}
			}
		}
		return _Instance;
	}

	public bool IsEntityTypeInRampUp(string entityType)
	{
		if (string.IsNullOrEmpty(entityType))
		{
			throw new ArgumentNullException(entityType);
		}
		DateTime dateTime = _UtcNowGetter();
		if (dateTime < _RampUpExpiration)
		{
			return true;
		}
		if (!_IsTypeSpecificRampUpEnabledGetter())
		{
			return false;
		}
		if (string.IsNullOrEmpty(entityType))
		{
			return false;
		}
		if (_TypeSpecificRampUpExpirationCount <= 0)
		{
			return false;
		}
		if (!_TypeSpecificRampUpExpirations.TryGetValue(entityType, out var value))
		{
			return false;
		}
		if (value > dateTime)
		{
			return true;
		}
		RemoveExpiredEntityFromTypeSpecificRampUpExpirations(entityType);
		return false;
	}

	public void TouchRampUp()
	{
		_RampUpExpiration = _UtcNowGetter() + GetRampUpTime();
	}

	public bool IsRemoteCacheable(string entityType)
	{
		return _RemoteCacheableEntities.Contains(entityType);
	}

	public void TouchRampUp(string entityType)
	{
		if (string.IsNullOrEmpty(entityType))
		{
			throw new ArgumentNullException(entityType);
		}
		AddEntityTypeSpecificRampUpExpiration(entityType);
	}

	private void AddEntityTypeSpecificRampUpExpiration(string entityType)
	{
		if (string.IsNullOrEmpty(entityType))
		{
			throw new ArgumentNullException(entityType);
		}
		if (!_TypeSpecificRampUpExpirations.ContainsKey(entityType) && _TypeSpecificRampUpExpirations.TryAdd(entityType, _UtcNowGetter() + GetRampUpTime()))
		{
			Interlocked.Exchange(ref _TypeSpecificRampUpExpirationCount, _TypeSpecificRampUpExpirations.Count);
		}
	}

	private void RemoveExpiredEntityFromTypeSpecificRampUpExpirations(string entityType)
	{
		if (_TypeSpecificRampUpExpirations.TryRemove(entityType, out var _))
		{
			Interlocked.Exchange(ref _TypeSpecificRampUpExpirationCount, _TypeSpecificRampUpExpirations.Count);
		}
	}

	private TimeSpan GetRampUpTime()
	{
		return _Settings.RampUpTime;
	}

	private void UpdateRemoteCacheableEntities(string value)
	{
		if (_IsTypeSpecificRampUpEnabledGetter())
		{
			UpdateRemoteCacheableEntitiesWithTypeSpecificRampUpBehavior(value);
		}
		else
		{
			UpdateRemoteCacheableEntitiesWithLegacyRampUpBehavior(value);
		}
	}

	private void UpdateRemoteCacheableEntitiesWithLegacyRampUpBehavior(string value)
	{
		if (!(_LastRemoteCacheableEntities == value))
		{
			if (_LastRemoteCacheableEntitiesInitialized)
			{
				TouchRampUp();
			}
			string[] collection = (from e in value.Split(new char[1] { ',' })
				where !string.IsNullOrWhiteSpace(e)
				select e).ToArray();
			_RemoteCacheableEntities = new HashSet<string>(collection);
			_LastRemoteCacheableEntities = value;
			_LastRemoteCacheableEntitiesInitialized = true;
			_Logger.LifecycleEvent(() => $"{_RemoteCacheableEntities.Count} remote cacheable objects from '{value}'");
		}
	}

	private void UpdateRemoteCacheableEntitiesWithTypeSpecificRampUpBehavior(string value)
	{
		string[] entitiesFromSetting = GetEntitiesFromSetting(value);
		_RemoteCacheableEntities = new HashSet<string>(entitiesFromSetting);
		if (_LastRemoteCacheableEntities == value)
		{
			return;
		}
		if (_LastRemoteCacheableEntitiesInitialized)
		{
			HashSet<string> hashSet = new HashSet<string>(GetEntitiesFromSetting(_LastRemoteCacheableEntities));
			IEnumerable<string> entityTypes = _RemoteCacheableEntities.Except(hashSet).Union(hashSet.Except(_RemoteCacheableEntities));
			if (entityTypes.Any())
			{
				_Logger.LifecycleEvent(() => string.Format("{0} entityTypes marked for RampUp.  Complete list: {1}", entityTypes.Count(), string.Join(",", entityTypes)));
				foreach (string item in entityTypes)
				{
					TouchRampUp(item);
				}
			}
		}
		_LastRemoteCacheableEntities = value;
		_LastRemoteCacheableEntitiesInitialized = true;
		_Logger.LifecycleEvent(() => $"{_RemoteCacheableEntities.Count} remote cacheable objects from '{value}'");
	}

	private string[] GetEntitiesFromSetting(string value)
	{
		return (from el in value.Split(new char[1] { ',' })
			select el.Trim() into e
			where !string.IsNullOrWhiteSpace(e)
			select e).ToArray();
	}
}
