using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ReportAbuseResources_en_us : TranslationResourcesBase, IReportAbuseResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string ActionReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public virtual string ExampleComment => "Comment (optional)...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string HeadingReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public virtual string HeadingSuccess => "Thank You!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public virtual string LabelAllRulesLink => "See all rules.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public virtual string LabelBlockWarning => "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public virtual string LabelCategoryBullying => "Bullying, Harassment, Hate Speech";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public virtual string LabelCategoryBullyingV2 => "Bullying, Harassment, Discrimination";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public virtual string LabelCategoryContent => "Inappropriate Content - Place, Image, Model";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public virtual string LabelCategoryDating => "Dating";

	public virtual string LabelCategoryInappropriate => "Inappropriate Language - Profanity & Adult Content";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public virtual string LabelCategoryOther => "Other rule violation";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public virtual string LabelCategoryPrivateInfo => "Asking for or Giving Private Information";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public virtual string LabelCategoryScamming => "Exploiting, Cheating, Scamming";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public virtual string LabelCategoryTheft => "Account Theft - Phishing, Hacking, Trading";

	public virtual string LabelCategoryThreats => "Real Life Threats & Suicide Threats";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public virtual string LabelComment => "Comment:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public virtual string LabelDeletePost => "Delete Post (and any replies)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public virtual string LabelLeaveUnchanged => "Leave post unchanged";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public virtual string LabelModCategoryAdultContent => "Adult Content";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public virtual string LabelModCategoryAdvertisement => "Advertisement";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public virtual string LabelModCategoryHarrasment => "Harrasment";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public virtual string LabelModCategoryInappropriate => "Inappropriate";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public virtual string LabelModCategoryNone => "None";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public virtual string LabelModCategoryPrivacy => "Privacy";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public virtual string LabelModCategoryProfanity => "Profanity";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public virtual string LabelModCategoryScamming => "Scamming";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public virtual string LabelModCategorySpam => "Spam";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public virtual string LabelModCategoryUnclassified => "Unclassified Mild";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public virtual string LabelModeratorNote => "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public virtual string LabelNeedJavaScript => "You need JavaScript enabled to view this video.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public virtual string LabelNotSureQuestion => "Not sure if the thing you are trying to report is really against the rules?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public virtual string LabelPrivacyPolicyLink => "Privacy Policy";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public virtual string LabelReason => "Reason";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public virtual string LabelRules1 => "No swear words";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public virtual string LabelRules2 => "No account sharing or trading";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public virtual string LabelRules3 => "No dating - no asking for boyfriends or girlfriends";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public virtual string LabelRules4 => "No asking real life info about each other - no asking for phone numbers or email addresses";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public virtual string LabelRulesHeading => "Some of the basic rules of Roblox include the following:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public virtual string LabelSafetyHelpLink => "Roblox Safety.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public virtual string LabelScrubBody => "Scrub Body";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public virtual string LabelScrubSubjectAndBody => "Scrub Subject and Body";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public virtual string LabelSeeCommunityRules => "See Community Rules";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public virtual string LabelSelectCategory => "Please select a category";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public virtual string LabelSelectMedia => "Select any inappropriate media:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public virtual string LabelSelectReason => "Select a reason for your moderation action:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public virtual string LabelSubject => "Subject:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public virtual string MessageErrorMissingParams => "One or more required parameters are missing or invalid";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public virtual string MessageErrorReportingCategories => "There was a problem loading reporting categories.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public virtual string MessageErrorSubmit => "There was a problem submitting your report.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public virtual string MessageGenericError => "There was a problem with the page";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public virtual string MessageSuccess => "Your report has been sent.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public virtual string MessageThankYou => "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public virtual string ResponsePermissionError => "This account does not have enough permissions";

	public ReportAbuseResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.ReportAbuse",
				_GetTemplateForActionReportAbuse()
			},
			{
				"Action.Submit",
				_GetTemplateForActionSubmit()
			},
			{
				"Example.Comment",
				_GetTemplateForExampleComment()
			},
			{
				"Heading.ReportAbuse",
				_GetTemplateForHeadingReportAbuse()
			},
			{
				"Heading.Success",
				_GetTemplateForHeadingSuccess()
			},
			{
				"Label.AllRulesLink",
				_GetTemplateForLabelAllRulesLink()
			},
			{
				"Label.BlockWarning",
				_GetTemplateForLabelBlockWarning()
			},
			{
				"Label.CategoryBullying",
				_GetTemplateForLabelCategoryBullying()
			},
			{
				"Label.CategoryBullyingV2",
				_GetTemplateForLabelCategoryBullyingV2()
			},
			{
				"Label.CategoryContent",
				_GetTemplateForLabelCategoryContent()
			},
			{
				"Label.CategoryDating",
				_GetTemplateForLabelCategoryDating()
			},
			{
				"Label.CategoryInappropriate",
				_GetTemplateForLabelCategoryInappropriate()
			},
			{
				"Label.CategoryOther",
				_GetTemplateForLabelCategoryOther()
			},
			{
				"Label.CategoryPrivateInfo",
				_GetTemplateForLabelCategoryPrivateInfo()
			},
			{
				"Label.CategoryScamming",
				_GetTemplateForLabelCategoryScamming()
			},
			{
				"Label.CategoryTheft",
				_GetTemplateForLabelCategoryTheft()
			},
			{
				"Label.CategoryThreats",
				_GetTemplateForLabelCategoryThreats()
			},
			{
				"Label.Comment",
				_GetTemplateForLabelComment()
			},
			{
				"Label.DeletePost",
				_GetTemplateForLabelDeletePost()
			},
			{
				"Label.LeaveUnchanged",
				_GetTemplateForLabelLeaveUnchanged()
			},
			{
				"Label.ModCategoryAdultContent",
				_GetTemplateForLabelModCategoryAdultContent()
			},
			{
				"Label.ModCategoryAdvertisement",
				_GetTemplateForLabelModCategoryAdvertisement()
			},
			{
				"Label.ModCategoryHarrasment",
				_GetTemplateForLabelModCategoryHarrasment()
			},
			{
				"Label.ModCategoryInappropriate",
				_GetTemplateForLabelModCategoryInappropriate()
			},
			{
				"Label.ModCategoryNone",
				_GetTemplateForLabelModCategoryNone()
			},
			{
				"Label.ModCategoryPrivacy",
				_GetTemplateForLabelModCategoryPrivacy()
			},
			{
				"Label.ModCategoryProfanity",
				_GetTemplateForLabelModCategoryProfanity()
			},
			{
				"Label.ModCategoryScamming",
				_GetTemplateForLabelModCategoryScamming()
			},
			{
				"Label.ModCategorySpam",
				_GetTemplateForLabelModCategorySpam()
			},
			{
				"Label.ModCategoryUnclassified",
				_GetTemplateForLabelModCategoryUnclassified()
			},
			{
				"Label.ModeratorNote",
				_GetTemplateForLabelModeratorNote()
			},
			{
				"Label.NeedJavaScript",
				_GetTemplateForLabelNeedJavaScript()
			},
			{
				"Label.NotSureQuestion",
				_GetTemplateForLabelNotSureQuestion()
			},
			{
				"Label.PrivacyPolicyLink",
				_GetTemplateForLabelPrivacyPolicyLink()
			},
			{
				"Label.Reason",
				_GetTemplateForLabelReason()
			},
			{
				"Label.Rules1",
				_GetTemplateForLabelRules1()
			},
			{
				"Label.Rules2",
				_GetTemplateForLabelRules2()
			},
			{
				"Label.Rules3",
				_GetTemplateForLabelRules3()
			},
			{
				"Label.Rules4",
				_GetTemplateForLabelRules4()
			},
			{
				"Label.RulesHeading",
				_GetTemplateForLabelRulesHeading()
			},
			{
				"Label.SafetyHelpLink",
				_GetTemplateForLabelSafetyHelpLink()
			},
			{
				"Label.ScrubBody",
				_GetTemplateForLabelScrubBody()
			},
			{
				"Label.ScrubSubjectAndBody",
				_GetTemplateForLabelScrubSubjectAndBody()
			},
			{
				"Label.SeeCommunityRules",
				_GetTemplateForLabelSeeCommunityRules()
			},
			{
				"Label.SelectCategory",
				_GetTemplateForLabelSelectCategory()
			},
			{
				"Label.SelectMedia",
				_GetTemplateForLabelSelectMedia()
			},
			{
				"Label.SelectReason",
				_GetTemplateForLabelSelectReason()
			},
			{
				"Label.Subject",
				_GetTemplateForLabelSubject()
			},
			{
				"Label.TellUsHow",
				_GetTemplateForLabelTellUsHow()
			},
			{
				"Message.ErrorMissingParams",
				_GetTemplateForMessageErrorMissingParams()
			},
			{
				"Message.ErrorReportingCategories",
				_GetTemplateForMessageErrorReportingCategories()
			},
			{
				"Message.ErrorSubmit",
				_GetTemplateForMessageErrorSubmit()
			},
			{
				"Message.GenericError",
				_GetTemplateForMessageGenericError()
			},
			{
				"Message.Success",
				_GetTemplateForMessageSuccess()
			},
			{
				"Message.ThankYou",
				_GetTemplateForMessageThankYou()
			},
			{
				"Response.PermissionError",
				_GetTemplateForResponsePermissionError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ReportAbuse";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForExampleComment()
	{
		return "Comment (optional)...";
	}

	protected virtual string _GetTemplateForHeadingReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForHeadingSuccess()
	{
		return "Thank You!";
	}

	protected virtual string _GetTemplateForLabelAllRulesLink()
	{
		return "See all rules.";
	}

	protected virtual string _GetTemplateForLabelBlockWarning()
	{
		return "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!";
	}

	protected virtual string _GetTemplateForLabelCategoryBullying()
	{
		return "Bullying, Harassment, Hate Speech";
	}

	protected virtual string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "Bullying, Harassment, Discrimination";
	}

	protected virtual string _GetTemplateForLabelCategoryContent()
	{
		return "Inappropriate Content - Place, Image, Model";
	}

	protected virtual string _GetTemplateForLabelCategoryDating()
	{
		return "Dating";
	}

	protected virtual string _GetTemplateForLabelCategoryInappropriate()
	{
		return "Inappropriate Language - Profanity & Adult Content";
	}

	protected virtual string _GetTemplateForLabelCategoryOther()
	{
		return "Other rule violation";
	}

	protected virtual string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "Asking for or Giving Private Information";
	}

	protected virtual string _GetTemplateForLabelCategoryScamming()
	{
		return "Exploiting, Cheating, Scamming";
	}

	protected virtual string _GetTemplateForLabelCategoryTheft()
	{
		return "Account Theft - Phishing, Hacking, Trading";
	}

	protected virtual string _GetTemplateForLabelCategoryThreats()
	{
		return "Real Life Threats & Suicide Threats";
	}

	protected virtual string _GetTemplateForLabelComment()
	{
		return "Comment:";
	}

	protected virtual string _GetTemplateForLabelDeletePost()
	{
		return "Delete Post (and any replies)";
	}

	protected virtual string _GetTemplateForLabelLeaveUnchanged()
	{
		return "Leave post unchanged";
	}

	protected virtual string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "Adult Content";
	}

	protected virtual string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "Advertisement";
	}

	protected virtual string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "Harrasment";
	}

	protected virtual string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "Inappropriate";
	}

	protected virtual string _GetTemplateForLabelModCategoryNone()
	{
		return "None";
	}

	protected virtual string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "Privacy";
	}

	protected virtual string _GetTemplateForLabelModCategoryProfanity()
	{
		return "Profanity";
	}

	protected virtual string _GetTemplateForLabelModCategoryScamming()
	{
		return "Scamming";
	}

	protected virtual string _GetTemplateForLabelModCategorySpam()
	{
		return "Spam";
	}

	protected virtual string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "Unclassified Mild";
	}

	protected virtual string _GetTemplateForLabelModeratorNote()
	{
		return "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue.";
	}

	protected virtual string _GetTemplateForLabelNeedJavaScript()
	{
		return "You need JavaScript enabled to view this video.";
	}

	protected virtual string _GetTemplateForLabelNotSureQuestion()
	{
		return "Not sure if the thing you are trying to report is really against the rules?";
	}

	protected virtual string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "Privacy Policy";
	}

	protected virtual string _GetTemplateForLabelReason()
	{
		return "Reason";
	}

	protected virtual string _GetTemplateForLabelRules1()
	{
		return "No swear words";
	}

	protected virtual string _GetTemplateForLabelRules2()
	{
		return "No account sharing or trading";
	}

	protected virtual string _GetTemplateForLabelRules3()
	{
		return "No dating - no asking for boyfriends or girlfriends";
	}

	protected virtual string _GetTemplateForLabelRules4()
	{
		return "No asking real life info about each other - no asking for phone numbers or email addresses";
	}

	protected virtual string _GetTemplateForLabelRulesHeading()
	{
		return "Some of the basic rules of Roblox include the following:";
	}

	protected virtual string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox Safety.";
	}

	protected virtual string _GetTemplateForLabelScrubBody()
	{
		return "Scrub Body";
	}

	protected virtual string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "Scrub Subject and Body";
	}

	protected virtual string _GetTemplateForLabelSeeCommunityRules()
	{
		return "See Community Rules";
	}

	protected virtual string _GetTemplateForLabelSelectCategory()
	{
		return "Please select a category";
	}

	protected virtual string _GetTemplateForLabelSelectMedia()
	{
		return "Select any inappropriate media:";
	}

	protected virtual string _GetTemplateForLabelSelectReason()
	{
		return "Select a reason for your moderation action:";
	}

	protected virtual string _GetTemplateForLabelSubject()
	{
		return "Subject:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public virtual string LabelTellUsHow(string creatorName)
	{
		return $"Tell us how you think {creatorName} is breaking the rules of Roblox.";
	}

	protected virtual string _GetTemplateForLabelTellUsHow()
	{
		return "Tell us how you think {creatorName} is breaking the rules of Roblox.";
	}

	protected virtual string _GetTemplateForMessageErrorMissingParams()
	{
		return "One or more required parameters are missing or invalid";
	}

	protected virtual string _GetTemplateForMessageErrorReportingCategories()
	{
		return "There was a problem loading reporting categories.";
	}

	protected virtual string _GetTemplateForMessageErrorSubmit()
	{
		return "There was a problem submitting your report.";
	}

	protected virtual string _GetTemplateForMessageGenericError()
	{
		return "There was a problem with the page";
	}

	protected virtual string _GetTemplateForMessageSuccess()
	{
		return "Your report has been sent.";
	}

	protected virtual string _GetTemplateForMessageThankYou()
	{
		return "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out ";
	}

	protected virtual string _GetTemplateForResponsePermissionError()
	{
		return "This account does not have enough permissions";
	}
}
