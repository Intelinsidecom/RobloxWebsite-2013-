namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface for exposing the expression platform object. 
/// Expressions are a either user or moderator entered strings that are persisted.
/// </summary>
public interface IExpression
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	long Id { get; }

	/// <summary>
	/// Gets the value.
	/// </summary>
	string Value { get; }
}
