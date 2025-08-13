using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Redis;

public interface IConnectionBuilder
{
	Task<IConnectionMultiplexer> CreateConnectionMultiplexerAsync(ConfigurationOptions configuration);
}
