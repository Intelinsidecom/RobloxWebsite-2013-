using System;
using Roblox.EventLog;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Social.Messages;
using Roblox.Platform.Universes;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Register event handlers on events related to CloudEdit instances 
/// </summary>
public class CloudEditEventHandlerRegistrar : ICloudEditEventHandlerRegistrar
{
	private readonly CloudEditUpdateSystemMessageSender _CloudEditUpdateSystemMessageSender;

	private readonly CloudEditUserNotificationPublisher _CloudEditUserNotificationPublisher;

	private readonly ILogger _Logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditEventHandlerRegistrar" /> class.
	/// </summary>
	/// <param name="systemMessageSender">The system message sender <see cref="T:Roblox.Platform.Social.Messages.ISystemMessageSender" />.</param>
	/// <param name="universeFactory">The universe factory <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="placeFactory">The place factory <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="logger">The logger <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// Thrown when any of arguments is null
	/// </exception>
	public CloudEditEventHandlerRegistrar(ISystemMessageSender systemMessageSender, IUniverseFactory universeFactory, IPlaceFactory placeFactory, ILogger logger)
	{
		if (systemMessageSender == null)
		{
			throw new PlatformArgumentNullException("systemMessageSender");
		}
		if (universeFactory == null)
		{
			throw new PlatformArgumentNullException("universeFactory");
		}
		if (placeFactory == null)
		{
			throw new PlatformArgumentNullException("placeFactory");
		}
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		_CloudEditUpdateSystemMessageSender = new CloudEditUpdateSystemMessageSender(systemMessageSender, universeFactory, placeFactory);
		_CloudEditUserNotificationPublisher = new CloudEditUserNotificationPublisher(logger);
		_Logger = logger;
	}

	/// <inheritdoc cref="M:Roblox.Platform.CloudEdit.Permissions.ICloudEditEventHandlerRegistrar.OnUserAddedToCloudEdit(Roblox.Platform.Universes.IUniverse,Roblox.Platform.Membership.IUser,Roblox.Platform.Membership.IUser)" />
	public void OnUserAddedToCloudEdit(IUniverse universe, IUser invitingUser, IUser addedUser)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (invitingUser == null)
		{
			throw new ArgumentNullException("invitingUser");
		}
		if (addedUser == null)
		{
			throw new ArgumentNullException("addedUser");
		}
		try
		{
			_CloudEditUpdateSystemMessageSender.SendCloudEditInvitationMessage(universe, addedUser, invitingUser);
		}
		catch (PlatformOperationUnavailableException ex2)
		{
			_Logger.Error(ex2);
		}
		try
		{
			_CloudEditUserNotificationPublisher.UserAddedToCloudEdit(addedUser.Id, invitingUser.Id, universe.Id);
		}
		catch (PlatformOperationUnavailableException ex)
		{
			_Logger.Error(ex);
		}
	}
}
