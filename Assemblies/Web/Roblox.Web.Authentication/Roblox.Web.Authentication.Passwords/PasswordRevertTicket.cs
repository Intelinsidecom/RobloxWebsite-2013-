using System;

namespace Roblox.Web.Authentication.Passwords;

public class PasswordRevertTicket
{
	public string Email { get; set; }

	public Guid Guid { get; set; }
}
