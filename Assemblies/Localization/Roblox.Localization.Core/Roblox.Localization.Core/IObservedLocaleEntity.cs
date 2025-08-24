using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

internal interface IObservedLocaleEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Locale { get; set; }

	int? LanguageId { get; set; }

	int? SupportedLocaleId { get; set; }
}
