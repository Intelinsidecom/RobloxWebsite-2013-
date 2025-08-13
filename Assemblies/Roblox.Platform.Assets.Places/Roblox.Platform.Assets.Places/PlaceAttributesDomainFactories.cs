using Roblox.Platform.Assets.Places.Entities;
using Roblox.Platform.Assets.Places.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Places;

public class PlaceAttributesDomainFactories : DomainFactoriesBase
{
	internal virtual ISettings Settings { get; }

	internal virtual IPlaceAttributeEntityFactory AttributeEntityFactory { get; }

	internal virtual IGameConstraintEntityFactory ConstraintEntityFactory { get; }

	internal virtual ISocialSlotTypeEntityFactory SocialSlotTypeEntityFactory { get; }

	public virtual IPlaceAttributeFactory PlaceAttributeFactory { get; }

	public PlaceAttributesDomainFactories()
	{
		Settings = Roblox.Platform.Assets.Places.Properties.Settings.Default;
		AttributeEntityFactory = new PlaceAttributeEntityFactory(this);
		ConstraintEntityFactory = new GameConstraintEntityFactory();
		SocialSlotTypeEntityFactory = new SocialSlotTypeEntityFactory();
		PlaceAttributeFactory = new PlaceAttributeFactory(this);
	}
}
