namespace Roblox.Kickbox;

internal class KickboxVerifyEmailResult : IKickboxVerifyEmailResult
{
	public string Status { get; set; }

	public string Error { get; set; }

	public string Result { get; set; }

	public string Reason { get; set; }

	public bool Role { get; set; }

	public bool Free { get; set; }

	public bool Disposable { get; set; }

	public bool AcceptAll { get; set; }

	public string DidYouMean { get; set; }

	public double Sendex { get; set; }

	public string Email { get; set; }

	public string User { get; set; }

	public string Domain { get; set; }

	public bool Success { get; set; }

	public string Message { get; set; }
}
