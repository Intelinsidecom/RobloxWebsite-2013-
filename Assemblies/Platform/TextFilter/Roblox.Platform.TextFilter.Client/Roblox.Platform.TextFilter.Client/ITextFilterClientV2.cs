using System.Threading;
using System.Threading.Tasks;

namespace Roblox.TextFilter.Client;

public interface ITextFilterClientV2
{
	FilterLiveTextResult FilterLiveText(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId);

	Task<FilterLiveTextResult> FilterLiveTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId, CancellationToken cancellationToken);

	FilterTextResult FilterObjectName(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId = "", bool ignoreVerticalFilter = false);

	Task<FilterTextResult> FilterObjectNameAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken);

	FilterTextResult FilterSearchKeyword(string text, IClientTextAuthor author, TextFilterUsage usage);

	Task<FilterTextResult> FilterSearchKeywordAsync(string text, IClientTextAuthor author, TextFilterUsage usage, CancellationToken cancellationToken);

	FilterTextResult FilterText(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId = "", bool ignoreVerticalFilter = false);

	Task<FilterTextResult> FilterTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken);

	FilterUsernameResult FilterUsername(string text, IClientTextAuthor author, bool canBypassReservedUsername);

	Task<FilterUsernameResult> FilterUsernameAsync(string text, IClientTextAuthor author, bool canBypassReservedUsername, CancellationToken cancellationToken);
}
