using System.Diagnostics.CodeAnalysis;
using Roblox.Moderation;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ExpressionEntityFactory : IExpressionEntityFactory
{
	public IExpressionEntity GetOrCreate(string value)
	{
		Roblox.Moderation.Expression cal = Roblox.Moderation.Expression.GetOrCreate(value);
		return CalToCachedMssql(cal);
	}

	public IExpressionEntity Get(long id)
	{
		Roblox.Moderation.Expression cal = Roblox.Moderation.Expression.Get(id);
		return CalToCachedMssql(cal);
	}

	public IExpressionEntity Get(string value)
	{
		Roblox.Moderation.Expression cal = Roblox.Moderation.Expression.Get(value);
		return CalToCachedMssql(cal);
	}

	private IExpressionEntity CalToCachedMssql(Roblox.Moderation.Expression cal)
	{
		if (cal != null)
		{
			return new ExpressionCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
