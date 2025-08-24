using Roblox.Entities;

namespace Roblox.Platform.Localization.Core;

internal interface ILanguageEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Name { get; set; }

	string NativeName { get; set; }

	string LanguageCode { get; set; }
}
