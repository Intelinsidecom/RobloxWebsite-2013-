using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ModerationLocaleEntityFactory : IModerationLocaleEntityFactory, IDomainFactory<ModerationDomainFactories>, IDomainObject<ModerationDomainFactories>
{
	public ModerationDomainFactories DomainFactories { get; }

	public ModerationLocaleEntityFactory(ModerationDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IModerationLocaleEntity Get(int id)
	{
		return CalToCachedMssql(ModerationLocaleCAL.Get(id));
	}

	public IModerationLocaleEntity GetBySupportedLocaleId(int supportedLocaleId)
	{
		return CalToCachedMssql(ModerationLocaleCAL.GetBySupportedLocaleID(supportedLocaleId));
	}

	public IEnumerable<IModerationLocaleEntity> GetByIsActiveEnumerative(bool isActive, int count, int exclusiveStartId = 0)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException("'count' must be positive");
		}
		return ModerationLocaleCAL.GetModerationLocalesByIsActive(isActive, count, exclusiveStartId).Select(CalToCachedMssql);
	}

	public IModerationLocaleEntity GetOrCreate(int supportedLocaleId)
	{
		return CalToCachedMssql(ModerationLocaleCAL.GetOrCreate(supportedLocaleId));
	}

	private static IModerationLocaleEntity CalToCachedMssql(ModerationLocaleCAL cal)
	{
		if (cal != null)
		{
			return new ModerationLocaleCachedMssqlEntity
			{
				Id = cal.ID,
				SupportedLocaleId = cal.SupportedLocaleID,
				IsActive = cal.IsActive,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
