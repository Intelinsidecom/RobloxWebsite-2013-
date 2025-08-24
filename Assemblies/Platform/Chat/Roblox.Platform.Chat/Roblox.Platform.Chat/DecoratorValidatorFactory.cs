using System.Collections.Generic;

namespace Roblox.Platform.Chat;

internal class DecoratorValidatorFactory : IDecoratorValidatorFactory
{
	private const string _ICE_BREAKER = "icebreaker";

	private readonly IReadOnlyDictionary<string, IDecoratorValidator> _DecoratorTypeValidators;

	public DecoratorValidatorFactory(IMessageDataAccessor messageDataAccessor)
	{
		_DecoratorTypeValidators = new Dictionary<string, IDecoratorValidator> { 
		{
			"icebreaker",
			new IceBreakerDecoratorValidator(messageDataAccessor)
		} };
	}

	public IDecoratorValidator GetDecoratorValidator(string decorator)
	{
		if (!_DecoratorTypeValidators.TryGetValue(decorator, out var value))
		{
			return null;
		}
		return value;
	}
}
