using System.Collections.Generic;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An interface that holds results of getting translation history.
/// </summary>
public interface IGetTranslationHistoryResult
{
	/// <summary>
	/// A collection of <see cref="T:Roblox.Platform.TranslationStorage.ITranslationSummary" />.
	/// </summary>
	IReadOnlyCollection<ITranslationSummary> History { get; }

	/// <summary>
	/// The last evaluated id.
	/// </summary>
	string LastEvaluatedId { get; }
}
