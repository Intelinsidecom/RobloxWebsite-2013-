using Roblox.Entities;
namespace Roblox.Localization.Auditinternal {
    interface IAccountCountriesAuditMetadataTypeEntity : IUpdateableEntity<byte>, IEntity<byte>

{
	string Value { get; set; }

	string Description { get; set; }
}


}
