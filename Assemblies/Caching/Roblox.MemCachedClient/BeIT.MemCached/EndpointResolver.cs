using System;
using System.Linq;
using System.Net;
using DnsClient;

namespace BeIT.MemCached;

internal class EndpointResolver : IEndpointResolver
{
	private volatile ILookupClient _LookupClient;

	private readonly IMemcachedClientDnsSettings _DnsSettings;

	public EndpointResolver(IMemcachedClientDnsSettings settings)
	{
		EndpointResolver endpointResolver = this;
		_DnsSettings = settings ?? throw new ArgumentNullException("settings");
		settings.PropertyChanged += delegate
		{
			endpointResolver._LookupClient = endpointResolver.CreateLookupClient(settings);
		};
		_LookupClient = CreateLookupClient(settings);
	}

	public IPEndPoint GetEndPoint(string host, ushort defaultPort = 11211)
	{
		if (string.IsNullOrWhiteSpace(host))
		{
			throw new ArgumentNullException("host");
		}
		host = host.Trim();
		ushort result = defaultPort;
		if (host.Contains(":"))
		{
			string[] array = host.Split(new char[1] { ':' });
			if (!ushort.TryParse(array[1], out result))
			{
				throw new ArgumentException($"Unable to parse host: {host}", "host");
			}
			host = array[0];
		}
		if (IPAddress.TryParse(host, out var address))
		{
			return new IPEndPoint(address, result);
		}
		if (_DnsSettings.IsUpgradedDnsResolvingEnabled)
		{
			IPHostEntry iPHostEntry;
			try
			{
				iPHostEntry = LookupClientGetHostEntry(_LookupClient, host);
			}
			catch (Exception innerException)
			{
				throw new ArgumentException($"Unable to resolve host using ILookupClient: {host}", "host", innerException);
			}
			return new IPEndPoint(iPHostEntry?.AddressList?.FirstOrDefault() ?? throw new ArgumentException($"Host {host} did not resolve to any records", "host"), result);
		}
		IPAddress iPAddress;
		try
		{
			iPAddress = DnsGetHostEntry(host).AddressList.FirstOrDefault();
		}
		catch (Exception innerException2)
		{
			throw new ArgumentException($"Unable to resolve host using Dns class: {host}", "host", innerException2);
		}
		if (iPAddress == null)
		{
			throw new ArgumentException($"Host {host} did not resolve to any records", "host");
		}
		return new IPEndPoint(iPAddress, result);
	}

	internal virtual ILookupClient CreateLookupClient(IMemcachedClientDnsSettings settings)
	{
		IPAddress[] nameservers = settings.Nameservers;
		LookupClient obj = ((nameservers != null && nameservers.Length != 0) ? new LookupClient(settings.Nameservers) : new LookupClient());
		obj.UseCache = false;
		return obj;
	}

	internal virtual IPHostEntry LookupClientGetHostEntry(ILookupClient lookupClient, string host)
	{
		return lookupClient.GetHostEntry(host);
	}

	internal virtual IPHostEntry DnsGetHostEntry(string host)
	{
		return Dns.GetHostEntry(host);
	}
}
