using Roblox.Platform.Core;
using Roblox.Platform.Moderation.Entities;

namespace Roblox.Platform.Moderation.Factories;

internal class ExpressionFactory : IExpressionFactory
{
	private readonly ModerationDomainFactories _DomainFactories;

	public ExpressionFactory(ModerationDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IExpression GetOrCreate(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new PlatformArgumentException("value");
		}
		IExpressionEntity entity = _DomainFactories.ExpressionEntityFactory.GetOrCreate(value);
		return new Expression(entity.Id, entity.Value);
	}

	public IExpression Get(long id)
	{
		IExpressionEntity entity = _DomainFactories.ExpressionEntityFactory.Get(id);
		if (entity != null)
		{
			return new Expression(entity.Id, entity.Value);
		}
		return null;
	}

	public IExpression Get(string value)
	{
		IExpressionEntity entity = _DomainFactories.ExpressionEntityFactory.Get(value);
		if (entity != null)
		{
			return new Expression(entity.Id, entity.Value);
		}
		return null;
	}
}
