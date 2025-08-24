using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingEntityFactory : ITwoStepVerificationSettingEntityFactory
{
	public ITwoStepVerificationSettingEntity Get(long id)
	{
		return CalToCachedMssql(TwoStepVerificationSetting.Get(id));
	}

	public ITwoStepVerificationSettingEntity GetByUserId(long userId)
	{
		return CalToCachedMssql(TwoStepVerificationSetting.GetByUserID(userId));
	}

	public ITwoStepVerificationSettingEntity GetOrCreate(long userId)
	{
		return CalToCachedMssql(TwoStepVerificationSetting.GetOrCreate(userId));
	}

	public ITwoStepVerificationSettingEntity Clone(ITwoStepVerificationSettingEntity entity)
	{
		return new TwoStepVerificationSettingCachedMssqlEntity
		{
			Id = entity.Id,
			IsEnabled = entity.IsEnabled,
			UserId = entity.UserId,
			Created = entity.Created,
			Updated = entity.Updated,
			TwoStepVerificationMediaTypeId = entity.TwoStepVerificationMediaTypeId
		};
	}

	private static ITwoStepVerificationSettingEntity CalToCachedMssql(TwoStepVerificationSetting cal)
	{
		if (cal != null)
		{
			return new TwoStepVerificationSettingCachedMssqlEntity
			{
				Id = cal.ID,
				IsEnabled = cal.IsEnabled,
				UserId = cal.UserID,
				Created = cal.Created,
				Updated = cal.Updated,
				TwoStepVerificationMediaTypeId = cal.TwoStepVerificationMediaTypeID
			};
		}
		return null;
	}
}
