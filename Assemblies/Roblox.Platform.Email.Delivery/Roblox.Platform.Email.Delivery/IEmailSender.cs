using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// Provides a common interface for an object that handles the sending of Emails.
/// </summary>
public interface IEmailSender
{
	/// <summary>
	/// Sends the specified email.
	/// </summary>
	/// <param name="email">The email to be sent.</param>
	/// <exception cref="T:Roblox.Platform.Email.Delivery.EmailQueueingException">Thrown when there are problems publishing the email to SNS.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Email.Delivery.EmailInvalidException">Thrown when the input email failed the validity check.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown when the input email is null.</exception>
	void SendEmail(IEmail email);

	/// <summary>
	/// Sends the specified email.
	/// </summary>
	/// <param name="email">The email to be sent.</param>
	/// <param name="commonEmailResources">The <see cref="T:Roblox.TranslationResources.Communication.ICommonEmailResources" /></param>
	/// <exception cref="T:Roblox.Platform.Email.Delivery.EmailQueueingException">Thrown when there are problems publishing the email to SNS.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Email.Delivery.EmailInvalidException">Thrown when the input email failed the validity check.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown when the input email is null.</exception>
	void SendEmail(IEmail email, ICommonEmailResources commonEmailResources);
}
