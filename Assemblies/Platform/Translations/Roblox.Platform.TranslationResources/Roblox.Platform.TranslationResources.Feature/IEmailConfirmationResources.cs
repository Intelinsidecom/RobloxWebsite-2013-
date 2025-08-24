namespace Roblox.TranslationResources.Feature;

public interface IEmailConfirmationResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	string ActionDone { get; }

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	string ActionViewItem { get; }

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	string HeadingThankYou { get; }

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	string MessageEmailVerified { get; }

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	string MessageEmailVerifiedEnjoyFreeHat { get; }
}
