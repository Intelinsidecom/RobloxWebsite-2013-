using System;
using Roblox.Entities;

namespace Roblox.Platform.IpAddresses.Entities;

internal class IpAddressCachedMssqlEntity : IIpAddressEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public State State { get; set; }

	public DateTime? Expiration { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public string Value { get; set; }

	public void Update()
	{
		IPAddress cal = IPAddress.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.State = State;
		cal.Expiration = Expiration;
		cal.Value = Value;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(IPAddress.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
