using System;
using Roblox.Platform.Assets.Places.Entities;
using Roblox.Platform.Assets.Places.Enums;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets.Places;

internal class GameInstanceConstraint : IGameInstanceConstraint
{
	internal long _PlaceId { get; }

	internal PlaceAttributesDomainFactories _DomainFactories { get; }

	public int MaxPlayers { get; private set; }

	public int SocialSlots { get; private set; }

	public int? SocialSlotTypeID { get; private set; }

	public GameInstanceConstraint(IGameConstraintEntity entity, PlaceAttributesDomainFactories domainFactories)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_PlaceId = entity.PlaceId;
		MaxPlayers = entity.MaxPlayers;
		SocialSlots = entity.SocialSlots ?? 0;
		SocialSlotTypeID = entity.SocialSlotTypeID;
	}

	public void SetMaxPlayers(int maxPlayers, IUser actingUser)
	{
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		int maxPlayersForRoleset = MaxPlayersForRoleset(actingUser);
		if (maxPlayers > maxPlayersForRoleset)
		{
			maxPlayers = maxPlayersForRoleset;
		}
		if (maxPlayers < _DomainFactories.Settings.MinPlayersPerPlace)
		{
			maxPlayers = _DomainFactories.Settings.MinPlayersPerPlace;
		}
		if (maxPlayers != MaxPlayers)
		{
			int socialSlots = ValidateSocialSlots(SocialSlots, maxPlayers);
			IGameConstraintEntity obj = _DomainFactories.ConstraintEntityFactory.GetByPlaceId(_PlaceId) ?? throw new InvalidOperationException($"Attempted to update nonexistant GameConstraint entity for place {_PlaceId}");
			obj.MaxPlayers = maxPlayers;
			obj.SocialSlots = socialSlots;
			obj.Update();
			MaxPlayers = maxPlayers;
			SocialSlots = socialSlots;
		}
	}

	public void SetSocialSlots(int socialSlots, IUser actingUser)
	{
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		IGameConstraintEntity entity = _DomainFactories.ConstraintEntityFactory.GetByPlaceId(_PlaceId);
		if (entity == null)
		{
			throw new InvalidOperationException($"Attempted to update nonexistant GameConstraint entity for place {_PlaceId}");
		}
		socialSlots = ValidateSocialSlots(socialSlots, MaxPlayers);
		if (socialSlots != SocialSlots)
		{
			entity.SocialSlots = socialSlots;
			entity.Update();
			SocialSlots = socialSlots;
		}
	}

	public void SetSocialSlotType(Roblox.Platform.Assets.Places.Enums.SocialSlotType socialSlotType, IUser actingUser)
	{
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		if (actingUser.IsSocialSlotTypesEnabled())
		{
			int socialID = _DomainFactories.SocialSlotTypeEntityFactory.GetByValue(socialSlotType.ToString()).Id;
			if (socialID != SocialSlotTypeID)
			{
				IGameConstraintEntity obj = _DomainFactories.ConstraintEntityFactory.GetByPlaceId(_PlaceId) ?? throw new InvalidOperationException($"Attempted to update nonexistant GameConstraint entity for place {_PlaceId}");
				obj.SocialSlotTypeID = socialID;
				obj.Update();
				SocialSlotTypeID = socialID;
			}
		}
	}

	internal virtual int MaxPlayersForRoleset(IUser actingUser)
	{
		if (actingUser.IsTrustedContributor() || actingUser.IsBetaTester())
		{
			return _DomainFactories.Settings.MaxPlayersPerBetaTesterPlace;
		}
		return _DomainFactories.Settings.MaxPlayersPerPlace;
	}

	private int ValidateSocialSlots(int socialSlots, int maxPlayers)
	{
		return Math.Max(0, Math.Min(socialSlots, maxPlayers - 1));
	}
}
