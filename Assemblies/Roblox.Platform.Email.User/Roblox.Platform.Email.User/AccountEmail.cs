namespace Roblox.Platform.Email.User;

internal class AccountEmail : IAccountEmail
{
	public int Id { get; set; }

	public string Email { get; set; }

	public bool IsBlacklisted { get; set; }

	public bool IsVerified { get; set; }

	public bool IsValid { get; set; }

	public bool IsCurrent { get; set; }

	public long AccountId { get; set; }
}
