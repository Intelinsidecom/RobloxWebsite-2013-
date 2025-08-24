using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocalesAuditCompositeEntryAccessor : IAccountLocalesAuditCompositeEntryAccessor
{
	private readonly IAccountLocalesAuditMetadataEntityFactory _MetadataEntityFactory;

	private readonly IAccountLocalesAuditEntryEntityFactory _AuditEntryEntityFactory;

	private readonly IAccountLocaleEntityFactory _AccountLocaleEntityFactory;

	private readonly ISettings _Settings;

	private readonly IAccountLocalesAuditCompositeEntryFactory _AuditCompositeEntryFactory;

	private readonly IAccountLocalesAuditMetadataTypeConverter _MetadataTypeConverter;

	internal AccountLocalesAuditCompositeEntryAccessor(IAccountLocalesAuditMetadataEntityFactory metadataEntityFactory, IAccountLocalesAuditEntryEntityFactory auditEntryEntityFactory, IAccountLocaleEntityFactory accountLocaleEntityFactory, ISettings settings, IAccountLocalesAuditCompositeEntryFactory auditCompositeEntryFactory, IAccountLocalesAuditMetadataTypeConverter metadataTypeConverter)
	{
		_MetadataEntityFactory = metadataEntityFactory.AssignOrThrowIfNull("metadataEntityFactory");
		_AuditEntryEntityFactory = auditEntryEntityFactory.AssignOrThrowIfNull("auditEntryEntityFactory");
		_AccountLocaleEntityFactory = accountLocaleEntityFactory.AssignOrThrowIfNull("accountLocaleEntityFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_AuditCompositeEntryFactory = auditCompositeEntryFactory.AssignOrThrowIfNull("auditCompositeEntryFactory");
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
	}

	public ICollection<IAccountLocalesAuditCompositeEntry> GetSupportedLocaleHistory(IUser user, byte count, long exclusiveStartId = long.MaxValue)
	{
		return GetAuditHistoryByMetadataType(AccountLocalesAuditEntryMetadataType.SupportedLocaleSetOrChanged, user, count, exclusiveStartId);
	}

	public ICollection<IAccountLocalesAuditCompositeEntry> GetObservedLocaleHistory(IUser user, byte count, long exclusiveStartId = long.MaxValue)
	{
		return GetAuditHistoryByMetadataType(AccountLocalesAuditEntryMetadataType.ObservedLocaleSetOrChanged, user, count, exclusiveStartId);
	}

	internal ICollection<IAccountLocalesAuditCompositeEntry> GetAuditHistoryByMetadataType(AccountLocalesAuditEntryMetadataType metadataType, IUser user, byte count, long exclusiveStartId)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		IAccountLocaleEntity accountLocale = _AccountLocaleEntityFactory.GetByAccountId(user.AccountId);
		if (accountLocale == null)
		{
			return new List<IAccountLocalesAuditCompositeEntry>();
		}
		return GetByAuditIdAndMetadataTypeEnumerative(accountLocale.Id, metadataType, count, exclusiveStartId);
	}

	private ICollection<IAccountLocalesAuditCompositeEntry> GetByAuditIdAndMetadataTypeEnumerative(long accountLocaleId, AccountLocalesAuditEntryMetadataType metadataType, byte count, long exclusiveStartId)
	{
		if (count > _Settings.AccountLocalesAuditCompositeEntryCountLimit)
		{
			throw new PlatformArgumentException(string.Format("{0} can not exceed {1}.", "count", _Settings.AccountLocalesAuditCompositeEntryCountLimit));
		}
		byte metadataTypeId = _MetadataTypeConverter.GetEntityIdFromEnum(metadataType);
		IAccountLocalesAuditMetadataEntity[] metadata = _MetadataEntityFactory.GetByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeIdEnumerative(accountLocaleId, metadataTypeId, count, exclusiveStartId).ToArray();
		if (!metadata.Any())
		{
			return new IAccountLocalesAuditCompositeEntry[0];
		}
		IAccountLocalesAuditEntryEntity[] auditEntries = _AuditEntryEntityFactory.MultiGetByPublicIds(metadata.Select((IAccountLocalesAuditMetadataEntity md) => md.AccountLocalesAuditEntryPublicId).Distinct().ToArray()).ToArray();
		if (!auditEntries.Any())
		{
			return new IAccountLocalesAuditCompositeEntry[0];
		}
		return (from mData in metadata
			join aEntry in auditEntries on mData.AccountLocalesAuditEntryPublicId equals aEntry.PublicId into aEntry
			select GetByComposition(mData, aEntry.SingleOrDefault()) into composite
			orderby composite.Id descending
			select composite).ToArray();
	}

	private IAccountLocalesAuditCompositeEntry GetByComposition(IAccountLocalesAuditMetadataEntity metadata, IAccountLocalesAuditEntryEntity entry)
	{
		return _AuditCompositeEntryFactory.Create(metadata, entry);
	}
}
