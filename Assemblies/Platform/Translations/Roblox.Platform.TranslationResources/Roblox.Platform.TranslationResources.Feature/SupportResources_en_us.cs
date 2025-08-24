using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SupportResources_en_us : TranslationResourcesBase, ISupportResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// Cancel
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionDialogCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Dialog.OK"
	/// OK
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogOK => "OK";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public virtual string ActionDialogSend => "Send";

	/// <summary>
	/// Key: "Heading.ContactInformation"
	/// Contact Information
	/// English String: "Contact Information"
	/// </summary>
	public virtual string HeadingContactInformation => "Contact Information";

	/// <summary>
	/// Key: "Heading.DescriptionOfIssue"
	/// Description of issue
	/// English String: "Description of issue"
	/// </summary>
	public virtual string HeadingDescriptionOfIssue => "Description of issue";

	/// <summary>
	/// Key: "Heading.DeviceWithProblem"
	/// What device are you having the problem on?
	/// English String: "What device are you having the problem on?"
	/// </summary>
	public virtual string HeadingDeviceWithProblem => "What device are you having the problem on?";

	/// <summary>
	/// Key: "Heading.Dialog.ErrorWithoutContext"
	/// Error
	/// English String: "Error"
	/// </summary>
	public virtual string HeadingDialogErrorWithoutContext => "Error";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public virtual string HeadingDialogInvalidUsername => "Invalid Username";

	/// <summary>
	/// Key: "Heading.Dialog.RequestReceived"
	/// Request Received
	/// English String: "Request Received"
	/// </summary>
	public virtual string HeadingDialogRequestReceived => "Request Received";

	/// <summary>
	/// Key: "Heading.HelpCategoryType"
	/// Type of help category
	/// English String: "Type of help category"
	/// </summary>
	public virtual string HeadingHelpCategoryType => "Type of help category";

	/// <summary>
	/// Key: "Heading.IssueDetails"
	/// Issue Details
	/// English String: "Issue Details"
	/// </summary>
	public virtual string HeadingIssueDetails => "Issue Details";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// Contact Us
	/// English String: "Contact Us"
	/// </summary>
	public virtual string HeadingPageTitle => "Contact Us";

	/// <summary>
	/// Key: "Label.AccountHacked"
	/// Account Hacked
	/// English String: "Account Hacked"
	/// </summary>
	public virtual string LabelAccountHacked => "Account Hacked";

	/// <summary>
	/// Key: "Label.AccountOwnership"
	/// Account Hacked or Can't Log in
	/// English String: "Account Hacked or Can't Log in"
	/// </summary>
	public virtual string LabelAccountOwnership => "Account Hacked or Can't Log in";

	/// <summary>
	/// Key: "Label.AccountPin"
	/// Account PIN
	/// English String: "Account PIN"
	/// </summary>
	public virtual string LabelAccountPin => "Account PIN";

	public virtual string LabelAdjustChildSettings => "Adjust Child Privacy & Security Settings";

	/// <summary>
	/// Key: "Label.AmazonDevice"
	/// Amazon Device
	/// English String: "Amazon Device"
	/// </summary>
	public virtual string LabelAmazonDevice => "Amazon Device";

	/// <summary>
	/// Key: "Label.AndroidPhone"
	/// Android Phone
	/// English String: "Android Phone"
	/// </summary>
	public virtual string LabelAndroidPhone => "Android Phone";

	/// <summary>
	/// Key: "Label.AndroidTablet"
	/// Android Tablet
	/// English String: "Android Tablet"
	/// </summary>
	public virtual string LabelAndroidTablet => "Android Tablet";

	/// <summary>
	/// Key: "Label.AppealAccountContent"
	/// Appeal Account or Content
	/// English String: "Appeal Account or Content"
	/// </summary>
	public virtual string LabelAppealAccountContent => "Appeal Account or Content";

	/// <summary>
	/// Key: "Label.AppealFriend"
	/// Appeal for Friend
	/// English String: "Appeal for Friend"
	/// </summary>
	public virtual string LabelAppealFriend => "Appeal for Friend";

	public virtual string LabelBilling => "Billing & Payments";

	/// <summary>
	/// Key: "Label.BugReport"
	/// Bug Report
	/// English String: "Bug Report"
	/// </summary>
	public virtual string LabelBugReport => "Bug Report";

	/// <summary>
	/// Key: "Label.BuildersClub"
	/// Builders Club
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.CancelMembership"
	/// Cancel Membership
	/// English String: "Cancel Membership"
	/// </summary>
	public virtual string LabelCancelMembership => "Cancel Membership";

	/// <summary>
	/// Key: "Label.CannotInstall"
	/// Cannot Install Roblox or Studio
	/// English String: "Cannot Install Roblox or Studio"
	/// </summary>
	public virtual string LabelCannotInstall => "Cannot Install Roblox or Studio";

	/// <summary>
	/// Key: "Label.CannotPlayGame"
	/// Cannot Play Game
	/// English String: "Cannot Play Game"
	/// </summary>
	public virtual string LabelCannotPlayGame => "Cannot Play Game";

	/// <summary>
	/// Key: "Label.ChangeChildAge"
	/// Change Child Age
	/// English String: "Change Child Age"
	/// </summary>
	public virtual string LabelChangeChildAge => "Change Child Age";

	public virtual string LabelChatAgeSettings => "Chat & Age Settings";

	/// <summary>
	/// Key: "Label.Chromebook"
	/// Chromebook
	/// English String: "Chromebook"
	/// </summary>
	public virtual string LabelChromebook => "Chromebook";

	/// <summary>
	/// Key: "Label.ConfirmEmail"
	/// Confirm Email Address
	/// English String: "Confirm Email Address"
	/// </summary>
	public virtual string LabelConfirmEmail => "Confirm Email Address";

	/// <summary>
	/// Key: "Label.ContentAbuseReport"
	/// Report Content Breaking Rules
	/// English String: "Report Content Breaking Rules"
	/// </summary>
	public virtual string LabelContentAbuseReport => "Report Content Breaking Rules";

	public virtual string LabelContest => "Contests & Events";

	/// <summary>
	/// Key: "Label.ContestEventQuestion"
	/// Question or Issue
	/// English String: "Question or Issue"
	/// </summary>
	public virtual string LabelContestEventQuestion => "Question or Issue";

	/// <summary>
	/// Key: "Label.CSCharacter"
	/// Customer Service Character
	/// English String: "Customer Service Character"
	/// </summary>
	public virtual string LabelCSCharacter => "Customer Service Character";

	/// <summary>
	/// Key: "Label.DescribeIssue"
	/// Please describe your issue
	/// English String: "Please describe your issue"
	/// </summary>
	public virtual string LabelDescribeIssue => "Please describe your issue";

	/// <summary>
	/// Key: "Label.DevEx"
	/// DevEx
	/// English String: "DevEx"
	/// </summary>
	public virtual string LabelDevEx => "DevEx";

	/// <summary>
	/// Key: "Label.DevExHowTo"
	/// DevEx How To
	/// English String: "DevEx How To"
	/// </summary>
	public virtual string LabelDevExHowTo => "DevEx How To";

	/// <summary>
	/// Key: "Label.DevExMyRequest"
	/// DevEx My Request
	/// English String: "DevEx My Request"
	/// </summary>
	public virtual string LabelDevExMyRequest => "DevEx My Request";

	/// <summary>
	/// Key: "Label.DMCA"
	/// DMCA
	/// English String: "DMCA"
	/// </summary>
	public virtual string LabelDMCA => "DMCA";

	/// <summary>
	/// Key: "Label.EmailAddress"
	/// Email Address
	/// English String: "Email Address"
	/// </summary>
	public virtual string LabelEmailAddress => "Email Address";

	/// <summary>
	/// Key: "Label.ExploitReport"
	/// Exploit Report
	/// English String: "Exploit Report"
	/// </summary>
	public virtual string LabelExploitReport => "Exploit Report";

	/// <summary>
	/// Key: "Label.FirstName"
	/// First Name
	/// English String: "First Name"
	/// </summary>
	public virtual string LabelFirstName => "First Name";

	/// <summary>
	/// Key: "Label.ForgotPassword"
	/// Forgot Password
	/// English String: "Forgot Password"
	/// </summary>
	public virtual string LabelForgotPassword => "Forgot Password";

	/// <summary>
	/// Key: "Label.FreeRobux"
	/// Free Robux
	/// English String: "Free Robux"
	/// </summary>
	public virtual string LabelFreeRobux => "Free Robux";

	/// <summary>
	/// Key: "Label.GameCredit"
	/// Game Card
	/// English String: "Game Card"
	/// </summary>
	public virtual string LabelGameCredit => "Game Card";

	/// <summary>
	/// Key: "Label.GCPartialPayment"
	/// Purchase - Split Payment
	/// English String: "Purchase - Split Payment"
	/// </summary>
	public virtual string LabelGCPartialPayment => "Purchase - Split Payment";

	/// <summary>
	/// Key: "Label.GCRedeem"
	/// Game Card - Redeem
	/// English String: "Game Card - Redeem"
	/// </summary>
	public virtual string LabelGCRedeem => "Game Card - Redeem";

	/// <summary>
	/// Key: "Label.GCSpendCredit"
	/// Game Card - Spend Credit
	/// English String: "Game Card - Spend Credit"
	/// </summary>
	public virtual string LabelGCSpendCredit => "Game Card - Spend Credit";

	/// <summary>
	/// Key: "Label.HowTo"
	/// How To
	/// English String: "How To"
	/// </summary>
	public virtual string LabelHowTo => "How To";

	/// <summary>
	/// Key: "Label.HowToGeneral"
	/// How To - General
	/// English String: "How To - General"
	/// </summary>
	public virtual string LabelHowToGeneral => "How To - General";

	/// <summary>
	/// Key: "Label.HowToOther"
	/// How To - Other
	/// English String: "How To - Other"
	/// </summary>
	public virtual string LabelHowToOther => "How To - Other";

	public virtual string LabelIdeasSuggestions => "Ideas & Suggestions";

	/// <summary>
	/// Key: "Label.IPad"
	/// iPad
	/// English String: "iPad"
	/// </summary>
	public virtual string LabelIPad => "iPad";

	/// <summary>
	/// Key: "Label.IPhone"
	/// iPhone
	/// English String: "iPhone"
	/// </summary>
	public virtual string LabelIPhone => "iPhone";

	/// <summary>
	/// Key: "Label.IssueDescription"
	/// Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message.
	/// English String: "Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message."
	/// </summary>
	public virtual string LabelIssueDescription => "Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message.";

	/// <summary>
	/// Key: "Label.IWasScammed"
	/// I was Scammed
	/// English String: "I was Scammed"
	/// </summary>
	public virtual string LabelIWasScammed => "I was Scammed";

	/// <summary>
	/// Key: "Label.Mac"
	/// Mac
	/// English String: "Mac"
	/// </summary>
	public virtual string LabelMac => "Mac";

	/// <summary>
	/// Key: "Label.Membership"
	/// Support page. Membership {{dc.field_membership}} stop_memb.
	/// English String: "Membership"
	/// </summary>
	public virtual string LabelMembership => "Membership";

	/// <summary>
	/// Key: "Label.Moderation"
	/// Moderation
	/// English String: "Moderation"
	/// </summary>
	public virtual string LabelModeration => "Moderation";

	/// <summary>
	/// Key: "Label.OtherSiteClaim"
	/// Other Site Claim
	/// English String: "Other Site Claim"
	/// </summary>
	public virtual string LabelOtherSiteClaim => "Other Site Claim";

	/// <summary>
	/// Key: "Label.OwnerDMCAClaim"
	/// Owner DMCA Claim
	/// English String: "Owner DMCA Claim"
	/// </summary>
	public virtual string LabelOwnerDMCAClaim => "Owner DMCA Claim";

	/// <summary>
	/// Key: "Label.PC"
	/// PC
	/// English String: "PC"
	/// </summary>
	public virtual string LabelPC => "PC";

	/// <summary>
	/// Key: "Label.PhysicalToyIssue"
	/// Physical Toy Issue
	/// English String: "Physical Toy Issue"
	/// </summary>
	public virtual string LabelPhysicalToyIssue => "Physical Toy Issue";

	/// <summary>
	/// Key: "Label.PleaseSelect"
	/// Please Select...
	/// English String: "Please Select..."
	/// </summary>
	public virtual string LabelPleaseSelect => "Please Select...";

	/// <summary>
	/// Key: "Label.PrizeNotReceived"
	/// Prize Not Received
	/// English String: "Prize Not Received"
	/// </summary>
	public virtual string LabelPrizeNotReceived => "Prize Not Received";

	/// <summary>
	/// Key: "Label.PurchaseDeclined"
	/// Purchase - Declined
	/// English String: "Purchase - Declined"
	/// </summary>
	public virtual string LabelPurchaseDeclined => "Purchase - Declined";

	/// <summary>
	/// Key: "Label.PurchaseDidNotReceive"
	/// Purchase - Did Not Receive
	/// English String: "Purchase - Did Not Receive"
	/// </summary>
	public virtual string LabelPurchaseDidNotReceive => "Purchase - Did Not Receive";

	/// <summary>
	/// Key: "Label.PurchaseUnauthorizedCharge"
	/// Purchase - Unauthorized Charge
	/// English String: "Purchase - Unauthorized Charge"
	/// </summary>
	public virtual string LabelPurchaseUnauthorizedCharge => "Purchase - Unauthorized Charge";

	/// <summary>
	/// Key: "Label.ReportPhish"
	/// Report Phishing Site
	/// English String: "Report Phishing Site"
	/// </summary>
	public virtual string LabelReportPhish => "Report Phishing Site";

	/// <summary>
	/// Key: "Label.RobloxCrashing"
	/// Roblox Crashing
	/// English String: "Roblox Crashing"
	/// </summary>
	public virtual string LabelRobloxCrashing => "Roblox Crashing";

	/// <summary>
	/// Key: "Label.RobloxToys"
	/// Roblox Toys
	/// English String: "Roblox Toys"
	/// </summary>
	public virtual string LabelRobloxToys => "Roblox Toys";

	/// <summary>
	/// Key: "Label.Robux"
	/// Robux
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.RobuxPurchaseIssue"
	/// Robux - Purchase Issue
	/// English String: "Robux - Purchase Issue"
	/// </summary>
	public virtual string LabelRobuxPurchaseIssue => "Robux - Purchase Issue";

	/// <summary>
	/// Key: "Label.SafetyInquiry"
	/// Inappropriate game or user behavior
	/// English String: "Inappropriate game or user behavior"
	/// </summary>
	public virtual string LabelSafetyInquiry => "Inappropriate game or user behavior";

	/// <summary>
	/// Key: "Label.SafetyQueueTicket"
	/// User Safety Concern
	/// English String: "User Safety Concern"
	/// </summary>
	public virtual string LabelSafetyQueueTicket => "User Safety Concern";

	/// <summary>
	/// Key: "Label.SpecificGameIssue"
	/// Specific Game Issue
	/// English String: "Specific Game Issue"
	/// </summary>
	public virtual string LabelSpecificGameIssue => "Specific Game Issue";

	/// <summary>
	/// Key: "Label.Submit"
	/// Submit
	/// English String: "Submit"
	/// </summary>
	public virtual string LabelSubmit => "Submit";

	/// <summary>
	/// Key: "Label.SuggestFeature"
	/// Feature Suggestion
	/// English String: "Feature Suggestion"
	/// </summary>
	public virtual string LabelSuggestFeature => "Feature Suggestion";

	/// <summary>
	/// Key: "Label.SuggestFeedback"
	/// Feedback
	/// English String: "Feedback"
	/// </summary>
	public virtual string LabelSuggestFeedback => "Feedback";

	/// <summary>
	/// Key: "Label.TechnicalSupport"
	/// Technical Support
	/// English String: "Technical Support"
	/// </summary>
	public virtual string LabelTechnicalSupport => "Technical Support";

	/// <summary>
	/// Key: "Label.ToyCodeIssue"
	/// Toy Code Issue
	/// English String: "Toy Code Issue"
	/// </summary>
	public virtual string LabelToyCodeIssue => "Toy Code Issue";

	/// <summary>
	/// Key: "Label.TwoStepV"
	/// 2-Step Verification
	/// English String: "2-Step Verification"
	/// </summary>
	public virtual string LabelTwoStepV => "2-Step Verification";

	/// <summary>
	/// Key: "Label.UserAbuseReport"
	/// Report User Breaking Rules
	/// English String: "Report User Breaking Rules"
	/// </summary>
	public virtual string LabelUserAbuseReport => "Report User Breaking Rules";

	/// <summary>
	/// Key: "Label.Username"
	/// Username
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.VCCatalog"
	/// Website Item
	/// English String: "Website Item"
	/// </summary>
	public virtual string LabelVCCatalog => "Website Item";

	/// <summary>
	/// Key: "Label.VCInGame"
	/// In-Game Item
	/// English String: "In-Game Item"
	/// </summary>
	public virtual string LabelVCInGame => "In-Game Item";

	/// <summary>
	/// Key: "Label.Xbox"
	/// Xbox
	/// English String: "Xbox"
	/// </summary>
	public virtual string LabelXbox => "Xbox";

	/// <summary>
	/// Key: "Response.Dialog.ErrorWithoutContext"
	/// Something went wrong, please try again later.
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public virtual string ResponseDialogErrorWithoutContext => "Something went wrong, please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public virtual string ResponseDialogInvalidUsername => "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.";

	/// <summary>
	/// Key: "Response.Dialog.RequestReceived"
	/// Thank you for contacting Roblox. Please check your email for a message from Customer Service.
	/// English String: "Thank you for contacting Roblox. Please check your email for a message from Customer Service."
	/// </summary>
	public virtual string ResponseDialogRequestReceived => "Thank you for contacting Roblox. Please check your email for a message from Customer Service.";

	/// <summary>
	/// Key: "Response.Dialog.TooManyAttemptsError"
	/// Too many attempts. Try again later.
	/// English String: "Too many attempts. Try again later."
	/// </summary>
	public virtual string ResponseDialogTooManyAttemptsError => "Too many attempts. Try again later.";

	/// <summary>
	/// Key: "Response.Dialog.TryAgainError"
	/// An error occurred. Try again later.
	/// English String: "An error occurred. Try again later."
	/// </summary>
	public virtual string ResponseDialogTryAgainError => "An error occurred. Try again later.";

	/// <summary>
	/// Key: "Response.EmailFormatError"
	/// Please enter a properly formatted email address
	/// English String: "Please enter a properly formatted email address"
	/// </summary>
	public virtual string ResponseEmailFormatError => "Please enter a properly formatted email address";

	/// <summary>
	/// Key: "Response.EmailNotMatching"
	/// Email address does not match
	/// English String: "Email address does not match"
	/// </summary>
	public virtual string ResponseEmailNotMatching => "Email address does not match";

	/// <summary>
	/// Key: "Response.InvalidFirstName"
	/// Please enter a valid first name
	/// English String: "Please enter a valid first name"
	/// </summary>
	public virtual string ResponseInvalidFirstName => "Please enter a valid first name";

	/// <summary>
	/// Key: "Response.InvalidUsername"
	/// That doesn't appear to be a valid Roblox username.
	/// English String: "That doesn't appear to be a valid Roblox username."
	/// </summary>
	public virtual string ResponseInvalidUsername => "That doesn't appear to be a valid Roblox username.";

	/// <summary>
	/// Key: "Response.Under13Email"
	/// If you are under 13 years old, please provide your parent's email address
	/// English String: "If you are under 13 years old, please provide your parent's email address"
	/// </summary>
	public virtual string ResponseUnder13Email => "If you are under 13 years old, please provide your parent's email address";

	public SupportResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Dialog.Cancel",
				_GetTemplateForActionDialogCancel()
			},
			{
				"Action.Dialog.OK",
				_GetTemplateForActionDialogOK()
			},
			{
				"Action.Dialog.Send",
				_GetTemplateForActionDialogSend()
			},
			{
				"Heading.ContactInformation",
				_GetTemplateForHeadingContactInformation()
			},
			{
				"Heading.DescriptionOfIssue",
				_GetTemplateForHeadingDescriptionOfIssue()
			},
			{
				"Heading.DeviceWithProblem",
				_GetTemplateForHeadingDeviceWithProblem()
			},
			{
				"Heading.Dialog.ErrorWithoutContext",
				_GetTemplateForHeadingDialogErrorWithoutContext()
			},
			{
				"Heading.Dialog.InvalidUsername",
				_GetTemplateForHeadingDialogInvalidUsername()
			},
			{
				"Heading.Dialog.RequestReceived",
				_GetTemplateForHeadingDialogRequestReceived()
			},
			{
				"Heading.HelpCategoryType",
				_GetTemplateForHeadingHelpCategoryType()
			},
			{
				"Heading.IssueDetails",
				_GetTemplateForHeadingIssueDetails()
			},
			{
				"Heading.PageTitle",
				_GetTemplateForHeadingPageTitle()
			},
			{
				"Label.AccountHacked",
				_GetTemplateForLabelAccountHacked()
			},
			{
				"Label.AccountOwnership",
				_GetTemplateForLabelAccountOwnership()
			},
			{
				"Label.AccountPin",
				_GetTemplateForLabelAccountPin()
			},
			{
				"Label.AdjustChildSettings",
				_GetTemplateForLabelAdjustChildSettings()
			},
			{
				"Label.AmazonDevice",
				_GetTemplateForLabelAmazonDevice()
			},
			{
				"Label.AndroidPhone",
				_GetTemplateForLabelAndroidPhone()
			},
			{
				"Label.AndroidTablet",
				_GetTemplateForLabelAndroidTablet()
			},
			{
				"Label.AppealAccountContent",
				_GetTemplateForLabelAppealAccountContent()
			},
			{
				"Label.AppealFriend",
				_GetTemplateForLabelAppealFriend()
			},
			{
				"Label.Billing",
				_GetTemplateForLabelBilling()
			},
			{
				"Label.BugReport",
				_GetTemplateForLabelBugReport()
			},
			{
				"Label.BuildersClub",
				_GetTemplateForLabelBuildersClub()
			},
			{
				"Label.CancelMembership",
				_GetTemplateForLabelCancelMembership()
			},
			{
				"Label.CannotInstall",
				_GetTemplateForLabelCannotInstall()
			},
			{
				"Label.CannotPlayGame",
				_GetTemplateForLabelCannotPlayGame()
			},
			{
				"Label.ChangeChildAge",
				_GetTemplateForLabelChangeChildAge()
			},
			{
				"Label.ChatAgeSettings",
				_GetTemplateForLabelChatAgeSettings()
			},
			{
				"Label.Chromebook",
				_GetTemplateForLabelChromebook()
			},
			{
				"Label.ConfirmEmail",
				_GetTemplateForLabelConfirmEmail()
			},
			{
				"Label.ContentAbuseReport",
				_GetTemplateForLabelContentAbuseReport()
			},
			{
				"Label.Contest",
				_GetTemplateForLabelContest()
			},
			{
				"Label.ContestEventQuestion",
				_GetTemplateForLabelContestEventQuestion()
			},
			{
				"Label.CSCharacter",
				_GetTemplateForLabelCSCharacter()
			},
			{
				"Label.DescribeIssue",
				_GetTemplateForLabelDescribeIssue()
			},
			{
				"Label.DevEx",
				_GetTemplateForLabelDevEx()
			},
			{
				"Label.DevExHowTo",
				_GetTemplateForLabelDevExHowTo()
			},
			{
				"Label.DevExMyRequest",
				_GetTemplateForLabelDevExMyRequest()
			},
			{
				"Label.DMCA",
				_GetTemplateForLabelDMCA()
			},
			{
				"Label.EmailAddress",
				_GetTemplateForLabelEmailAddress()
			},
			{
				"Label.ExploitReport",
				_GetTemplateForLabelExploitReport()
			},
			{
				"Label.FirstName",
				_GetTemplateForLabelFirstName()
			},
			{
				"Label.ForgotPassword",
				_GetTemplateForLabelForgotPassword()
			},
			{
				"Label.FreeRobux",
				_GetTemplateForLabelFreeRobux()
			},
			{
				"Label.GameCredit",
				_GetTemplateForLabelGameCredit()
			},
			{
				"Label.GCPartialPayment",
				_GetTemplateForLabelGCPartialPayment()
			},
			{
				"Label.GCRedeem",
				_GetTemplateForLabelGCRedeem()
			},
			{
				"Label.GCSpendCredit",
				_GetTemplateForLabelGCSpendCredit()
			},
			{
				"Label.HowTo",
				_GetTemplateForLabelHowTo()
			},
			{
				"Label.HowToGeneral",
				_GetTemplateForLabelHowToGeneral()
			},
			{
				"Label.HowToOther",
				_GetTemplateForLabelHowToOther()
			},
			{
				"Label.IdeasSuggestions",
				_GetTemplateForLabelIdeasSuggestions()
			},
			{
				"Label.IPad",
				_GetTemplateForLabelIPad()
			},
			{
				"Label.IPhone",
				_GetTemplateForLabelIPhone()
			},
			{
				"Label.IssueDescription",
				_GetTemplateForLabelIssueDescription()
			},
			{
				"Label.IWasScammed",
				_GetTemplateForLabelIWasScammed()
			},
			{
				"Label.Mac",
				_GetTemplateForLabelMac()
			},
			{
				"Label.Membership",
				_GetTemplateForLabelMembership()
			},
			{
				"Label.Moderation",
				_GetTemplateForLabelModeration()
			},
			{
				"Label.OtherSiteClaim",
				_GetTemplateForLabelOtherSiteClaim()
			},
			{
				"Label.OwnerDMCAClaim",
				_GetTemplateForLabelOwnerDMCAClaim()
			},
			{
				"Label.PC",
				_GetTemplateForLabelPC()
			},
			{
				"Label.PhysicalToyIssue",
				_GetTemplateForLabelPhysicalToyIssue()
			},
			{
				"Label.PleaseSelect",
				_GetTemplateForLabelPleaseSelect()
			},
			{
				"Label.PrizeNotReceived",
				_GetTemplateForLabelPrizeNotReceived()
			},
			{
				"Label.PurchaseDeclined",
				_GetTemplateForLabelPurchaseDeclined()
			},
			{
				"Label.PurchaseDidNotReceive",
				_GetTemplateForLabelPurchaseDidNotReceive()
			},
			{
				"Label.PurchaseUnauthorizedCharge",
				_GetTemplateForLabelPurchaseUnauthorizedCharge()
			},
			{
				"Label.ReportPhish",
				_GetTemplateForLabelReportPhish()
			},
			{
				"Label.RobloxCrashing",
				_GetTemplateForLabelRobloxCrashing()
			},
			{
				"Label.RobloxToys",
				_GetTemplateForLabelRobloxToys()
			},
			{
				"Label.Robux",
				_GetTemplateForLabelRobux()
			},
			{
				"Label.RobuxPurchaseIssue",
				_GetTemplateForLabelRobuxPurchaseIssue()
			},
			{
				"Label.SafetyInquiry",
				_GetTemplateForLabelSafetyInquiry()
			},
			{
				"Label.SafetyQueueTicket",
				_GetTemplateForLabelSafetyQueueTicket()
			},
			{
				"Label.SpecificGameIssue",
				_GetTemplateForLabelSpecificGameIssue()
			},
			{
				"Label.Submit",
				_GetTemplateForLabelSubmit()
			},
			{
				"Label.SuggestFeature",
				_GetTemplateForLabelSuggestFeature()
			},
			{
				"Label.SuggestFeedback",
				_GetTemplateForLabelSuggestFeedback()
			},
			{
				"Label.TechnicalSupport",
				_GetTemplateForLabelTechnicalSupport()
			},
			{
				"Label.ToyCodeIssue",
				_GetTemplateForLabelToyCodeIssue()
			},
			{
				"Label.TwoStepV",
				_GetTemplateForLabelTwoStepV()
			},
			{
				"Label.UserAbuseReport",
				_GetTemplateForLabelUserAbuseReport()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.VCCatalog",
				_GetTemplateForLabelVCCatalog()
			},
			{
				"Label.VCInGame",
				_GetTemplateForLabelVCInGame()
			},
			{
				"Label.Xbox",
				_GetTemplateForLabelXbox()
			},
			{
				"Response.Dialog.ErrorWithoutContext",
				_GetTemplateForResponseDialogErrorWithoutContext()
			},
			{
				"Response.Dialog.InvalidUsername",
				_GetTemplateForResponseDialogInvalidUsername()
			},
			{
				"Response.Dialog.RequestReceived",
				_GetTemplateForResponseDialogRequestReceived()
			},
			{
				"Response.Dialog.TooManyAttemptsError",
				_GetTemplateForResponseDialogTooManyAttemptsError()
			},
			{
				"Response.Dialog.TryAgainError",
				_GetTemplateForResponseDialogTryAgainError()
			},
			{
				"Response.EmailFormatError",
				_GetTemplateForResponseEmailFormatError()
			},
			{
				"Response.EmailNotMatching",
				_GetTemplateForResponseEmailNotMatching()
			},
			{
				"Response.InvalidFirstName",
				_GetTemplateForResponseInvalidFirstName()
			},
			{
				"Response.InvalidUsername",
				_GetTemplateForResponseInvalidUsername()
			},
			{
				"Response.Under13Email",
				_GetTemplateForResponseUnder13Email()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Support";
	}

	protected virtual string _GetTemplateForActionDialogCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDialogOK()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogSend()
	{
		return "Send";
	}

	protected virtual string _GetTemplateForHeadingContactInformation()
	{
		return "Contact Information";
	}

	protected virtual string _GetTemplateForHeadingDescriptionOfIssue()
	{
		return "Description of issue";
	}

	protected virtual string _GetTemplateForHeadingDeviceWithProblem()
	{
		return "What device are you having the problem on?";
	}

	protected virtual string _GetTemplateForHeadingDialogErrorWithoutContext()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "Invalid Username";
	}

	protected virtual string _GetTemplateForHeadingDialogRequestReceived()
	{
		return "Request Received";
	}

	protected virtual string _GetTemplateForHeadingHelpCategoryType()
	{
		return "Type of help category";
	}

	protected virtual string _GetTemplateForHeadingIssueDetails()
	{
		return "Issue Details";
	}

	protected virtual string _GetTemplateForHeadingPageTitle()
	{
		return "Contact Us";
	}

	protected virtual string _GetTemplateForLabelAccountHacked()
	{
		return "Account Hacked";
	}

	protected virtual string _GetTemplateForLabelAccountOwnership()
	{
		return "Account Hacked or Can't Log in";
	}

	protected virtual string _GetTemplateForLabelAccountPin()
	{
		return "Account PIN";
	}

	protected virtual string _GetTemplateForLabelAdjustChildSettings()
	{
		return "Adjust Child Privacy & Security Settings";
	}

	protected virtual string _GetTemplateForLabelAmazonDevice()
	{
		return "Amazon Device";
	}

	protected virtual string _GetTemplateForLabelAndroidPhone()
	{
		return "Android Phone";
	}

	protected virtual string _GetTemplateForLabelAndroidTablet()
	{
		return "Android Tablet";
	}

	protected virtual string _GetTemplateForLabelAppealAccountContent()
	{
		return "Appeal Account or Content";
	}

	protected virtual string _GetTemplateForLabelAppealFriend()
	{
		return "Appeal for Friend";
	}

	protected virtual string _GetTemplateForLabelBilling()
	{
		return "Billing & Payments";
	}

	protected virtual string _GetTemplateForLabelBugReport()
	{
		return "Bug Report";
	}

	protected virtual string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected virtual string _GetTemplateForLabelCancelMembership()
	{
		return "Cancel Membership";
	}

	protected virtual string _GetTemplateForLabelCannotInstall()
	{
		return "Cannot Install Roblox or Studio";
	}

	protected virtual string _GetTemplateForLabelCannotPlayGame()
	{
		return "Cannot Play Game";
	}

	protected virtual string _GetTemplateForLabelChangeChildAge()
	{
		return "Change Child Age";
	}

	protected virtual string _GetTemplateForLabelChatAgeSettings()
	{
		return "Chat & Age Settings";
	}

	protected virtual string _GetTemplateForLabelChromebook()
	{
		return "Chromebook";
	}

	protected virtual string _GetTemplateForLabelConfirmEmail()
	{
		return "Confirm Email Address";
	}

	protected virtual string _GetTemplateForLabelContentAbuseReport()
	{
		return "Report Content Breaking Rules";
	}

	protected virtual string _GetTemplateForLabelContest()
	{
		return "Contests & Events";
	}

	protected virtual string _GetTemplateForLabelContestEventQuestion()
	{
		return "Question or Issue";
	}

	protected virtual string _GetTemplateForLabelCSCharacter()
	{
		return "Customer Service Character";
	}

	protected virtual string _GetTemplateForLabelDescribeIssue()
	{
		return "Please describe your issue";
	}

	protected virtual string _GetTemplateForLabelDevEx()
	{
		return "DevEx";
	}

	protected virtual string _GetTemplateForLabelDevExHowTo()
	{
		return "DevEx How To";
	}

	protected virtual string _GetTemplateForLabelDevExMyRequest()
	{
		return "DevEx My Request";
	}

	protected virtual string _GetTemplateForLabelDMCA()
	{
		return "DMCA";
	}

	protected virtual string _GetTemplateForLabelEmailAddress()
	{
		return "Email Address";
	}

	protected virtual string _GetTemplateForLabelExploitReport()
	{
		return "Exploit Report";
	}

	protected virtual string _GetTemplateForLabelFirstName()
	{
		return "First Name";
	}

	protected virtual string _GetTemplateForLabelForgotPassword()
	{
		return "Forgot Password";
	}

	protected virtual string _GetTemplateForLabelFreeRobux()
	{
		return "Free Robux";
	}

	protected virtual string _GetTemplateForLabelGameCredit()
	{
		return "Game Card";
	}

	protected virtual string _GetTemplateForLabelGCPartialPayment()
	{
		return "Purchase - Split Payment";
	}

	protected virtual string _GetTemplateForLabelGCRedeem()
	{
		return "Game Card - Redeem";
	}

	protected virtual string _GetTemplateForLabelGCSpendCredit()
	{
		return "Game Card - Spend Credit";
	}

	protected virtual string _GetTemplateForLabelHowTo()
	{
		return "How To";
	}

	protected virtual string _GetTemplateForLabelHowToGeneral()
	{
		return "How To - General";
	}

	protected virtual string _GetTemplateForLabelHowToOther()
	{
		return "How To - Other";
	}

	protected virtual string _GetTemplateForLabelIdeasSuggestions()
	{
		return "Ideas & Suggestions";
	}

	protected virtual string _GetTemplateForLabelIPad()
	{
		return "iPad";
	}

	protected virtual string _GetTemplateForLabelIPhone()
	{
		return "iPhone";
	}

	protected virtual string _GetTemplateForLabelIssueDescription()
	{
		return "Please describe the issue that you are facing. Include any relevant information like where the issue is occurring or the error message.";
	}

	protected virtual string _GetTemplateForLabelIWasScammed()
	{
		return "I was Scammed";
	}

	protected virtual string _GetTemplateForLabelMac()
	{
		return "Mac";
	}

	protected virtual string _GetTemplateForLabelMembership()
	{
		return "Membership";
	}

	protected virtual string _GetTemplateForLabelModeration()
	{
		return "Moderation";
	}

	protected virtual string _GetTemplateForLabelOtherSiteClaim()
	{
		return "Other Site Claim";
	}

	protected virtual string _GetTemplateForLabelOwnerDMCAClaim()
	{
		return "Owner DMCA Claim";
	}

	protected virtual string _GetTemplateForLabelPC()
	{
		return "PC";
	}

	protected virtual string _GetTemplateForLabelPhysicalToyIssue()
	{
		return "Physical Toy Issue";
	}

	protected virtual string _GetTemplateForLabelPleaseSelect()
	{
		return "Please Select...";
	}

	protected virtual string _GetTemplateForLabelPrizeNotReceived()
	{
		return "Prize Not Received";
	}

	protected virtual string _GetTemplateForLabelPurchaseDeclined()
	{
		return "Purchase - Declined";
	}

	protected virtual string _GetTemplateForLabelPurchaseDidNotReceive()
	{
		return "Purchase - Did Not Receive";
	}

	protected virtual string _GetTemplateForLabelPurchaseUnauthorizedCharge()
	{
		return "Purchase - Unauthorized Charge";
	}

	protected virtual string _GetTemplateForLabelReportPhish()
	{
		return "Report Phishing Site";
	}

	protected virtual string _GetTemplateForLabelRobloxCrashing()
	{
		return "Roblox Crashing";
	}

	protected virtual string _GetTemplateForLabelRobloxToys()
	{
		return "Roblox Toys";
	}

	protected virtual string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForLabelRobuxPurchaseIssue()
	{
		return "Robux - Purchase Issue";
	}

	protected virtual string _GetTemplateForLabelSafetyInquiry()
	{
		return "Inappropriate game or user behavior";
	}

	protected virtual string _GetTemplateForLabelSafetyQueueTicket()
	{
		return "User Safety Concern";
	}

	protected virtual string _GetTemplateForLabelSpecificGameIssue()
	{
		return "Specific Game Issue";
	}

	protected virtual string _GetTemplateForLabelSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForLabelSuggestFeature()
	{
		return "Feature Suggestion";
	}

	protected virtual string _GetTemplateForLabelSuggestFeedback()
	{
		return "Feedback";
	}

	protected virtual string _GetTemplateForLabelTechnicalSupport()
	{
		return "Technical Support";
	}

	protected virtual string _GetTemplateForLabelToyCodeIssue()
	{
		return "Toy Code Issue";
	}

	protected virtual string _GetTemplateForLabelTwoStepV()
	{
		return "2-Step Verification";
	}

	protected virtual string _GetTemplateForLabelUserAbuseReport()
	{
		return "Report User Breaking Rules";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelVCCatalog()
	{
		return "Website Item";
	}

	protected virtual string _GetTemplateForLabelVCInGame()
	{
		return "In-Game Item";
	}

	protected virtual string _GetTemplateForLabelXbox()
	{
		return "Xbox";
	}

	protected virtual string _GetTemplateForResponseDialogErrorWithoutContext()
	{
		return "Something went wrong, please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.";
	}

	protected virtual string _GetTemplateForResponseDialogRequestReceived()
	{
		return "Thank you for contacting Roblox. Please check your email for a message from Customer Service.";
	}

	protected virtual string _GetTemplateForResponseDialogTooManyAttemptsError()
	{
		return "Too many attempts. Try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogTryAgainError()
	{
		return "An error occurred. Try again later.";
	}

	protected virtual string _GetTemplateForResponseEmailFormatError()
	{
		return "Please enter a properly formatted email address";
	}

	protected virtual string _GetTemplateForResponseEmailNotMatching()
	{
		return "Email address does not match";
	}

	protected virtual string _GetTemplateForResponseInvalidFirstName()
	{
		return "Please enter a valid first name";
	}

	protected virtual string _GetTemplateForResponseInvalidUsername()
	{
		return "That doesn't appear to be a valid Roblox username.";
	}

	protected virtual string _GetTemplateForResponseUnder13Email()
	{
		return "If you are under 13 years old, please provide your parent's email address";
	}
}
