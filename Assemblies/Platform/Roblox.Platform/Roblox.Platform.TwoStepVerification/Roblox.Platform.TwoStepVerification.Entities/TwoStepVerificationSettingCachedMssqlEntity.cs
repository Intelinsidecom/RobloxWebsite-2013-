using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingCachedMssqlEntity : ITwoStepVerificationSettingEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public bool IsEnabled { get; set; }

	public long UserId { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte? TwoStepVerificationMediaTypeId { get; set; }

	public void Update()
	{
		TwoStepVerificationSetting cal = TwoStepVerificationSetting.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.IsEnabled = IsEnabled;
		cal.UserID = UserId;
		cal.TwoStepVerificationMediaTypeID = TwoStepVerificationMediaTypeId;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(TwoStepVerificationSetting.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
