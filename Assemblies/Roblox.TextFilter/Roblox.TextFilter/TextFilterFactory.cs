using System;
using Roblox.CommunitySift;
using Roblox.ContentFilterApi.Client;
using Roblox.TextFilter.Properties;

namespace Roblox.TextFilter;

/// <summary>
/// Factory for generating <see cref="T:Roblox.TextFilter.ITextFilter" /> objects.
/// </summary>
public class TextFilterFactory : ITextFilterFactory
{
	/// <summary>
	/// Get an instance of a new TextFilter. A new instance of an ICommunitySiftClient 
	/// will be instatiated to be used by this text filter
	/// </summary>
	[Obsolete("This method is not safe (hidden dependencies); Please use `GetTextFilter(ICommunitySiftClient communitySiftClient, IContentFilterClient contentFilterClient)`.")]
	public ITextFilter GetTextFilter()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		CommunitySiftClient communitySiftClient = new CommunitySiftClient(new CommunitySiftRestClient());
		ContentFilterClient contentFilterClient = new ContentFilterClient((Func<string>)(() => Settings.Default.ContentFilterApiKey));
		return GetTextFilter(communitySiftClient, (IContentFilterClient)(object)contentFilterClient);
	}

	/// <summary>
	/// Get an instance of a new TextFilter using the ICommunitySiftClient provided.
	/// </summary>
	public ITextFilter GetTextFilter(ICommunitySiftClient communitySiftClient, IContentFilterClient contentFilterClient)
	{
		Settings @default = Settings.Default;
		UsernameFilter usernameFilter = new UsernameFilter(@default, contentFilterClient);
		return new MetricTrackingTextFilterDecorator(new BasicTextFilter(@default, communitySiftClient, contentFilterClient, usernameFilter));
	}
}
