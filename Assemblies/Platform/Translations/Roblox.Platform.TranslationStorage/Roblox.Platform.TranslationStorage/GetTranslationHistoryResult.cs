using System.Collections.Generic;

namespace Roblox.Platform.TranslationStorage;

internal class GetTranslationHistoryResult : IGetTranslationHistoryResult
{
	public IReadOnlyCollection<ITranslationSummary> History { get; set; }

	public string LastEvaluatedId { get; set; }
}
