using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Consul;
using Roblox.ServiceDiscovery.Properties;

namespace Roblox.ServiceDiscovery;

public class LocalConsulClientProvider : IConsulClientProvider, INotifyPropertyChanged, IDisposable
{
	private readonly ISettings _Settings;

	public IConsulClient Client { get; private set; }

	public event PropertyChangedEventHandler PropertyChanged;

	[ExcludeFromCodeCoverage]
	public LocalConsulClientProvider()
		: this(Settings.Default)
	{
	}

	internal LocalConsulClientProvider(ISettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		settings.PropertyChanged += Settings_PropertyChanged;
		GenerateClient();
	}

	public void Dispose()
	{
		_Settings.PropertyChanged -= Settings_PropertyChanged;
	}

	private void Settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "ConsulAddress")
		{
			GenerateClient();
		}
	}

	private void GenerateClient()
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		Client = new ConsulClient(delegate(ConsulClientConfiguration config)
		{
			config.Address = new Uri(_Settings.ConsulAddress);
		});
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Client"));
	}
}
