using Roblox.Platform.Assets.Places.Enums;

namespace Roblox.Platform.Assets.Places;

public interface IGameInstanceConstraintFactory
{
	/// <exception cref="T:System.ArgumentNullException">Thrown if place is null</exception>
	IGameInstanceConstraint GetOrCreate(IPlace place);

	SocialSlotType GetSocialSlotType(int? id);
}
