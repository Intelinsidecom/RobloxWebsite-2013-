using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

namespace Roblox.Instrumentation.Infrastructure;

internal class InfrastructureServiceConfigurationProvider : IDisposable, IConfigurationProvider
{
	[DataContract]
	public class ConfigurationDto
	{
		[DataMember]
		public string ServerFarmName { get; set; }

		[DataMember]
		public string SuperFarmName { get; set; }

		[DataMember]
		public string PerfmonDatabase { get; set; }

		[DataMember]
		public string[] InfluxDbUrls { get; set; }

		[DataMember]
		public bool IsInfluxDbShardingOnWritesEnabled { get; set; }
	}

	private const string _InfrastructureServiceEndpoint = "https://infrastructure.simulping.com";

	private const string _MachineNameVariableKey = "RobloxInstrumentationMachineName";

	private static readonly TimeSpan _ConfigurationReloadInterval = TimeSpan.FromMinutes(10.0);

	private readonly string _MachineName;

	private readonly Action<Exception> _ExceptionHandler;

	private readonly string _ConfigurationUrl;

	private readonly Timer _Timer;

	private ICollectionConfiguration _CollectionConfiguration;

	private byte[] _LastJsonConfiguration;

	public InfrastructureServiceConfigurationProvider(string machineName, Action<Exception> exceptionHandler)
	{
		if (!string.IsNullOrWhiteSpace(machineName))
		{
			_MachineName = machineName;
		}
		else
		{
			string environmentVariable = Environment.GetEnvironmentVariable("RobloxInstrumentationMachineName", EnvironmentVariableTarget.Process);
			environmentVariable = environmentVariable ?? Environment.GetEnvironmentVariable("RobloxInstrumentationMachineName", EnvironmentVariableTarget.User);
			environmentVariable = environmentVariable ?? Environment.GetEnvironmentVariable("RobloxInstrumentationMachineName", EnvironmentVariableTarget.Machine);
			_MachineName = environmentVariable ?? Environment.MachineName.ToUpperInvariant();
		}
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentNullException("exceptionHandler");
		_ConfigurationUrl = "https://infrastructure.simulping.com/v2/GetPerfmonConfiguration?hostName=" + Uri.EscapeDataString(_MachineName);
		_Timer = new Timer(delegate
		{
			ReloadConfiguration();
		}, null, _ConfigurationReloadInterval, _ConfigurationReloadInterval);
	}

	public ICollectionConfiguration GetConfiguration()
	{
		if (_CollectionConfiguration == null)
		{
			ReloadConfiguration();
		}
		return _CollectionConfiguration;
	}

	public void Dispose()
	{
		_Timer?.Dispose();
	}

	private void ReloadConfiguration()
	{
		try
		{
			_Timer.Change(-1, -1);
			byte[] array;
			using (WebClient webClient = new WebClient())
			{
				array = webClient.DownloadData(_ConfigurationUrl);
			}
			if (_LastJsonConfiguration == null || !_LastJsonConfiguration.SequenceEqual(array) || _CollectionConfiguration == null)
			{
				using (MemoryStream stream = new MemoryStream(array))
				{
					ConfigurationDto configurationDto = (ConfigurationDto)new DataContractJsonSerializer(typeof(ConfigurationDto)).ReadObject(stream);
					_CollectionConfiguration = new InfrastructureServiceCollectionConfiguration(_MachineName, configurationDto.ServerFarmName, configurationDto.SuperFarmName, configurationDto.PerfmonDatabase, (IReadOnlyCollection<string>)(object)configurationDto.InfluxDbUrls, null, configurationDto.IsInfluxDbShardingOnWritesEnabled);
				}
				_LastJsonConfiguration = array;
			}
		}
		catch (Exception obj)
		{
			try
			{
				_ExceptionHandler?.Invoke(obj);
			}
			catch
			{
			}
		}
		finally
		{
			_Timer.Change(_ConfigurationReloadInterval, _ConfigurationReloadInterval);
		}
	}
}
