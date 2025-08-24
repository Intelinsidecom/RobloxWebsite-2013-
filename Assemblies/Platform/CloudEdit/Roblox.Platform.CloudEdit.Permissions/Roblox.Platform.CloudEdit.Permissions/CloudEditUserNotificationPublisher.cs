using System;
using Roblox.EventLog;
using Roblox.Platform.CloudEdit.Permissions.Properties;
using Roblox.Platform.Core;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Class which we are using for publishing real-time notifications to CloudEdit members
/// </summary>
internal class CloudEditUserNotificationPublisher
{
	private readonly Func<bool> _IsUserAddedToCloudEditNotificationEnabledFunc;

	private readonly UserNotificationPublisher<CloudEditUpdateNotificationMessage> _UserNotificationPublisher;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditUserNotificationPublisher" /> class.
	/// </summary>
	/// <param name="logger">The logger <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="isUserAddedToCloudEditNotificationEnabledFunc"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// Thrown when either of arguments is null
	/// </exception>
	public CloudEditUserNotificationPublisher(ILogger logger, Func<bool> isUserAddedToCloudEditNotificationEnabledFunc)
	{
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		if (isUserAddedToCloudEditNotificationEnabledFunc == null)
		{
			throw new PlatformArgumentNullException("isUserAddedToCloudEditNotificationEnabledFunc");
		}
		_IsUserAddedToCloudEditNotificationEnabledFunc = isUserAddedToCloudEditNotificationEnabledFunc;
		_UserNotificationPublisher = new UserNotificationPublisher<CloudEditUpdateNotificationMessage>(logger, "CloudEditNotifications");
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditUserNotificationPublisher" /> class.
	/// </summary>
	/// <param name="logger">The logger <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// Thrown when <paramref name="logger" /> is null
	/// </exception>
	public CloudEditUserNotificationPublisher(ILogger logger)
		: this(logger, () => Settings.Default.IsRealTimeNotificationForInvitationToTeamCreateEnabled)
	{
	}

	/// <summary>
	/// Notifies the specified user that he has been added to CloudEdit.
	/// </summary>
	/// <param name="addresseeUserId">The addressee user identifier.</param>
	/// <param name="inviterUserId">The inviter user identifier.</param>
	/// <param name="universeId">The universe identifier.</param>
	public void UserAddedToCloudEdit(long addresseeUserId, long inviterUserId, long universeId)
	{
		if (_IsUserAddedToCloudEditNotificationEnabledFunc())
		{
			CloudEditUpdateNotificationMessage notification = new CloudEditUpdateNotificationMessage(inviterUserId, universeId, CloudEditUpdateNotificationType.AddedToCloudEdit);
			_UserNotificationPublisher.Publish(addresseeUserId, notification);
		}
	}
}
