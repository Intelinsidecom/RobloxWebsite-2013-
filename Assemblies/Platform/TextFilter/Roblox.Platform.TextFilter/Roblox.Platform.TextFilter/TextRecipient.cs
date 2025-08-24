namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of the <see cref="T:Roblox.TextFilter.ITextRecipient" />
/// </summary>
public class TextRecipient : ITextRecipient
{
	public bool IsUnder13 { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="isUnder13"></param>
	public TextRecipient(bool isUnder13)
	{
		IsUnder13 = isUnder13;
	}
}
