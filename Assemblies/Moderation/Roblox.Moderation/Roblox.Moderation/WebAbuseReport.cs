using System;
using System.Collections.Generic;
using System.Web;

namespace Roblox.Moderation;

/// <summary>
/// This is a copy of the SCL WebAbuseReport that uses the <see cref="T:Roblox.Moderation.WebApplicationUrlGetter" /> to remove
/// static dependencies.
/// </summary>
public abstract class WebAbuseReport : AnyAbuseReport
{
	public delegate ICollection<IUtterable> AdditionalUtterableItemsGetter(int identifier);

	private WebApplicationUrlGetter _ApplicationUrlGetter;

	protected IReportContext _ReportContext;

	protected string ApplicationUrl => _ApplicationUrlGetter();

	protected WebAbuseReport(GetUserRankGetter getUserRankGetter, WebApplicationUrlGetter applicationUrlGetter)
		: base(getUserRankGetter)
	{
		_ApplicationUrlGetter = applicationUrlGetter ?? throw new ArgumentNullException("applicationUrlGetter");
	}

	protected IWebsiteReportContext BuildWebsiteContext(string contextUrl)
	{
		string contextUrlText = (string.IsNullOrEmpty(contextUrl) ? $"{ApplicationUrl}/{BuildContextUrl()}" : contextUrl);
		return new WebsiteContext
		{
			ContextUrl = contextUrlText
		};
	}

	/// <summary>
	/// Builds the relative context url 
	/// </summary>
	/// <returns></returns>
	protected abstract string BuildContextUrl();

	public string GetContextUrl()
	{
		if (_ReportContext is WebsiteContext webContext && !string.IsNullOrEmpty(webContext.ContextUrl))
		{
			ContextUrl.GetOrCreate(webContext.ContextUrl.Replace(ApplicationUrl, string.Empty).Replace(HttpUtility.UrlEncode(ApplicationUrl), string.Empty));
			return webContext.ContextUrl;
		}
		return string.Empty;
	}
}
