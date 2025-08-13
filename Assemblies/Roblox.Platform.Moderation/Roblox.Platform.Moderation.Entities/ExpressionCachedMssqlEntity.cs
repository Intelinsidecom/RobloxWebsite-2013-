using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Moderation;
using Roblox.Platform.Core;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ExpressionCachedMssqlEntity : IExpressionEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public string Value { get; set; }

	public void Update()
	{
		Roblox.Moderation.Expression cal = Roblox.Moderation.Expression.Get(Id);
		if (cal == null)
		{
			throw new PlatformDataIntegrityException("Performing update on a non persisted entity.");
		}
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(Roblox.Moderation.Expression.Get(Id) ?? throw new PlatformDataIntegrityException("Performing update on a non persisted entity.")).Delete();
	}
}
