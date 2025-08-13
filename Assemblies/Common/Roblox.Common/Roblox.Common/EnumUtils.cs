using Roblox.Common.NetStandard;

namespace Roblox.Common;

public static class EnumUtils
{
	/// <summary>
	/// Like Enum.TryParse, but won't accept values that aren't in the enum definition.
	/// </summary>
	/// <example>
	/// public enum PlayerAvatarTypeEnum : byte
	/// {
	///  R6 = 1,
	///  R15 = 3,
	/// }
	/// ...
	///
	/// PlayerAvatarType? result = StrictTryParseEnum&lt;PlayerAvatarType&gt;("11");
	///
	/// ==&gt; result==null
	/// Normal Enum.TryParse would just map whatever you sent onto a byte without complaint.  This one returns null in that case.
	/// </example>
	public static TEnum? StrictTryParseEnum<TEnum>(string value) where TEnum : struct
	{
		return Roblox.Common.NetStandard.EnumUtils.StrictTryParseEnum<TEnum>(value);
	}
}
