using System;
using Roblox.Platform.Membership.Entities;

namespace Roblox.Platform.Membership;

/// <inheritdoc cref="T:Roblox.Platform.Membership.IRoleset" />
internal class Roleset : IRoleset
{
	public int Id { get; }

	public string Name { get; }

	public int Rank { get; }

	public Roleset(IRoleSetEntity roleset)
	{
		if (roleset == null)
		{
			throw new ArgumentNullException("roleset");
		}
		Id = roleset.Id;
		Name = roleset.Name;
		Rank = roleset.Rank;
	}
}
