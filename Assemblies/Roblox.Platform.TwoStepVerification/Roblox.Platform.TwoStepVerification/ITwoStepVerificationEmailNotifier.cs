using Roblox.Platform.Membership;
using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.TwoStepVerification;

public interface ITwoStepVerificationEmailNotifier
{
	/// <summary>
	/// Sends an email to <see cref="T:Roblox.Platform.Membership.IUser" /> <paramref name="user" /> with <paramref name="subject" />, <paramref name="emailType" />, <paramref name="plainBody" />, <paramref name="htmlBody" />.
	/// </summary>
	/// <param name="user"><see cref="T:Roblox.Platform.Membership.IUser" /> to send the email to.</param>
	/// <param name="subject">Email subject.</param>
	/// <param name="emailType">Email type.</param>
	/// <param name="plainBody">Email plain body.</param>
	/// <param name="htmlBody">Email HTML body.</param>
	/// <param name="commonEmailResources">The <see cref="T:Roblox.TranslationResources.Communication.ICommonEmailResources" />.</param>
	void SendEmail(IUser user, string subject, string emailType, string plainBody, string htmlBody, ICommonEmailResources commonEmailResources);
}
