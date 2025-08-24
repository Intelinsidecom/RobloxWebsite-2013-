using System.ComponentModel;

namespace Roblox.Platform.Moderation.Properties;

public interface ISqsSettings : INotifyPropertyChanged
{
	string SqsTaskClientConfigSettingsUnk { get; }

	string SqsTaskClientConfigSettingsEs { get; }

	string SqsTaskClientConfigSettingsZhcn { get; }

	string SqsTaskClientConfigSettingsZhtw { get; }

	string SqsTaskClientConfigSettingsDe { get; }

	string SqsTaskClientConfigSettingsPt { get; }

	string SqsTaskClientConfigSettingsFr { get; }

	string SqsTaskClientConfigSettingsKo { get; }
}
