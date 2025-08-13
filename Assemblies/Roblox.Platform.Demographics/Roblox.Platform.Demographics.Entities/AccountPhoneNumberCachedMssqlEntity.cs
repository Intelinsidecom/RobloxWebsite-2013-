using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumberCachedMssqlEntity : IAccountPhoneNumberEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public long AccountId { get; set; }

	public string Phone { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public int? PhoneNumberId { get; set; }

	public bool? IsVerified { get; set; }

	public bool? IsActive { get; set; }

	public void Update()
	{
		AccountPhoneNumberCAL cal = AccountPhoneNumberCAL.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.Phone = Phone;
		cal.PhoneNumberID = PhoneNumberId;
		cal.IsVerified = IsVerified;
		cal.IsActive = IsActive;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(AccountPhoneNumberCAL.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
