namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IRecipient" />
/// <seealso cref="T:Roblox.Platform.Badges.IRecipient" />
internal class Recipient : IRecipient
{
	/// <inheritdoc cref="P:Roblox.Platform.Badges.IRecipient.TargetType" />
	public string TargetType { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IRecipient.TargetId" />
	public long TargetId { get; set; }
}
