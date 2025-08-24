namespace Roblox.Platform.Moderation.Entities;

internal interface IExpressionEntityFactory
{
	IExpressionEntity GetOrCreate(string value);

	IExpressionEntity Get(long id);

	IExpressionEntity Get(string value);
}
