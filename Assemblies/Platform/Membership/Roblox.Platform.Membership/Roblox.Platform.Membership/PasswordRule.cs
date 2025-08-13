using System.Text.RegularExpressions;

namespace Roblox.Platform.Membership;

public class PasswordRule
{
	public Regex Regex { get; set; }

	public string Description { get; set; }

	internal PasswordValidationResult PasswordValidationResult { get; set; }
}
