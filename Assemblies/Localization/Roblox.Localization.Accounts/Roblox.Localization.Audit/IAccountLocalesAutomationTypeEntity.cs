using Roblox.Entities;
namespace Roblox.Localization.Auditinternal {
    interface IAccountLocalesAutomationTypeEntity : IUpdateableEntity<byte>, IEntity<byte>

{
	string Value { get; set; }

	string Description { get; set; }
}


}
