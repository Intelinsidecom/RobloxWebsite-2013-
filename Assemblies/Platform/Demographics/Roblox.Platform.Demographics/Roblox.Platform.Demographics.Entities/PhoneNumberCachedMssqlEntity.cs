using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberCachedMssqlEntity : IPhoneNumberEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public short? PhoneNumberInternationalPrefixId { get; set; }

	public string NationalPhoneNumber { get; set; }

	public bool? IsBlacklisted { get; set; }

	public void Update()
	{
		PhoneNumberCAL cal = PhoneNumberCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.PhoneNumberInternationalPrefixID = PhoneNumberInternationalPrefixId;
		cal.NationalPhoneNumber = NationalPhoneNumber;
		cal.IsBlacklisted = IsBlacklisted;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(PhoneNumberCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
