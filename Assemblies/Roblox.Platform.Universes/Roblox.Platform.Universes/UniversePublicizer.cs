using System;
using System.Net;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets;
using Roblox.Platform.GroupAssets;
using Roblox.Platform.Groups;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes.Properties;
using Roblox.Properties;
using Roblox.Universes.Client;

namespace Roblox.Platform.Universes;

/// <inheritdoc />
public class UniversePublicizer : IUniversePublicizer
{
	private readonly IUniversesClient _UniversesClient;

	private readonly IUserFactory _UserFactory;

	private readonly IPlaceFactory _PlaceFactory;

	private readonly IGroupFactory _GroupFactory;

	private readonly ISettings _Settings;

	/// <summary>
	/// Creates a UniversePublicizer, standard constructor
	/// </summary>
	/// <param name="universesClient">An <see cref="T:Roblox.Universes.Client.IUniversesClient" /></param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <param name="groupFactory">An <see cref="T:Roblox.Platform.Groups.IGroupFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universesClient" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="placeFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="groupFactory" /></exception>
	public UniversePublicizer(IUniversesClient universesClient, IUserFactory userFactory, IPlaceFactory placeFactory, IGroupFactory groupFactory)
		: this(universesClient, userFactory, placeFactory, groupFactory, Roblox.Platform.Universes.Properties.Settings.Default)
	{
	}

	internal UniversePublicizer(IUniversesClient universesClient, IUserFactory userFactory, IPlaceFactory placeFactory, IGroupFactory groupFactory, ISettings settings)
	{
		_UniversesClient = universesClient ?? throw new ArgumentNullException("universesClient");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
		_GroupFactory = groupFactory ?? throw new ArgumentNullException("groupFactory");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc />
	public void SetUniverseToPublic(IUniverse universe)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (CanSetUniverseToPublic(universe))
		{
			try
			{
				IPlace rootPlace = (universe.RootPlaceId.HasValue ? _PlaceFactory.Get(universe.RootPlaceId.Value) : null);
				if (rootPlace == null)
				{
					throw new ArgumentException("Universe does not have a root place.", "universe");
				}
				long creatorAgentId = rootPlace.GetCreatorAgentId(_GroupFactory);
				_UniversesClient.SetUniverseToPublic(universe.Id, creatorAgentId, rootPlace.Id);
				return;
			}
			catch (WebException)
			{
				throw new OperationUnavailableException();
			}
		}
		throw new PublicUniverseLimitReachedException("Unable to set universe to public.");
	}

	/// <inheritdoc />
	public void SetUniverseToPrivate(IUniverse universe)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		try
		{
			IPlace rootPlace = (universe.RootPlaceId.HasValue ? _PlaceFactory.Get(universe.RootPlaceId.Value) : null);
			if (rootPlace == null)
			{
				if (!_Settings.IsSettingUniversePrivacyTypeToPrivateOnMissingRootPlaceIdEnabled)
				{
					throw new ArgumentException("Universe does not have a root place.", "universe");
				}
				_UniversesClient.UpdateUniverse(universe.Id, universe.Name, universe.Description, universe.RootPlaceId, universe.StudioAccessToApisAllowed, universe.IsArchived, (PrivacyType?)(PrivacyType)0);
			}
			else
			{
				long creatorAgentId = rootPlace.GetCreatorAgentId(_GroupFactory);
				_UniversesClient.SetUniverseToPrivate(universe.Id, creatorAgentId, rootPlace.Id);
			}
		}
		catch (WebException)
		{
			throw new OperationUnavailableException();
		}
	}

	/// <summary>
	/// Determines if the <see cref="T:Roblox.Platform.Universes.IUniverse" /> can be made public.
	/// </summary>
	/// <param name="universe">The universe to check.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when the <paramref name="universe" /> is null</exception>
	/// <exception cref="T:Roblox.Common.OperationUnavailableException">Thrown when the universes service is unable to perform the operation.</exception>
	private bool CanSetUniverseToPublic(IUniverse universe)
	{
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		if (universe.CreatorType == CreatorType.Group.ToString())
		{
			return true;
		}
		IUser user = _UserFactory.GetUser(universe.CreatorTargetId);
		if (user == null)
		{
			throw new DataIntegrityException($"Missing creator with id {universe.CreatorTargetId} for universe with id {universe.Id}.");
		}
		try
		{
			return _UniversesClient.GetCreatorPublicUniverseCount("User", user.Id) < Roblox.Properties.Settings.Default.MaxActiveUniversesCount;
		}
		catch (WebException)
		{
			throw new OperationUnavailableException();
		}
	}
}
