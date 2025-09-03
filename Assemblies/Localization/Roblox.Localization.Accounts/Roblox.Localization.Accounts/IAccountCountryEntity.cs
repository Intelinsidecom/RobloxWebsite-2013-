using Roblox.Entities;
namespace Roblox.Localization.Accounts {
    interface IAccountCountryEntity : IUpdateableEntity<long>, IEntity<long>

{
	long AccountId { get; set; }

	int? CountryId { get; set; }

	bool IsVerified { get; set; }
}


}
