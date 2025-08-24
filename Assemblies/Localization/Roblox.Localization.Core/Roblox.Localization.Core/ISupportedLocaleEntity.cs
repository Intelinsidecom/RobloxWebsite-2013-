using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

internal interface ISupportedLocaleEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Locale { get; set; }

	string Name { get; set; }

	string NativeName { get; set; }

	int LanguageId { get; set; }
}
