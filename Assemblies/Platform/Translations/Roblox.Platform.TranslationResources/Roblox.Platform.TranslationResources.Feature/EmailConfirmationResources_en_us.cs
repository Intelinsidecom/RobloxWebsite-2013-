using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class EmailConfirmationResources_en_us : TranslationResourcesBase, IEmailConfirmationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Done"
	/// button label
	/// English String: "Done"
	/// </summary>
	public virtual string ActionDone => "Done";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button which takes user to item details page
	/// English String: "View Item"
	/// </summary>
	public virtual string ActionViewItem => "View Item";

	/// <summary>
	/// Key: "Heading.ThankYou"
	/// heading
	/// English String: "Thank You!"
	/// </summary>
	public virtual string HeadingThankYou => "Thank You!";

	/// <summary>
	/// Key: "Message.EmailVerified"
	/// success message confirmation
	/// English String: "Your email has been verified"
	/// </summary>
	public virtual string MessageEmailVerified => "Your email has been verified";

	/// <summary>
	/// Key: "Message.EmailVerifiedEnjoyFreeHat"
	/// success message confirmation notifying user they have verified their email and have received a free hat
	/// English String: "Your email has been verified. Enjoy the free hat!"
	/// </summary>
	public virtual string MessageEmailVerifiedEnjoyFreeHat => "Your email has been verified. Enjoy the free hat!";

	public EmailConfirmationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Done",
				_GetTemplateForActionDone()
			},
			{
				"Action.ViewItem",
				_GetTemplateForActionViewItem()
			},
			{
				"Heading.ThankYou",
				_GetTemplateForHeadingThankYou()
			},
			{
				"Message.EmailVerified",
				_GetTemplateForMessageEmailVerified()
			},
			{
				"Message.EmailVerifiedEnjoyFreeHat",
				_GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.EmailConfirmation";
	}

	protected virtual string _GetTemplateForActionDone()
	{
		return "Done";
	}

	protected virtual string _GetTemplateForActionViewItem()
	{
		return "View Item";
	}

	protected virtual string _GetTemplateForHeadingThankYou()
	{
		return "Thank You!";
	}

	protected virtual string _GetTemplateForMessageEmailVerified()
	{
		return "Your email has been verified";
	}

	protected virtual string _GetTemplateForMessageEmailVerifiedEnjoyFreeHat()
	{
		return "Your email has been verified. Enjoy the free hat!";
	}
}
