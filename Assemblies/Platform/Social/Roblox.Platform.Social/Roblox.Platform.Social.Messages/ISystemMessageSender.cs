using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Messages;

public interface ISystemMessageSender
{
	/// <summary>
	/// Sends a private message from the default system user (<see cref="F:Roblox.Platform.Social.Messages.SystemMessageSenderType.Roblox" />).
	/// </summary>
	/// <param name="subject">The private message subject.</param>
	/// <param name="body">The contents of the private message.</param>
	/// <param name="recipientUser">The private message recipient.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Social.SendResult" />.</returns>
	SendResult Send(string subject, string body, IUser recipientUser);

	/// <summary>
	/// Sends a private message from the selected system user.
	/// </summary>
	/// <param name="subject">The private message subject.</param>
	/// <param name="body">The contents of the private message.</param>
	/// <param name="recipientUser">The private message recipient.</param>
	/// <param name="systemMessageSenderType">The system user to send as.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Social.SendResult" />.</returns>
	SendResult Send(string subject, string body, IUser recipientUser, SystemMessageSenderType systemMessageSenderType);
}
