using System;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

public interface IMembershipMigrationStateEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Value { get; set; }

	new DateTime Created { get; set; }

	new DateTime Updated { get; set; }
}
