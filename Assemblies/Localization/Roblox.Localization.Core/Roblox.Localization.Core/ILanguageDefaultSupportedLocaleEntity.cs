using Roblox.Entities;
namespace Roblox.Localization.Core {
    interface ILanguageDefaultSupportedLocaleEntity : IUpdateableEntity<int>, IEntity<int>

{
	int LanguageId { get; set; }

	int SupportedLocaleId { get; set; }
}


}
