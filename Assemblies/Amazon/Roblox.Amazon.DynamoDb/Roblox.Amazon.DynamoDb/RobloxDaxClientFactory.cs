using System;
using Amazon;
using Amazon.DAX;
using Amazon.Runtime;
using Roblox.Amazon.DynamoDb.Properties;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Amazon.DynamoDb.IRobloxDaxClientFactory" />.
/// </summary>
public class RobloxDaxClientFactory : IRobloxDaxClientFactory
{
	private static readonly Lazy<IRobloxDaxClientFactory> _Instance = new Lazy<IRobloxDaxClientFactory>(() => new RobloxDaxClientFactory());

	private RobloxDaxClientDefaultSettings _CurrentDefaultSettings;

	private readonly IDaxClientSettings _Settings;

	/// <summary>
	/// Gets the instance of <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientFactory" />.
	/// </summary>
	public static IRobloxDaxClientFactory Instance => _Instance.Value;

	/// <inheritdoc />
	public event Action<RobloxDaxClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientFactory" />.
	/// </summary>
	public RobloxDaxClientFactory()
		: this(DaxClientSettings.Default)
	{
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientFactory" />. Should only be used for testing.
	/// </summary>
	/// <param name="settings">The <see cref="T:Roblox.Amazon.DynamoDb.Properties.IDaxClientSettings" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /></exception>
	internal RobloxDaxClientFactory(IDaxClientSettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		RebuildSettings();
		_Settings.PropertyChanged += delegate
		{
			RebuildSettings();
		};
	}

	/// <inheritdoc />
	public IAmazonDAX Create(AWSCredentials credentials, string clientInstanceName)
	{
		return Create(credentials, _CurrentDefaultSettings.RegionEndpoint, clientInstanceName);
	}

	/// <inheritdoc />
	public IAmazonDAX Create(AWSCredentials credentials, RobloxDaxClientConfig daxClientConfig)
	{
		return (IAmazonDAX)(object)new RobloxDaxClient(credentials, daxClientConfig);
	}

	/// <inheritdoc />
	public IAmazonDAX Create(AWSCredentials credentials, RegionEndpoint regionEndpoint, string clientInstanceName)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (clientInstanceName == null)
		{
			throw new ArgumentNullException("clientInstanceName");
		}
		RobloxDaxClientDefaultSettings settings = GetDefaultSettings();
		RobloxDaxClientConfig robloxDaxClientConfig = new RobloxDaxClientConfig(clientInstanceName, settings);
		((ClientConfig)robloxDaxClientConfig).RegionEndpoint = regionEndpoint;
		RobloxDaxClientConfig config = robloxDaxClientConfig;
		return Create(credentials, config);
	}

	/// <inheritdoc />
	public RobloxDaxClientDefaultSettings GetDefaultSettings()
	{
		return _CurrentDefaultSettings;
	}

	private void RebuildSettings()
	{
		RobloxDaxClientDefaultSettings newSettings = new RobloxDaxClientDefaultSettings(_Settings);
		if (!_CurrentDefaultSettings.Equals(newSettings))
		{
			_CurrentDefaultSettings = newSettings;
			this.DefaultClientSettingsChanged?.Invoke(_CurrentDefaultSettings);
		}
	}
}
