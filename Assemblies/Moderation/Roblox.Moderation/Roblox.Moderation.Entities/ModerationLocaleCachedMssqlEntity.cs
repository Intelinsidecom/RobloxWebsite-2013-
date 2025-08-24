using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ModerationLocaleCachedMssqlEntity : IModerationLocaleEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public int SupportedLocaleId { get; set; }

	public bool IsActive { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		ModerationLocaleCAL cal = ModerationLocaleCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.SupportedLocaleID = SupportedLocaleId;
		cal.IsActive = IsActive;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(ModerationLocaleCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
