using System;
using System.Configuration;

namespace Roblox.Configuration;

public class GroupConfigElement : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _Properties;

	private static readonly ConfigurationProperty _GroupNameProperty;

	private static readonly ConfigurationProperty _UpdateIntervalProperty;

	private static readonly ConfigurationProperty _ConfigurationServiceEndpointProperty;

	private static readonly ConfigurationProperty _UseConfigurationServiceEnabledProperty;

	private static readonly ConfigurationProperty _OverrideFileNameProperty;

	public string GroupName
	{
		get
		{
			return (string)((ConfigurationElement)this)[_GroupNameProperty];
		}
		set
		{
			((ConfigurationElement)this)[_GroupNameProperty] = value;
		}
	}

	public TimeSpan UpdateInterval
	{
		get
		{
			return (TimeSpan)((ConfigurationElement)this)[_UpdateIntervalProperty];
		}
		set
		{
			((ConfigurationElement)this)[_UpdateIntervalProperty] = value;
		}
	}

	public string ConfigurationServiceEndpoint
	{
		get
		{
			return (string)((ConfigurationElement)this)[_ConfigurationServiceEndpointProperty];
		}
		set
		{
			((ConfigurationElement)this)[_ConfigurationServiceEndpointProperty] = value;
		}
	}

	public bool UseConfigurationService
	{
		get
		{
			return (bool)((ConfigurationElement)this)[_UseConfigurationServiceEnabledProperty];
		}
		set
		{
			((ConfigurationElement)this)[_UseConfigurationServiceEnabledProperty] = value;
		}
	}

	public string OverrideFileName
	{
		get
		{
			return (string)((ConfigurationElement)this)[_OverrideFileNameProperty];
		}
		set
		{
			((ConfigurationElement)this)[_OverrideFileNameProperty] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => _Properties;

	static GroupConfigElement()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		_Properties = new ConfigurationPropertyCollection();
		_GroupNameProperty = new ConfigurationProperty("groupName", typeof(string), (object)null, (ConfigurationPropertyOptions)2);
		_Properties.Add(_GroupNameProperty);
		_UpdateIntervalProperty = new ConfigurationProperty("updateInterval", typeof(TimeSpan), (object)TimeSpan.Zero, (ConfigurationPropertyOptions)0);
		_Properties.Add(_UpdateIntervalProperty);
		_ConfigurationServiceEndpointProperty = new ConfigurationProperty("serviceEndpoint", typeof(string), (object)null, (ConfigurationPropertyOptions)2);
		_Properties.Add(_ConfigurationServiceEndpointProperty);
		_UseConfigurationServiceEnabledProperty = new ConfigurationProperty("useService", typeof(bool), (object)true, (ConfigurationPropertyOptions)0);
		_Properties.Add(_UseConfigurationServiceEnabledProperty);
		_OverrideFileNameProperty = new ConfigurationProperty("overrideFileName", typeof(string), (object)null, (ConfigurationPropertyOptions)0);
		_Properties.Add(_OverrideFileNameProperty);
	}
}
