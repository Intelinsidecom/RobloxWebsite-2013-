using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Moderation.Entities;

namespace Roblox.Platform.Moderation;

/// <inheritdoc />
internal class ModerationLocaleFactory : IModerationLocaleFactory
{
	private readonly ModerationDomainFactories _DomainFactories;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	public ModerationLocaleFactory(ModerationDomainFactories domainFactories, ICoreLocalizationAccessor coreLocalizationAccessor)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new ArgumentNullException("coreLocalizationAccessor");
	}

	/// <inheritdoc />
	public ICollection<IModerationLocale> GetAllModerationLocalesByActiveStatus(bool isActive)
	{
		return (from l in _DomainFactories.ModerationLocaleEntityFactory.GetByIsActiveEnumerative(isActive, int.MaxValue).Select(EntityToPlatform)
			where l != null
			select l).ToArray();
	}

	/// <inheritdoc />
	public IModerationLocale GetActiveByLocalizationLocale(ISupportedLocaleIdentifier localeIdentifier)
	{
		return GetAllModerationLocalesByActiveStatus(isActive: true).FirstOrDefault((IModerationLocale ml) => ml.SupportedLocale.Id == localeIdentifier?.Id);
	}

	public IModerationLocale GetOrCreate(ISupportedLocale locale)
	{
		if (locale == null)
		{
			throw new PlatformArgumentNullException("locale");
		}
		IModerationLocaleEntity entity = _DomainFactories.ModerationLocaleEntityFactory.GetOrCreate(locale.Id);
		return EntityToPlatform(entity);
	}

	private IModerationLocale EntityToPlatform(IModerationLocaleEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		ISupportedLocale supportedLocale = _CoreLocalizationAccessor.GetSupportedLocaleBySupportedLocaleId(GetSupportedLocaleIdentifier(entity.SupportedLocaleId));
		return new ModerationLocale(_DomainFactories, entity, supportedLocale);
	}

	internal virtual ISupportedLocaleIdentifier GetSupportedLocaleIdentifier(int supportedLocaleId)
	{
		return new SupportedLocaleIdentifier(supportedLocaleId);
	}
}
