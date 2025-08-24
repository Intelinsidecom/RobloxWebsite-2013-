using System;
using Roblox.EventLog;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Party.Events;

public class PartyChangeEventsHandler : IPartyChangeEventsHandler
{
	public delegate void OnPartyEvent(Guid partyId, WalledGarden walledGarden);

	public delegate void OnUserSpecificPartyEvent(Guid partyId, IUser user, WalledGarden walledGarden);

	private readonly IPartyEventsPublisher _PartyEventsPublisher;

	private readonly ILogger _Logger;

	public PartyChangeEventsHandler(IPartyEventsPublisher partyEventsPublisher, ILogger logger)
	{
		_PartyEventsPublisher = partyEventsPublisher;
		_Logger = logger;
	}

	public void OnPartyReadyToBeDeleted(Guid partyId)
	{
		try
		{
			_PartyEventsPublisher.Publish(partyId, PartyEventType.PartyReadyToBeDeleted);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void OnPartyCreated(Guid partyId)
	{
		try
		{
			_PartyEventsPublisher.Publish(partyId, PartyEventType.PartyCreated);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void OnPartyInvitationAccepted(Guid partyId, IUser user)
	{
		try
		{
			_PartyEventsPublisher.Publish(partyId, PartyEventType.PartyInvitationAccepted, user.Id);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void OnPartyInvitationSent(Guid partyId, IUser user)
	{
		try
		{
			_PartyEventsPublisher.Publish(partyId, PartyEventType.PartyInvitationSent, user.Id);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	public void OnPartyMemberLeft(Guid partyId, IUser user)
	{
		try
		{
			_PartyEventsPublisher.Publish(partyId, PartyEventType.PartyMemberLeft, user.Id);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}
}
