namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents an identifier used to identify a Captchad target.
/// </summary>
public struct Identifier
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Captcha.IdentifierTargetType" /> of the target.
	/// </summary>
	public IdentifierTargetType TargetType { get; set; }

	/// <summary>
	/// The value used to identify the target.
	/// </summary>
	public string Value { get; set; }

	/// <summary>
	/// Serializes the <see cref="T:Roblox.Platform.Captcha.Identifier" /> as a string.
	/// </summary>
	/// <returns>The string representation of the <see cref="T:Roblox.Platform.Captcha.Identifier" />.</returns>
	internal string Serialize()
	{
		return string.Format("TargetType:{0}_Value:{1}", TargetType, Value ?? "");
	}
}
