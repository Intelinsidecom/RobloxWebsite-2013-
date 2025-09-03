using Roblox.Entities;
namespace Roblox.Localization.Audit {
    interface IAccountCountriesChangeAgentTypeEntity : IUpdateableEntity<byte>, IEntity<byte>

{
	string Value { get; set; }

	string Description { get; set; }
}


}
