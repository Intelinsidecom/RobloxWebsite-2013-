using System.Configuration;

namespace Roblox.Configuration;

public class GroupConfigElements : ConfigurationElementCollection
{
	public override ConfigurationElementCollectionType CollectionType => (ConfigurationElementCollectionType)0;

	protected override string ElementName => "group";

	protected override ConfigurationPropertyCollection Properties => new ConfigurationPropertyCollection();

	public GroupConfigElement this[int index]
	{
		get
		{
			return (GroupConfigElement)(object)((ConfigurationElementCollection)this).BaseGet(index);
		}
		set
		{
			if (((ConfigurationElementCollection)this).BaseGet(index) != null)
			{
				((ConfigurationElementCollection)this).BaseRemoveAt(index);
			}
			((ConfigurationElementCollection)this).BaseAdd(index, (ConfigurationElement)(object)value);
		}
	}

	public GroupConfigElement this[string name] => (GroupConfigElement)(object)((ConfigurationElementCollection)this).BaseGet((object)name);

	public void Add(GroupConfigElement item)
	{
		((ConfigurationElementCollection)this).BaseAdd((ConfigurationElement)(object)item);
	}

	public void Remove(GroupConfigElement item)
	{
		((ConfigurationElementCollection)this).BaseRemove((object)item);
	}

	public void RemoveAt(int index)
	{
		((ConfigurationElementCollection)this).BaseRemoveAt(index);
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return (ConfigurationElement)(object)new GroupConfigElement();
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return (element as GroupConfigElement).GroupName;
	}
}
