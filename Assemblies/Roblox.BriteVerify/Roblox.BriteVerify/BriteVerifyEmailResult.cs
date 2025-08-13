namespace Roblox.BriteVerify;

internal class BriteVerifyEmailResult : IBriteVerifyEmailResult
{
	public string Address { get; set; }

	public string Account { get; set; }

	public string Domain { get; set; }

	public string Status { get; set; }

	public string Connected { get; set; }

	public bool IsDisposable { get; set; }

	public bool IsRoleAddress { get; set; }

	public string ErrorCode { get; set; }

	public string Error { get; set; }

	public double Duration { get; set; }
}
