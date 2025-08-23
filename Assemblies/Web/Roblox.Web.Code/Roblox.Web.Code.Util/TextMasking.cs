namespace Roblox.Web.Code.Util;

public class TextMasking
{
	private const short _DefaultNumberOfVisiblePhoneDigits = 4;

	private const short _DefaultNumberOfVisibleEmailCharacters = 1;

	private const char _DefaultPhoneNumberMaskingCharacter = '*';

	private const char _DefaultEmailMaskingCharacter = '*';

	/// <summary>
	/// Replace characters before the domain/ip (the @ symbol) with the given <see cref="!:maskCharacter" />.
	/// The first <see cref="!:numberOfVisibleCharacters" /> can be revealed.
	/// </summary>
	/// <param name="email">email address to mask</param>
	/// <param name="numberOfVisibleCharacters">number of characters to display before masking starts, negative numbers are treated as zero</param>
	/// <param name="maskCharacter">character to use for masking</param>
	/// <returns></returns>
	public static string GetMaskedEmail(string email, int numberOfVisibleCharacters = 1, char maskCharacter = '*')
	{
		int at = email?.IndexOf("@") ?? (-1);
		if (at <= 0)
		{
			return email;
		}
		int firstNchars = ((numberOfVisibleCharacters <= at) ? numberOfVisibleCharacters : at);
		firstNchars = ((firstNchars >= 0) ? firstNchars : 0);
		int numMaskedChars = at - firstNchars;
		return $"{email.Substring(0, firstNchars)}{new string(maskCharacter, numMaskedChars)}{email.Substring(at, email.Length - at)}";
	}

	public static string GetMaskedPhone(string phone, int numberOfVisibleDigits = 4, char maskCharacter = '*')
	{
		if (string.IsNullOrEmpty(phone))
		{
			return string.Empty;
		}
		int length = phone.Length;
		if (length <= numberOfVisibleDigits)
		{
			return phone;
		}
		int numberOfCharsToMask = length - numberOfVisibleDigits;
		return new string(maskCharacter, numberOfCharsToMask) + phone.Substring(numberOfCharsToMask);
	}
}
