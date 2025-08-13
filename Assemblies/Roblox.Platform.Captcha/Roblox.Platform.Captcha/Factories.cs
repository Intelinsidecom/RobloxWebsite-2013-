using Roblox.Caching.Shared;
using Roblox.Platform.Core;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents a set of factories used by the Captcha platform.
/// </summary>
public class Factories
{
	internal ISuccessFactory SuccessFactory { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Captcha.Factories" /> class.
	/// </summary>
	/// <param name="sharedCacheClient"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sharedCacheClient" /> is null.</exception>
	public Factories(ISharedCacheClient sharedCacheClient)
	{
		if (sharedCacheClient == null)
		{
			throw new PlatformArgumentNullException("sharedCacheClient");
		}
		SuccessFactory = new SuccessFactory(sharedCacheClient);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Captcha.Factories" /> class.
	/// </summary>
	/// <param name="sharedCacheClient"></param>
	/// <param name="initialize">Whether or not to initialize each of the factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sharedCacheClient" /> is null, but only when <paramref name="initialize" /> is true.</exception>
	internal Factories(ISharedCacheClient sharedCacheClient, bool initialize)
	{
		if (initialize)
		{
			if (sharedCacheClient == null)
			{
				throw new PlatformArgumentNullException("sharedCacheClient");
			}
			SuccessFactory = new SuccessFactory(sharedCacheClient);
		}
	}
}
