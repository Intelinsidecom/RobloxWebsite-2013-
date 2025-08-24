using System;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingFactory" />
/// </summary>
internal class TwoStepVerificationSettingFactory : ITwoStepVerificationSettingFactory
{
	private readonly ITwoStepVerificationSettingEntityFactory _SettingEntityFactory;

	private readonly ITwoStepVerificationMediaTypeFactory _MediaTypeFactory;

	/// <inheritdoc cref="E:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingFactory.OnSettingInstantiated" />
	public event Action<ITwoStepVerificationSetting> OnSettingInstantiated;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSettingFactory" />
	/// </summary>
	/// <param name="mediaTypeFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationMediaTypeFactory" /></param>
	/// <param name="settingEntityFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationSettingEntityFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="mediaTypeFactory" /> or <paramref name="settingEntityFactory" /> is null.</exception>
	public TwoStepVerificationSettingFactory(ITwoStepVerificationMediaTypeFactory mediaTypeFactory, ITwoStepVerificationSettingEntityFactory settingEntityFactory)
	{
		_SettingEntityFactory = settingEntityFactory.AssignOrThrowIfNull("settingEntityFactory");
		_MediaTypeFactory = mediaTypeFactory.AssignOrThrowIfNull("mediaTypeFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingFactory.GetByUser(Roblox.Platform.MembershipCore.IUserIdentifier)" />
	public ITwoStepVerificationSetting GetByUser(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		ITwoStepVerificationSettingEntity entity = _SettingEntityFactory.GetByUserId(user.Id);
		if (entity == null)
		{
			return null;
		}
		TwoStepVerificationSetting setting = new TwoStepVerificationSetting(_MediaTypeFactory, _SettingEntityFactory, entity);
		this.OnSettingInstantiated?.Invoke(setting);
		return setting;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSettingFactory.GetOrCreateByUser(Roblox.Platform.MembershipCore.IUserIdentifier)" />
	public ITwoStepVerificationSetting GetOrCreateByUser(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		ITwoStepVerificationSettingEntity entity = _SettingEntityFactory.GetOrCreate(user.Id);
		TwoStepVerificationSetting setting = new TwoStepVerificationSetting(_MediaTypeFactory, _SettingEntityFactory, entity);
		this.OnSettingInstantiated?.Invoke(setting);
		return setting;
	}
}
