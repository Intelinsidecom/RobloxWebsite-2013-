using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Roblox.Platform.Assets;
using Roblox.Platform.CloudEdit.Permissions.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Platform.Social.Messages;
using Roblox.Platform.Universes;
using Roblox.Web.SEO;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Sends system messages about CloudEdit events
/// </summary>
internal class CloudEditUpdateSystemMessageSender
{
	private readonly ISystemMessageSender _SystemMessageSender;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly Func<int> _GetPlacesLinksMaximumFunc;

	private readonly Func<bool> _IsSystemMessageForInvitationToTeamCreateEnabledFunc;

	private readonly IPlaceFactory _PlaceFactory;

	private const string _TeamCreateInvitationMessageTemplate = "{0} has invited you to work on their {1} game. {2}";

	private const string _TeamCreateInvitationMessagePlaceLinksPrefix = "You may join them by following one of the links below.<br/><br/>";

	private const string _TeamCreateInvitationMessageSubject = "Team Create invitation";

	private const string _PlaceLinkTemplate = "<a href=\"/games/{0}/{1}\" class=\"text-link\">{2}</a><br/>";

	private const string _UserLinkTemplate = "<a href=\"/users/{0}/profile/\" class=\"text-link\">{1}</a>";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditUpdateSystemMessageSender" /> class.
	/// </summary>
	/// <param name="systemMessageSender">The system message sender <see cref="T:Roblox.Platform.Social.Messages.ISystemMessageSender" />&gt;.</param>
	/// <param name="universeFactory">The universe factory <see cref="T:Roblox.Platform.Universes.IUniverseFactory" />.</param>
	/// <param name="placeFactory">The place factory <see cref="T:Roblox.Platform.Assets.IPlaceFactory" />.</param>
	/// <param name="getPlacesLinksMaximumFunc">Function which has to return maximum amount of place links in message.</param>
	/// <param name="isSystemMessageForInvitationToTeamCreateEnabledFunc">
	/// Function which has to return true when SystemMessageForInvitationToTeamCreate is enabled, otherwise false.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// Thrown when either of arguments is null
	/// </exception>
	public CloudEditUpdateSystemMessageSender(ISystemMessageSender systemMessageSender, IUniverseFactory universeFactory, IPlaceFactory placeFactory, Func<int> getPlacesLinksMaximumFunc, Func<bool> isSystemMessageForInvitationToTeamCreateEnabledFunc)
	{
		if (systemMessageSender == null)
		{
			throw new PlatformArgumentNullException("systemMessageSender");
		}
		if (universeFactory == null)
		{
			throw new PlatformArgumentNullException("universeFactory");
		}
		if (getPlacesLinksMaximumFunc == null)
		{
			throw new PlatformArgumentNullException("getPlacesLinksMaximumFunc");
		}
		if (isSystemMessageForInvitationToTeamCreateEnabledFunc == null)
		{
			throw new PlatformArgumentNullException("isSystemMessageForInvitationToTeamCreateEnabledFunc");
		}
		if (placeFactory == null)
		{
			throw new PlatformArgumentNullException("placeFactory");
		}
		_SystemMessageSender = systemMessageSender;
		_UniverseFactory = universeFactory;
		_GetPlacesLinksMaximumFunc = getPlacesLinksMaximumFunc;
		_IsSystemMessageForInvitationToTeamCreateEnabledFunc = isSystemMessageForInvitationToTeamCreateEnabledFunc;
		_PlaceFactory = placeFactory;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CloudEdit.Permissions.CloudEditUpdateSystemMessageSender" /> class.
	/// </summary>
	/// <param name="systemMessageSender">The system message sender.</param>
	/// <param name="universeFactory">The universe factory.</param>
	/// <param name="placeFactory">The place factory.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// Thrown when either of arguments is null
	/// </exception>
	public CloudEditUpdateSystemMessageSender(ISystemMessageSender systemMessageSender, IUniverseFactory universeFactory, IPlaceFactory placeFactory)
		: this(systemMessageSender, universeFactory, placeFactory, () => Settings.Default.AmountOfPlacesLinksInTeamCreateInvitationMessage, () => Settings.Default.IsSystemMessageForInvitationToTeamCreateEnabled)
	{
	}

	public void SendCloudEditInvitationMessage(IUniverse universe, IUser recipient, IUser inviter)
	{
		if (!_IsSystemMessageForInvitationToTeamCreateEnabledFunc())
		{
			return;
		}
		if (universe == null)
		{
			throw new PlatformArgumentNullException("universe");
		}
		if (recipient == null)
		{
			throw new PlatformArgumentNullException("recipient");
		}
		if (inviter == null)
		{
			throw new PlatformArgumentNullException("inviter");
		}
		List<long> placeIdsToSend = new List<long>();
		int placesLinksMaximum = _GetPlacesLinksMaximumFunc();
		if (universe.RootPlaceId.HasValue)
		{
			placeIdsToSend.Add(universe.RootPlaceId.Value);
			placesLinksMaximum--;
		}
		long totalCount;
		IEnumerable<long> placeIds = _UniverseFactory.GetUniversePlaceIdsPaged(universe.Id, 1, out totalCount, isUniverseCreation: false);
		if (placeIds != null && placeIds.Any())
		{
			placeIdsToSend.AddRange(placeIds.Where((long pId) => !placeIdsToSend.Contains(pId)).Take(placesLinksMaximum));
		}
		StringBuilder placeLinksSb = new StringBuilder();
		if (placeIdsToSend.Any())
		{
			placeLinksSb.Append("You may join them by following one of the links below.<br/><br/>");
			foreach (IPlace place in placeIdsToSend.Select((long placeId) => _PlaceFactory.Get(placeId)))
			{
				placeLinksSb.AppendFormat("<a href=\"/games/{0}/{1}\" class=\"text-link\">{2}</a><br/>", place.Id, NameConverter.ConvertToSEO(place.Name), HttpUtility.HtmlEncode(place.Name));
			}
		}
		string invitorLink = $"<a href=\"/users/{inviter.Id}/profile/\" class=\"text-link\">{HttpUtility.HtmlEncode(inviter.Name)}</a>";
		string message = $"{invitorLink} has invited you to work on their {HttpUtility.HtmlEncode(universe.Name)} game. {placeLinksSb}";
		SendResult sendResult = _SystemMessageSender.Send("Team Create invitation", message, recipient);
		if (sendResult == SendResult.Success)
		{
			return;
		}
		throw new PlatformOperationUnavailableException($"SystemMessageSender returned '{sendResult}' on Send method call. Recipient id: {recipient.Id}");
	}
}
