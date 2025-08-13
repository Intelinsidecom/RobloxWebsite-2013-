using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

public class DefaultConnectionBuilder : IConnectionBuilder
{
	public async Task<IConnectionMultiplexer> CreateConnectionMultiplexerAsync(ConfigurationOptions configurationOptions)
	{
		return await ConnectionMultiplexer.ConnectAsync(configurationOptions).ConfigureAwait(continueOnCapturedContext: false);
	}
}
