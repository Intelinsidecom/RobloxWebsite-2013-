namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TextFilter.ITextAuthor" />.
/// </summary>
public class TextAuthor : ITextAuthor
{
	/// <summary>
	/// See <see cref="T:Roblox.TextFilter.ITextAuthor" />.
	/// </summary>
	public virtual long Id { get; }

	/// <summary>
	/// See <see cref="T:Roblox.TextFilter.ITextAuthor" />.
	/// </summary>
	public virtual string Name { get; }

	/// <summary>
	/// See <see cref="T:Roblox.TextFilter.ITextAuthor" />.
	/// </summary>
	public virtual bool IsUnder13 { get; }

	/// <summary>
	/// A basic implementation of <see cref="T:Roblox.TextFilter.ITextAuthor" />
	/// </summary>
	/// <param name="id"><see cref="P:Roblox.TextFilter.TextAuthor.Id" /></param>
	/// <param name="name"><see cref="P:Roblox.TextFilter.TextAuthor.Name" /></param>
	/// <param name="isUnder13"><see cref="P:Roblox.TextFilter.TextAuthor.IsUnder13" /></param>
	public TextAuthor(long id, string name, bool isUnder13)
	{
		Id = id;
		Name = name;
		IsUnder13 = isUnder13;
	}
}
