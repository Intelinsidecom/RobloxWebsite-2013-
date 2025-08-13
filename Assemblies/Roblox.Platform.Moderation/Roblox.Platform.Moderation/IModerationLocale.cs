using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface representing <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />s active in the moderation system
/// </summary>
public interface IModerationLocale
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" />
	/// </summary>
	ISupportedLocale SupportedLocale { get; }

	/// <summary>
	/// Whether the <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /> is active in the moderation system or not
	/// </summary>
	bool IsActive { get; }

	/// <summary>
	/// Sets whether the <see cref="T:Roblox.Platform.Localization.Core.ISupportedLocale" /> is active in the moderation system or not
	/// </summary>
	void SetIsActive(bool isActive);
}
