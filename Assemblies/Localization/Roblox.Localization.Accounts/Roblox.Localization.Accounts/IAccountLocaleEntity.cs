using Roblox.Entities;
namespace Roblox.Localization.Accounts {
    interface IAccountLocaleEntity : IUpdateableEntity<long>, IEntity<long>

{
	long AccountId { get; set; }

	int ObservedLocaleId { get; set; }

	int? SupportedLocaleId { get; set; }
}


}
