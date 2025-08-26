using Roblox.Entities;
namespace Roblox.Localization.Coreinternal {
    interface ILanguageEntity : IUpdateableEntity<int>, IEntity<int>

{
	string Name { get; set; }

	string NativeName { get; set; }

	string LanguageCode { get; set; }
}


}
