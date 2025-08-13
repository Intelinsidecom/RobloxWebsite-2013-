using System;
using System.Runtime.Serialization;

namespace Roblox.Configuration.Client;

[DataContract]
public class Setting : ISetting
{
	[DataMember(Name = "Id")]
	public int Id { get; set; }

	[DataMember(Name = "GroupName")]
	public string GroupName { get; set; }

	[DataMember(Name = "Name")]
	public string Name { get; set; }

	[DataMember(Name = "Type")]
	public string Type { get; set; }

	[DataMember(Name = "Value")]
	public string Value { get; set; }

	[DataMember(Name = "ValueUri")]
	public string ValueUri { get; set; }

	[DataMember(Name = "Comment")]
	public string Comment { get; set; }

	[DataMember(Name = "IsEnvironmentSpecific")]
	public bool IsEnvironmentSpecific { get; set; }

	[DataMember(Name = "Updated")]
	public DateTime Updated { get; set; }

	[DataMember(Name = "IsMasked")]
	public bool IsMasked { get; set; }

	[DataMember(Name = "IsValueSameForAllTestEnvironments")]
	public bool IsValueSameForAllTestEnvironments { get; set; }

	[DataMember(Name = "IsValueUniqueForProduction")]
	public bool IsValueUniqueForProduction { get; set; }

	[DataMember(Name = "Priority")]
	public int Priority { get; set; }

	[DataMember(Name = "Conditions")]
	public SettingConditions Conditions { get; set; }

	public SettingFlags Flags
	{
		get
		{
			SettingFlags settingFlags = SettingFlags.None;
			if (IsEnvironmentSpecific)
			{
				settingFlags |= SettingFlags.EnvironmentSpecific;
			}
			if (IsValueSameForAllTestEnvironments)
			{
				settingFlags |= SettingFlags.TestEnvironmentsMatch;
			}
			if (IsValueUniqueForProduction)
			{
				settingFlags |= SettingFlags.ProductionUnique;
			}
			if (IsMasked)
			{
				settingFlags |= SettingFlags.Masked;
			}
			return settingFlags;
		}
	}

	public Setting()
	{
	}

	public Setting(Setting setting)
	{
		if (setting == null)
		{
			throw new ArgumentNullException("setting");
		}
		Id = setting.Id;
		GroupName = setting.GroupName;
		Name = setting.Name;
		Type = setting.Type;
		Value = setting.Value;
		ValueUri = setting.ValueUri;
		Comment = setting.Comment;
		IsEnvironmentSpecific = setting.IsEnvironmentSpecific;
		Updated = setting.Updated;
		IsMasked = setting.IsMasked;
		IsValueSameForAllTestEnvironments = setting.IsValueSameForAllTestEnvironments;
		IsValueUniqueForProduction = setting.IsValueUniqueForProduction;
		Priority = setting.Priority;
		Conditions = setting.Conditions;
	}
}
