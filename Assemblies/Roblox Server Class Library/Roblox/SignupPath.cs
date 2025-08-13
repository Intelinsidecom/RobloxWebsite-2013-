using System;
using Roblox.Properties;

namespace Roblox;

public static class SignupPath
{
	public static readonly int Under13EmailRequired = 1;

	public static readonly int Under13EmailOptional = 2;

	public static readonly int Over13EmailOptional = 3;

	private static int PercentEmailRequired => Settings.Default.PercentEmailRequired;

	public static int GetRandomPathForUnder13()
	{
		if (PercentEmailRequired == 0)
		{
			return Under13EmailOptional;
		}
		if (PercentEmailRequired == 100)
		{
			return Under13EmailRequired;
		}
		if (new Random().Next(1, 100) > PercentEmailRequired)
		{
			return Under13EmailOptional;
		}
		return Under13EmailRequired;
	}
}
