using System;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A interface that holds a translation change history record.
/// </summary>
public interface ITranslationSummary
{
	/// <summary>
	/// The translation value.
	/// </summary>
	string TranslationValue { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TranslationStorage.IChangeAgent" />
	/// </summary>
	IChangeAgent ChangeAgent { get; }

	/// <summary>
	/// The time when the change happened.
	/// </summary>
	DateTime Created { get; }
}
