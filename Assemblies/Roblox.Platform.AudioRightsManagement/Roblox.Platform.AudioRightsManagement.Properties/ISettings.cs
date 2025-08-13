using System;
using System.ComponentModel;

namespace Roblox.Platform.AudioRightsManagement.Properties;

/// <summary>
/// Settings for the Roblox.Platform.AudioRightsManagement namespace.
/// </summary>
internal interface ISettings : INotifyPropertyChanged
{
	/// <summary>
	/// The sns topic arn to to publish to.
	/// </summary>
	string AudioReviewEventsSnsTopicArn { get; }

	/// <summary>
	/// The account credentials to write to the sns topic.
	/// </summary>
	string AudioReviewEventsPublisherAwsAccessKeyAndSecretKey { get; }

	/// <summary>
	/// The csv of audio assets to replace blocked audio with.
	/// </summary>
	string ReplacementAudioAssetIds { get; }

	/// <summary>
	/// Whether the <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioReplacer" /> should actually replace audio.
	/// </summary>
	bool IsAudioReplacingEnabled { get; }

	/// <summary>
	/// How long to cache audio statuses?
	/// </summary>
	TimeSpan AudioCopyrightStatusCacheExpiration { get; }
}
