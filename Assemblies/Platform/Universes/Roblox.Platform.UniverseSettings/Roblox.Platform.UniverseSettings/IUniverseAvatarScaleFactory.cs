using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseAvatarScaleFactory
{
	void SetUniverseAvatarScales(IUser user, long universeId, Scale minScale, Scale maxScale);
}
