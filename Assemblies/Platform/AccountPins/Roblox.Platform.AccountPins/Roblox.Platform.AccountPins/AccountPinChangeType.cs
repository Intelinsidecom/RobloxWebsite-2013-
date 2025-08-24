using System.ComponentModel;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// Enum for the types of changes that can be made to an <see cref="T:Roblox.Platform.AccountPins.IAccountPin" />
/// </summary>
public enum AccountPinChangeType
{
	/// <summary>
	/// Data migration
	/// </summary>
	[Description("Data migration")]
	DataMigration = 1,
	/// <summary>
	/// Entered new pin
	/// </summary>
	[Description("Entered new pin")]
	PinAdded,
	/// <summary>
	/// Turned pin off
	/// </summary>
	[Description("Turned pin off")]
	PinDisabled,
	/// <summary>
	/// Disabled old pin to be replaced by new pin
	/// </summary>
	[Description("Disabled old pin to be replaced by new pin")]
	PinReplaced
}
