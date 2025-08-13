namespace Roblox.Platform.Membership;

public static class GenderTypeExtensions
{
	/// <summary>
	/// Converts a nullable byte value to a <see cref="T:Roblox.Platform.Membership.GenderType" /> enum.
	/// Null and any byte value that does not map to currently supported gender types are assigned to be GenderType.Unknown.
	/// </summary>
	public static GenderType TranslateToGenderType(this byte? genderTypeId)
	{
		byte? b = genderTypeId;
		if (b.HasValue)
		{
			byte valueOrDefault = b.GetValueOrDefault();
			if ((uint)(valueOrDefault - 2) <= 1u)
			{
				return (GenderType)genderTypeId.Value;
			}
		}
		return GenderType.Unknown;
	}

	/// <summary>
	/// Converts a byte to a <see cref="T:Roblox.Platform.Membership.GenderType" /> enum.
	/// Any byte value that does not map to currently supported gender types are assigned to be GenderType.Unknown.
	/// </summary>
	public static GenderType TranslateToGenderType(this byte genderTypeId)
	{
		return ((byte?)genderTypeId).TranslateToGenderType();
	}

	/// <summary>
	/// Converts a string representation of byte to a <see cref="T:Roblox.Platform.Membership.GenderType" /> enum.
	/// Any byte value that does not map to currently supported gender types are assigned to be GenderType.Unknown.
	/// If the string cannot be parsed into a byte, it is assigned to be GenderType.Unknown.
	/// </summary>
	public static GenderType TranslateToGenderType(this string gender)
	{
		if (byte.TryParse(gender, out var genderTypeId))
		{
			return genderTypeId.TranslateToGenderType();
		}
		return GenderType.Unknown;
	}

	/// <summary>
	/// Converts a <see cref="T:Roblox.Platform.Membership.GenderType" /> enum to its byte representation.
	/// </summary>
	public static byte TranslateToByte(this GenderType genderType)
	{
		return (byte)genderType;
	}
}
