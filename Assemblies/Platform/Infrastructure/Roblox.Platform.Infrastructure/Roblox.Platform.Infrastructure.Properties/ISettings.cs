using System;

namespace Roblox.Platform.Infrastructure.Properties;

internal interface ISettings
{
	object this[string propertyName] { get; set; }

	string AllowedServerGroupIDs { get; }

	string AllowedXForwardedForProxyServerTypeIds { get; }

	TimeSpan DosArrestNetworksRefreshInterval { get; }

	TimeSpan GameRelayIpAddressToDatacenterIdMapRefreshInterval { get; }

	string GameServerJobSignatureAlternateSalt { get; }

	string GameServerJobSignatureSalt { get; }

	TimeSpan PrimaryIPAddressToServerMapRefreshInterval { get; }

	TimeSpan ServerIDsInAllowedGroupsRefreshInterval { get; }

	TimeSpan SnatIpAddressesRefreshInterval { get; }

	TimeSpan VendorIDToNameMapRefreshInterval { get; }

	string XForwardedForProxyIpAddressRanges { get; }

	string WhitelistedIpAddressRanges { get; }
}
