namespace Roblox.Platform.Marketing;

/// <summary>
/// Creates and Gets SponsoredPageDeviceTypes which are used to target sponsored page based on device types.  
/// </summary>
public interface ISponsoredPageDeviceTypeFactory
{
	/// <summary>
	/// Gets instance of <see cref="T:Roblox.Platform.Marketing.SponsoredPageDeviceType" /> by sponsoredPageId.
	/// </summary>
	/// <param name="sponsoredPageId">The sponsored page Id.</param>
	ISponsoredPageDeviceType GetBySponsoredPageId(int sponsoredPageId);

	/// <summary>
	/// Creates or update <see cref="T:Roblox.Platform.Marketing.SponsoredPageDeviceType" />.
	/// </summary>
	/// <param name="sponsoredPageId">The sponsored page id.</param>
	/// <param name="deviceTypesBitMasked">Bit masked device types.</param>
	ISponsoredPageDeviceType CreateSponsoredPageDeviceType(int sponsoredPageId, long deviceTypesBitMasked);
}
