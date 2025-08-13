using System;
using System.Collections.Generic;
using System.ComponentModel;
using Roblox.Caching.Interfaces;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.StaticContent;
using Roblox.StaticContent.Client;
using Roblox.Web.Authentication;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Web.StaticContent.IStaticContentResolver" />
public class StaticContentResolver : IStaticContentResolver
{
	private const string _ContentPackCacheKeyPrefix = "Roblox.Web.StaticContent.StaticContentResolver.GetLatestContentPack";

	private readonly IUserStaticContentFactory _UserStaticContentFactory;

	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly IStaticContentSettings _StaticContentSettings;

	private readonly ILogger _Logger;

	private readonly IRequestCache _RequestCache;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.StaticContentResolver" />.
	/// </summary>
	/// <param name="userStaticContentFactory">An <see cref="T:Roblox.Platform.StaticContent.IUserStaticContentFactory" />.</param>
	/// <param name="webAuthenticationReader">An <see cref="T:Roblox.Web.Authentication.IWebAuthenticationReader" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="requestCache">An <see cref="T:Roblox.Caching.Interfaces.IRequestCache" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="userStaticContentFactory" />
	/// - <paramref name="webAuthenticationReader" />
	/// - <paramref name="logger" />
	/// - <paramref name="requestCache" />
	/// </exception>
	public StaticContentResolver(IUserStaticContentFactory userStaticContentFactory, IWebAuthenticationReader webAuthenticationReader, ILogger logger, IRequestCache requestCache)
		: this(userStaticContentFactory, webAuthenticationReader, Settings.Default, logger, requestCache)
	{
	}

	internal StaticContentResolver(IUserStaticContentFactory userStaticContentFactory, IWebAuthenticationReader webAuthenticationReader, IStaticContentSettings staticContentSettings, ILogger logger, IRequestCache requestCache)
	{
		_UserStaticContentFactory = userStaticContentFactory ?? throw new ArgumentNullException("userStaticContentFactory");
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_StaticContentSettings = staticContentSettings ?? throw new ArgumentNullException("staticContentSettings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_RequestCache = requestCache ?? throw new ArgumentNullException("requestCache");
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentResolver.GetStaticContentUrls(Roblox.Platform.StaticContent.StaticContentComponent,Roblox.StaticContent.Client.StaticContentContentType)" />
	public ISet<Uri> GetStaticContentUrls(StaticContentComponent component, StaticContentContentType contentType)
	{
		if (!Enum.IsDefined(typeof(StaticContentComponent), component))
		{
			throw new InvalidEnumArgumentException("component", (int)component, typeof(StaticContentComponent));
		}
		if (!Enum.IsDefined(typeof(StaticContentContentType), contentType))
		{
			throw new InvalidEnumArgumentException("contentType", (int)contentType, typeof(StaticContentContentType));
		}
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		IContentPack contentPack = GetLatestContentPack(component, authenticatedUser);
		if (contentPack != null)
		{
			switch (contentType)
			{
			case StaticContentContentType.Css:
				return contentPack.CssCdnUrls;
			case StaticContentContentType.JavaScript:
				return contentPack.JavaScriptCdnUrls;
			}
		}
		return new HashSet<Uri>();
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentResolver.GetTranslationResourceNamespaces(Roblox.Platform.StaticContent.StaticContentComponent)" />
	public ISet<string> GetTranslationResourceNamespaces(StaticContentComponent component)
	{
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		return GetLatestContentPack(component, authenticatedUser)?.TranslationResourceNamespaces ?? new HashSet<string>();
	}

	/// <inheritdoc cref="M:Roblox.Web.StaticContent.IStaticContentResolver.GetComponentDependencies(Roblox.Platform.StaticContent.StaticContentComponent)" />
	public ISet<StaticContentComponent> GetComponentDependencies(StaticContentComponent component)
	{
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		return GetLatestContentPack(component, authenticatedUser)?.ComponentDependencies ?? new HashSet<StaticContentComponent>();
	}

	internal virtual IContentPack GetLatestContentPack(StaticContentComponent component, IUser authenticatedUser)
	{
		string cacheKey = string.Format("{0}:{1}:{2}", "Roblox.Web.StaticContent.StaticContentResolver.GetLatestContentPack", component, authenticatedUser?.Id);
		return _RequestCache.Get(cacheKey, () => LoadLatestContentPack(component, authenticatedUser));
	}

	internal IContentPack LoadLatestContentPack(StaticContentComponent component, IUser authenticatedUser)
	{
		try
		{
			return _UserStaticContentFactory.GetLatestContentPack(authenticatedUser, component);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
		return null;
	}
}
