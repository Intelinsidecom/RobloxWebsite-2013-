namespace Roblox.Platform.Membership;

public interface IPasswordValidationResponse
{
	/// <summary>
	/// Use this property to get result.
	/// Success =&gt; ValidPassword otherwise failed.
	/// To get message use ToDescription and not ToString
	/// </summary>
	PasswordValidationResult Result { get; }
}
