using System;
using Roblox.CommunitySift;
using Roblox.ContentFilterApi.Client;

namespace Roblox.TextFilter;

/// <summary>
/// Factory for generating TextFilters.
/// </summary>
public interface ITextFilterFactory
{
	/// <summary>
	/// Basic factory methods generates default values.
	/// We eventually want to move away from this method.
	/// </summary>
	/// <returns></returns>
	[Obsolete("This method is not safe (hidden dependencies); Please use `GetTextFilter(ICommunitySiftClient communitySiftClient, IContentFilterClient contentFilterClient)`.")]
	ITextFilter GetTextFilter();

	/// <summary>
	/// Factory method supporting explicity CommSift and ContentFilter clients.
	/// </summary>
	/// <param name="communitySiftClient"></param>
	/// <param name="contentFilterClient"></param>
	/// <returns></returns>
	ITextFilter GetTextFilter(ICommunitySiftClient communitySiftClient, IContentFilterClient contentFilterClient);
}
