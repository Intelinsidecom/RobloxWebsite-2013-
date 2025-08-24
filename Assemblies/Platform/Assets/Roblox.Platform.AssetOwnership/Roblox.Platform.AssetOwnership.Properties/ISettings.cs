using System.ComponentModel;

namespace Roblox.Platform.AssetOwnership.Properties;

internal interface ISettings : INotifyPropertyChanged
{
	bool UsingOv2AtAllEnabled { get; }

	string TeeShirtWriteStrategy { get; }

	int TeeShirtOv2WritePercentage { get; }

	string UserAssetShimClientApiKey { get; }

	float AssetResaleCommissionRate { get; }

	string AssetInstancesApiKey { get; }

	string Ov2ApiKey { get; }

	bool ErrorLogLevelForRemediationRequestRecorder { get; }
}
