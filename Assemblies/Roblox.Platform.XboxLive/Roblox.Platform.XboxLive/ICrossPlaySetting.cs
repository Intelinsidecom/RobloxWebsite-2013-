using System;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// Determines whether the user has enabled or disabled CrossPlay
/// </summary>
public interface ICrossPlaySetting
{
	/// <summary>
	/// Gets the user identifier.
	/// </summary>
	/// <value>
	/// The user identifier.
	/// </value>
	long UserId { get; }

	/// <summary>
	/// Gets a value indicating whether this instance is enabled.
	/// </summary>
	/// <value>
	///   <c>true</c> CrossPlay is enabled; otherwise, <c>false</c>.
	/// </value>
	bool IsEnabled { get; }

	/// <summary>
	/// Gets the created Date.
	/// </summary>
	/// <value>
	/// The created Date.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Gets the updated date.
	/// </summary>
	/// <value>
	/// The updated Date.
	/// </value>
	DateTime Updated { get; }

	void SetEnabled(bool enabled);
}
