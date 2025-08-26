using Roblox.Entities;
namespace Roblox.Localization.Auditinternal {
    interface IAccountLocalesAuditMetadataTypeEntity : IUpdateableEntity<byte>, IEntity<byte>

{
	string Value { get; set; }

	string Description { get; set; }
}


}
