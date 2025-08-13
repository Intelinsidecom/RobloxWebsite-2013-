namespace Roblox.Platform.Membership;

internal static class AgeBracketExtensions
{
	internal static AgeBracket TranslateAgeBracket(this Roblox.AgeBracket ageBracket)
	{
		if (ageBracket == Roblox.AgeBracket.Age13OrOver)
		{
			return AgeBracket.Age13OrOver;
		}
		return AgeBracket.AgeUnder13;
	}

	internal static Roblox.AgeBracket TranslateAgeBracket(this AgeBracket ageBracket)
	{
		if (ageBracket == AgeBracket.Age13OrOver)
		{
			return Roblox.AgeBracket.Age13OrOver;
		}
		return Roblox.AgeBracket.AgeUnder13;
	}
}
