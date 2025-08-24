using System;
using Roblox.Platform.Assets.Places.Entities;
using Roblox.Platform.Assets.Places.Enums;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets.Places;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Assets.Places.IGameInstanceConstraintFactory" />
/// </summary>
public class GameInstanceConstraintFactory : IGameInstanceConstraintFactory
{
	private readonly IUserFactory _UserFactory;

	internal virtual PlaceAttributesDomainFactories _DomainFactories { get; }

	/// <summary>
	/// Default Constructor
	/// </summary>
	/// <param name="domainFactories"><see cref="T:Roblox.Platform.Assets.Places.PlaceAttributesDomainFactories" /></param>
	/// <param name="userFactory"><see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	public GameInstanceConstraintFactory(PlaceAttributesDomainFactories domainFactories, IUserFactory userFactory)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	/// <inheritdoc />
	public IGameInstanceConstraint GetOrCreate(IPlace place)
	{
		if (place == null)
		{
			throw new ArgumentNullException("place");
		}
		IGameConstraintEntity entity = _DomainFactories.ConstraintEntityFactory.GetByPlaceId(place.Id);
		if (entity == null)
		{
			entity = _DomainFactories.ConstraintEntityFactory.GetOrCreate(place.Id, _DomainFactories.Settings.MaxPlayersDefault);
			if (IsSocialSlotTypesEnabled(place.CreatorTargetId))
			{
				entity.SocialSlotTypeID = _DomainFactories.SocialSlotTypeEntityFactory.GetByValue(Roblox.Platform.Assets.Places.Enums.SocialSlotType.Automatic.ToString()).Id;
			}
			else
			{
				entity.SocialSlots = _DomainFactories.Settings.SocialSlotsDefault;
			}
			entity.Update();
		}
		else if (IsSocialSlotTypesEnabled(place.CreatorTargetId) && !entity.SocialSlotTypeID.HasValue)
		{
			entity.SocialSlotTypeID = _DomainFactories.SocialSlotTypeEntityFactory.GetByValue(Roblox.Platform.Assets.Places.Enums.SocialSlotType.Automatic.ToString()).Id;
			entity.Update();
		}
		if (entity.SocialSlotTypeID == _DomainFactories.SocialSlotTypeEntityFactory.GetByValue(Roblox.Platform.Assets.Places.Enums.SocialSlotType.Automatic.ToString()).Id)
		{
			int? entitySocialSlots = entity.SocialSlots;
			int calculatedSocialSlots = SocialSlotsCalculation.CalculateSocialSlots(entity.MaxPlayers);
			entity.SocialSlots = calculatedSocialSlots;
			if (entitySocialSlots != calculatedSocialSlots)
			{
				entity.Update();
			}
		}
		return new GameInstanceConstraint(entity, _DomainFactories);
	}

	public Roblox.Platform.Assets.Places.Enums.SocialSlotType GetSocialSlotType(int? id)
	{
		int socialSlotTypeID = id ?? _DomainFactories.SocialSlotTypeEntityFactory.GetByValue(Roblox.Platform.Assets.Places.Enums.SocialSlotType.Automatic.ToString()).Id;
		string socialSlotType = _DomainFactories.SocialSlotTypeEntityFactory.Get(socialSlotTypeID).Value;
		return (Roblox.Platform.Assets.Places.Enums.SocialSlotType)Enum.Parse(typeof(Roblox.Platform.Assets.Places.Enums.SocialSlotType), socialSlotType);
	}

	internal virtual bool IsSocialSlotTypesEnabled(long? userId)
	{
		if (!userId.HasValue)
		{
			return false;
		}
		try
		{
			return _UserFactory.MustGetUser(userId.Value).IsSocialSlotTypesEnabled();
		}
		catch (Exception)
		{
			return false;
		}
	}
}
