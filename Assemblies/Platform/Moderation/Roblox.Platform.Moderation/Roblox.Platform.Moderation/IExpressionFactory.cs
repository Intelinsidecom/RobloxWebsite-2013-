namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface for creating or getting an <see cref="T:Roblox.Platform.Moderation.IExpression" />. An expression is user or moderator enterd strings that are persisted.
/// </summary>
public interface IExpressionFactory
{
	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Moderation.IExpression" />.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Moderation.IExpression" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the value is null or empty</exception>
	IExpression GetOrCreate(string value);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Moderation.IExpression" />.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Moderation.IExpression" /> or null if not found.</returns>
	IExpression Get(long id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Moderation.IExpression" /> by value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Moderation.IExpression" /> or null if not found.</returns>
	IExpression Get(string value);
}
