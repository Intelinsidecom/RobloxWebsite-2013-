using System;

namespace Roblox.Platform.TranslationStorage;

internal class TranslationSummary : ITranslationSummary
{
	public string TranslationValue { get; set; }

	public IChangeAgent ChangeAgent { get; set; }

	public DateTime Created { get; set; }
}
