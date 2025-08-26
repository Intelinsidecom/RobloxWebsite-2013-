namespace Roblox.Moderation.Entitiesinternal {
    interface IExpressionEntityFactory

{
	IExpressionEntity GetOrCreate(string value);

	IExpressionEntity Get(long id);

	IExpressionEntity Get(string value);
}


}
