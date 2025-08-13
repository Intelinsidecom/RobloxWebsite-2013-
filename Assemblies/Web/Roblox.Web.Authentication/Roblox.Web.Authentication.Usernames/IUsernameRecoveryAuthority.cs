namespace Roblox.Web.Authentication.Usernames;

public interface IUsernameRecoveryAuthority
{
	/// <summary>
	/// Sends a message to the owner of the phone containing the username
	/// </summary>
	/// <param name="ip">The ip of the user for floodchecking</param>
	/// <param name="target">The target phone number to send the message to</param>
	IRecoverUsernameResult RecoverUsernameByPhone(string ip, string target);
}
