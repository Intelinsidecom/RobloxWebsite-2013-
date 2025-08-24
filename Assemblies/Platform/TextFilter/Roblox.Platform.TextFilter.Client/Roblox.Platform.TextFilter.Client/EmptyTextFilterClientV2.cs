using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.TextFilter.Client;

public class EmptyTextFilterClientV2 : ITextFilterClientV2
{
	public FilterLiveTextResult FilterLiveText(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId)
	{
		throw new NotImplementedException();
	}

	public Task<FilterLiveTextResult> FilterLiveTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string server, string instanceId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public FilterTextResult FilterObjectName(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter)
	{
		throw new NotImplementedException();
	}

	public Task<FilterTextResult> FilterObjectNameAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public FilterTextResult FilterSearchKeyword(string text, IClientTextAuthor author, TextFilterUsage usage)
	{
		throw new NotImplementedException();
	}

	public Task<FilterTextResult> FilterSearchKeywordAsync(string text, IClientTextAuthor author, TextFilterUsage usage, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public FilterTextResult FilterText(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter)
	{
		throw new NotImplementedException();
	}

	public Task<FilterTextResult> FilterTextAsync(string text, IClientTextAuthor author, TextFilterUsage usage, string instanceId, bool ignoreVerticalFilter, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public FilterUsernameResult FilterUsername(string text, IClientTextAuthor author, bool canBypassReservedUsername)
	{
		throw new NotImplementedException();
	}

	public Task<FilterUsernameResult> FilterUsernameAsync(string text, IClientTextAuthor author, bool canBypassReservedUsername, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}
