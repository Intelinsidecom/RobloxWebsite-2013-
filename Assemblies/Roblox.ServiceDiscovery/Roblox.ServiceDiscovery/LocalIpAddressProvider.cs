using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Roblox.EventLog;

namespace Roblox.ServiceDiscovery;

public class LocalIpAddressProvider : ILocalIpAddressProvider, INotifyPropertyChanged
{
	private readonly IDns _Dns;

	private readonly object _AddressV4Lock;

	private readonly object _AddressV6Lock;

	private IPAddress _AddressV4;

	private IPAddress _AddressV6;

	private readonly ILogger _Logger;

	public virtual IPAddress AddressV4
	{
		get
		{
			return _AddressV4;
		}
		internal set
		{
			if (value.Equals(_AddressV4))
			{
				return;
			}
			lock (_AddressV4Lock)
			{
				if (value.Equals(_AddressV4))
				{
					return;
				}
				_AddressV4 = value;
			}
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AddressV4"));
		}
	}

	public virtual IPAddress AddressV6
	{
		get
		{
			return _AddressV6;
		}
		internal set
		{
			if (value.Equals(_AddressV6))
			{
				return;
			}
			lock (_AddressV6Lock)
			{
				if (value.Equals(_AddressV6))
				{
					return;
				}
				_AddressV6 = value;
			}
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("_AddressV6"));
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public LocalIpAddressProvider(ILogger logger)
		: this(new DnsWrapper(), logger)
	{
	}

	internal LocalIpAddressProvider(IDns dns, ILogger logger)
	{
		_Dns = dns ?? throw new ArgumentNullException("dns");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AddressV4Lock = new object();
		_AddressV6Lock = new object();
		NetworkChange.NetworkAddressChanged += delegate
		{
			RefreshIpAddresses();
		};
		RefreshIpAddresses();
		_Logger.Info(() => string.Format("{0} initialized with IPv4 address: {1}", "LocalIpAddressProvider", AddressV4));
		_Logger.Info(() => string.Format("{0} initialized with IPv6 address: {1}", "LocalIpAddressProvider", AddressV6));
	}

	public IList<IPAddress> GetIpAddressesV4()
	{
		return GetIpAddresses(AddressFamily.InterNetwork).ToList();
	}

	public IList<IPAddress> GetIpAddressesV6()
	{
		return GetIpAddresses(AddressFamily.InterNetworkV6).ToList();
	}

	internal void RefreshIpAddresses()
	{
		RefreshIpAddresses(AddressFamily.InterNetwork);
		RefreshIpAddresses(AddressFamily.InterNetworkV6);
	}

	internal virtual void RefreshIpAddresses(AddressFamily addressFamily)
	{
		if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6)
		{
			_Logger.Error(() => $"Unsupported address family: {addressFamily}");
			return;
		}
		List<IPAddress> list = GetIpAddresses(addressFamily).ToList();
		if (!list.Any())
		{
			_Logger.Error(() => string.Format("No public {0} address found for server, while trying to refresh IP address in {1}!", addressFamily, "RefreshIpAddresses"));
		}
		else if ((addressFamily != AddressFamily.InterNetwork || !list.Contains(AddressV4)) && (addressFamily != AddressFamily.InterNetworkV6 || !list.Contains(AddressV6)))
		{
			IPAddress newIpAddress = list.First();
			IPAddress oldIpAddress;
			if (addressFamily == AddressFamily.InterNetwork)
			{
				oldIpAddress = AddressV4;
				AddressV4 = newIpAddress;
			}
			else
			{
				oldIpAddress = AddressV6;
				AddressV6 = newIpAddress;
			}
			_Logger.Info(() => $"{addressFamily} IP address changed from {oldIpAddress} to {newIpAddress}.");
		}
	}

	internal virtual IEnumerable<IPAddress> GetIpAddresses(AddressFamily addressFamily)
	{
		IPHostEntry hostEntry;
		try
		{
			string hostName = _Dns.GetHostName();
			hostEntry = _Dns.GetHostEntry(hostName);
		}
		catch (Exception ex)
		{
			Exception ex2 = ex;
			Exception e = ex2;
			_Logger.Error(() => $"Exception encountered while acquiring host information from DNS: {e}");
			return Enumerable.Empty<IPAddress>();
		}
		if (hostEntry == null)
		{
			return Enumerable.Empty<IPAddress>();
		}
		return hostEntry.AddressList.Where((IPAddress address) => address.AddressFamily == addressFamily).ToList();
	}
}
