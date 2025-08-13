using System.Configuration;

namespace Roblox.Configuration;

public class ProviderConfigSection : ConfigurationSection
{
	private static readonly ConfigurationPropertyCollection _Properties;

	private static readonly ConfigurationProperty _IsDatabaseWritableProperty;

	private static readonly ConfigurationProperty _GroupConfigs;

	public bool IsDatabaseReadonly
	{
		get
		{
			return !(bool)((ConfigurationElement)this)[_IsDatabaseWritableProperty];
		}
		set
		{
			((ConfigurationElement)this)[_IsDatabaseWritableProperty] = !value;
		}
	}

	public GroupConfigElements GroupConfigs => (GroupConfigElements)((ConfigurationElement)this)[_GroupConfigs];

	protected override ConfigurationPropertyCollection Properties => _Properties;

	static ProviderConfigSection()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		_Properties = new ConfigurationPropertyCollection();
		_IsDatabaseWritableProperty = new ConfigurationProperty("isDatabaseWritable", typeof(bool), (object)false, (ConfigurationPropertyOptions)0);
		_Properties.Add(_IsDatabaseWritableProperty);
		_GroupConfigs = new ConfigurationProperty("groups", typeof(GroupConfigElements), (object)null, (ConfigurationPropertyOptions)2);
		_Properties.Add(_GroupConfigs);
	}
}
