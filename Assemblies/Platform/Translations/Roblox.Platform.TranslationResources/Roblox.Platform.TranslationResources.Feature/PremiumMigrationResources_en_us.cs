using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PremiumMigrationResources_en_us : TranslationResourcesBase, IPremiumMigrationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public virtual string HeadingMigrationTitle => "Builders Club is now Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public virtual string PopUpTitle => "Builders Club is now Roblox Premium";

	public PremiumMigrationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.MigrationBody",
				_GetTemplateForDescriptionMigrationBody()
			},
			{
				"Description.MigrationContent",
				_GetTemplateForDescriptionMigrationContent()
			},
			{
				"Description.MigrationMesg",
				_GetTemplateForDescriptionMigrationMesg()
			},
			{
				"Heading.MigrationTitle",
				_GetTemplateForHeadingMigrationTitle()
			},
			{
				"PopUp.Body",
				_GetTemplateForPopUpBody()
			},
			{
				"PopUp.Title",
				_GetTemplateForPopUpTitle()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PremiumMigration";
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. "
	/// </summary>
	public virtual string DescriptionMigrationBody(string robuxAmount)
	{
		return $"Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. ";
	}

	protected virtual string _GetTemplateForDescriptionMigrationBody()
	{
		return "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public virtual string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  ";
	}

	protected virtual string _GetTemplateForDescriptionMigrationContent()
	{
		return "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public virtual string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  ";
	}

	protected virtual string _GetTemplateForDescriptionMigrationMesg()
	{
		return "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  ";
	}

	protected virtual string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club is now Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public virtual string PopUpBody(string robuxAmount)
	{
		return $"Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details.";
	}

	protected virtual string _GetTemplateForPopUpBody()
	{
		return "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details.";
	}

	protected virtual string _GetTemplateForPopUpTitle()
	{
		return "Builders Club is now Roblox Premium";
	}
}
