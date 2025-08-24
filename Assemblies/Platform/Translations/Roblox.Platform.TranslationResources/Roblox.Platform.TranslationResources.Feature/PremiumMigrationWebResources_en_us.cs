using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PremiumMigrationWebResources_en_us : TranslationResourcesBase, IPremiumMigrationWebResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public virtual string HeadingMigrationModalTitle => "Builders Club is now Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public virtual string HeadingMigrationTitle => "Builders Club is now Roblox Premium";

	public PremiumMigrationWebResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.MigrationBody",
				_GetTemplateForDescriptionMigrationBody()
			},
			{
				"Description.MigrationModalBody",
				_GetTemplateForDescriptionMigrationModalBody()
			},
			{
				"Heading.MigrationModalTitle",
				_GetTemplateForHeadingMigrationModalTitle()
			},
			{
				"Heading.MigrationTitle",
				_GetTemplateForHeadingMigrationTitle()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PremiumMigrationWeb";
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public virtual string DescriptionMigrationBody(string robuxAmount, string newLine)
	{
		return $"Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  ";
	}

	protected virtual string _GetTemplateForDescriptionMigrationBody()
	{
		return "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public virtual string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details.";
	}

	protected virtual string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "Going forward, you will receive a full month’s worth of Robux on the day of your subscription renewal. Today, we’re giving you this month's Robux minus what you’ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details.";
	}

	protected virtual string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club is now Roblox Premium";
	}

	protected virtual string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club is now Roblox Premium";
	}
}
