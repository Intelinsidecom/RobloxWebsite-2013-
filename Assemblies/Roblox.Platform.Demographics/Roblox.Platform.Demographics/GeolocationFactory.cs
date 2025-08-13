using System;
using Roblox.Demographics;
using Roblox.FloodCheckers;
using Roblox.MaxMind.GeoIP2;
using Roblox.Platform.Demographics.Properties;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents a factory that produces <see cref="T:Roblox.Platform.Demographics.IGeolocation" />s.
/// </summary>
public class GeolocationFactory : IGeolocationFactory
{
	private readonly Lazy<MaxmindClient> _Client;

	/// <summary>
	/// </summary>
	public GeolocationFactory(string apiName)
	{
		_Client = new Lazy<MaxmindClient>(() => new MaxmindClient(apiName));
	}

	public IGeolocation GetGeolocation(string ip)
	{
		return GetOrCreateGeolocationPrivate(ip, createRecordsIfNotPresent: false);
	}

	public IGeolocation GetOrCreateGeolocation(string ip)
	{
		return GetOrCreateGeolocationPrivate(ip, createRecordsIfNotPresent: true);
	}

	private IGeolocation GetOrCreateGeolocationPrivate(string ip, bool createRecordsIfNotPresent)
	{
		Geolocation geolocation = new Geolocation();
		IPAddress ipAddress = IPAddress.GetByAddress(ip);
		if (ipAddress == null && !createRecordsIfNotPresent)
		{
			return geolocation;
		}
		ipAddress = ipAddress ?? IPAddress.GetOrCreate(ip);
		IPAddressCountry ipAddressCountryEntity = IPAddressCountry.GetByIPAddressID(ipAddress.ID);
		IPAddressGeoposition ipAddressGeopositionEntity = null;
		if (Settings.Default.EnableGeoposition)
		{
			ipAddressGeopositionEntity = IPAddressGeoposition.GetByIPAddressID(ipAddress.ID);
		}
		if (createRecordsIfNotPresent && ShouldLookup(ipAddressCountryEntity, ipAddressGeopositionEntity))
		{
			FloodChecker floodchecker = new FloodChecker("GeopositionLookupByIp", $"GeopositionLookupByIp_{ipAddress.ID}", Settings.Default.GeopositionLookupByIpFloodcheckLimit, Settings.Default.GeopositionLookupByIpFloodcheckExpiry, Settings.Default.GeopositionLookupByIpFloodcheckEnabled);
			if (floodchecker.IsFlooded())
			{
				return geolocation;
			}
			floodchecker.UpdateCount();
			IPLookupType lookupType = ((!Settings.Default.EnableGeoposition) ? IPLookupType.Country : IPLookupType.City);
			IIPLookupResult lookupResult = _Client.Value.Lookup(ip, lookupType);
			if (lookupResult == null || lookupResult.IPLookupErrorType == IPLookupErrorType.Other)
			{
				return geolocation;
			}
			int? countryId = Roblox.Demographics.Country.GetByCode(lookupResult.CountryCode)?.ID;
			if (ipAddressCountryEntity == null)
			{
				ipAddressCountryEntity = IPAddressCountry.GetOrCreateIPAddressCountryByIPAddressIDAndCountryID(ipAddress.ID, countryId);
			}
			else
			{
				ipAddressCountryEntity.CountryID = countryId;
				ipAddressCountryEntity.Save();
			}
			if (Settings.Default.EnableGeoposition)
			{
				long? geopositionEntityId;
				if (lookupResult.Longitude.HasValue && lookupResult.Latitude.HasValue)
				{
					Geoposition geopositionEntity = Geoposition.GetOrCreate(lookupResult.Latitude.Value, lookupResult.Longitude.Value);
					geopositionEntityId = geopositionEntity.ID;
				}
				else
				{
					geopositionEntityId = null;
				}
				if (ipAddressGeopositionEntity == null)
				{
					ipAddressGeopositionEntity = IPAddressGeoposition.GetOrCreate(ipAddress.ID, geopositionEntityId);
				}
				else
				{
					ipAddressGeopositionEntity.GeopositionID = geopositionEntityId;
					ipAddressGeopositionEntity.Save();
				}
			}
		}
		PopulateCountryId(ipAddressCountryEntity, geolocation);
		PopulateGeoposition(ipAddressGeopositionEntity, geolocation);
		return geolocation;
	}

	private static void PopulateGeoposition(IPAddressGeoposition ipAddressGeopositionEntity, Geolocation geolocation)
	{
		if (ipAddressGeopositionEntity != null)
		{
			geolocation.IsGeopositionLookupAttempted = true;
			if (ipAddressGeopositionEntity.GeopositionID.HasValue)
			{
				Geoposition geopositionEntity = Geoposition.Get(ipAddressGeopositionEntity.GeopositionID.Value);
				geolocation.Latitude = geopositionEntity.Latitude;
				geolocation.Longitude = geopositionEntity.Longitude;
			}
		}
	}

	private static void PopulateCountryId(IPAddressCountry ipAddressCountryEntity, Geolocation getlocation)
	{
		if (ipAddressCountryEntity != null)
		{
			getlocation.IsCountryLookupAttempted = true;
			if (ipAddressCountryEntity.CountryID.HasValue)
			{
				Roblox.Demographics.Country country = Roblox.Demographics.Country.Get(ipAddressCountryEntity.CountryID.Value);
				getlocation.CountryId = country.ID;
			}
		}
	}

	private static bool ShouldLookup(IPAddressCountry ipAddressCountryEntity, IPAddressGeoposition ipAddressGeopositionEntity)
	{
		DateTime now = DateTime.Now;
		TimeSpan maxAge = Settings.Default.IPAddressLookupRefreshInterval;
		bool num = ipAddressCountryEntity == null || now - ipAddressCountryEntity.Updated > maxAge;
		bool shouldLookupGeoposition = Settings.Default.EnableGeoposition && (ipAddressGeopositionEntity == null || now - ipAddressGeopositionEntity.Updated > maxAge);
		return num || shouldLookupGeoposition;
	}
}
