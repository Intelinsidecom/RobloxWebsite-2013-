using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Roblox.Configuration;
using Roblox.Networking;
using Roblox.Platform.Infrastructure.Properties;

namespace Roblox.Platform.Infrastructure;

internal class ServerValidatorInstance : IServerValidator
{
	private readonly ISettings _Settings;

	private IReadOnlyCollection<IpAddressRange> _AllowedProxyIpAddressRanges;

	private IReadOnlyCollection<IpAddressRange> _WhitelistedIpAddressRanges;

	private HashSet<int> _AllowedProxyServerTypeIds;

	public ServerValidatorInstance()
	{
		_Settings = Settings.Default;
		ReadAllowedProxyIpRangesFromSettings();
		if (_Settings == Settings.Default)
		{
			Settings.Default.MonitorChanges((Settings s) => s.XForwardedForProxyIpAddressRanges, ReadAllowedProxyIpRangesFromSettings);
		}
		ReadAllowedProxyServerTypeIdsFromSettings();
		if (_Settings == Settings.Default)
		{
			Settings.Default.MonitorChanges((Settings s) => s.AllowedXForwardedForProxyServerTypeIds, ReadAllowedProxyServerTypeIdsFromSettings);
		}
		ReadWhitelistedIpRangesFromSettings();
		if (_Settings == Settings.Default)
		{
			Settings.Default.MonitorChanges((Settings s) => s.WhitelistedIpAddressRanges, ReadWhitelistedIpRangesFromSettings);
		}
	}

	internal ServerValidatorInstance(ISettings settings)
	{
		_Settings = settings;
		ReadAllowedProxyIpRangesFromSettings();
		ReadAllowedProxyServerTypeIdsFromSettings();
		ReadWhitelistedIpRangesFromSettings();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerTypeByIpAddress(System.String)" />
	public ServerType? GetServerTypeByIpAddress(string ipAddress)
	{
		int? serverTypeId = GetServerTypeIdByIpAddress(ipAddress);
		if (serverTypeId.HasValue)
		{
			ServerType serverType = (ServerType)serverTypeId.Value;
			if (Enum.IsDefined(typeof(ServerType), serverType))
			{
				return serverType;
			}
		}
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerTypeIdByIpAddress(System.String)" />
	public int? GetServerTypeIdByIpAddress(string ipAddress)
	{
		if (!IsIpAddressInIpToServerMap(ipAddress, out var server))
		{
			return null;
		}
		return server.ServerTypeID;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerStatusByIpAddress(System.String)" />
	public ServerStatus? GetServerStatusByIpAddress(string ipAddress)
	{
		int? serverStatusId = GetServerStatusIdByIpAddress(ipAddress);
		if (serverStatusId.HasValue)
		{
			ServerStatus serverType = (ServerStatus)serverStatusId.Value;
			if (Enum.IsDefined(typeof(ServerStatus), serverType))
			{
				return serverType;
			}
		}
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.GetServerStatusIdByIpAddress(System.String)" />
	public int? GetServerStatusIdByIpAddress(string ipAddress)
	{
		if (!IsIpAddressInIpToServerMap(ipAddress, out var server))
		{
			return null;
		}
		return server.ServerStatusID;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.VerifyAccess(System.String)" />
	public bool VerifyAccess(string ipAddress)
	{
		if (!IsIpAddressInIpToServerMap(ipAddress, out var server))
		{
			return false;
		}
		if (server.ServerTypeID == 11 || server.ServerTypeID == 27)
		{
			return true;
		}
		return IsServerIdInAllowedGroupsMap(server.ID);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.IsAllowedProxyIp(System.String)" />
	public bool IsAllowedProxyIp(string ipAddressString)
	{
		IPAddress.TryParse(ipAddressString, out var ipAddress);
		if (IsIpAddressInSnatIpList(ipAddressString) || IsIpAddressInRange(_AllowedProxyIpAddressRanges, ipAddress))
		{
			return true;
		}
		if (!IsIpAddressInIpToServerMap(ipAddressString, out var server))
		{
			return false;
		}
		if (_AllowedProxyServerTypeIds.Contains(server.ServerTypeID))
		{
			return true;
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.IsDosArrestIp(System.String)" />
	public bool IsDosArrestIp(string ipAddress)
	{
		return RefreshAheadDatabaseLookups.DosArrestNetworksIpAddresses.Contains(ipAddress);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Infrastructure.IServerValidator.IsWhitelistedIp(System.String)" />
	public bool IsWhitelistedIp(string ipAddressString)
	{
		IPAddress.TryParse(ipAddressString, out var ipAddress);
		return IsIpAddressInRange(_WhitelistedIpAddressRanges, ipAddress);
	}

	internal virtual bool IsServerIdInAllowedGroupsMap(int serverId)
	{
		return RefreshAheadDatabaseLookups.ServerIDsInAllowedGroups.Contains(serverId);
	}

	internal virtual bool IsIpAddressInIpToServerMap(string ipAddress, out Server server)
	{
		return RefreshAheadDatabaseLookups.IPAddressToServerMap.TryGetValue(ipAddress, out server);
	}

	internal virtual bool IsIpAddressInSnatIpList(string ipAddress)
	{
		return RefreshAheadDatabaseLookups.SnatIpAddresses.Contains(ipAddress);
	}

	private void ReadAllowedProxyIpRangesFromSettings()
	{
		_AllowedProxyIpAddressRanges = IpAddressRange.ParseStringList(_Settings.XForwardedForProxyIpAddressRanges);
	}

	private void ReadAllowedProxyServerTypeIdsFromSettings()
	{
		_AllowedProxyServerTypeIds = MultiValueSettingParser.ParseCommaDelimitedListString(_Settings.AllowedXForwardedForProxyServerTypeIds, int.Parse);
	}

	private void ReadWhitelistedIpRangesFromSettings()
	{
		_WhitelistedIpAddressRanges = IpAddressRange.ParseStringList(_Settings.WhitelistedIpAddressRanges);
	}

	private bool IsIpAddressInRange(IReadOnlyCollection<IpAddressRange> ipRanges, IPAddress ipAddress)
	{
		if (ipAddress == null)
		{
			return false;
		}
		return ipRanges.Aggregate(seed: false, (bool result, IpAddressRange ipRange) => result || ipRange.IsInRange(ipAddress));
	}
}
