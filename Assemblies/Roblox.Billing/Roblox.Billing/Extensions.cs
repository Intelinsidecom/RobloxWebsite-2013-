namespace Roblox.Billing;

public static class Extensions
{
	public static string GetLastNDigits(this string number, int n)
	{
		if (string.IsNullOrEmpty(number))
		{
			return string.Empty;
		}
		int length = number.Length;
		if (length > n)
		{
			return number.Substring(length - n);
		}
		return number;
	}

	public static string GetFirstNDigits(this string number, int n)
	{
		if (string.IsNullOrEmpty(number))
		{
			return string.Empty;
		}
		if (number.Length > n)
		{
			return number.Substring(0, n);
		}
		return number;
	}
}
