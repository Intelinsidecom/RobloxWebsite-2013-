using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Demographics;
using Roblox.Marketing;
using Roblox.Platform.Demographics;
using Roblox.Platform.Devices;
using Roblox.Platform.Marketing.Properties;
using Roblox.Web.Devices;

namespace Roblox.Platform.Marketing;

/// <inheritdoc cref="T:Roblox.Platform.Marketing.ISponsoredPageProvider" />
public class SponsoredPageProvider : ISponsoredPageProvider
{
	private const int _SponsoredPageCountryMaxRows = 100;

	private readonly IDeviceFactory _DeviceFactory;

	private readonly IGeolocationFactory _GeolocationFactory;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	public SponsoredPageProvider(IDeviceFactory deviceFactory, IGeolocationFactory geolocationFactory, IClientDeviceIdentifier clientDeviceIdentifier)
	{
		_DeviceFactory = deviceFactory ?? throw new ArgumentNullException("deviceFactory");
		_GeolocationFactory = geolocationFactory ?? throw new ArgumentNullException("geolocationFactory");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Marketing.ISponsoredPageProvider.IsSponsoredPageAuthorizedForCountry(Roblox.Marketing.SponsoredPage,System.Int32)" />
	public bool IsSponsoredPageAuthorizedForCountry(SponsoredPage sponsoredPage, int countryId)
	{
		return FilterViewableSponsoredPagesForCountryAndDevice(new List<SponsoredPage> { sponsoredPage }, countryId).Any();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Marketing.ISponsoredPageProvider.GetAllAvailableSponsoredPagesForUser(System.String,System.String)" />
	public ICollection<ISponsoredPageNavigation> GetAllAvailableSponsoredPagesForUser(string ip, string userAgent)
	{
		ICollection<ISponsoredPageNavigation> sponsoredPages = new List<ISponsoredPageNavigation>();
		int countryId = _GeolocationFactory.GetOrCreateGeolocation(ip).CountryId ?? Country.GetUSACountry().ID;
		DeviceType deviceType = _ClientDeviceIdentifier.GetDeviceType(userAgent);
		foreach (SponsoredPage page in FilterViewableSponsoredPagesForCountryAndDevice(SponsoredPage.GetAllSponsoredPages(), countryId, deviceType))
		{
			string pageName = page.Name;
			string pageType = PageType.Get(page.PageTypeID).Value;
			string pagePath = ((!string.IsNullOrEmpty(pageType) && !string.IsNullOrEmpty(pageName)) ? ("/" + pageType.ToLower() + "/" + pageName) : null);
			sponsoredPages.Add(new SponsoredPageNavigation
			{
				Name = pageName,
				Title = page.Title,
				LogoImageHash = page.NavigationLogoImageMd5Hash,
				PageType = pageType,
				PagePath = pagePath
			});
		}
		return sponsoredPages;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Marketing.ISponsoredPageProvider.GetSponsoredPageByOverrideUrl(System.String)" />
	public SponsoredPage GetSponsoredPageByOverrideUrl(string overrideUrl)
	{
		if (string.IsNullOrEmpty(overrideUrl))
		{
			return null;
		}
		ICollection<SponsoredPage> allSponsoredPages = SponsoredPage.GetAllSponsoredPages();
		string altOverrideUrl = "/" + overrideUrl;
		foreach (SponsoredPage sponsoredPage in allSponsoredPages)
		{
			string navigationOverrideUrl = sponsoredPage.NavigationOverrideUrl;
			if (navigationOverrideUrl == overrideUrl || navigationOverrideUrl == altOverrideUrl)
			{
				return sponsoredPage;
			}
		}
		return null;
	}

	private IEnumerable<SponsoredPage> FilterViewableSponsoredPagesForCountryAndDevice(ICollection<SponsoredPage> sponsoredPages, int countryId, DeviceType? deviceType = null)
	{
		return sponsoredPages.Where((SponsoredPage sponsoredPage) => sponsoredPage.Enabled && IsSponsoredPageVisibleForCountry(sponsoredPage, countryId) && IsSponsoredPageVisibleForDevice(sponsoredPage, deviceType));
	}

	private bool IsSponsoredPageVisibleForCountry(SponsoredPage sponsoredPage, int countryId)
	{
		int pageNumber = 1;
		ICollection<SponsoredPageCountry> sponsoredPageCountries = SponsoredPageCountry.GetSponsoredPageCountriesBySponsoredPageIDPaged(sponsoredPage.ID, pageNumber, 100);
		if (sponsoredPageCountries.Count == 0)
		{
			return true;
		}
		bool visible = sponsoredPageCountries.Any((SponsoredPageCountry entry) => entry.CountryID == countryId);
		while (sponsoredPageCountries.Count > 0 && !visible)
		{
			sponsoredPageCountries = SponsoredPageCountry.GetSponsoredPageCountriesBySponsoredPageIDPaged(sponsoredPage.ID, pageNumber, 100);
			pageNumber++;
			visible = sponsoredPageCountries.Any((SponsoredPageCountry entry) => entry.CountryID == countryId);
		}
		return visible;
	}

	private bool IsSponsoredPageVisibleForDevice(SponsoredPage sponsoredPage, DeviceType? deviceType)
	{
		if (!Settings.Default.IsSponsoredPageDevicesSelectorEnabled || !deviceType.HasValue)
		{
			return true;
		}
		Roblox.Marketing.SponsoredPageDeviceType entity = Roblox.Marketing.SponsoredPageDeviceType.GetBySponsoredPageId(sponsoredPage.ID);
		if (entity == null)
		{
			return true;
		}
		SponsoredPageDeviceType sponsoredPageDeviceType = new SponsoredPageDeviceType(entity);
		return _DeviceFactory.GetSupportedDeviceTypesForSponsoredPage(sponsoredPageDeviceType.DeviceTypesBitMask).Contains(deviceType.Value);
	}
}
