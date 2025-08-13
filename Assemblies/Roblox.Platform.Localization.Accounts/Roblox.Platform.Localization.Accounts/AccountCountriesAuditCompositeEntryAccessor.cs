using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountriesAuditCompositeEntryAccessor : IAccountCountriesAuditCompositeEntryAccessor
{
	private readonly IAccountCountriesAuditMetadataEntityFactory _AccountCountriesAuditMetadataEntityFactory;

	private readonly IAccountCountriesAuditEntryEntityFactory _AccountCountriesAuditEntryEntityFactory;

	private readonly IAccountCountryEntityFactory _AccountCountryEntityFactory;

	private readonly ISettings _Settings;

	private readonly IAccountCountriesAuditCompositeEntryFactory _AuditCompositeEntryFactory;

	private readonly IAccountCountriesAuditMetadataTypeConverter _MetadataTypeConverter;

	internal AccountCountriesAuditCompositeEntryAccessor(IAccountCountriesAuditMetadataEntityFactory accountCountriesAuditMetadataEntityFactory, IAccountCountriesAuditEntryEntityFactory accountCountriesAuditEntryEntityFactory, IAccountCountryEntityFactory accountCountryEntityFactory, ISettings settings, IAccountCountriesAuditCompositeEntryFactory auditCompositeEntryFactory, IAccountCountriesAuditMetadataTypeConverter metadataTypeConverter)
	{
		_AccountCountriesAuditMetadataEntityFactory = accountCountriesAuditMetadataEntityFactory.AssignOrThrowIfNull("accountCountriesAuditMetadataEntityFactory");
		_AccountCountriesAuditEntryEntityFactory = accountCountriesAuditEntryEntityFactory.AssignOrThrowIfNull("accountCountriesAuditEntryEntityFactory");
		_AccountCountryEntityFactory = accountCountryEntityFactory.AssignOrThrowIfNull("accountCountryEntityFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_AuditCompositeEntryFactory = auditCompositeEntryFactory.AssignOrThrowIfNull("auditCompositeEntryFactory");
		_MetadataTypeConverter = metadataTypeConverter.AssignOrThrowIfNull("metadataTypeConverter");
	}

	public ICollection<IAccountCountriesAuditCompositeEntry> GetCountryHistory(IUser user, byte count, long exclusiveStartId = 0L)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} can not be null.", "user"));
		}
		IAccountCountryEntity accountCountry = _AccountCountryEntityFactory.GetByAccountId(user.AccountId);
		if (accountCountry == null)
		{
			return new List<IAccountCountriesAuditCompositeEntry>();
		}
		return GetByAuditIdAndMetadataTypeEnumerative(accountCountry.Id, AccountCountriesAuditEntryMetadataType.CountrySetOrChanged, count, exclusiveStartId);
	}

	internal ICollection<IAccountCountriesAuditCompositeEntry> GetByAuditIdAndMetadataTypeEnumerative(long auditId, AccountCountriesAuditEntryMetadataType metadataType, byte count, long? exclusiveStartId = long.MaxValue)
	{
		if (count > _Settings.AccountCountriesAuditCompositeEntryCountLimit)
		{
			throw new PlatformArgumentException(string.Format("{0} can not exceed {1}.", "count", _Settings.AccountCountriesAuditCompositeEntryCountLimit));
		}
		byte metadataTypeId = _MetadataTypeConverter.GetEntityIdFromEnum(metadataType);
		IAccountCountriesAuditMetadataEntity[] metadata = _AccountCountriesAuditMetadataEntityFactory.GetByAccountCountriesAuditEntryAuditIdAndAccountCountriesAuditMetadataTypeIdEnumerative(auditId, metadataTypeId, count, exclusiveStartId).ToArray();
		if (!metadata.Any())
		{
			return new IAccountCountriesAuditCompositeEntry[0];
		}
		IAccountCountriesAuditEntryEntity[] auditEntries = _AccountCountriesAuditEntryEntityFactory.SingleGetsByPublicIds(metadata.Select((IAccountCountriesAuditMetadataEntity md) => md.AccountCountriesAuditEntryPublicId).Distinct().ToArray()).ToArray();
		if (!auditEntries.Any())
		{
			return new IAccountCountriesAuditCompositeEntry[0];
		}
		return (from mData in metadata
			join aEntry in auditEntries on mData.AccountCountriesAuditEntryPublicId equals aEntry.PublicId into aEntries
			select GetByComposition(mData, aEntries.FirstOrDefault())).ToArray();
	}

	private IAccountCountriesAuditCompositeEntry GetByComposition(IAccountCountriesAuditMetadataEntity metadata, IAccountCountriesAuditEntryEntity entry)
	{
		return _AuditCompositeEntryFactory.Create(metadata, entry);
	}
}
