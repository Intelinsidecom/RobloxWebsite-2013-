using System;
using Newtonsoft.Json;

namespace Roblox.MaxMind.GeoIP2.Responses;

public class TraitsResponse
{
	/// <summary>
	///     The
	///     <a href="http://en.wikipedia.org/wiki/Autonomous_system_(Internet)">
	///         autonomous system number
	///     </a>
	///     associated with the IP address.
	///     This attribute is only available from the City and Insights web
	///     service end points.
	/// </summary>
	[JsonProperty("autonomous_system_number")]
	public int? AutonomousSystemNumber { get; internal set; }

	/// <summary>
	///     The organization associated with the registered
	///     <a href="http://en.wikipedia.org/wiki/Autonomous_system_(Internet)">
	///         autonomous system number
	///     </a>
	///     for the IP address. This attribute
	///     is only available from the City and Insights web service end points.
	/// </summary>
	[JsonProperty("autonomous_system_organization")]
	public string AutonomousSystemOrganization { get; internal set; }

	/// <summary>
	///     The second level domain associated with the IP address. This will
	///     be something like "example.com" or "example.co.uk", not
	///     "foo.example.com". This attribute is only available from the
	///     City and Insights web service end points.
	/// </summary>
	[JsonProperty("domain")]
	public string Domain { get; internal set; }

	/// <summary>
	///     The IP address that the data in the model is for. If you
	///     performed a "me" lookup against the web service, this will be the
	///     externally routable IP address for the system the code is running
	///     on. If the system is behind a NAT, this may differ from the IP
	///     address locally assigned to it.
	/// </summary>
	[JsonProperty("ip_address")]
	public string IPAddress { get; internal set; }

	/// <summary>
	///     This is true if the IP is an anonymous proxy. See
	///     <a href="http://dev.maxmind.com/faq/geoip#anonproxy">
	///         MaxMind's GeoIP
	///         FAQ
	///     </a>
	/// </summary>
	[JsonProperty("is_anonymous_proxy")]
	[Obsolete("Use our GeoIP2 Anonymous IP database instead.")]
	public bool IsAnonymousProxy { get; internal set; }

	/// <summary>
	///     This is true if the IP belong to a satellite internet provider.
	/// </summary>
	[JsonProperty("is_satellite_provider")]
	[Obsolete("Due to increased mobile usage, we have insufficient data to maintain this field.")]
	public bool IsSatelliteProvider { get; internal set; }

	/// <summary>
	///     The name of the ISP associated with the IP address. This
	///     attribute is only available from the City and Insights web
	///     service end points.
	/// </summary>
	[JsonProperty("isp")]
	public string Isp { get; internal set; }

	/// <summary>
	///     The name of the organization associated with the IP address. This
	///     attribute is only available from the City and Insights web
	///     service end points.
	/// </summary>
	[JsonProperty("organization")]
	public string Organization { get; internal set; }

	/// <summary>
	///     The user type associated with the IP address. This can be one of
	///     the following values:
	///     business
	///     cafe
	///     cellular
	///     college
	///     content_delivery_network
	///     dialup
	///     government
	///     hosting
	///     library
	///     military
	///     residential
	///     router
	///     school
	///     search_engine_spider
	///     traveler
	///     This attribute is only available from the Insights end point.
	/// </summary>
	[JsonProperty("user_type")]
	public string UserType { get; internal set; }
}
