using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Caching.Interfaces;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.StaticContent;
using Roblox.StaticContent.Client;
using Roblox.TranslationResources;
using Roblox.Web.Authentication;
using Roblox.Web.Code;
using Roblox.Web.Code.Interfaces;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Web.StaticContent.IStaticContentRenderer" />
public class StaticContentRenderer : IStaticContentRenderer
{
	private const string _ComponentRenderedCheckCacheKeyPrefix = "Roblox.Web.StaticContent.StaticContentRenderer.HasComponentBeenRendered";

	private readonly IRequestCache _RequestCache;

	private readonly IStaticContentSettings _StaticContentSettings;

	private readonly IStaticContentResolver _StaticContentResolver;

	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	private readonly ILocalizationResourceScripts _LocalizationResourceScripts;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.StaticContentRenderer" />.
	/// </summary>
	/// <param name="staticContentResolver">An <see cref="T:Roblox.Web.StaticContent.IStaticContentResolver" />.</param>
	/// <param name="webAuthenticationReader">An <see cref="T:Roblox.Web.Authentication.IWebAuthenticationReader" />.</param>
	/// <param name="localizationResourceProvider">An <see cref="T:Roblox.Platform.Localization.Accounts.ILocalizationResourceProvider" />.</param>
	/// <param name="localizationResourceScripts">An <see cref="T:Roblox.Web.Code.Interfaces.ILocalizationResourceScripts" />.</param>
	/// <param name="requestCache">An <see cref="T:Roblox.Caching.Interfaces.IRequestCache" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentResolver" />
	/// - <paramref name="webAuthenticationReader" />
	/// - <paramref name="localizationResourceProvider" />
	/// - <paramref name="localizationResourceScripts" />
	/// - <paramref name="requestCache" />
	/// </exception>
	public StaticContentRenderer(IStaticContentResolver staticContentResolver, IWebAuthenticationReader webAuthenticationReader, ILocalizationResourceProvider localizationResourceProvider, ILocalizationResourceScripts localizationResourceScripts, IRequestCache requestCache)
		: this(staticContentResolver, webAuthenticationReader, localizationResourceProvider, localizationResourceScripts, requestCache, Settings.Default)
	{
	}

	internal StaticContentRenderer(IStaticContentResolver staticContentResolver, IWebAuthenticationReader webAuthenticationReader, ILocalizationResourceProvider localizationResourceProvider, ILocalizationResourceScripts localizationResourceScripts, IRequestCache requestCache, IStaticContentSettings staticContentSettings)
	{
		_StaticContentResolver = staticContentResolver ?? throw new ArgumentNullException("staticContentResolver");
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_LocalizationResourceProvider = localizationResourceProvider ?? throw new ArgumentNullException("localizationResourceProvider");
		_LocalizationResourceScripts = localizationResourceScripts ?? throw new ArgumentNullException("localizationResourceScripts");
		_RequestCache = requestCache ?? throw new ArgumentNullException("requestCache");
		_StaticContentSettings = staticContentSettings ?? throw new ArgumentNullException("staticContentSettings");
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentRenderer.GetContentHtmlTags(Roblox.Platform.StaticContent.StaticContentComponent,Roblox.StaticContent.Client.StaticContentContentType)" />
	public string GetContentHtmlTags(StaticContentComponent component, StaticContentContentType contentType)
	{
		if (HasComponentBeenRendered(component, contentType))
		{
			return string.Empty;
		}
		SetComponentHasRendered(component, contentType);
		StringBuilder tagBuilder = new StringBuilder();
		if (_StaticContentSettings.ComponentDependencyLoadingEnabled)
		{
			foreach (StaticContentComponent componentDependency in _StaticContentResolver.GetComponentDependencies(component))
			{
				tagBuilder.Append(GetContentHtmlTags(componentDependency, contentType));
			}
		}
		if (contentType == StaticContentContentType.Css || contentType == StaticContentContentType.JavaScript)
		{
			foreach (Uri uri in _StaticContentResolver.GetStaticContentUrls(component, contentType))
			{
				switch (contentType)
				{
				case StaticContentContentType.Css:
					tagBuilder.AppendLine(RobloxCSS.RenderWebAppStylesheetTag(uri.AbsoluteUri, component.ToString()));
					break;
				case StaticContentContentType.JavaScript:
					tagBuilder.AppendLine(RobloxScripts.RenderWebAppScriptTag(uri.AbsoluteUri, component.ToString()));
					break;
				}
			}
			if (contentType == StaticContentContentType.JavaScript)
			{
				AddTranslationResources(component);
			}
		}
		return tagBuilder.ToString();
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentRenderer.AddTranslationResources(Roblox.Platform.StaticContent.StaticContentComponent)" />
	public void AddTranslationResources(StaticContentComponent component)
	{
		ISet<string> translationResourceNamespaces = _StaticContentResolver.GetTranslationResourceNamespaces(component);
		if (!translationResourceNamespaces.Any())
		{
			return;
		}
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		IMasterResources masterResources = _LocalizationResourceProvider.GetLocalizationResources(authenticatedUser);
		foreach (ITranslationResources translationResources in translationResourceNamespaces.Select(masterResources.GetTranslationResourcesByFullNamespace))
		{
			if (translationResources != null)
			{
				AddLocalizationResources(translationResources);
			}
		}
	}

	private void AddLocalizationResources(ITranslationResources translationResources)
	{
		string translationResourcesScript = _LocalizationResourceScripts.GetScriptFileForResource(translationResources);
		if (!RobloxScripts.PageScripts.Contains(translationResourcesScript))
		{
			RobloxScripts.PageEndScripts.Add(translationResourcesScript);
		}
	}

	private bool HasComponentBeenRendered(StaticContentComponent component, StaticContentContentType contentType)
	{
		string cacheKey = GetRenderedCacheKey(component, contentType);
		if (_RequestCache.Get<bool>(cacheKey, out var rendered))
		{
			return rendered;
		}
		return false;
	}

	private void SetComponentHasRendered(StaticContentComponent component, StaticContentContentType contentType)
	{
		string cacheKey = GetRenderedCacheKey(component, contentType);
		_RequestCache.Set(cacheKey, value: true);
	}

	private string GetRenderedCacheKey(StaticContentComponent component, StaticContentContentType contentType)
	{
		return string.Format("{0}:{1}:{2}", "Roblox.Web.StaticContent.StaticContentRenderer.HasComponentBeenRendered", component, contentType);
	}
}
