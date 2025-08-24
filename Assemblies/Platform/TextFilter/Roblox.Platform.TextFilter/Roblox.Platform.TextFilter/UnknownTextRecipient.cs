namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TextFilter.ITextRecipient" /> specifically for the case of an unkown user.
/// By default this user will be under 13.
/// </summary>
public class UnknownTextRecipient : ITextRecipient
{
	public bool IsUnder13 => true;
}
