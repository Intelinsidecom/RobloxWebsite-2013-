using System;
using System.ComponentModel;
using System.Linq;
using Roblox.DataV2.Core;
using Roblox.EventLog;
using Roblox.Http.ServiceClient;
using Roblox.Platform.Core;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.Membership;
using Roblox.Platform.StaticContent.Properties;

namespace Roblox.Platform.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IUserStaticContentFactory" />
public class UserStaticContentFactory : IUserStaticContentFactory
{
	private const int _PageSize = 1;

	private readonly IStaticContentFactory _StaticContentFactory;

	private readonly IContentValidationApprover _ContentValidationApprover;

	private readonly IComponentSuffixProvider _ComponentSuffixProvider;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly IExclusiveStartKeyInfo<long> _LatestContentPackPageExclusiveStartKeyInfo;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.UserStaticContentFactory" />.
	/// </summary>
	/// <param name="staticContentFactory">An <see cref="T:Roblox.Platform.StaticContent.IStaticContentFactory" />.</param>
	/// <param name="contentValidationApprover">An <see cref="T:Roblox.Platform.StaticContent.IContentValidationApprover" />.</param>
	/// <param name="componentSuffixProvider">An <see cref="T:Roblox.Platform.StaticContent.IComponentSuffixProvider" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentFactory" />
	/// - <paramref name="contentValidationApprover" />
	/// - <paramref name="componentSuffixProvider" />
	/// - <paramref name="logger" />
	/// </exception>
	public UserStaticContentFactory(IStaticContentFactory staticContentFactory, IContentValidationApprover contentValidationApprover, IComponentSuffixProvider componentSuffixProvider, ILogger logger)
		: this(staticContentFactory, contentValidationApprover, componentSuffixProvider, logger, Settings.Default)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.UserStaticContentFactory" />.
	/// </summary>
	/// <param name="staticContentFactory">An <see cref="T:Roblox.Platform.StaticContent.IStaticContentFactory" />.</param>
	/// <param name="contentValidationApprover">An <see cref="T:Roblox.Platform.StaticContent.IContentValidationApprover" />.</param>
	/// <param name="componentSuffixProvider">An <see cref="T:Roblox.Platform.StaticContent.IComponentSuffixProvider" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="settings">An <see cref="T:Roblox.Platform.StaticContent.Properties.ISettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="staticContentFactory" />
	/// - <paramref name="contentValidationApprover" />
	/// - <paramref name="componentSuffixProvider" />
	/// - <paramref name="logger" />
	/// - <paramref name="settings" />
	/// </exception>
	internal UserStaticContentFactory(IStaticContentFactory staticContentFactory, IContentValidationApprover contentValidationApprover, IComponentSuffixProvider componentSuffixProvider, ILogger logger, ISettings settings)
	{
		_StaticContentFactory = staticContentFactory ?? throw new ArgumentNullException("staticContentFactory");
		_ContentValidationApprover = contentValidationApprover ?? throw new ArgumentNullException("contentValidationApprover");
		_ComponentSuffixProvider = componentSuffixProvider ?? throw new ArgumentNullException("componentSuffixProvider");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_LatestContentPackPageExclusiveStartKeyInfo = new ExclusiveStartKeyInfo<long>(SortOrder.Desc, PagingDirection.Forward, 1);
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IUserStaticContentFactory.GetLatestContentPack(Roblox.Platform.Membership.IUser,Roblox.Platform.StaticContent.StaticContentComponent)" />
	public IContentPack GetLatestContentPack(IUser user, StaticContentComponent component)
	{
		if (!Enum.IsDefined(typeof(StaticContentComponent), component))
		{
			throw new InvalidEnumArgumentException("component", (int)component, typeof(StaticContentComponent));
		}
		IContentPack suffixedContentPack = null;
		string componentSuffix = _ComponentSuffixProvider.GetComponentSuffix();
		if (!string.IsNullOrWhiteSpace(componentSuffix))
		{
			string suffixedComponentName = $"{component}:{componentSuffix}";
			try
			{
				suffixedContentPack = GetLatestContentPack(user, suffixedComponentName);
			}
			catch (ServiceOperationErrorException e)
			{
				_Logger.Verbose($"Error retrieving content pack with suffix. Are you sure you rebuilt the WebApp being retrieved?\n\tComponent: {suffixedComponentName}\n\n{e}");
			}
			if (suffixedContentPack != null && suffixedContentPack.Created > DateTime.UtcNow - _Settings.ComponentSuffixMaxAge)
			{
				return suffixedContentPack;
			}
		}
		IContentPack latestContentPack = GetLatestContentPack(user, component.ToString());
		return latestContentPack ?? suffixedContentPack;
	}

	internal IContentPack GetLatestContentPack(IUser user, string componentName)
	{
		IContentPack contentPack = _StaticContentFactory.GetContentPacks(componentName, enabled: true, validated: true, exclusiveStartKey: _LatestContentPackPageExclusiveStartKeyInfo, useCache: true).Items.FirstOrDefault();
		if (_ContentValidationApprover.CanAccessInvalidatedContent(user))
		{
			IContentPack testContentPack = _StaticContentFactory.GetContentPacks(componentName, enabled: true, validated: false, exclusiveStartKey: _LatestContentPackPageExclusiveStartKeyInfo, useCache: true).Items.FirstOrDefault();
			if (testContentPack != null && (contentPack == null || contentPack.Created < testContentPack.Created))
			{
				return testContentPack;
			}
		}
		return contentPack;
	}
}
