using System;
using Roblox.Entities;
namespace Roblox.Platform.PremiumFeatures
{
    public interface IMembershipMigrationStateEntity : IUpdateableEntity<int>, IEntity<int>

{
	string Value { get; set; }

	new DateTime Created { get; set; }

	new DateTime Updated { get; set; }
}


}
