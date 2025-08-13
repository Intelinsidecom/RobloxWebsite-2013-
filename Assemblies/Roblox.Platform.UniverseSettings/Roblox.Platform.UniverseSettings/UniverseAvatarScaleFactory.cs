using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAvatarScaleFactory : IUniverseAvatarScaleFactory
{
	private readonly IUniverseSettingsFactory _UniverseSettingsFactory;

	private readonly OutfitDomainFactories _OutfitDomainFactories;

	private readonly UniverseAvatarSettingsDefaults _UniverseAvatarSettingsDefaults;

	public UniverseAvatarScaleFactory(IUniverseSettingsFactory universeSettingsFactory, OutfitDomainFactories outfitDomainFactories)
	{
		_UniverseSettingsFactory = universeSettingsFactory ?? throw new PlatformArgumentNullException("universeSettingsFactory");
		_OutfitDomainFactories = outfitDomainFactories ?? throw new PlatformArgumentNullException("outfitDomainFactories");
		_UniverseAvatarSettingsDefaults = new UniverseAvatarSettingsDefaults(outfitDomainFactories.ScaleFactory);
	}

	public void SetUniverseAvatarScales(IUser user, long universeId, Scale minScale, Scale maxScale)
	{
		if (universeId == 0L)
		{
			throw new PlatformArgumentException("universeId");
		}
		if (minScale == null && maxScale == null)
		{
			throw new PlatformArgumentNullException(string.Format("Missing both {0} and {1}", "minScale", "maxScale"));
		}
		UniverseAvatarSettingsResponseModel entity = _UniverseSettingsFactory.GetUniverseAvatarSettings(universeId);
		if (minScale == null)
		{
			minScale = (entity.UniverseAvatarMinScaleId.HasValue ? _OutfitDomainFactories.ScaleFactory.Get(entity.UniverseAvatarMinScaleId.Value) : _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMinScale());
		}
		if (maxScale == null)
		{
			maxScale = (entity.UniverseAvatarMaxScaleId.HasValue ? _OutfitDomainFactories.ScaleFactory.Get(entity.UniverseAvatarMaxScaleId.Value) : _UniverseAvatarSettingsDefaults.GetDefaultNewUniverseAvatarMaxScale());
		}
		bool minValid;
		Scale clampedMinScale = _OutfitDomainFactories.ScaleAuthority.GetClampedScale(out minValid, minScale, null);
		if (!minValid)
		{
			throw new PlatformArgumentException("Min scales are not in the acceptable scale range.");
		}
		bool maxValid;
		Scale clampedMaxScale = _OutfitDomainFactories.ScaleAuthority.GetClampedScale(out maxValid, maxScale, null);
		if (!maxValid)
		{
			throw new PlatformArgumentException("Max scales are not in the acceptable scale range.");
		}
		IEnumerable<ScaleRules> violatedMinMaxScales = _OutfitDomainFactories.ScaleAuthority.CompareMinAndMaxScales(clampedMinScale, clampedMaxScale);
		if (violatedMinMaxScales != null && violatedMinMaxScales.Any())
		{
			throw new PlatformArgumentException("All min scales must be less than or equal to max scales.");
		}
		_UniverseSettingsFactory.SetUniverseAvatarMinScale(user, universeId, clampedMinScale);
		_UniverseSettingsFactory.SetUniverseAvatarMaxScale(user, universeId, clampedMaxScale);
	}
}
