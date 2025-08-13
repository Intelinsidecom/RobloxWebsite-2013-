using System;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting" />
/// </summary>
internal class TwoStepVerificationSetting : ITwoStepVerificationSetting
{
	private const TwoStepVerificationMediaType _DefaultMediaType = TwoStepVerificationMediaType.Email;

	private readonly ITwoStepVerificationMediaTypeFactory _TwoStepVerificationMediaTypeFactory;

	private readonly ITwoStepVerificationSettingEntityFactory _TwoStepVerificationSettingEntityFactory;

	private readonly long _Id;

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.UserIdentifier" />
	public IUserIdentifier UserIdentifier { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.IsEnabled" />
	public bool IsEnabled { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.MediaType" />
	public TwoStepVerificationMediaType MediaType { get; set; }

	/// <inheritdoc cref="E:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.OnPreChange" />
	public event Action<ITwoStepVerificationSettingEntity> OnPreChange;

	/// <inheritdoc cref="E:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.OnPostChange" />
	public event Action<ITwoStepVerificationSettingEntity, ITwoStepVerificationSettingEntity> OnPostChange;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSetting" />
	/// </summary>
	/// <param name="mediaTypeFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationMediaTypeFactory" /></param>
	/// <param name="settingEntityFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntityFactory" /></param>
	/// <param name="entity">An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntity" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="mediaTypeFactory" />, <paramref name="settingEntityFactory" />, or <paramref name="entity" /> is null.</exception>
	internal TwoStepVerificationSetting(ITwoStepVerificationMediaTypeFactory mediaTypeFactory, ITwoStepVerificationSettingEntityFactory settingEntityFactory, ITwoStepVerificationSettingEntity entity)
	{
		if (mediaTypeFactory == null)
		{
			throw new PlatformArgumentNullException("mediaTypeFactory");
		}
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		UserIdentifier = UserIdentifierFactory.GetUserIdentifier(entity.UserId);
		IsEnabled = entity.IsEnabled;
		MediaType = TwoStepVerificationMediaType.Email;
		if (entity.TwoStepVerificationMediaTypeId.HasValue)
		{
			MediaType = mediaTypeFactory.GetValueById(entity.TwoStepVerificationMediaTypeId.Value);
		}
		_TwoStepVerificationMediaTypeFactory = mediaTypeFactory;
		_TwoStepVerificationSettingEntityFactory = settingEntityFactory.AssignOrThrowIfNull("settingEntityFactory");
		_Id = entity.Id;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.Save" />
	public void Save()
	{
		ITwoStepVerificationSettingEntity entity = _TwoStepVerificationSettingEntityFactory.Get(_Id);
		if (entity == null)
		{
			throw new PlatformDataIntegrityException("Unable to find entity");
		}
		ITwoStepVerificationSettingEntity oldEntity = _TwoStepVerificationSettingEntityFactory.Clone(entity);
		this.OnPreChange?.Invoke(oldEntity);
		entity.UserId = UserIdentifier.Id;
		entity.IsEnabled = IsEnabled;
		entity.TwoStepVerificationMediaTypeId = _TwoStepVerificationMediaTypeFactory.GetIdByValue(MediaType);
		entity.Update();
		this.OnPostChange?.Invoke(oldEntity, entity);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSetting.ToDTO" />
	public TwoStepVerificationSettingDTO ToDTO()
	{
		return new TwoStepVerificationSettingDTO
		{
			UserIdentifier = UserIdentifier,
			IsEnabled = IsEnabled,
			MediaType = MediaType
		};
	}
}
