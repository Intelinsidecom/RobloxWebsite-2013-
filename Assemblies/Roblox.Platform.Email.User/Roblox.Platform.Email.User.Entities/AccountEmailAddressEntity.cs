using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Email.User.Entities;

[ExcludeFromCodeCoverage]
internal class AccountEmailAddressEntity : IAccountEmailAddressEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public long AccountId { get; set; }

	public int EmailAddressId { get; set; }

	public bool IsVerified { get; set; }

	public bool IsValid { get; set; }

	public bool NewsLetter { get; set; }

	public void Delete()
	{
		(AccountEmailAddress.Get(Id) ?? throw new PlatformDataIntegrityException($"Specified ID {Id} does not exist.")).Delete();
	}

	public void Update()
	{
		AccountEmailAddress obj = AccountEmailAddress.Get(Id) ?? throw new PlatformDataIntegrityException($"Specified ID {Id} does not exist.");
		obj.AccountID = AccountId;
		obj.EmailAddressID = EmailAddressId;
		obj.IsVerified = IsVerified;
		obj.IsValid = IsValid;
		obj.Newsletter = NewsLetter;
		obj.Save();
	}
}
