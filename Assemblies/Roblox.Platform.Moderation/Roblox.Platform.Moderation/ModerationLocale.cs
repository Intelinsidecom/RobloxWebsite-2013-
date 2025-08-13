using System;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Moderation.Entities;

namespace Roblox.Platform.Moderation;

internal class ModerationLocale : IModerationLocale
{
	private readonly ModerationDomainFactories _DomainFactories;

	public int Id { get; }

	public ISupportedLocale SupportedLocale { get; private set; }

	public bool IsActive { get; private set; }

	internal ModerationLocale(ModerationDomainFactories domainFactories, IModerationLocaleEntity entity, ISupportedLocale supportedLocale)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (supportedLocale == null)
		{
			throw new ArgumentNullException("supportedLocale");
		}
		if (entity.SupportedLocaleId != supportedLocale.Id)
		{
			throw new ArgumentException("supportedLocale");
		}
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		Id = entity.Id;
		SupportedLocale = supportedLocale;
		IsActive = entity.IsActive;
	}

	public void SetIsActive(bool isActive)
	{
		IModerationLocaleEntity obj = _DomainFactories.ModerationLocaleEntityFactory.Get(Id) ?? throw new InvalidOperationException($"Attempted update unpersisted entity with id {Id}");
		obj.IsActive = isActive;
		obj.Update();
		IsActive = isActive;
	}
}
