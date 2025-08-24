using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class PhoneNumberInternationalPrefixCachedMssqlEntity : IPhoneNumberInternationalPrefixEntity, IUpdateableEntity<short>, IEntity<short>
{
	public short Id { get; set; }

	public int CountryId { get; set; }

	public string InternationalPrefix { get; set; }

	public bool IsActive { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		PhoneNumberInternationalPrefixCAL cal = PhoneNumberInternationalPrefixCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.CountryID = CountryId;
		cal.InternationalPrefix = InternationalPrefix;
		cal.IsActive = IsActive;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(PhoneNumberInternationalPrefixCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
