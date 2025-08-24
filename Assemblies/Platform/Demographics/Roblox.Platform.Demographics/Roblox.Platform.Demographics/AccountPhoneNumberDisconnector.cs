using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Demographics.Entities;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides functionality to disconnect accounts from phone numbers.
/// </summary>
public class AccountPhoneNumberDisconnector : IAccountPhoneNumberDisconnector
{
	private readonly DemographicsDomainFactories _DomainFactories;

	private readonly IAccountPhoneNumberDisconnectorSettings _Settings;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.AccountPhoneNumberDisconnector" /> class.
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Demographics.DemographicsDomainFactories" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> If any of the args are null </exception>
	public AccountPhoneNumberDisconnector(DemographicsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		_Settings = _DomainFactories.AccountPhoneNumberDisconnectorSettings;
	}

	/// <inheritdoc />
	public void DisconnectPhoneNumbersFromAccount(IUser user, DisconnectAccountPhoneNumbersReasons reason)
	{
		if (user == null)
		{
			throw new ArgumentNullException();
		}
		DeleteAccountPhoneNumbers(user, reason);
		DisconnectPhoneAudits(user, reason);
	}

	/// <summary>
	/// Deletes account phone numbers for specified user.
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" />User</param>
	/// <param name="reason">
	/// <see cref="T:Roblox.Platform.Demographics.DisconnectAccountPhoneNumbersReasons" />
	/// </param>
	private void DeleteAccountPhoneNumbers(IUser user, DisconnectAccountPhoneNumbersReasons reason)
	{
		int batchSize = _Settings.AccountPhoneNumbersPageSize;
		List<IAccountPhoneNumberEntity> accountPhoneNumbersList = _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdEnumerative(user.AccountId, batchSize)?.ToList();
		while (accountPhoneNumbersList != null && accountPhoneNumbersList.Any())
		{
			DeleteAccountPhoneNumbersEntities(user, accountPhoneNumbersList, reason);
			long? startId = accountPhoneNumbersList.Last().Id;
			accountPhoneNumbersList = _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdEnumerative(user.AccountId, batchSize, startId)?.ToList();
		}
	}

	/// <summary>
	/// Deletes phone number audits for the provided <see cref="T:Roblox.Platform.Membership.IUser" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="reason">The reason for disconnection <see cref="T:Roblox.Platform.Demographics.DisconnectAccountPhoneNumbersReasons" /></param>
	private void DisconnectPhoneAudits(IUser user, DisconnectAccountPhoneNumbersReasons reason)
	{
		int batchSize = _Settings.PhoneNumbersAuditMetadataPageSize;
		List<IAccountPhoneNumbersAuditMetadataEntity> auditMetadata = _DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.GetByUserIdEnumerative(user.Id, batchSize, null)?.ToList();
		while (auditMetadata != null && auditMetadata.Any())
		{
			DisconnectPhoneAuditMetadataEntities(user, auditMetadata, reason);
			long? startId = auditMetadata.Last().Id;
			auditMetadata = _DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.GetByUserIdEnumerative(user.Id, batchSize, startId)?.ToList();
		}
	}

	/// <summary>
	/// Deletes phone audit metadata entities.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="auditMetadata">Collection of <see cref="T:Roblox.Platform.Demographics.Entities.Audit.IAccountPhoneNumbersAuditMetadataEntity" />.</param>
	/// <param name="reason">
	/// <see cref="T:Roblox.Platform.Demographics.DisconnectAccountPhoneNumbersReasons" />
	/// </param>
	private void DisconnectPhoneAuditMetadataEntities(IUser user, IEnumerable<IAccountPhoneNumbersAuditMetadataEntity> auditMetadata, DisconnectAccountPhoneNumbersReasons reason)
	{
		List<Guid> publicGuids = auditMetadata.Select((IAccountPhoneNumbersAuditMetadataEntity meta) => meta.AccountPhoneNumbersAuditEntriesPublicId).ToList();
		foreach (IAccountPhoneNumbersAuditEntryEntity entry in _DomainFactories.AccountPhoneNumbersAuditEntryEntityFactory.GetByPublicIds(publicGuids))
		{
			if (entry.Audit_AccountId == user.AccountId)
			{
				entry.Audit_PhoneNumberId = null;
				entry.Audit_Phone = reason.ToString();
				entry.Update();
			}
		}
	}

	/// <summary>
	/// Deletes account phone numbers entities.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="accountPhoneNumbersList">Collection of <see cref="T:Roblox.Platform.Demographics.Entities.IAccountPhoneNumberEntity" />.</param>
	/// <param name="reason">
	/// <see cref="T:Roblox.Platform.Demographics.DisconnectAccountPhoneNumbersReasons" />
	/// </param>
	private void DeleteAccountPhoneNumbersEntities(IUser user, IEnumerable<IAccountPhoneNumberEntity> accountPhoneNumbersList, DisconnectAccountPhoneNumbersReasons reason)
	{
		foreach (IAccountPhoneNumberEntity accountPhoneNumber in accountPhoneNumbersList)
		{
			accountPhoneNumber.Delete();
			accountPhoneNumber.Phone = reason.ToString();
			accountPhoneNumber.PhoneNumberId = null;
			CreateAuditPhoneNumber(accountPhoneNumber, user, AccountPhoneNumberChangeTypes.PhoneNumberDeleted, null);
		}
	}

	private void CreateAuditPhoneNumber(IAccountPhoneNumberEntity accountPhoneNumberEntity, IUserIdentifier user, AccountPhoneNumberChangeTypes changeType, IUserIdentifier actorUser)
	{
		IAccountPhoneNumbersAuditEntryEntity auditEntryEntity = _DomainFactories.AccountPhoneNumbersAuditEntryEntityFactory.CreateNew(accountPhoneNumberEntity);
		if (auditEntryEntity != null)
		{
			_DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.CreateNew(user, auditEntryEntity.PublicId, changeType, actorUser);
		}
	}
}
