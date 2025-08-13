using System;
using Amazon;
using Amazon.DAX;
using Amazon.Runtime;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Responsible for creating <see cref="T:Amazon.DAX.IAmazonDAX" />s as well as the authority on the default settings.
/// </summary>
public interface IRobloxDaxClientFactory
{
	/// <summary>
	/// Occurs when default client settings changed <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings" />.
	/// Don't forget to unsubscribe to avoid memory leaks.
	/// </summary>
	event Action<RobloxDaxClientDefaultSettings> DefaultClientSettingsChanged;

	/// <summary>
	/// Gets the default client settings.
	/// </summary>
	/// <returns><see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings" /></returns>
	RobloxDaxClientDefaultSettings GetDefaultSettings();

	/// <summary>
	/// Creates a new <see cref="T:Amazon.DAX.IAmazonDAX" /> using <paramref name="credentials" /> and the default <see cref="T:Amazon.RegionEndpoint" />.
	/// </summary>
	/// <param name="credentials">The <see cref="T:Amazon.Runtime.AWSCredentials" /> to use.</param>
	/// <param name="clientInstanceName">The name of the client.</param>
	/// <returns>The created <see cref="T:Amazon.DAX.IAmazonDAX" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="credentials" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="clientInstanceName" /> is null or empty.</exception>
	IAmazonDAX Create(AWSCredentials credentials, string clientInstanceName);

	/// <summary>
	/// Creates a new <see cref="T:Amazon.DAX.IAmazonDAX" /> using <paramref name="credentials" /> and a custom <see cref="T:Amazon.RegionEndpoint" />.
	/// </summary>
	/// <param name="credentials">The <see cref="T:Amazon.Runtime.AWSCredentials" /> to use.</param>
	/// <param name="regionEndpoint">The <see cref="T:Amazon.RegionEndpoint" /> to use.</param>
	/// <param name="clientInstanceName">The name of the client.</param>
	/// <returns>The created <see cref="T:Amazon.DAX.IAmazonDAX" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="credentials" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="regionEndpoint" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="clientInstanceName" /> is null or empty.</exception>
	IAmazonDAX Create(AWSCredentials credentials, RegionEndpoint regionEndpoint, string clientInstanceName);

	/// <summary>
	/// Creates a new <see cref="T:Amazon.DAX.IAmazonDAX" /> using an explicit <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientConfig" />.
	/// </summary>
	/// <param name="credentials">The <see cref="T:Amazon.Runtime.AWSCredentials" /> to use.</param>
	/// <param name="daxClientConfig">The <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientConfig" /> to use.</param>
	/// <returns>The created <see cref="T:Amazon.DAX.IAmazonDAX" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="credentials" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="daxClientConfig" /></exception>
	IAmazonDAX Create(AWSCredentials credentials, RobloxDaxClientConfig daxClientConfig);
}
