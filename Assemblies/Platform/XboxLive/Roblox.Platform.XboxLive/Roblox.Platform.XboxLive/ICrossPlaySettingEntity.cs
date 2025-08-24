using Roblox.Entities;

namespace Roblox.Platform.XboxLive;

/// <summary>
/// Settings for user CrossPlay information.
/// </summary>
/// <seealso cref="!:Roblox.Entities.IUpdateableEntity&lt;System.Int64&gt;" />
internal interface ICrossPlaySettingEntity : IUpdateableEntity<long>, IEntity<long>
{
	/// <summary>
	/// Gets or sets the user identifier.
	/// </summary>
	/// <value>
	/// The user identifier.
	/// </value>
	long UserId { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether a user has opted out of CrossPlay.
	/// </summary>
	/// <value>
	///   <c>true</c> if the user has CrossPlay enabled otherwise, <c>false</c>.
	/// </value>
	bool IsEnabled { get; set; }
}
