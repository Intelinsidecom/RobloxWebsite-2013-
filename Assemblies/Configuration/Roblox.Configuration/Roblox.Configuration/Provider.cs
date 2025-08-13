using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Roblox.Configuration;

public class Provider : SettingsProvider
{
	private const int _MaxRetries = 20;

	private const int _SoftLogCharacterLimit = 20000;

	private bool _OneTimeInitializeComplete;

	private string _GroupName;

	private bool _HasSettings;

	private bool _HasConnectionStrings;

	private ApplicationSettingsBase _ApplicationSettings;

	private SettingsProvider _AlternateSettings;

	private DateTime _LastSettingModificationDateTime = DateTime.MinValue;

	private DateTime _LastConnectionStringModificationDateTime = DateTime.MinValue;

	private bool _IsFirstFetch = true;

	private string _OverriddenSettingsFileName;

	private Dictionary<string, object> _OverriddenSettings;

	private DateTime _LastFileBasedOverrideModificationDateTime = DateTime.MinValue;

	private static readonly ProviderConfigSection _RobloxConfigurationSection;

	private static readonly ConfigurationServiceProvider _ConfigurationClient;

	private static readonly ConfigurationServiceFetcher _ConfigurationServiceFetcher;

	private static readonly string _ServiceEndpoint;

	private static readonly SelfDisposingTimer _Timer;

	private static readonly ConcurrentDictionary<string, Provider> _RegisteredProviders;

	public override string Description => "A service-backed SettingsProvider that synchronizes assembly settings from a common repository.";

	public override string ApplicationName { get; set; }

	static Provider()
	{
		Utilities.LogInformation("Roblox.Configuration.Provider static init section started");
		_RobloxConfigurationSection = ConfigurationManager.GetSection("robloxConfigurationProvider") as ProviderConfigSection;
		if (_RobloxConfigurationSection != null)
		{
			GroupConfigElement groupConfiguration = GetGroupConfiguration();
			string text = (_ServiceEndpoint = groupConfiguration.ConfigurationServiceEndpoint);
			_ConfigurationClient = new ConfigurationServiceProvider(text);
			_ConfigurationServiceFetcher = new ConfigurationServiceFetcher(_ConfigurationClient);
			Utilities.LogInformation($"Roblox.Configuration.Provider static init API Client pointing to endpoint {text}");
			TimeSpan updateInterval = groupConfiguration.UpdateInterval;
			_Timer = new SelfDisposingTimer(RefreshRegisteredProviders, updateInterval, updateInterval);
			_RegisteredProviders = new ConcurrentDictionary<string, Provider>();
			Utilities.LogInformation($"Roblox.Configuration.Provider static init Timer created, refresh every {updateInterval}");
		}
		else
		{
			Utilities.LogWarning("No config file found with robloxConfigurationProvider");
		}
	}

	public static string GetConfigurationServiceEndpoint()
	{
		return _ServiceEndpoint ?? "";
	}

	public static void RegisterSettings(SettingsLoadedEventArgs e, ApplicationSettingsBase applicationSettings)
	{
		Provider provider = e.Provider as Provider;
		provider?.UpdateApplicationSettings(applicationSettings);
		string text = provider?._GroupName;
		if (!string.IsNullOrEmpty(text) && _RegisteredProviders != null && !_RegisteredProviders.ContainsKey(text))
		{
			if (_RegisteredProviders.TryAdd(text, provider))
			{
				Utilities.LogInformation($"Settings Group {text} is registered");
			}
			else
			{
				Utilities.LogWarning($"Settings Group {text} failed to register");
			}
		}
	}

	private static void RefreshRegisteredProviders()
	{
		try
		{
			Utilities.LogInformation($"RefreshRegisteredProviders - Start on {_RegisteredProviders.Count} settings providers");
			_Timer.Pause();
			foreach (KeyValuePair<string, Provider> registeredProvider in _RegisteredProviders)
			{
				registeredProvider.Value.ReloadChangedSettings();
			}
			Utilities.LogInformation($"RefreshRegisteredProviders - Complete on {_RegisteredProviders.Count} settings providers");
		}
		catch (Exception arg)
		{
			Utilities.LogError($"RefreshRegisteredProviders in Roblox.Configuration.Provider failed with the following\n {arg}");
		}
		finally
		{
			_Timer.Unpause();
		}
	}

	private static GroupConfigElement GetGroupConfiguration(string groupName = "*")
	{
		GroupConfigElement result = null;
		if (_RobloxConfigurationSection != null)
		{
			result = _RobloxConfigurationSection.GroupConfigs[groupName] ?? _RobloxConfigurationSection.GroupConfigs["*"];
		}
		return result;
	}

	public override void Initialize(string name, NameValueCollection col)
	{
		if (string.IsNullOrEmpty(name))
		{
			name = ((object)this).GetType().FullName;
		}
		((ProviderBase)this).Initialize(name, col);
	}

	public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
	{
		OneTimeInitializeFromContext(context);
		if (_AlternateSettings != null)
		{
			return _AlternateSettings.GetPropertyValues(context, collection);
		}
		LoadLocalOverrides(collection, out var settingsPropertyValueCollection, out var settingsProperties);
		if (_ConfigurationClient == null)
		{
			return settingsPropertyValueCollection;
		}
		int maxAttempts = ((!_IsFirstFetch) ? 1 : 20);
		DateTime minValue = DateTime.MinValue;
		if (_HasSettings)
		{
			UpdateSettingsFromService(settingsProperties, maxAttempts, minValue);
		}
		if (_HasConnectionStrings)
		{
			UpdateConnectionStringsFromService(settingsProperties, maxAttempts, minValue);
		}
		return settingsPropertyValueCollection;
	}

	private void LoadLocalOverrides(SettingsPropertyCollection collection, out SettingsPropertyValueCollection settingsPropertyValueCollection, out Dictionary<string, SettingsPropertyValue> settingsProperties)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		settingsPropertyValueCollection = new SettingsPropertyValueCollection();
		settingsProperties = new Dictionary<string, SettingsPropertyValue>(collection.Count);
		foreach (SettingsProperty item in collection)
		{
			SettingsProperty val = item;
			SettingsPropertyValue val2 = new SettingsPropertyValue(val);
			string settingName = $"{_GroupName}.{val.Name}";
			if (TryGetOverriddenSettingValue(settingName, out var overriddenValue))
			{
				val2.PropertyValue = overriddenValue;
			}
			settingsPropertyValueCollection.Add(val2);
			settingsProperties[val.Name] = val2;
		}
	}

	private void UpdateSettingsFromService(Dictionary<string, SettingsPropertyValue> settingsProperties, int maxAttempts, DateTime lastModification)
	{
		IReadOnlyCollection<ISetting> readOnlyCollection = _ConfigurationServiceFetcher.FetchWithRetries(_ConfigurationServiceFetcher.GetAllSettings, _GroupName, maxAttempts);
		_IsFirstFetch = false;
		List<string> list = new List<string>();
		foreach (ISetting item in readOnlyCollection)
		{
			if (item.Updated > lastModification)
			{
				lastModification = item.Updated;
			}
			if (!settingsProperties.TryGetValue(item.Name, out var value))
			{
				list.Add(item.Name);
				continue;
			}
			string settingName = $"{_GroupName}.{item.Name}";
			if (TryGetOverriddenSettingValue(settingName, out var overriddenValue))
			{
				value.SerializedValue = overriddenValue;
			}
			else
			{
				value.SerializedValue = item.Value;
			}
		}
		if (list.Count > 0)
		{
			Utilities.LogWarning(BuildUnknownSettingsMessage(list, "Settings"));
		}
		_LastSettingModificationDateTime = lastModification;
	}

	private void UpdateConnectionStringsFromService(Dictionary<string, SettingsPropertyValue> settingsProperties, int maxAttempts, DateTime lastModification)
	{
		IReadOnlyCollection<IConnectionString> readOnlyCollection = _ConfigurationServiceFetcher.FetchWithRetries(_ConfigurationServiceFetcher.GetAllConnectionStrings, _GroupName, maxAttempts);
		_IsFirstFetch = false;
		List<string> list = new List<string>();
		foreach (IConnectionString item in readOnlyCollection)
		{
			if (item.Updated > lastModification)
			{
				lastModification = item.Updated;
			}
			if (!settingsProperties.TryGetValue(item.Name, out var value))
			{
				list.Add(item.Name);
			}
			else
			{
				value.SerializedValue = item.Value;
			}
		}
		if (list.Count > 0)
		{
			Utilities.LogWarning(BuildUnknownSettingsMessage(list, "Connection Strings"));
		}
		_LastConnectionStringModificationDateTime = lastModification;
	}

	private bool TryGetOverriddenSettingValue(string settingName, out object overriddenValue)
	{
		overriddenValue = null;
		if (_OverriddenSettings != null && _OverriddenSettings.TryGetValue(settingName, out var value))
		{
			overriddenValue = value;
			return true;
		}
		return false;
	}

	public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		OneTimeInitializeFromContext(context);
		if (_AlternateSettings != null)
		{
			_AlternateSettings.SetPropertyValues(context, collection);
			return;
		}
		if (_ConfigurationClient == null)
		{
			throw new ConfigurationErrorsException("SettingsService endpoint is not defined.");
		}
		foreach (SettingsPropertyValue item in collection)
		{
			SettingsPropertyValue val = item;
			SettingsSerializeAs serializeAs = val.Property.SerializeAs;
			if ((int)serializeAs != 0)
			{
				Utilities.LogWarning($"Property {_GroupName}.{val.Name} cannot be saved because it serializes as {serializeAs}");
			}
			else
			{
				SaveProperty(val);
			}
		}
	}

	private void OneTimeInitializeFromContext(SettingsContext context)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Utilities.LogInformation($"OneTimeInitializeFromContext from {context}");
		if (!_OneTimeInitializeComplete)
		{
			try
			{
				_GroupName = (string)((Hashtable)(object)context)[(object)"GroupName"];
			}
			catch (Exception ex)
			{
				throw new ConfigurationErrorsException("Invalid or missing GroupName", ex);
			}
			Utilities.LogInformation($"ProviderBase identifying settings for {_GroupName}");
			DetectSettingsAndConnectionStringInClass(context);
			GroupConfigElement groupConfiguration = GetGroupConfiguration(_GroupName);
			DetectFileSystemOverridesForGroup(groupConfiguration);
			if (string.IsNullOrEmpty(groupConfiguration?.ConfigurationServiceEndpoint))
			{
				DetectAlternateSettings();
			}
			_OneTimeInitializeComplete = true;
		}
	}

	private void DetectSettingsAndConnectionStringInClass(SettingsContext context)
	{
		bool flag = false;
		bool flag2 = false;
		try
		{
			PropertyInfo[] array = (((Hashtable)(object)context)[(object)"SettingsClassType"] as Type)?.GetProperties();
			if (array == null)
			{
				return;
			}
			PropertyInfo[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].GetCustomAttributes(inherit: true).OfType<SpecialSettingAttribute>().Any((SpecialSettingAttribute specialSettingAttribute) => (int)specialSettingAttribute.SpecialSetting == 0))
				{
					flag2 = true;
				}
				else
				{
					flag = true;
				}
				if (flag && flag2)
				{
					break;
				}
			}
			_HasSettings = flag;
			_HasConnectionStrings = flag2;
		}
		catch (Exception ex)
		{
			Utilities.LogError(ex.ToString());
		}
	}

	private void DetectFileSystemOverridesForGroup(GroupConfigElement config)
	{
		_OverriddenSettingsFileName = config?.OverrideFileName;
		_OverriddenSettings = FileBasedSettingsOverrideHelper.ReadOverriddenSettingsFromFilePath(_OverriddenSettingsFileName, Utilities.LogError);
	}

	private void DetectAlternateSettings()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		Utilities.LogInformation("Group {0} is using file-based configuration", _GroupName);
		_AlternateSettings = (SettingsProvider)new LocalFileSettingsProvider();
		((ProviderBase)_AlternateSettings).Initialize((string)null, (NameValueCollection)null);
	}

	private void SaveProperty(SettingsPropertyValue settingsPropertyValue)
	{
		string name = settingsPropertyValue.Name;
		string fullName = settingsPropertyValue.Property.PropertyType.FullName;
		string value = (string)settingsPropertyValue.SerializedValue;
		DateTime timestamp = Utilities.GetTimestamp();
		if (IsConnectionString(settingsPropertyValue))
		{
			_LastConnectionStringModificationDateTime = timestamp;
		}
		else
		{
			_LastSettingModificationDateTime = timestamp;
		}
		try
		{
			_ConfigurationClient.SetProperty(_GroupName, name, fullName, value, timestamp);
		}
		catch (Exception ex)
		{
			Utilities.LogError(ex.ToString());
		}
	}

	private bool IsConnectionString(SettingsPropertyValue settingsPropertyValue)
	{
		if (!_HasConnectionStrings)
		{
			return false;
		}
		return ConfigurationManager.ConnectionStrings[_GroupName + "." + settingsPropertyValue.Name] != null;
	}

	private string BuildUnknownSettingsMessage(List<string> unknownSettings, string settingType)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"The following unknown {settingType} are defined in group: {_GroupName}");
		stringBuilder.AppendLine();
		int num = 0;
		foreach (string unknownSetting in unknownSettings)
		{
			if (stringBuilder.Length < 20000)
			{
				stringBuilder.Append(unknownSetting);
				stringBuilder.Append(", ");
				num++;
				continue;
			}
			stringBuilder.Append($" and {unknownSettings.Count - num} others. Message Truncated.");
			break;
		}
		return stringBuilder.ToString();
	}

	private void ReloadChangedSettings()
	{
		try
		{
			if (_ApplicationSettings == null)
			{
				Utilities.LogWarning($"RegisterSettings in {_GroupName}.OnSettingsLoaded was not invoked. Setting changes made through the service will not be synchronized to this process.");
				return;
			}
			if (HasOverriddenSettingsFileBeenModified(out var newModificationTime))
			{
				_OverriddenSettings = FileBasedSettingsOverrideHelper.ReadOverriddenSettingsFromFilePath(_OverriddenSettingsFileName);
				_LastFileBasedOverrideModificationDateTime = newModificationTime;
				_ApplicationSettings.Reload();
			}
			if ((_HasSettings && _ConfigurationClient.SettingUpdatesAreAvailable(_GroupName, _LastSettingModificationDateTime)) || (_HasConnectionStrings && _ConfigurationClient.ConnectionStringUpdatesAreAvailable(_GroupName, _LastConnectionStringModificationDateTime)))
			{
				Utilities.LogInformation($"Changes detected for Group {_GroupName}. Reloading settings.");
				_ApplicationSettings.Reload();
			}
		}
		catch (Exception ex)
		{
			Utilities.LogError(ex.ToString());
		}
	}

	private bool HasOverriddenSettingsFileBeenModified(out DateTime newModificationTime)
	{
		if (!string.IsNullOrWhiteSpace(_OverriddenSettingsFileName))
		{
			try
			{
				DateTime dateTime = (newModificationTime = File.GetLastWriteTime(_OverriddenSettingsFileName));
				return _LastFileBasedOverrideModificationDateTime < dateTime;
			}
			catch (Exception arg)
			{
				Utilities.LogWarning($"There was an exception while fetching last modification time for settings override filename:{_OverriddenSettingsFileName}. Exception:{arg}");
			}
		}
		newModificationTime = _LastFileBasedOverrideModificationDateTime;
		return false;
	}

	private void UpdateApplicationSettings(ApplicationSettingsBase applicationSettings)
	{
		if (_ApplicationSettings != applicationSettings)
		{
			if (_ApplicationSettings != null)
			{
				throw new InvalidOperationException("RegisterSettings changing applicationSettings");
			}
			_ApplicationSettings = applicationSettings;
		}
	}
}
