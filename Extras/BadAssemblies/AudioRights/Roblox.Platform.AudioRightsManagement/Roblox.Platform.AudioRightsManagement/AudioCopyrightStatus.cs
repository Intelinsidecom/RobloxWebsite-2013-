using System.Runtime.Serialization;

namespace Roblox.Platform.AudioRightsManagement;

public enum AudioCopyrightStatus
{
	/// <summary>
	/// The audio copyright status is not known.
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
	/// <summary>
	/// The audio file is not copyrighted.
	/// </summary>
	[EnumMember(Value = "ok")]
	Ok,
	/// <summary>
	/// The audio is copyrighted.
	/// </summary>
	[EnumMember(Value = "copyrighted")]
	Copyrighted,
	/// <summary>
	/// The audio is invalid.
	/// </summary>
	[EnumMember(Value = "invalid")]
	Invalid
}
