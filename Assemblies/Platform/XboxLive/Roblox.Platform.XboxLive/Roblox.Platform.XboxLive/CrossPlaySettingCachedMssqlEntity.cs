using System;
using Roblox.Entities;
using Roblox.Platform.XboxLive.Entities;

namespace Roblox.Platform.XboxLive;

internal class CrossPlaySettingCachedMssqlEntity : ICrossPlaySettingEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long UserId { get; set; }

	public bool IsEnabled { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		CrossPlaySettingCAL cal = CrossPlaySettingCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.UserId = UserId;
		cal.IsEnabled = IsEnabled;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(CrossPlaySettingCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
