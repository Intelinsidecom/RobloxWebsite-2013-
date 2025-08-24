using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

internal interface ILanguageDefaultSupportedLocaleEntity : IUpdateableEntity<int>, IEntity<int>
{
	int LanguageId { get; set; }

	int SupportedLocaleId { get; set; }
}
