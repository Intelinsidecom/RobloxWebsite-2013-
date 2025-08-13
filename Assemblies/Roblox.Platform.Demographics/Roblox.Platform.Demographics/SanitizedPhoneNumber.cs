namespace Roblox.Platform.Demographics;

public class SanitizedPhoneNumber : ISanitizedPhoneNumber
{
	public IPhoneNumberInternationalPrefix InternationalPrefix { get; set; }

	public string NationalNumber { get; set; }

	public string FullNumber { get; set; }
}
