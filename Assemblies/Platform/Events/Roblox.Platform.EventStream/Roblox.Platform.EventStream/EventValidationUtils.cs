using System.Text;

namespace Roblox.Platform.EventStream;

public static class EventValidationUtils
{
	private const int _TargetMaxLength = 50;

	public static bool ValidateTarget(string target)
	{
		if (!IsAscii(target))
		{
			return false;
		}
		if (target.Length > 50)
		{
			return false;
		}
		if (IsStartsWithDigit(target))
		{
			return false;
		}
		for (int charIndex = 0; charIndex < target.Length; charIndex++)
		{
			if (!char.IsLetterOrDigit(target, charIndex))
			{
				return false;
			}
		}
		return true;
	}

	private static bool IsAscii(string value)
	{
		return Encoding.UTF8.GetByteCount(value) == value.Length;
	}

	private static bool IsStartsWithDigit(string value)
	{
		if (value.Length > 0 && char.IsDigit(value[0]))
		{
			return true;
		}
		return false;
	}
}
