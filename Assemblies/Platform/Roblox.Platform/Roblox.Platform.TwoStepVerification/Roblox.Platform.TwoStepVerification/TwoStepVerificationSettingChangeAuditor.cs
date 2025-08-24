using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;
using Roblox.Platform.TwoStepVerification.Entities.Audit;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationSettingChangeAuditor
{
	private readonly TwoStepVerificationDomainProvider _DomainProvider;

	private readonly ILogger _Logger;

	private readonly Func<IUserIdentifier> _GetActorIdentifierCallback;

	internal virtual bool IsSettingsTableAuditingEnabled => Settings.Default.IsSettingsTableAuditingEnabled;

	public TwoStepVerificationSettingChangeAuditor(TwoStepVerificationDomainProvider domainProvider, ILogger logger, Func<IUserIdentifier> getActorIdentifierCallback)
	{
		_DomainProvider = domainProvider.AssignOrThrowIfNull("domainProvider");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_GetActorIdentifierCallback = getActorIdentifierCallback.AssignOrThrowIfNull("getActorIdentifierCallback");
	}

	public void RegisterEvents(ITwoStepVerificationSettingFactory twoStepVerificationSettingFactory)
	{
		if (twoStepVerificationSettingFactory == null)
		{
			throw new PlatformArgumentNullException("twoStepVerificationSettingFactory");
		}
		twoStepVerificationSettingFactory.OnSettingInstantiated += OnSettingInstantiated;
	}

	private void OnSettingInstantiated(ITwoStepVerificationSetting setting)
	{
		setting.OnPreChange += OnPreChange;
		setting.OnPostChange += OnPostChange;
	}

	private void OnPreChange(ITwoStepVerificationSettingEntity entity)
	{
		try
		{
			BackfillUnauditedPastData(entity);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
		}
	}

	private void OnPostChange(ITwoStepVerificationSettingEntity oldEntity, ITwoStepVerificationSettingEntity newEntity)
	{
		if (!IsSettingsTableAuditingEnabled)
		{
			return;
		}
		ITwoStepVerificationSettingsAuditEntryEntity auditEntryEntity = _DomainProvider.SettingsAuditEntryEntityFactory.CreateNew(newEntity);
		if (auditEntryEntity != null)
		{
			IUserIdentifier userIdentifier = UserIdentifierFactory.GetUserIdentifier(newEntity.UserId);
			IUserIdentifier actorIdentifier = _GetActorIdentifierCallback();
			if (oldEntity.IsEnabled != newEntity.IsEnabled)
			{
				_DomainProvider.SettingsAuditMetadataEntityFactory.CreateNew(userIdentifier, auditEntryEntity.PublicId, TwoStepVerificationChangeType.ChangeIsEnabled, actorIdentifier);
			}
			if (oldEntity.TwoStepVerificationMediaTypeId != newEntity.TwoStepVerificationMediaTypeId)
			{
				_DomainProvider.SettingsAuditMetadataEntityFactory.CreateNew(userIdentifier, auditEntryEntity.PublicId, TwoStepVerificationChangeType.ChangeMediaType, actorIdentifier);
			}
		}
	}

	private void BackfillUnauditedPastData(ITwoStepVerificationSettingEntity entity)
	{
		if (!IsSettingsTableAuditingEnabled)
		{
			return;
		}
		bool unauditedIsEnabled = false;
		bool unauditedMediaType = false;
		ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> isEnabledHistory = _DomainProvider.GetSettingsAuditCompositeEntryFactory(null).GetEnableDisableHistory(entity.UserId, 1);
		if (!isEnabledHistory.Any() || isEnabledHistory.First().Audit_IsEnabled != entity.IsEnabled)
		{
			unauditedIsEnabled = true;
		}
		if (entity.TwoStepVerificationMediaTypeId.HasValue)
		{
			ICollection<ITwoStepVerificationSettingsAuditCompositeEntry> mediaTypeHistory = _DomainProvider.GetSettingsAuditCompositeEntryFactory(null).GetMediaTypeHistory(entity.UserId, 1);
			if (!mediaTypeHistory.Any() || mediaTypeHistory.First().Audit_TwoStepVerificationMediaType != _DomainProvider.TwoStepVerificationMediaTypeFactory.GetValueById(entity.TwoStepVerificationMediaTypeId.Value))
			{
				unauditedMediaType = true;
			}
		}
		if (unauditedIsEnabled || unauditedMediaType)
		{
			ITwoStepVerificationSettingsAuditEntryEntity auditEntryEntity = _DomainProvider.SettingsAuditEntryEntityFactory.CreateNew(entity);
			if (unauditedIsEnabled)
			{
				_DomainProvider.SettingsAuditMetadataEntityFactory.CreateLegacyEntry(entity.UserId, auditEntryEntity.PublicId, TwoStepVerificationChangeType.ChangeIsEnabled, 0);
			}
			if (unauditedMediaType)
			{
				_DomainProvider.SettingsAuditMetadataEntityFactory.CreateLegacyEntry(entity.UserId, auditEntryEntity.PublicId, TwoStepVerificationChangeType.ChangeMediaType, 0);
			}
		}
	}
}
