namespace Roblox.Platform.Moderation;

internal class Expression : IExpression
{
	public string Value { get; }

	public long Id { get; }

	public Expression(long id, string value)
	{
		Id = id;
		Value = value;
	}
}
