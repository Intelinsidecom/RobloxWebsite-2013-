using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class AccountSettingsResources_en_us : TranslationResourcesBase, IAccountSettingsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BillingHistoryLoadMore"
	/// English String: "Load More"
	/// </summary>
	public virtual string ActionBillingHistoryLoadMore => "Load More";

	/// <summary>
	/// Key: "Action.CancelRenewal"
	/// English String: "Cancel Renewal"
	/// </summary>
	public virtual string ActionCancelRenewal => "Cancel Renewal";

	/// <summary>
	/// Key: "Action.Dialog.AddEmail"
	/// English String: "Add Email"
	/// </summary>
	public virtual string ActionDialogAddEmail => "Add Email";

	/// <summary>
	/// Key: "Action.Dialog.AddPhone"
	/// English String: "Add Phone"
	/// </summary>
	public virtual string ActionDialogAddPhone => "Add Phone";

	/// <summary>
	/// Key: "Action.Dialog.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionDialogCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Dialog.ChangeEmail"
	/// English String: "Change Email"
	/// </summary>
	public virtual string ActionDialogChangeEmail => "Change Email";

	/// <summary>
	/// Key: "Action.Dialog.ChangeEmailConfirmation"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogChangeEmailConfirmation => "OK";

	/// <summary>
	/// Key: "Action.Dialog.ChangePassword"
	/// English String: "Update"
	/// </summary>
	public virtual string ActionDialogChangePassword => "Update";

	/// <summary>
	/// Key: "Action.Dialog.ChangePasswordConfirmation"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogChangePasswordConfirmation => "OK";

	/// <summary>
	/// Key: "Action.Dialog.ChangeUsernameBuy"
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionDialogChangeUsernameBuy => "Buy";

	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// English String: "Close"
	/// </summary>
	public virtual string ActionDialogClose => "Close";

	/// <summary>
	/// Key: "Action.Dialog.EditPhonePrimary"
	/// English String: "Edit Phone"
	/// </summary>
	public virtual string ActionDialogEditPhonePrimary => "Edit Phone";

	/// <summary>
	/// Key: "Action.Dialog.EditPhoneSecondary"
	/// English String: "Remove Phone Number"
	/// </summary>
	public virtual string ActionDialogEditPhoneSecondary => "Remove Phone Number";

	/// <summary>
	/// Key: "Action.Dialog.InsufficientFundsBuy"
	/// English String: "Buy"
	/// </summary>
	public virtual string ActionDialogInsufficientFundsBuy => "Buy";

	/// <summary>
	/// Key: "Action.Dialog.No"
	/// English String: "No"
	/// </summary>
	public virtual string ActionDialogNo => "No";

	/// <summary>
	/// Key: "Action.Dialog.PinCreate"
	/// English String: "Add"
	/// </summary>
	public virtual string ActionDialogPinCreate => "Add";

	/// <summary>
	/// Key: "Action.Dialog.PinCreateOk"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogPinCreateOk => "OK";

	/// <summary>
	/// Key: "Action.Dialog.PinUnlock"
	/// English String: "Unlock"
	/// </summary>
	public virtual string ActionDialogPinUnlock => "Unlock";

	/// <summary>
	/// Key: "Action.Dialog.RemovePhonePrimary"
	/// English String: "Remove"
	/// </summary>
	public virtual string ActionDialogRemovePhonePrimary => "Remove";

	/// <summary>
	/// Key: "Action.Dialog.RemovePhoneSecondary"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionDialogRemovePhoneSecondary => "Cancel";

	/// <summary>
	/// Key: "Action.Dialog.Send"
	/// Send
	/// English String: "Send"
	/// </summary>
	public virtual string ActionDialogSend => "Send";

	/// <summary>
	/// Key: "Action.Dialog.Success"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogSuccess => "OK";

	/// <summary>
	/// Key: "Action.Dialog.Update"
	/// English String: "Update"
	/// </summary>
	public virtual string ActionDialogUpdate => "Update";

	/// <summary>
	/// Key: "Action.Dialog.VerifyEmailOk"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogVerifyEmailOk => "OK";

	/// <summary>
	/// Key: "Action.Dialog.VerifyEmailPrimary"
	/// English String: "Verify Email"
	/// </summary>
	public virtual string ActionDialogVerifyEmailPrimary => "Verify Email";

	/// <summary>
	/// Key: "Action.Dialog.VerifyEmailRetry"
	/// English String: "Retry"
	/// </summary>
	public virtual string ActionDialogVerifyEmailRetry => "Retry";

	/// <summary>
	/// Key: "Action.Dialog.VerifyPhonePrimary"
	/// English String: "Verify"
	/// </summary>
	public virtual string ActionDialogVerifyPhonePrimary => "Verify";

	/// <summary>
	/// Key: "Action.Dialog.VerifyPhoneResendLink"
	/// English String: "Resend Code"
	/// </summary>
	public virtual string ActionDialogVerifyPhoneResendLink => "Resend Code";

	/// <summary>
	/// Key: "Action.Dialog.VerifyPhoneSecondary"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionDialogVerifyPhoneSecondary => "Cancel";

	/// <summary>
	/// Key: "Action.Dialog.Yes"
	/// English String: "Yes"
	/// </summary>
	public virtual string ActionDialogYes => "Yes";

	/// <summary>
	/// Key: "Action.Hide"
	/// English String: "Hide"
	/// </summary>
	public virtual string ActionHide => "Hide";

	/// <summary>
	/// Key: "Action.Join"
	/// English String: "Join"
	/// </summary>
	public virtual string ActionJoin => "Join";

	/// <summary>
	/// Key: "Action.JoinBuildersClub"
	/// English String: "Join Builders Club"
	/// </summary>
	public virtual string ActionJoinBuildersClub => "Join Builders Club";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public virtual string ActionSave => "Save";

	/// <summary>
	/// Key: "Action.Show"
	/// English String: "Show"
	/// </summary>
	public virtual string ActionShow => "Show";

	/// <summary>
	/// Key: "Action.SignoutAllSessions"
	/// English String: "Sign out"
	/// </summary>
	public virtual string ActionSignoutAllSessions => "Sign out";

	/// <summary>
	/// Key: "Action.SocialDisconnect"
	/// English String: "Disconnect"
	/// </summary>
	public virtual string ActionSocialDisconnect => "Disconnect";

	/// <summary>
	/// Key: "Action.SuccessDialogButtonText"
	/// English String: "OK"
	/// </summary>
	public virtual string ActionSuccessDialogButtonText => "OK";

	/// <summary>
	/// Key: "Action.Unblock"
	/// English String: "Unblock"
	/// </summary>
	public virtual string ActionUnblock => "Unblock";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public virtual string ActionUpgradeMembership => "Upgrade Membership";

	/// <summary>
	/// Key: "Description.AccountControls"
	/// English String: "You can setup account restrictions on this account to restrict access to account settings and uncurated content"
	/// </summary>
	public virtual string DescriptionAccountControls => "You can setup account restrictions on this account to restrict access to account settings and uncurated content";

	/// <summary>
	/// Key: "Description.AccountEmailRevertEmail.Subject"
	/// Subject for account email revert email that is sent out to the old account when the new account email is verified.
	/// English String: "Roblox Email Reset"
	/// </summary>
	public virtual string DescriptionAccountEmailRevertEmailSubject => "Roblox Email Reset";

	/// <summary>
	/// Key: "Description.DesktopPush1"
	/// English String: "See notifications on this computer even when Roblox is closed."
	/// </summary>
	public virtual string DescriptionDesktopPush1 => "See notifications on this computer even when Roblox is closed.";

	/// <summary>
	/// Key: "Description.DesktopPush2"
	/// English String: "To see notifications, you may be prompted to turn on push notifications on your browser."
	/// </summary>
	public virtual string DescriptionDesktopPush2 => "To see notifications, you may be prompted to turn on push notifications on your browser.";

	/// <summary>
	/// Key: "Description.DesktopPush3"
	/// English String: "Desktop notifications for this device."
	/// </summary>
	public virtual string DescriptionDesktopPush3 => "Desktop notifications for this device.";

	/// <summary>
	/// Key: "Description.Dialog.AddPhone"
	/// English String: "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)"
	/// </summary>
	public virtual string DescriptionDialogAddPhone => "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)";

	/// <summary>
	/// Key: "Description.Dialog.ChangeEmailConfirmation"
	/// English String: "An email has been sent for verification"
	/// </summary>
	public virtual string DescriptionDialogChangeEmailConfirmation => "An email has been sent for verification";

	/// <summary>
	/// Key: "Description.Dialog.ChangeEmailWarning"
	/// English String: "The account email will not change until the new email has been verified."
	/// </summary>
	public virtual string DescriptionDialogChangeEmailWarning => "The account email will not change until the new email has been verified.";

	/// <summary>
	/// Key: "Description.Dialog.ChangePasswordConfirmation"
	/// English String: "You have successfully changed your password."
	/// </summary>
	public virtual string DescriptionDialogChangePasswordConfirmation => "You have successfully changed your password.";

	/// <summary>
	/// Key: "Description.Dialog.ChangeUsernameDisclaimer"
	/// English String: "Important: Original account creation date will carry over to your new username."
	/// </summary>
	public virtual string DescriptionDialogChangeUsernameDisclaimer => "Important: Original account creation date will carry over to your new username.";

	/// <summary>
	/// Key: "Description.Dialog.ChangeUsernameForFree"
	/// Description notifying the user that this username change is free
	/// English String: "Change username once for free."
	/// </summary>
	public virtual string DescriptionDialogChangeUsernameForFree => "Change username once for free.";

	/// <summary>
	/// Key: "Description.Dialog.ChangeUsernameHistory"
	/// English String: "Previous forum posts will appear under your old username and will NOT carry over to your new username."
	/// </summary>
	public virtual string DescriptionDialogChangeUsernameHistory => "Previous forum posts will appear under your old username and will NOT carry over to your new username.";

	/// <summary>
	/// Key: "Description.Dialog.ChangeUsernameTitle"
	/// English String: "Change Username"
	/// </summary>
	public virtual string DescriptionDialogChangeUsernameTitle => "Change Username";

	/// <summary>
	/// Key: "Description.Dialog.EditPhoneWarning"
	/// English String: "The phone number will not change until the new phone number has been verified."
	/// </summary>
	public virtual string DescriptionDialogEditPhoneWarning => "The phone number will not change until the new phone number has been verified.";

	/// <summary>
	/// Key: "Description.Dialog.EmailProvideAndVerifyWarning"
	/// warning message when user doesn't have email address on file at the time of changing username
	/// English String: "You must provide and verify your email before you can change your username."
	/// </summary>
	public virtual string DescriptionDialogEmailProvideAndVerifyWarning => "You must provide and verify your email before you can change your username.";

	/// <summary>
	/// Key: "Description.Dialog.EmailVerificationSent"
	/// English String: "Thanks! Your verification email has been sent."
	/// </summary>
	public virtual string DescriptionDialogEmailVerificationSent => "Thanks! Your verification email has been sent.";

	/// <summary>
	/// Key: "Description.Dialog.EmailVerifyWarning"
	/// English String: "You must verify your email before you can change your username."
	/// </summary>
	public virtual string DescriptionDialogEmailVerifyWarning => "You must verify your email before you can change your username.";

	/// <summary>
	/// Key: "Description.Dialog.FacebookDisconnectWarning"
	/// English String: "Please add password to secure your account before disconnecting from Facebook."
	/// </summary>
	public virtual string DescriptionDialogFacebookDisconnectWarning => "Please add password to secure your account before disconnecting from Facebook.";

	/// <summary>
	/// Key: "Description.Dialog.MissingEmailAccountPin"
	/// error message
	/// English String: "You must provide and verify your email before you can add an Account PIN."
	/// </summary>
	public virtual string DescriptionDialogMissingEmailAccountPin => "You must provide and verify your email before you can add an Account PIN.";

	/// <summary>
	/// Key: "Description.Dialog.MissingEmailTwoStepVerification"
	/// error message
	/// English String: "You must provide and verify your email before you can enable 2 Step Verification."
	/// </summary>
	public virtual string DescriptionDialogMissingEmailTwoStepVerification => "You must provide and verify your email before you can enable 2 Step Verification.";

	/// <summary>
	/// Key: "Description.Dialog.MissingEmailUsername"
	/// error message
	/// English String: "You must provide and verify your email before you can change your username."
	/// </summary>
	public virtual string DescriptionDialogMissingEmailUsername => "You must provide and verify your email before you can change your username.";

	/// <summary>
	/// Key: "Description.Dialog.PinUnlock"
	/// English String: "Enter the Account PIN attached to your account"
	/// </summary>
	public virtual string DescriptionDialogPinUnlock => "Enter the Account PIN attached to your account";

	/// <summary>
	/// Key: "Description.Dialog.UnverifiedEmailAccountPin"
	/// error message
	/// English String: "You must verify your email before you can add an Account PIN."
	/// </summary>
	public virtual string DescriptionDialogUnverifiedEmailAccountPin => "You must verify your email before you can add an Account PIN.";

	/// <summary>
	/// Key: "Description.Dialog.UnverifiedEmailTwoStepVerification"
	/// error message
	/// English String: "You must verify your email before you can enable 2 Step Verification."
	/// </summary>
	public virtual string DescriptionDialogUnverifiedEmailTwoStepVerification => "You must verify your email before you can enable 2 Step Verification.";

	/// <summary>
	/// Key: "Description.Dialog.UnverifiedEmailUsername"
	/// error message
	/// English String: "You must verify your email before you can change your username."
	/// </summary>
	public virtual string DescriptionDialogUnverifiedEmailUsername => "You must verify your email before you can change your username.";

	/// <summary>
	/// Key: "Description.FastTrack"
	/// A description of the Fast Track program that is intended to help users understand why they are part of the program and how they can best be involved.
	/// English String: "You have been enrolled in the Fast Track reporting program for making good abuse reports.  Your abuse reports are now Fast Tracked for review.  Stay in the program by continuing to make good abuse reports. Thank you for helping to make Roblox a positive experience!"
	/// </summary>
	public virtual string DescriptionFastTrack => "You have been enrolled in the Fast Track reporting program for making good abuse reports.  Your abuse reports are now Fast Tracked for review.  Stay in the program by continuing to make good abuse reports. Thank you for helping to make Roblox a positive experience!";

	/// <summary>
	/// Key: "Description.FastTrack.Statistics"
	/// A section of the page dedicated to reporting, analysis, and charting of Fast Track contributor quality.
	/// English String: "Statistics"
	/// </summary>
	public virtual string DescriptionFastTrackStatistics => "Statistics";

	/// <summary>
	/// Key: "Description.HelpText.Description"
	/// English String: "Do not provide any details that can be used to identify you outside Roblox."
	/// </summary>
	public virtual string DescriptionHelpTextDescription => "Do not provide any details that can be used to identify you outside Roblox.";

	/// <summary>
	/// Key: "Description.HelpText.FastTrack.Accuracy"
	/// Help text that explains to users how we define Accuracy of abuse reports for the Fast Track program. Intention is to help avoid user confusion about the meaning of the scores.
	/// English String: "Accuracy is how often moderation agreed with abuse reports. Your number will show after you submit several reports. 'Everyone' means all of the Fast Track members as a group."
	/// </summary>
	public virtual string DescriptionHelpTextFastTrackAccuracy => "Accuracy is how often moderation agreed with abuse reports. Your number will show after you submit several reports. 'Everyone' means all of the Fast Track members as a group.";

	/// <summary>
	/// Key: "Description.HelpText.PrivacyMode"
	/// English String: "Updating age to under 13 will enable Privacy Mode."
	/// </summary>
	public virtual string DescriptionHelpTextPrivacyMode => "Updating age to under 13 will enable Privacy Mode.";

	/// <summary>
	/// Key: "Description.HoverText.ChangePassword"
	/// English String: "Change Password"
	/// </summary>
	public virtual string DescriptionHoverTextChangePassword => "Change Password";

	/// <summary>
	/// Key: "Description.HoverText.ChangeUsername"
	/// English String: "Change Username"
	/// </summary>
	public virtual string DescriptionHoverTextChangeUsername => "Change Username";

	/// <summary>
	/// Key: "Description.HoverText.UpdateEmail"
	/// English String: "Update Email"
	/// </summary>
	public virtual string DescriptionHoverTextUpdateEmail => "Update Email";

	/// <summary>
	/// Key: "Description.MembershipHelp"
	/// English String: "For billing and payment questions: info@roblox.com"
	/// </summary>
	public virtual string DescriptionMembershipHelp => "For billing and payment questions: info@roblox.com";

	/// <summary>
	/// Key: "Description.MembershipStatus"
	/// English String: "You're not a member yet. Join Builders Club today!"
	/// </summary>
	public virtual string DescriptionMembershipStatus => "You're not a member yet. Join Builders Club today!";

	/// <summary>
	/// Key: "Description.MembershipStatusRobloxPremium"
	/// English String: "You're not a member yet. Join Roblox Premium today!"
	/// </summary>
	public virtual string DescriptionMembershipStatusRobloxPremium => "You're not a member yet. Join Roblox Premium today!";

	/// <summary>
	/// Key: "Description.MobilePush1"
	/// English String: "See notifications on your devices' home screens. You can turn them on or off from the Roblox app."
	/// </summary>
	public virtual string DescriptionMobilePush1 => "See notifications on your devices' home screens. You can turn them on or off from the Roblox app.";

	/// <summary>
	/// Key: "Description.MobilePush2"
	/// English String: "Mobile push notifications for this device."
	/// </summary>
	public virtual string DescriptionMobilePush2 => "Mobile push notifications for this device.";

	/// <summary>
	/// Key: "Description.NotificationStream1"
	/// English String: "See notifications in my stream. Click the notifications icon in the top bar to view these notifications."
	/// </summary>
	public virtual string DescriptionNotificationStream1 => "See notifications in my stream. Click the notifications icon in the top bar to view these notifications.";

	/// <summary>
	/// Key: "Description.NotificationStream2"
	/// English String: "After you turn off a notification type, we won't send you any new notifications of that type."
	/// </summary>
	public virtual string DescriptionNotificationStream2 => "After you turn off a notification type, we won't send you any new notifications of that type.";

	/// <summary>
	/// Key: "Description.RenevalFromWebsiteOnly"
	/// English String: "Note: If you would like to cancel your renewal membership, please log in from the website."
	/// </summary>
	public virtual string DescriptionRenevalFromWebsiteOnly => "Note: If you would like to cancel your renewal membership, please log in from the website.";

	/// <summary>
	/// Key: "Description.SuccessDialogMessage"
	/// English String: "Saved  Successfully!"
	/// </summary>
	public virtual string DescriptionSuccessDialogMessage => "Saved  Successfully!";

	/// <summary>
	/// Key: "Description.TwoStepVerificationSecondary"
	/// English String: "A verified email is required"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationSecondary => "A verified email is required";

	/// <summary>
	/// Key: "Description.UsernameChangeEmail.Subject"
	/// Subject for username change email that is sent out on a successful change of username
	/// English String: "Roblox Username Change"
	/// </summary>
	public virtual string DescriptionUsernameChangeEmailSubject => "Roblox Username Change";

	/// <summary>
	/// Key: "Description.VerificationEmail.Subject.Over13"
	/// Subject for verification email that is sent out when an over 13 user adds an email to the account
	/// English String: "Roblox Email Verification"
	/// </summary>
	public virtual string DescriptionVerificationEmailSubjectOver13 => "Roblox Email Verification";

	/// <summary>
	/// Key: "Description.VerificationEmail.Subject.Under13"
	/// Subject for verification email that is sent out when an under 13 user adds an email to the account
	/// English String: "Roblox Account Authorization"
	/// </summary>
	public virtual string DescriptionVerificationEmailSubjectUnder13 => "Roblox Account Authorization";

	/// <summary>
	/// Key: "Example.Description"
	/// English String: "Describe yourself(1000 character limit)"
	/// </summary>
	public virtual string ExampleDescription => "Describe yourself(1000 character limit)";

	/// <summary>
	/// Key: "Example.Facebook"
	/// English String: "e.g. www.facebook.com/Roblox"
	/// </summary>
	public virtual string ExampleFacebook => "e.g. www.facebook.com/Roblox";

	/// <summary>
	/// Key: "Example.GooglePlus"
	/// English String: "e.g. http://plus.google.com/profileId"
	/// </summary>
	public virtual string ExampleGooglePlus => "e.g. http://plus.google.com/profileId";

	/// <summary>
	/// Key: "Example.Twitch"
	/// English String: "e.g. www.twitch.tv/roblox/profile"
	/// </summary>
	public virtual string ExampleTwitch => "e.g. www.twitch.tv/roblox/profile";

	/// <summary>
	/// Key: "Example.Twitter"
	/// English String: "e.g. @Roblox"
	/// </summary>
	public virtual string ExampleTwitter => "e.g. @Roblox";

	/// <summary>
	/// Key: "Example.YouTube"
	/// English String: "e.g. www.youtube.com/user/roblox"
	/// </summary>
	public virtual string ExampleYouTube => "e.g. www.youtube.com/user/roblox";

	/// <summary>
	/// Key: "Heading.AccountControls"
	/// English String: "What are Account Controls?"
	/// </summary>
	public virtual string HeadingAccountControls => "What are Account Controls?";

	/// <summary>
	/// Key: "Heading.AccountInfo"
	/// English String: "Account Info"
	/// </summary>
	public virtual string HeadingAccountInfo => "Account Info";

	/// <summary>
	/// Key: "Heading.Billing"
	/// English String: "Billing"
	/// </summary>
	public virtual string HeadingBilling => "Billing";

	/// <summary>
	/// Key: "Heading.BlockedUsers"
	/// English String: "Blocked Users"
	/// </summary>
	public virtual string HeadingBlockedUsers => "Blocked Users";

	/// <summary>
	/// Key: "Heading.ContactSettings"
	/// English String: "Contact Settings"
	/// </summary>
	public virtual string HeadingContactSettings => "Contact Settings";

	/// <summary>
	/// Key: "Heading.DesktopPush"
	/// English String: "Desktop Push"
	/// </summary>
	public virtual string HeadingDesktopPush => "Desktop Push";

	/// <summary>
	/// Key: "Heading.Dialog.AddPassword"
	/// English String: "Add Password"
	/// </summary>
	public virtual string HeadingDialogAddPassword => "Add Password";

	/// <summary>
	/// Key: "Heading.Dialog.AddPhone"
	/// English String: "Add Phone"
	/// </summary>
	public virtual string HeadingDialogAddPhone => "Add Phone";

	/// <summary>
	/// Key: "Heading.Dialog.ChangeEmail"
	/// English String: "Change My Email"
	/// </summary>
	public virtual string HeadingDialogChangeEmail => "Change My Email";

	/// <summary>
	/// Key: "Heading.Dialog.ChangeEmailConfirmation"
	/// English String: "Email Address Changed"
	/// </summary>
	public virtual string HeadingDialogChangeEmailConfirmation => "Email Address Changed";

	/// <summary>
	/// Key: "Heading.Dialog.ChangePassword"
	/// English String: "Change Password"
	/// </summary>
	public virtual string HeadingDialogChangePassword => "Change Password";

	/// <summary>
	/// Key: "Heading.Dialog.ChangePasswordConfirmation"
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingDialogChangePasswordConfirmation => "Success";

	/// <summary>
	/// Key: "Heading.Dialog.ChangePasswordSuccess"
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingDialogChangePasswordSuccess => "Success";

	/// <summary>
	/// Key: "Heading.Dialog.ChangeUsername"
	/// English String: "Change Username"
	/// </summary>
	public virtual string HeadingDialogChangeUsername => "Change Username";

	/// <summary>
	/// Key: "Heading.Dialog.DefaultError"
	/// English String: "Error"
	/// </summary>
	public virtual string HeadingDialogDefaultError => "Error";

	/// <summary>
	/// Key: "Heading.Dialog.DefaultSuccess"
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingDialogDefaultSuccess => "Success";

	/// <summary>
	/// Key: "Heading.Dialog.EditPhone"
	/// English String: "Edit Phone"
	/// </summary>
	public virtual string HeadingDialogEditPhone => "Edit Phone";

	/// <summary>
	/// Key: "Heading.Dialog.InsufficientFunds"
	/// English String: "Insufficient Funds"
	/// </summary>
	public virtual string HeadingDialogInsufficientFunds => "Insufficient Funds";

	/// <summary>
	/// Key: "Heading.Dialog.InvalidUsername"
	/// Invalid Username
	/// English String: "Invalid Username"
	/// </summary>
	public virtual string HeadingDialogInvalidUsername => "Invalid Username";

	/// <summary>
	/// Key: "Heading.Dialog.PinCreate"
	/// English String: "Add PIN"
	/// </summary>
	public virtual string HeadingDialogPinCreate => "Add PIN";

	/// <summary>
	/// Key: "Heading.Dialog.PinCreateSuccessConfirmation"
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingDialogPinCreateSuccessConfirmation => "Success";

	/// <summary>
	/// Key: "Heading.Dialog.PinUnlock"
	/// English String: "Account PIN Required"
	/// </summary>
	public virtual string HeadingDialogPinUnlock => "Account PIN Required";

	/// <summary>
	/// Key: "Heading.Dialog.RemovePhone"
	/// English String: "Remove Phone"
	/// </summary>
	public virtual string HeadingDialogRemovePhone => "Remove Phone";

	/// <summary>
	/// Key: "Heading.Dialog.VerifiedEmailRequired"
	/// English String: "Verified Email Required"
	/// </summary>
	public virtual string HeadingDialogVerifiedEmailRequired => "Verified Email Required";

	/// <summary>
	/// Key: "Heading.Dialog.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public virtual string HeadingDialogVerifyEmail => "Verify Email";

	/// <summary>
	/// Key: "Heading.Dialog.VerifyPhone"
	/// English String: "Verify Phone"
	/// </summary>
	public virtual string HeadingDialogVerifyPhone => "Verify Phone";

	/// <summary>
	/// Key: "Heading.FastTrack"
	/// Fast Track is the name of the limited access community moderation program.
	/// English String: "Fast Track"
	/// </summary>
	public virtual string HeadingFastTrack => "Fast Track";

	/// <summary>
	/// Key: "Heading.MembershipStatus"
	/// English String: "Membership status"
	/// </summary>
	public virtual string HeadingMembershipStatus => "Membership status";

	/// <summary>
	/// Key: "Heading.NotificationOptions"
	/// English String: "Notify me when"
	/// </summary>
	public virtual string HeadingNotificationOptions => "Notify me when";

	/// <summary>
	/// Key: "Heading.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public virtual string HeadingNotifications => "Notifications";

	/// <summary>
	/// Key: "Heading.Notifications.ActionWhen"
	/// English String: "Notify me when"
	/// </summary>
	public virtual string HeadingNotificationsActionWhen => "Notify me when";

	/// <summary>
	/// Key: "Heading.Notifications.DesktopPush"
	/// English String: "Desktop Push"
	/// </summary>
	public virtual string HeadingNotificationsDesktopPush => "Desktop Push";

	/// <summary>
	/// Key: "Heading.Notifications.MobilePush"
	/// English String: "Mobile Push"
	/// </summary>
	public virtual string HeadingNotificationsMobilePush => "Mobile Push";

	/// <summary>
	/// Key: "Heading.Notifications.Stream"
	/// English String: "Notification Stream"
	/// </summary>
	public virtual string HeadingNotificationsStream => "Notification Stream";

	/// <summary>
	/// Key: "Heading.NotificationStream"
	/// English String: "Notification Stream"
	/// </summary>
	public virtual string HeadingNotificationStream => "Notification Stream";

	/// <summary>
	/// Key: "Heading.OtherSettings"
	/// English String: "Other Settings"
	/// </summary>
	public virtual string HeadingOtherSettings => "Other Settings";

	/// <summary>
	/// Key: "Heading.PageTitle"
	/// English String: "My Settings"
	/// </summary>
	public virtual string HeadingPageTitle => "My Settings";

	/// <summary>
	/// Key: "Heading.Personal"
	/// English String: "Personal"
	/// </summary>
	public virtual string HeadingPersonal => "Personal";

	/// <summary>
	/// Key: "Heading.Pin"
	/// English String: "Account PIN"
	/// </summary>
	public virtual string HeadingPin => "Account PIN";

	/// <summary>
	/// Key: "Heading.PrivacySettings"
	/// English String: "Privacy Settings"
	/// </summary>
	public virtual string HeadingPrivacySettings => "Privacy Settings";

	/// <summary>
	/// Key: "Heading.RenevalDate"
	/// English String: "Renewal date"
	/// </summary>
	public virtual string HeadingRenevalDate => "Renewal date";

	/// <summary>
	/// Key: "Heading.Restrictions"
	/// English String: "Account Restrictions"
	/// </summary>
	public virtual string HeadingRestrictions => "Account Restrictions";

	/// <summary>
	/// Key: "Heading.SecureSignOut"
	/// English String: "Secure Sign Out"
	/// </summary>
	public virtual string HeadingSecureSignOut => "Secure Sign Out";

	/// <summary>
	/// Key: "Heading.SocialNetworks"
	/// English String: "Social Networks"
	/// </summary>
	public virtual string HeadingSocialNetworks => "Social Networks";

	/// <summary>
	/// Key: "Heading.SocialSignOn"
	/// English String: "Social Sign On"
	/// </summary>
	public virtual string HeadingSocialSignOn => "Social Sign On";

	/// <summary>
	/// Key: "Heading.SuccessDialogTitle"
	/// English String: "Success"
	/// </summary>
	public virtual string HeadingSuccessDialogTitle => "Success";

	/// <summary>
	/// Key: "Heading.Tab.AccountInfo"
	/// English String: "Account Info"
	/// </summary>
	public virtual string HeadingTabAccountInfo => "Account Info";

	/// <summary>
	/// Key: "Heading.Tab.Billing"
	/// English String: "Billing"
	/// </summary>
	public virtual string HeadingTabBilling => "Billing";

	/// <summary>
	/// Key: "Heading.Tab.FastTrack"
	/// Fast Track is the name of the limited access community moderation program.
	/// English String: "Fast Track"
	/// </summary>
	public virtual string HeadingTabFastTrack => "Fast Track";

	/// <summary>
	/// Key: "Heading.Tab.Notifications"
	/// English String: "Notifications"
	/// </summary>
	public virtual string HeadingTabNotifications => "Notifications";

	/// <summary>
	/// Key: "Heading.Tab.Privacy"
	/// English String: "Privacy"
	/// </summary>
	public virtual string HeadingTabPrivacy => "Privacy";

	/// <summary>
	/// Key: "Heading.Tab.Security"
	/// English String: "Security"
	/// </summary>
	public virtual string HeadingTabSecurity => "Security";

	/// <summary>
	/// Key: "Heading.Transactions"
	/// English String: "Transactions"
	/// </summary>
	public virtual string HeadingTransactions => "Transactions";

	/// <summary>
	/// Key: "Heading.TwoStepVerification"
	/// English String: "2 Step Verification"
	/// </summary>
	public virtual string HeadingTwoStepVerification => "2 Step Verification";

	/// <summary>
	/// Key: "Heading.Xbox"
	/// English String: "Xbox"
	/// </summary>
	public virtual string HeadingXbox => "Xbox";

	/// <summary>
	/// Key: "Label.AccountPinDisabled"
	/// English String: "Account PIN is currently disabled"
	/// </summary>
	public virtual string LabelAccountPinDisabled => "Account PIN is currently disabled";

	/// <summary>
	/// Key: "Label.AccountPinEnabled"
	/// English String: "Account PIN is currently enabled"
	/// </summary>
	public virtual string LabelAccountPinEnabled => "Account PIN is currently enabled";

	/// <summary>
	/// Key: "Label.AccountRestrictionDisabled"
	/// English String: "Account Restrictions is currently disabled"
	/// </summary>
	public virtual string LabelAccountRestrictionDisabled => "Account Restrictions is currently disabled";

	/// <summary>
	/// Key: "Label.AccountRestrictionEnabled"
	/// English String: "Account Restrictions is currently enabled"
	/// </summary>
	public virtual string LabelAccountRestrictionEnabled => "Account Restrictions is currently enabled";

	/// <summary>
	/// Key: "Label.AddEmail"
	/// English String: "Add Email"
	/// </summary>
	public virtual string LabelAddEmail => "Add Email";

	/// <summary>
	/// Key: "Label.AddEmailParent"
	/// English String: "Add Parent's Email"
	/// </summary>
	public virtual string LabelAddEmailParent => "Add Parent's Email";

	/// <summary>
	/// Key: "Label.AddPassword"
	/// English String: "Add Password:"
	/// </summary>
	public virtual string LabelAddPassword => "Add Password:";

	/// <summary>
	/// Key: "Label.AddPhone"
	/// English String: "Add Phone"
	/// </summary>
	public virtual string LabelAddPhone => "Add Phone";

	/// <summary>
	/// Key: "Label.AddPhoneLink"
	/// English String: "Add Phone"
	/// </summary>
	public virtual string LabelAddPhoneLink => "Add Phone";

	/// <summary>
	/// Key: "Label.BillingHelp"
	/// English String: "For billing and payment questions:"
	/// </summary>
	public virtual string LabelBillingHelp => "For billing and payment questions:";

	/// <summary>
	/// Key: "Label.BillingHistoryCost"
	/// English String: "Cost"
	/// </summary>
	public virtual string LabelBillingHistoryCost => "Cost";

	/// <summary>
	/// Key: "Label.BillingHistoryDate"
	/// English String: "Date"
	/// </summary>
	public virtual string LabelBillingHistoryDate => "Date";

	/// <summary>
	/// Key: "Label.BillingHistoryDescription"
	/// English String: "Description"
	/// </summary>
	public virtual string LabelBillingHistoryDescription => "Description";

	/// <summary>
	/// Key: "Label.BillingHistoryGeneralErrors"
	/// error message
	/// English String: "Service is currently disabled, please try again later."
	/// </summary>
	public virtual string LabelBillingHistoryGeneralErrors => "Service is currently disabled, please try again later.";

	/// <summary>
	/// Key: "Label.BillingHistoryNoTransactions"
	/// English String: "No Transactions"
	/// </summary>
	public virtual string LabelBillingHistoryNoTransactions => "No Transactions";

	/// <summary>
	/// Key: "Label.BillingHistoryPaymentType"
	/// English String: "Payment Type"
	/// </summary>
	public virtual string LabelBillingHistoryPaymentType => "Payment Type";

	/// <summary>
	/// Key: "Label.Birthday"
	/// English String: "Birthday"
	/// </summary>
	public virtual string LabelBirthday => "Birthday";

	/// <summary>
	/// Key: "Label.BuildersClub"
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.ChangeYourUsername"
	/// English String: "change your username"
	/// </summary>
	public virtual string LabelChangeYourUsername => "change your username";

	/// <summary>
	/// Key: "Label.ChooseLanguage"
	/// English String: "Choose Language"
	/// </summary>
	public virtual string LabelChooseLanguage => "Choose Language";

	/// <summary>
	/// Key: "Label.ClassicTheme"
	/// name of Theme, classic theme
	/// English String: "Off"
	/// </summary>
	public virtual string LabelClassicTheme => "Off";

	/// <summary>
	/// Key: "Label.ConnectAccount"
	/// English String: "Connect account:"
	/// </summary>
	public virtual string LabelConnectAccount => "Connect account:";

	/// <summary>
	/// Key: "Label.Country"
	/// English String: "Choose a Country/Region"
	/// </summary>
	public virtual string LabelCountry => "Choose a Country/Region";

	/// <summary>
	/// Key: "Label.CountryTitle"
	/// label for country on account settings page
	/// English String: "Location"
	/// </summary>
	public virtual string LabelCountryTitle => "Location";

	/// <summary>
	/// Key: "Label.DarkTheme"
	/// Dark Theme
	/// English String: "Dark"
	/// </summary>
	public virtual string LabelDarkTheme => "Dark";

	/// <summary>
	/// Key: "Label.Dialog.AddEmailOver13"
	/// English String: "Add My Email"
	/// </summary>
	public virtual string LabelDialogAddEmailOver13 => "Add My Email";

	/// <summary>
	/// Key: "Label.Dialog.AddEmailUnder13"
	/// English String: "Add Parent's Email"
	/// </summary>
	public virtual string LabelDialogAddEmailUnder13 => "Add Parent's Email";

	/// <summary>
	/// Key: "Label.Dialog.AddPhoneField"
	/// English String: "Phone Number"
	/// </summary>
	public virtual string LabelDialogAddPhoneField => "Phone Number";

	/// <summary>
	/// Key: "Label.Dialog.AddPhonePassword"
	/// English String: "Verify Account Password"
	/// </summary>
	public virtual string LabelDialogAddPhonePassword => "Verify Account Password";

	/// <summary>
	/// Key: "Label.Dialog.ChangeEmailField"
	/// English String: "Change My Email"
	/// </summary>
	public virtual string LabelDialogChangeEmailField => "Change My Email";

	/// <summary>
	/// Key: "Label.Dialog.ChangeEmailOver13"
	/// English String: "Change My Email"
	/// </summary>
	public virtual string LabelDialogChangeEmailOver13 => "Change My Email";

	/// <summary>
	/// Key: "Label.Dialog.ChangeEmailUnder13"
	/// English String: "Change Parent's Email"
	/// </summary>
	public virtual string LabelDialogChangeEmailUnder13 => "Change Parent's Email";

	/// <summary>
	/// Key: "Label.Dialog.ChangePasswordConfirm"
	/// English String: "Confirm Password"
	/// </summary>
	public virtual string LabelDialogChangePasswordConfirm => "Confirm Password";

	/// <summary>
	/// Key: "Label.Dialog.ChangePasswordCurrent"
	/// English String: "Current Password"
	/// </summary>
	public virtual string LabelDialogChangePasswordCurrent => "Current Password";

	/// <summary>
	/// Key: "Label.Dialog.ChangePasswordNew"
	/// English String: "New Password"
	/// </summary>
	public virtual string LabelDialogChangePasswordNew => "New Password";

	/// <summary>
	/// Key: "Label.Dialog.ChangeUsernameAccountPassword"
	/// English String: "Account Password"
	/// </summary>
	public virtual string LabelDialogChangeUsernameAccountPassword => "Account Password";

	/// <summary>
	/// Key: "Label.Dialog.ChangeUsernameField"
	/// English String: "Desired Username (3-20 characters)"
	/// </summary>
	public virtual string LabelDialogChangeUsernameField => "Desired Username (3-20 characters)";

	/// <summary>
	/// Key: "Label.Dialog.ConfirmPin"
	/// English String: "Confirm your PIN"
	/// </summary>
	public virtual string LabelDialogConfirmPin => "Confirm your PIN";

	/// <summary>
	/// Key: "Label.Dialog.EditPhoneCurrentNumber"
	/// English String: "Current Number:"
	/// </summary>
	public virtual string LabelDialogEditPhoneCurrentNumber => "Current Number:";

	/// <summary>
	/// Key: "Label.Dialog.EmailAddressChanged"
	/// English String: "Email Address Changed"
	/// </summary>
	public virtual string LabelDialogEmailAddressChanged => "Email Address Changed";

	/// <summary>
	/// Key: "Label.Dialog.EmailRequired"
	/// English String: "Email Required"
	/// </summary>
	public virtual string LabelDialogEmailRequired => "Email Required";

	/// <summary>
	/// Key: "Label.Dialog.VerifiedEmail"
	/// English String: "Verified email:"
	/// </summary>
	public virtual string LabelDialogVerifiedEmail => "Verified email:";

	/// <summary>
	/// Key: "Label.Dialog.VerifyPassword"
	/// English String: "Verify Account Password"
	/// </summary>
	public virtual string LabelDialogVerifyPassword => "Verify Account Password";

	/// <summary>
	/// Key: "Label.Dialog.VerifyPhoneCodeLabel"
	/// English String: "Enter the code we just sent to your phone"
	/// </summary>
	public virtual string LabelDialogVerifyPhoneCodeLabel => "Enter the code we just sent to your phone";

	/// <summary>
	/// Key: "Label.Dialog.VerifySms"
	/// English String: "Verify SMS"
	/// </summary>
	public virtual string LabelDialogVerifySms => "Verify SMS";

	/// <summary>
	/// Key: "Label.DropDown.Custom"
	/// English String: "Custom"
	/// </summary>
	public virtual string LabelDropDownCustom => "Custom";

	/// <summary>
	/// Key: "Label.DropDown.Default"
	/// English String: "Default"
	/// </summary>
	public virtual string LabelDropDownDefault => "Default";

	/// <summary>
	/// Key: "Label.DropDown.Everyone"
	/// English String: "Everyone"
	/// </summary>
	public virtual string LabelDropDownEveryone => "Everyone";

	/// <summary>
	/// Key: "Label.DropDown.Followers"
	/// English String: "Friends, Users I Follow, and Followers"
	/// </summary>
	public virtual string LabelDropDownFollowers => "Friends, Users I Follow, and Followers";

	/// <summary>
	/// Key: "Label.DropDown.Following"
	/// English String: "Friends and Users I Follow"
	/// </summary>
	public virtual string LabelDropDownFollowing => "Friends and Users I Follow";

	/// <summary>
	/// Key: "Label.DropDown.Friends"
	/// English String: "Friends"
	/// </summary>
	public virtual string LabelDropDownFriends => "Friends";

	/// <summary>
	/// Key: "Label.DropDown.High"
	/// English String: "High"
	/// </summary>
	public virtual string LabelDropDownHigh => "High";

	/// <summary>
	/// Key: "Label.DropDown.Low"
	/// English String: "Low"
	/// </summary>
	public virtual string LabelDropDownLow => "Low";

	/// <summary>
	/// Key: "Label.DropDown.Medium"
	/// English String: "Medium"
	/// </summary>
	public virtual string LabelDropDownMedium => "Medium";

	/// <summary>
	/// Key: "Label.DropDown.None"
	/// English String: "None"
	/// </summary>
	public virtual string LabelDropDownNone => "None";

	/// <summary>
	/// Key: "Label.DropDown.NoOne"
	/// English String: "No one"
	/// </summary>
	public virtual string LabelDropDownNoOne => "No one";

	/// <summary>
	/// Key: "Label.DropDown.Off"
	/// English String: "Off"
	/// </summary>
	public virtual string LabelDropDownOff => "Off";

	/// <summary>
	/// Key: "Label.Email"
	/// English String: "Email address:"
	/// </summary>
	public virtual string LabelEmail => "Email address:";

	/// <summary>
	/// Key: "Label.EmailParent"
	/// English String: "Parent's Email address:"
	/// </summary>
	public virtual string LabelEmailParent => "Parent's Email address:";

	/// <summary>
	/// Key: "Label.EmailVerificationPending"
	/// English String: "Pending verification"
	/// </summary>
	public virtual string LabelEmailVerificationPending => "Pending verification";

	/// <summary>
	/// Key: "Label.ExpirationDate"
	/// English String: "Expiration date"
	/// </summary>
	public virtual string LabelExpirationDate => "Expiration date";

	/// <summary>
	/// Key: "Label.Facebook"
	/// English String: "Facebook:"
	/// </summary>
	public virtual string LabelFacebook => "Facebook:";

	/// <summary>
	/// Key: "Label.FastTrack.Accuracy"
	/// A label above a report of the Fast Track member's reporting accuracy compared to other Fast Track members.
	/// English String: "Accuracy"
	/// </summary>
	public virtual string LabelFastTrackAccuracy => "Accuracy";

	/// <summary>
	/// Key: "Label.FastTrack.AllFastTrackMembers"
	/// The group of Roblox community members who are part of the Fast Track Member Role. These users, together, represent some of our most useful community reporters and their reports are given special attention.
	/// English String: "Everyone"
	/// </summary>
	public virtual string LabelFastTrackAllFastTrackMembers => "Everyone";

	/// <summary>
	/// Key: "Label.FastTrack.ReportMonth"
	/// A label for a column in a report that indicates that the column will contain months. For example "January" or "March".
	/// English String: "Month"
	/// </summary>
	public virtual string LabelFastTrackReportMonth => "Month";

	/// <summary>
	/// Key: "Label.FastTrack.ReportYear"
	/// A label used as a column header in a report table. This column contains "years". These will be localized. Examples for en-us "2015" and "2020"
	/// English String: "Year"
	/// </summary>
	public virtual string LabelFastTrackReportYear => "Year";

	/// <summary>
	/// Key: "Label.FastTrack.Statistics"
	/// Title of a section of the Fast Track member page that includes reporting and statistical data.
	/// English String: "Statistics"
	/// </summary>
	public virtual string LabelFastTrackStatistics => "Statistics";

	/// <summary>
	/// Key: "Label.FastTrack.You"
	/// Pronoun for the current user, who in this context is a Fast Track member. The usage here is intended to be as a heading for a column in a table.
	/// English String: "You"
	/// </summary>
	public virtual string LabelFastTrackYou => "You";

	/// <summary>
	/// Key: "Label.Gender"
	/// English String: "Gender"
	/// </summary>
	public virtual string LabelGender => "Gender";

	/// <summary>
	/// Key: "Label.GooglePlus"
	/// English String: "Google+:"
	/// </summary>
	public virtual string LabelGooglePlus => "Google+:";

	/// <summary>
	/// Key: "Label.LightTheme"
	/// Light Theme
	/// English String: "Light"
	/// </summary>
	public virtual string LabelLightTheme => "Light";

	/// <summary>
	/// Key: "Label.LocaleTitle"
	/// text label for locale select on account setting's page
	/// English String: "Language"
	/// </summary>
	public virtual string LabelLocaleTitle => "Language";

	/// <summary>
	/// Key: "Label.MembershipStatusRobloxPremium"
	/// English String: "You're not a member yet. Join Roblox Premium today!"
	/// </summary>
	public virtual string LabelMembershipStatusRobloxPremium => "You're not a member yet. Join Roblox Premium today!";

	/// <summary>
	/// Key: "Label.Notifications.AddedToPrivateServer"
	/// English String: "I am invited to a VIP server"
	/// </summary>
	public virtual string LabelNotificationsAddedToPrivateServer => "I am invited to a VIP server";

	/// <summary>
	/// Key: "Label.Notifications.Chat"
	/// English String: "Someone chats with me"
	/// </summary>
	public virtual string LabelNotificationsChat => "Someone chats with me";

	/// <summary>
	/// Key: "Label.Notifications.ConversationUniverseChanged"
	/// label for notification settings
	/// English String: "Someone pins a new game to play together"
	/// </summary>
	public virtual string LabelNotificationsConversationUniverseChanged => "Someone pins a new game to play together";

	/// <summary>
	/// Key: "Label.Notifications.DeveloperMetricsAvailable"
	/// English String: "Analytics report becomes available"
	/// </summary>
	public virtual string LabelNotificationsDeveloperMetricsAvailable => "Analytics report becomes available";

	/// <summary>
	/// Key: "Label.Notifications.FriendRequestAccepted"
	/// English String: "Someone accepts my friend request"
	/// </summary>
	public virtual string LabelNotificationsFriendRequestAccepted => "Someone accepts my friend request";

	/// <summary>
	/// Key: "Label.Notifications.FriendRequestReceived"
	/// English String: "I receive a friend request"
	/// </summary>
	public virtual string LabelNotificationsFriendRequestReceived => "I receive a friend request";

	/// <summary>
	/// Key: "Label.Notifications.GameUpdate"
	/// Checkbox label for enabling game update notifications in the notification stream
	/// English String: "I receive update notifications"
	/// </summary>
	public virtual string LabelNotificationsGameUpdate => "I receive update notifications";

	/// <summary>
	/// Key: "Label.Notifications.PartyInvited"
	/// English String: "Someone invites me to a party"
	/// </summary>
	public virtual string LabelNotificationsPartyInvited => "Someone invites me to a party";

	/// <summary>
	/// Key: "Label.Notifications.PartyJoined"
	/// English String: "Someone joins a party I'm in"
	/// </summary>
	public virtual string LabelNotificationsPartyJoined => "Someone joins a party I'm in";

	/// <summary>
	/// Key: "Label.Notifications.PrivateMessage"
	/// English String: "I receive a private message"
	/// </summary>
	public virtual string LabelNotificationsPrivateMessage => "I receive a private message";

	/// <summary>
	/// Key: "Label.Notifications.TeamCreateInvite"
	/// English String: "Someone invites me to edit a game"
	/// </summary>
	public virtual string LabelNotificationsTeamCreateInvite => "Someone invites me to edit a game";

	/// <summary>
	/// Key: "Label.Password"
	/// English String: "Password:"
	/// </summary>
	public virtual string LabelPassword => "Password:";

	/// <summary>
	/// Key: "Label.Phone"
	/// English String: "Phone Number:"
	/// </summary>
	public virtual string LabelPhone => "Phone Number:";

	/// <summary>
	/// Key: "Label.PinTimeMins"
	/// English String: "min"
	/// </summary>
	public virtual string LabelPinTimeMins => "min";

	/// <summary>
	/// Key: "Label.PinTimeRemaining"
	/// English String: "Time Remaining"
	/// </summary>
	public virtual string LabelPinTimeRemaining => "Time Remaining";

	/// <summary>
	/// Key: "Label.PinTimeSecs"
	/// English String: "sec"
	/// </summary>
	public virtual string LabelPinTimeSecs => "sec";

	/// <summary>
	/// Key: "Label.PreviousUsernames"
	/// English String: "Previous usernames:"
	/// </summary>
	public virtual string LabelPreviousUsernames => "Previous usernames:";

	/// <summary>
	/// Key: "Label.PrivacyMode"
	/// English String: "Privacy Mode"
	/// </summary>
	public virtual string LabelPrivacyMode => "Privacy Mode";

	/// <summary>
	/// Key: "Label.RenevalDate"
	/// English String: "Renewal date"
	/// </summary>
	public virtual string LabelRenevalDate => "Renewal date";

	/// <summary>
	/// Key: "Label.SignOutAllSessions"
	/// English String: "Sign out of all other sessions"
	/// </summary>
	public virtual string LabelSignOutAllSessions => "Sign out of all other sessions";

	/// <summary>
	/// Key: "Label.SocialLinksVisibility"
	/// English String: "Visible to:"
	/// </summary>
	public virtual string LabelSocialLinksVisibility => "Visible to:";

	/// <summary>
	/// Key: "Label.ThemeTitle"
	/// English String: "Theme"
	/// </summary>
	public virtual string LabelThemeTitle => "Theme";

	/// <summary>
	/// Key: "Label.ToolTip.ContactSettings"
	/// English String: "Custom - Control your own settings. Default - Enable chat and messages with Friends. Off - Disables chat and messages."
	/// </summary>
	public virtual string LabelToolTipContactSettings => "Custom - Control your own settings. Default - Enable chat and messages with Friends. Off - Disables chat and messages.";

	/// <summary>
	/// Key: "Label.ToolTip.PinLocked"
	/// English String: "All settings are locked. To edit, please unlock with your PIN"
	/// </summary>
	public virtual string LabelToolTipPinLocked => "All settings are locked. To edit, please unlock with your PIN";

	/// <summary>
	/// Key: "Label.ToolTip.PinUnlocked"
	/// English String: "Click to lock your Settings page"
	/// </summary>
	public virtual string LabelToolTipPinUnlocked => "Click to lock your Settings page";

	/// <summary>
	/// Key: "Label.ToolTip.PrivacyMode"
	/// English String: "Click here for more information"
	/// </summary>
	public virtual string LabelToolTipPrivacyMode => "Click here for more information";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanChatInApp"
	/// English String: "This setting controls who this user will be allowed to chat with in the app and on the web (separate from in game). The setting also prevents this user from posting on Forums and group walls."
	/// </summary>
	public virtual string LabelToolTipWhoCanChatInApp => "This setting controls who this user will be allowed to chat with in the app and on the web (separate from in game). The setting also prevents this user from posting on Forums and group walls.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanChatInGame"
	/// English String: "This setting controls who this user will be allowed to chat with in game."
	/// </summary>
	public virtual string LabelToolTipWhoCanChatInGame => "This setting controls who this user will be allowed to chat with in game.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanFindMeByPhone"
	/// This setting controls who can find you using the phone number you provided.
	/// English String: "This setting controls who can find you using the phone number you provided."
	/// </summary>
	public virtual string LabelToolTipWhoCanFindMeByPhone => "This setting controls who can find you using the phone number you provided.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanInviteVIP"
	/// English String: "This setting controls who can join this user in VIP servers - servers that can only be joined by invitation of the server owner."
	/// </summary>
	public virtual string LabelToolTipWhoCanInviteVIP => "This setting controls who can join this user in VIP servers - servers that can only be joined by invitation of the server owner.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanJoinGame"
	/// English String: "This setting controls who can see which game I'm in and join me in my server. Selecting no one means no one can follow me into my specific server, but I will be playing with other users."
	/// </summary>
	public virtual string LabelToolTipWhoCanJoinGame => "This setting controls who can see which game I'm in and join me in my server. Selecting no one means no one can follow me into my specific server, but I will be playing with other users.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanMessageMe"
	/// English String: "This setting controls who this user can receive messages from in their messages inbox."
	/// </summary>
	public virtual string LabelToolTipWhoCanMessageMe => "This setting controls who this user can receive messages from in their messages inbox.";

	/// <summary>
	/// Key: "Label.ToolTip.WhoCanSeeInventory"
	/// English String: "This setting controls who can see your inventory."
	/// </summary>
	public virtual string LabelToolTipWhoCanSeeInventory => "This setting controls who can see your inventory.";

	/// <summary>
	/// Key: "Label.TradeFilter"
	/// English String: "Trade quality filter"
	/// </summary>
	public virtual string LabelTradeFilter => "Trade quality filter";

	/// <summary>
	/// Key: "Label.Twitch"
	/// English String: "Twitch"
	/// </summary>
	public virtual string LabelTwitch => "Twitch";

	/// <summary>
	/// Key: "Label.Twitter"
	/// English String: "Twitter:"
	/// </summary>
	public virtual string LabelTwitter => "Twitter:";

	/// <summary>
	/// Key: "Label.TwoStepEmail"
	/// English String: "enable 2 Step Verification"
	/// </summary>
	public virtual string LabelTwoStepEmail => "enable 2 Step Verification";

	/// <summary>
	/// Key: "Label.TwoStepPrerequisite"
	/// English String: "A verified email is required."
	/// </summary>
	public virtual string LabelTwoStepPrerequisite => "A verified email is required.";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "Improve your account security. A code will be required when you login from a new device."
	/// </summary>
	public virtual string LabelTwoStepVerification => "Improve your account security. A code will be required when you login from a new device.";

	/// <summary>
	/// Key: "Label.TwoStepVerificationEnabled"
	/// English String: "Your account is protected!"
	/// </summary>
	public virtual string LabelTwoStepVerificationEnabled => "Your account is protected!";

	/// <summary>
	/// Key: "Label.UpdateEmail"
	/// English String: "Update Email"
	/// </summary>
	public virtual string LabelUpdateEmail => "Update Email";

	/// <summary>
	/// Key: "Label.UpdatePhone"
	/// English String: "Update Phone"
	/// </summary>
	public virtual string LabelUpdatePhone => "Update Phone";

	/// <summary>
	/// Key: "Label.UseDeviceLanguage"
	/// Allow user to use device language
	/// English String: "Use Device Language"
	/// </summary>
	public virtual string LabelUseDeviceLanguage => "Use Device Language";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username:"
	/// </summary>
	public virtual string LabelUsername => "Username:";

	/// <summary>
	/// Key: "Label.Verified"
	/// English String: "Verified"
	/// </summary>
	public virtual string LabelVerified => "Verified";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public virtual string LabelVerify => "Verify";

	/// <summary>
	/// Key: "Label.WhoCanChatInApp"
	/// English String: "Who can chat with me in app?"
	/// </summary>
	public virtual string LabelWhoCanChatInApp => "Who can chat with me in app?";

	/// <summary>
	/// Key: "Label.WhoCanChatInGame"
	/// English String: "Who can chat with me?"
	/// </summary>
	public virtual string LabelWhoCanChatInGame => "Who can chat with me?";

	/// <summary>
	/// Key: "Label.WhoCanFindMeByPhone"
	/// Who can find me by my phone number?
	/// English String: "Who can find me by my phone number?"
	/// </summary>
	public virtual string LabelWhoCanFindMeByPhone => "Who can find me by my phone number?";

	/// <summary>
	/// Key: "Label.WhoCanInviteVIP"
	/// English String: "Who can invite me to VIP Servers?"
	/// </summary>
	public virtual string LabelWhoCanInviteVIP => "Who can invite me to VIP Servers?";

	/// <summary>
	/// Key: "Label.WhoCanJoinGame"
	/// English String: "Who can join me?"
	/// </summary>
	public virtual string LabelWhoCanJoinGame => "Who can join me?";

	/// <summary>
	/// Key: "Label.WhoCanMessageMe"
	/// English String: "Who can message me?"
	/// </summary>
	public virtual string LabelWhoCanMessageMe => "Who can message me?";

	/// <summary>
	/// Key: "Label.WhoCanSeeInventory"
	/// This setting controls who can see the user's inventory.
	/// English String: "Who can see my inventory?"
	/// </summary>
	public virtual string LabelWhoCanSeeInventory => "Who can see my inventory?";

	/// <summary>
	/// Key: "Label.WhoCanTradeWithMe"
	/// English String: "Who can trade with me?"
	/// </summary>
	public virtual string LabelWhoCanTradeWithMe => "Who can trade with me?";

	/// <summary>
	/// Key: "Label.XboxConnected"
	/// English String: "Connected with an Xbox account"
	/// </summary>
	public virtual string LabelXboxConnected => "Connected with an Xbox account";

	/// <summary>
	/// Key: "Label.YouTube"
	/// English String: "YouTube:"
	/// </summary>
	public virtual string LabelYouTube => "YouTube:";

	/// <summary>
	/// Key: "LabelInsufficientRobux"
	/// English String: "Insufficient Robux"
	/// </summary>
	public virtual string LabelInsufficientRobux => "Insufficient Robux";

	/// <summary>
	/// Key: "Message.Error.AccountHasPin"
	/// English String: "The account already has a PIN. Try making a different request."
	/// </summary>
	public virtual string MessageErrorAccountHasPin => "The account already has a PIN. Try making a different request.";

	/// <summary>
	/// Key: "Message.Error.AccountLocked"
	/// English String: "The account is locked. Unlock the acount before performing the action."
	/// </summary>
	public virtual string MessageErrorAccountLocked => "The account is locked. Unlock the acount before performing the action.";

	/// <summary>
	/// Key: "Message.Error.Default"
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public virtual string MessageErrorDefault => "Something went wrong, please try again later.";

	/// <summary>
	/// Key: "Message.Error.Email.AlreadyVerified"
	/// English String: "The email is already verified."
	/// </summary>
	public virtual string MessageErrorEmailAlreadyVerified => "The email is already verified.";

	/// <summary>
	/// Key: "Message.Error.Email.FeatureDisabled"
	/// English String: "This feature is currently disabled. Please try again later."
	/// </summary>
	public virtual string MessageErrorEmailFeatureDisabled => "This feature is currently disabled. Please try again later.";

	/// <summary>
	/// Key: "Message.Error.Email.IncorrectPassword"
	/// English String: "Password is incorrect."
	/// </summary>
	public virtual string MessageErrorEmailIncorrectPassword => "Password is incorrect.";

	/// <summary>
	/// Key: "Message.Error.Email.InvalidEmail"
	/// English String: "Invalid email address."
	/// </summary>
	public virtual string MessageErrorEmailInvalidEmail => "Invalid email address.";

	/// <summary>
	/// Key: "Message.Error.Email.NoEmailAssociated"
	/// English String: "No email address is associated with the account."
	/// </summary>
	public virtual string MessageErrorEmailNoEmailAssociated => "No email address is associated with the account.";

	/// <summary>
	/// Key: "Message.Error.Email.PinLocked"
	/// English String: "PIN is locked."
	/// </summary>
	public virtual string MessageErrorEmailPinLocked => "PIN is locked.";

	/// <summary>
	/// Key: "Message.Error.Email.SameEmail"
	/// English String: "This is already the current email."
	/// </summary>
	public virtual string MessageErrorEmailSameEmail => "This is already the current email.";

	/// <summary>
	/// Key: "Message.Error.Email.TooManyAccounts"
	/// English String: "There are too many accounts associated with this email address."
	/// </summary>
	public virtual string MessageErrorEmailTooManyAccounts => "There are too many accounts associated with this email address.";

	/// <summary>
	/// Key: "Message.Error.Email.TooManyUpdates"
	/// English String: "Too many attempts to update email. Please try again later."
	/// </summary>
	public virtual string MessageErrorEmailTooManyUpdates => "Too many attempts to update email. Please try again later.";

	/// <summary>
	/// Key: "Message.Error.Email.TooManyVerify"
	/// English String: "Too many attempts to send verification email. Please try again later."
	/// </summary>
	public virtual string MessageErrorEmailTooManyVerify => "Too many attempts to send verification email. Please try again later.";

	/// <summary>
	/// Key: "Message.Error.Email.Unknown"
	/// English String: "An unknown error occured."
	/// </summary>
	public virtual string MessageErrorEmailUnknown => "An unknown error occured.";

	/// <summary>
	/// Key: "Message.Error.IncorrectPin"
	/// English String: "Incorrect PIN."
	/// </summary>
	public virtual string MessageErrorIncorrectPin => "Incorrect PIN.";

	/// <summary>
	/// Key: "Message.Error.InvalidPinFormat"
	/// English String: "Invalid PIN format."
	/// </summary>
	public virtual string MessageErrorInvalidPinFormat => "Invalid PIN format.";

	/// <summary>
	/// Key: "Message.Error.NoPin"
	/// English String: "No PIN exists on the account."
	/// </summary>
	public virtual string MessageErrorNoPin => "No PIN exists on the account.";

	/// <summary>
	/// Key: "Message.Error.NoVerifiedEmail"
	/// English String: "The account does not have a verified email."
	/// </summary>
	public virtual string MessageErrorNoVerifiedEmail => "The account does not have a verified email.";

	/// <summary>
	/// Key: "Message.Error.System"
	/// English String: "System error."
	/// </summary>
	public virtual string MessageErrorSystem => "System error.";

	/// <summary>
	/// Key: "Message.Error.TooManyRequests"
	/// English String: "Too many requests made. Try again later."
	/// </summary>
	public virtual string MessageErrorTooManyRequests => "Too many requests made. Try again later.";

	/// <summary>
	/// Key: "MessageEmailAddSuccess"
	/// English String: "Email Added"
	/// </summary>
	public virtual string MessageEmailAddSuccess => "Email Added";

	/// <summary>
	/// Key: "MessageEmailAlreadyVerifiedError"
	/// English String: "Your email is already verified!"
	/// </summary>
	public virtual string MessageEmailAlreadyVerifiedError => "Your email is already verified!";

	/// <summary>
	/// Key: "MessageFeatureDisabledError"
	/// English String: "This feature is currently disabled. Please try again later."
	/// </summary>
	public virtual string MessageFeatureDisabledError => "This feature is currently disabled. Please try again later.";

	/// <summary>
	/// Key: "MessageInsufficientRobuxErrorForUserName"
	/// You don't have enough Robux to change your username.
	/// English String: "You don't have enough Robux to change your username."
	/// </summary>
	public virtual string MessageInsufficientRobuxErrorForUserName => "You don't have enough Robux to change your username.";

	/// <summary>
	/// Key: "MessageInvalidEmail"
	/// English String: "Invalid Email"
	/// </summary>
	public virtual string MessageInvalidEmail => "Invalid Email";

	/// <summary>
	/// Key: "MessageNoEmailAssociatedError"
	/// English String: "You must associate an email address with your account"
	/// </summary>
	public virtual string MessageNoEmailAssociatedError => "You must associate an email address with your account";

	/// <summary>
	/// Key: "MessagePermissionError"
	/// English String: "You don't have enough Robux to change your username."
	/// </summary>
	public virtual string MessagePermissionError => "You don't have enough Robux to change your username.";

	/// <summary>
	/// Key: "MessagePinLockedError"
	/// English String: "PIN is locked."
	/// </summary>
	public virtual string MessagePinLockedError => "PIN is locked.";

	/// <summary>
	/// Key: "MessageSameEmailError"
	/// English String: "This is already the current verified email."
	/// </summary>
	public virtual string MessageSameEmailError => "This is already the current verified email.";

	/// <summary>
	/// Key: "MessageSettingsUpdateSuccess"
	/// English String: "Your settings have been updated."
	/// </summary>
	public virtual string MessageSettingsUpdateSuccess => "Your settings have been updated.";

	/// <summary>
	/// Key: "MessageTooManyAccountsOnEmailError"
	/// English String: "There are too many accounts associated with this email address."
	/// </summary>
	public virtual string MessageTooManyAccountsOnEmailError => "There are too many accounts associated with this email address.";

	/// <summary>
	/// Key: "MessageTooManyAttemptsError"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public virtual string MessageTooManyAttemptsError => "Too many attempts. Please try again later.";

	/// <summary>
	/// Key: "MessageUnknownError"
	/// English String: "An unknown error occurred."
	/// </summary>
	public virtual string MessageUnknownError => "An unknown error occurred.";

	/// <summary>
	/// Key: "MessageWrongPassword"
	/// English String: "Your password is incorrect."
	/// </summary>
	public virtual string MessageWrongPassword => "Your password is incorrect.";

	/// <summary>
	/// Key: "Respones.InvalidCodePhone"
	/// error message
	/// English String: "Code is invalid. Please check your phone and try again."
	/// </summary>
	public virtual string ResponesInvalidCodePhone => "Code is invalid. Please check your phone and try again.";

	/// <summary>
	/// Key: "Respones.InventoryAndTradePrivacyConflictError"
	/// English String: "The value for \"Who can trade with me\" should be the same or more restrictive than the value for \"Who can see my inventory\"."
	/// </summary>
	public virtual string ResponesInventoryAndTradePrivacyConflictError => "The value for \"Who can trade with me\" should be the same or more restrictive than the value for \"Who can see my inventory\".";

	/// <summary>
	/// Key: "Response.CodeRequired"
	/// error message
	/// English String: "A code is required. Please enter your code."
	/// </summary>
	public virtual string ResponseCodeRequired => "A code is required. Please enter your code.";

	/// <summary>
	/// Key: "Response.Dialog.BirthdayChangeDefaultWarning"
	/// English String: "Changing your birthday to under age 13 cannot be un-done. Are you sure you want to continue?"
	/// </summary>
	public virtual string ResponseDialogBirthdayChangeDefaultWarning => "Changing your birthday to under age 13 cannot be un-done. Are you sure you want to continue?";

	/// <summary>
	/// Key: "Response.Dialog.BirthdayChangePasswordBody"
	/// English String: "You must add a password to your Roblox account to change your birthday."
	/// </summary>
	public virtual string ResponseDialogBirthdayChangePasswordBody => "You must add a password to your Roblox account to change your birthday.";

	/// <summary>
	/// Key: "Response.Dialog.BirthdayChangePasswordTitle"
	/// English String: "Must Add Password"
	/// </summary>
	public virtual string ResponseDialogBirthdayChangePasswordTitle => "Must Add Password";

	/// <summary>
	/// Key: "Response.Dialog.BirthdayChangeSocialWarning"
	/// English String: "Changing your birthday to under age 13 cannot be un-done. Your Social Sign On from Facebook will be disabled and you will need to sign on using your Roblox password."
	/// </summary>
	public virtual string ResponseDialogBirthdayChangeSocialWarning => "Changing your birthday to under age 13 cannot be un-done. Your Social Sign On from Facebook will be disabled and you will need to sign on using your Roblox password.";

	/// <summary>
	/// Key: "Response.Dialog.ChangePasswordIncorrectPassword"
	/// Your current password is incorrect, the password was not changed.
	/// English String: "Your current password is incorrect, the password was not changed."
	/// </summary>
	public virtual string ResponseDialogChangePasswordIncorrectPassword => "Your current password is incorrect, the password was not changed.";

	/// <summary>
	/// Key: "Response.Dialog.ChangePasswordNoMatch"
	/// English String: "Passwords do not match"
	/// </summary>
	public virtual string ResponseDialogChangePasswordNoMatch => "Passwords do not match";

	/// <summary>
	/// Key: "Response.Dialog.ChangePasswordTooShortError"
	/// English String: "Must be at least 8 characters long"
	/// </summary>
	public virtual string ResponseDialogChangePasswordTooShortError => "Must be at least 8 characters long";

	/// <summary>
	/// Key: "Response.Dialog.ChangeUsernameNoInput"
	/// English String: "Please enter a username."
	/// </summary>
	public virtual string ResponseDialogChangeUsernameNoInput => "Please enter a username.";

	/// <summary>
	/// Key: "Response.Dialog.ChangeUsernameNotAllowed"
	/// error message
	/// English String: "Username not appropriate for Roblox."
	/// </summary>
	public virtual string ResponseDialogChangeUsernameNotAllowed => "Username not appropriate for Roblox.";

	/// <summary>
	/// Key: "Response.Dialog.ChangeUsernameNotAvailable"
	/// English String: "This username is already in use."
	/// </summary>
	public virtual string ResponseDialogChangeUsernameNotAvailable => "This username is already in use.";

	/// <summary>
	/// Key: "Response.Dialog.ChangeUsernameSuccess"
	/// success message
	/// English String: "Successfully changed username."
	/// </summary>
	public virtual string ResponseDialogChangeUsernameSuccess => "Successfully changed username.";

	/// <summary>
	/// Key: "Response.Dialog.CountryListError"
	/// English String: "Error loading country list"
	/// </summary>
	public virtual string ResponseDialogCountryListError => "Error loading country list";

	/// <summary>
	/// Key: "Response.Dialog.CurrencyServiceError"
	/// English String: "There was an error with the currency service. Try again later."
	/// </summary>
	public virtual string ResponseDialogCurrencyServiceError => "There was an error with the currency service. Try again later.";

	/// <summary>
	/// Key: "Response.Dialog.DefaultErrorMessage"
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public virtual string ResponseDialogDefaultErrorMessage => "Something went wrong, please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.DefaultErrorTitle"
	/// English String: "Error occured"
	/// </summary>
	public virtual string ResponseDialogDefaultErrorTitle => "Error occured";

	/// <summary>
	/// Key: "Response.Dialog.DefaultSuccessMessage"
	/// English String: "Saved Successfully!"
	/// </summary>
	public virtual string ResponseDialogDefaultSuccessMessage => "Saved Successfully!";

	/// <summary>
	/// Key: "Response.Dialog.DisconnectXBoxError"
	/// English String: "There was an error disconnecting your Xbox account, please try again later."
	/// </summary>
	public virtual string ResponseDialogDisconnectXBoxError => "There was an error disconnecting your Xbox account, please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.EmailSentForVerification"
	/// English String: "An email has been sent for verification."
	/// </summary>
	public virtual string ResponseDialogEmailSentForVerification => "An email has been sent for verification.";

	/// <summary>
	/// Key: "Response.Dialog.InvalidEmailAddress"
	/// English String: "Invalid Email Address"
	/// </summary>
	public virtual string ResponseDialogInvalidEmailAddress => "Invalid Email Address";

	/// <summary>
	/// Key: "Response.Dialog.InvalidPhoneNumber"
	/// English String: "Invalid phone number"
	/// </summary>
	public virtual string ResponseDialogInvalidPhoneNumber => "Invalid phone number";

	/// <summary>
	/// Key: "Response.Dialog.InvalidUsername"
	/// Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.
	/// English String: "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker."
	/// </summary>
	public virtual string ResponseDialogInvalidUsername => "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.";

	/// <summary>
	/// Key: "Response.Dialog.PasswordRulesError"
	/// English String: "Password must contain at least 2 digits, 4 letters, 1 symbol, and be at least 8 characters."
	/// </summary>
	public virtual string ResponseDialogPasswordRulesError => "Password must contain at least 2 digits, 4 letters, 1 symbol, and be at least 8 characters.";

	/// <summary>
	/// Key: "Response.Dialog.PinCreateConfirmation"
	/// English String: "Your PIN is now set. You will need to enter this PIN before accessing the Settings page in the future."
	/// </summary>
	public virtual string ResponseDialogPinCreateConfirmation => "Your PIN is now set. You will need to enter this PIN before accessing the Settings page in the future.";

	/// <summary>
	/// Key: "Response.Dialog.PinCreateMismatch"
	/// English String: "PINs do not match"
	/// </summary>
	public virtual string ResponseDialogPinCreateMismatch => "PINs do not match";

	/// <summary>
	/// Key: "Response.Dialog.SignoutSessionFailed"
	/// English String: "There was an error signing you out of all other sessions, please try again later."
	/// </summary>
	public virtual string ResponseDialogSignoutSessionFailed => "There was an error signing you out of all other sessions, please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.SignoutSessionsConfirmation"
	/// English String: "You have been signed out of all other sessions."
	/// </summary>
	public virtual string ResponseDialogSignoutSessionsConfirmation => "You have been signed out of all other sessions.";

	/// <summary>
	/// Key: "Response.Dialog.TwoStepDisableWarning"
	/// English String: "If you turn off 2-Step Verification, only your password will be needed when you login from a new device. Are you sure?"
	/// </summary>
	public virtual string ResponseDialogTwoStepDisableWarning => "If you turn off 2-Step Verification, only your password will be needed when you login from a new device. Are you sure?";

	/// <summary>
	/// Key: "Response.Dialog.TwoStepSuccessTitle"
	/// English String: "2 Step Verification Enabled"
	/// </summary>
	public virtual string ResponseDialogTwoStepSuccessTitle => "2 Step Verification Enabled";

	/// <summary>
	/// Key: "Response.Dialog.TwoStepSucessBody"
	/// English String: "Your account is now protected! No further action is required at this time. A security code will be sent next time you login from a new device."
	/// </summary>
	public virtual string ResponseDialogTwoStepSucessBody => "Your account is now protected! No further action is required at this time. A security code will be sent next time you login from a new device.";

	/// <summary>
	/// Key: "Response.Dialog.UpdateInventorySetting"
	/// English String: "We have updated your inventory privacy setting. The inventory and trade settings must be consistent."
	/// </summary>
	public virtual string ResponseDialogUpdateInventorySetting => "We have updated your inventory privacy setting. The inventory and trade settings must be consistent.";

	/// <summary>
	/// Key: "Response.Dialog.UpdateNotificationSettingsError"
	/// English String: "There was an error updating your notification settings, please try again later."
	/// </summary>
	public virtual string ResponseDialogUpdateNotificationSettingsError => "There was an error updating your notification settings, please try again later.";

	/// <summary>
	/// Key: "Response.Dialog.UpdateTradeSetting"
	/// English String: "We have updated your trade privacy setting. The inventory and trade settings must be consistent."
	/// </summary>
	public virtual string ResponseDialogUpdateTradeSetting => "We have updated your trade privacy setting. The inventory and trade settings must be consistent.";

	/// <summary>
	/// Key: "Response.Dialog.VerifyPhoneInvalidCode"
	/// English String: "Code is invalid. Please check your phone and try again."
	/// </summary>
	public virtual string ResponseDialogVerifyPhoneInvalidCode => "Code is invalid. Please check your phone and try again.";

	/// <summary>
	/// Key: "Response.Dialog.Warning"
	/// English String: "Warning"
	/// </summary>
	public virtual string ResponseDialogWarning => "Warning";

	/// <summary>
	/// Key: "Response.FeatureDisabled"
	/// error message
	/// English String: "This feature is currently disabled. Please try again later."
	/// </summary>
	public virtual string ResponseFeatureDisabled => "This feature is currently disabled. Please try again later.";

	/// <summary>
	/// Key: "Response.GeneralError"
	/// error
	/// English String: "An error occurred. Please try again."
	/// </summary>
	public virtual string ResponseGeneralError => "An error occurred. Please try again.";

	/// <summary>
	/// Key: "Response.IncorrectCodeTooManyTimes"
	/// error message
	/// English String: "You have entered the incorrect code too many times."
	/// </summary>
	public virtual string ResponseIncorrectCodeTooManyTimes => "You have entered the incorrect code too many times.";

	/// <summary>
	/// Key: "Response.IncorrectPasswordTryAgain"
	/// error message
	/// English String: "Incorrect password. Please check your password and try again."
	/// </summary>
	public virtual string ResponseIncorrectPasswordTryAgain => "Incorrect password. Please check your password and try again.";

	/// <summary>
	/// Key: "Response.InvalidPhoneTryAgain"
	/// error message
	/// English String: "Phone number format is invalid. Please check and try again."
	/// </summary>
	public virtual string ResponseInvalidPhoneTryAgain => "Phone number format is invalid. Please check and try again.";

	/// <summary>
	/// Key: "Response.NotificationBar.PhoneRemovedConfirmation"
	/// English String: "Phone has been removed"
	/// </summary>
	public virtual string ResponseNotificationBarPhoneRemovedConfirmation => "Phone has been removed";

	/// <summary>
	/// Key: "Response.NotificationBar.PhoneVerifyConfirmation"
	/// English String: "Phone has been successfully updated!"
	/// </summary>
	public virtual string ResponseNotificationBarPhoneVerifyConfirmation => "Phone has been successfully updated!";

	/// <summary>
	/// Key: "Response.NumberAlreadyAssociated"
	/// error message
	/// English String: "Number is already associated with another account."
	/// </summary>
	public virtual string ResponseNumberAlreadyAssociated => "Number is already associated with another account.";

	/// <summary>
	/// Key: "Response.PinRequired"
	/// error
	/// English String: "Please enter your PIN to change your settings."
	/// </summary>
	public virtual string ResponsePinRequired => "Please enter your PIN to change your settings.";

	/// <summary>
	/// Key: "Response.SocialMedia.ValidationError"
	/// English String: "The social network link is not valid."
	/// </summary>
	public virtual string ResponseSocialMediaValidationError => "The social network link is not valid.";

	/// <summary>
	/// Key: "ResponseAgeDownError"
	/// English String: "Sorry but you cannot change your age to under 13.  If you are under 13, please create a new account and contact support to delete your old account."
	/// </summary>
	public virtual string ResponseAgeDownError => "Sorry but you cannot change your age to under 13.  If you are under 13, please create a new account and contact support to delete your old account.";

	public AccountSettingsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BillingHistoryLoadMore",
				_GetTemplateForActionBillingHistoryLoadMore()
			},
			{
				"Action.CancelRenewal",
				_GetTemplateForActionCancelRenewal()
			},
			{
				"Action.Dialog.AddEmail",
				_GetTemplateForActionDialogAddEmail()
			},
			{
				"Action.Dialog.AddPhone",
				_GetTemplateForActionDialogAddPhone()
			},
			{
				"Action.Dialog.Cancel",
				_GetTemplateForActionDialogCancel()
			},
			{
				"Action.Dialog.ChangeEmail",
				_GetTemplateForActionDialogChangeEmail()
			},
			{
				"Action.Dialog.ChangeEmailConfirmation",
				_GetTemplateForActionDialogChangeEmailConfirmation()
			},
			{
				"Action.Dialog.ChangePassword",
				_GetTemplateForActionDialogChangePassword()
			},
			{
				"Action.Dialog.ChangePasswordConfirmation",
				_GetTemplateForActionDialogChangePasswordConfirmation()
			},
			{
				"Action.Dialog.ChangeUsernameBuy",
				_GetTemplateForActionDialogChangeUsernameBuy()
			},
			{
				"Action.Dialog.Close",
				_GetTemplateForActionDialogClose()
			},
			{
				"Action.Dialog.EditPhonePrimary",
				_GetTemplateForActionDialogEditPhonePrimary()
			},
			{
				"Action.Dialog.EditPhoneSecondary",
				_GetTemplateForActionDialogEditPhoneSecondary()
			},
			{
				"Action.Dialog.InsufficientFundsBuy",
				_GetTemplateForActionDialogInsufficientFundsBuy()
			},
			{
				"Action.Dialog.No",
				_GetTemplateForActionDialogNo()
			},
			{
				"Action.Dialog.PinCreate",
				_GetTemplateForActionDialogPinCreate()
			},
			{
				"Action.Dialog.PinCreateOk",
				_GetTemplateForActionDialogPinCreateOk()
			},
			{
				"Action.Dialog.PinUnlock",
				_GetTemplateForActionDialogPinUnlock()
			},
			{
				"Action.Dialog.RemovePhonePrimary",
				_GetTemplateForActionDialogRemovePhonePrimary()
			},
			{
				"Action.Dialog.RemovePhoneSecondary",
				_GetTemplateForActionDialogRemovePhoneSecondary()
			},
			{
				"Action.Dialog.Send",
				_GetTemplateForActionDialogSend()
			},
			{
				"Action.Dialog.Success",
				_GetTemplateForActionDialogSuccess()
			},
			{
				"Action.Dialog.Update",
				_GetTemplateForActionDialogUpdate()
			},
			{
				"Action.Dialog.VerifyEmailOk",
				_GetTemplateForActionDialogVerifyEmailOk()
			},
			{
				"Action.Dialog.VerifyEmailPrimary",
				_GetTemplateForActionDialogVerifyEmailPrimary()
			},
			{
				"Action.Dialog.VerifyEmailRetry",
				_GetTemplateForActionDialogVerifyEmailRetry()
			},
			{
				"Action.Dialog.VerifyPhonePrimary",
				_GetTemplateForActionDialogVerifyPhonePrimary()
			},
			{
				"Action.Dialog.VerifyPhoneResendLink",
				_GetTemplateForActionDialogVerifyPhoneResendLink()
			},
			{
				"Action.Dialog.VerifyPhoneSecondary",
				_GetTemplateForActionDialogVerifyPhoneSecondary()
			},
			{
				"Action.Dialog.Yes",
				_GetTemplateForActionDialogYes()
			},
			{
				"Action.Hide",
				_GetTemplateForActionHide()
			},
			{
				"Action.Join",
				_GetTemplateForActionJoin()
			},
			{
				"Action.JoinBuildersClub",
				_GetTemplateForActionJoinBuildersClub()
			},
			{
				"Action.Save",
				_GetTemplateForActionSave()
			},
			{
				"Action.Show",
				_GetTemplateForActionShow()
			},
			{
				"Action.SignoutAllSessions",
				_GetTemplateForActionSignoutAllSessions()
			},
			{
				"Action.SocialDisconnect",
				_GetTemplateForActionSocialDisconnect()
			},
			{
				"Action.SuccessDialogButtonText",
				_GetTemplateForActionSuccessDialogButtonText()
			},
			{
				"Action.Unblock",
				_GetTemplateForActionUnblock()
			},
			{
				"Action.UpgradeMembership",
				_GetTemplateForActionUpgradeMembership()
			},
			{
				"Description.AccountControls",
				_GetTemplateForDescriptionAccountControls()
			},
			{
				"Description.AccountEmailRevertEmail.From",
				_GetTemplateForDescriptionAccountEmailRevertEmailFrom()
			},
			{
				"Description.AccountEmailRevertEmail.HtmlBody",
				_GetTemplateForDescriptionAccountEmailRevertEmailHtmlBody()
			},
			{
				"Description.AccountEmailRevertEmail.PlainBody",
				_GetTemplateForDescriptionAccountEmailRevertEmailPlainBody()
			},
			{
				"Description.AccountEmailRevertEmail.Subject",
				_GetTemplateForDescriptionAccountEmailRevertEmailSubject()
			},
			{
				"Description.AccountRestrictionsEnabled",
				_GetTemplateForDescriptionAccountRestrictionsEnabled()
			},
			{
				"Description.BlockedLimitMessage",
				_GetTemplateForDescriptionBlockedLimitMessage()
			},
			{
				"Description.ContactSetting",
				_GetTemplateForDescriptionContactSetting()
			},
			{
				"Description.DesktopPush1",
				_GetTemplateForDescriptionDesktopPush1()
			},
			{
				"Description.DesktopPush2",
				_GetTemplateForDescriptionDesktopPush2()
			},
			{
				"Description.DesktopPush3",
				_GetTemplateForDescriptionDesktopPush3()
			},
			{
				"Description.Dialog.AddPhone",
				_GetTemplateForDescriptionDialogAddPhone()
			},
			{
				"Description.Dialog.ChangeEmailConfirmation",
				_GetTemplateForDescriptionDialogChangeEmailConfirmation()
			},
			{
				"Description.Dialog.ChangeEmailWarning",
				_GetTemplateForDescriptionDialogChangeEmailWarning()
			},
			{
				"Description.Dialog.ChangePasswordConfirmation",
				_GetTemplateForDescriptionDialogChangePasswordConfirmation()
			},
			{
				"Description.Dialog.ChangeUsernameDisclaimer",
				_GetTemplateForDescriptionDialogChangeUsernameDisclaimer()
			},
			{
				"Description.Dialog.ChangeUsernameForFree",
				_GetTemplateForDescriptionDialogChangeUsernameForFree()
			},
			{
				"Description.Dialog.ChangeUsernameHistory",
				_GetTemplateForDescriptionDialogChangeUsernameHistory()
			},
			{
				"Description.Dialog.ChangeUsernamePageText",
				_GetTemplateForDescriptionDialogChangeUsernamePageText()
			},
			{
				"Description.Dialog.ChangeUsernameTitle",
				_GetTemplateForDescriptionDialogChangeUsernameTitle()
			},
			{
				"Description.Dialog.EditPhoneWarning",
				_GetTemplateForDescriptionDialogEditPhoneWarning()
			},
			{
				"Description.Dialog.EmailProvideAndVerifyWarning",
				_GetTemplateForDescriptionDialogEmailProvideAndVerifyWarning()
			},
			{
				"Description.Dialog.EmailVerificationSent",
				_GetTemplateForDescriptionDialogEmailVerificationSent()
			},
			{
				"Description.Dialog.EmailVerifyWarning",
				_GetTemplateForDescriptionDialogEmailVerifyWarning()
			},
			{
				"Description.Dialog.FacebookDisconnectWarning",
				_GetTemplateForDescriptionDialogFacebookDisconnectWarning()
			},
			{
				"Description.Dialog.InsufficientFundsWarning",
				_GetTemplateForDescriptionDialogInsufficientFundsWarning()
			},
			{
				"Description.Dialog.MissingEmailAccountPin",
				_GetTemplateForDescriptionDialogMissingEmailAccountPin()
			},
			{
				"Description.Dialog.MissingEmailTwoStepVerification",
				_GetTemplateForDescriptionDialogMissingEmailTwoStepVerification()
			},
			{
				"Description.Dialog.MissingEmailUsername",
				_GetTemplateForDescriptionDialogMissingEmailUsername()
			},
			{
				"Description.Dialog.PinUnlock",
				_GetTemplateForDescriptionDialogPinUnlock()
			},
			{
				"Description.Dialog.RemovePhoneWarning",
				_GetTemplateForDescriptionDialogRemovePhoneWarning()
			},
			{
				"Description.Dialog.UnverifiedEmailAccountPin",
				_GetTemplateForDescriptionDialogUnverifiedEmailAccountPin()
			},
			{
				"Description.Dialog.UnverifiedEmailTwoStepVerification",
				_GetTemplateForDescriptionDialogUnverifiedEmailTwoStepVerification()
			},
			{
				"Description.Dialog.UnverifiedEmailUsername",
				_GetTemplateForDescriptionDialogUnverifiedEmailUsername()
			},
			{
				"Description.FastTrack",
				_GetTemplateForDescriptionFastTrack()
			},
			{
				"Description.FastTrack.Statistics",
				_GetTemplateForDescriptionFastTrackStatistics()
			},
			{
				"Description.HelpText.Description",
				_GetTemplateForDescriptionHelpTextDescription()
			},
			{
				"Description.HelpText.FastTrack.Accuracy",
				_GetTemplateForDescriptionHelpTextFastTrackAccuracy()
			},
			{
				"Description.HelpText.PrivacyMode",
				_GetTemplateForDescriptionHelpTextPrivacyMode()
			},
			{
				"Description.HoverText.ChangePassword",
				_GetTemplateForDescriptionHoverTextChangePassword()
			},
			{
				"Description.HoverText.ChangeUsername",
				_GetTemplateForDescriptionHoverTextChangeUsername()
			},
			{
				"Description.HoverText.UpdateEmail",
				_GetTemplateForDescriptionHoverTextUpdateEmail()
			},
			{
				"Description.MembershipHelp",
				_GetTemplateForDescriptionMembershipHelp()
			},
			{
				"Description.MembershipStatus",
				_GetTemplateForDescriptionMembershipStatus()
			},
			{
				"Description.MembershipStatusRobloxPremium",
				_GetTemplateForDescriptionMembershipStatusRobloxPremium()
			},
			{
				"Description.MobilePush1",
				_GetTemplateForDescriptionMobilePush1()
			},
			{
				"Description.MobilePush2",
				_GetTemplateForDescriptionMobilePush2()
			},
			{
				"Description.NotificationStream1",
				_GetTemplateForDescriptionNotificationStream1()
			},
			{
				"Description.NotificationStream2",
				_GetTemplateForDescriptionNotificationStream2()
			},
			{
				"Description.RenevalFromWebsiteOnly",
				_GetTemplateForDescriptionRenevalFromWebsiteOnly()
			},
			{
				"Description.SuccessDialogMessage",
				_GetTemplateForDescriptionSuccessDialogMessage()
			},
			{
				"Description.TwoStepVerificationSecondary",
				_GetTemplateForDescriptionTwoStepVerificationSecondary()
			},
			{
				"Description.TwoStepverificationSecondaryEnabled",
				_GetTemplateForDescriptionTwoStepverificationSecondaryEnabled()
			},
			{
				"Description.UsernameChangeEmail.Body",
				_GetTemplateForDescriptionUsernameChangeEmailBody()
			},
			{
				"Description.UsernameChangeEmail.From",
				_GetTemplateForDescriptionUsernameChangeEmailFrom()
			},
			{
				"Description.UsernameChangeEmail.Subject",
				_GetTemplateForDescriptionUsernameChangeEmailSubject()
			},
			{
				"Description.VerificationEmail.From.Over13",
				_GetTemplateForDescriptionVerificationEmailFromOver13()
			},
			{
				"Description.VerificationEmail.From.Under13",
				_GetTemplateForDescriptionVerificationEmailFromUnder13()
			},
			{
				"Description.VerificationEmail.HtmlBody.Over13\t",
				_GetTemplateForDescriptionVerificationEmailHtmlBodyOver13()
			},
			{
				"Description.VerificationEmail.HtmlBody.Under13",
				_GetTemplateForDescriptionVerificationEmailHtmlBodyUnder13()
			},
			{
				"Description.VerificationEmail.HtmlBody.Under13.Part2",
				_GetTemplateForDescriptionVerificationEmailHtmlBodyUnder13Part2()
			},
			{
				"Description.VerificationEmail.PlainBody.Over13",
				_GetTemplateForDescriptionVerificationEmailPlainBodyOver13()
			},
			{
				"Description.VerificationEmail.PlainBody.Under13",
				_GetTemplateForDescriptionVerificationEmailPlainBodyUnder13()
			},
			{
				"Description.VerificationEmail.PlainBody.Under13.Part2",
				_GetTemplateForDescriptionVerificationEmailPlainBodyUnder13Part2()
			},
			{
				"Description.VerificationEmail.Subject.Over13",
				_GetTemplateForDescriptionVerificationEmailSubjectOver13()
			},
			{
				"Description.VerificationEmail.Subject.Under13",
				_GetTemplateForDescriptionVerificationEmailSubjectUnder13()
			},
			{
				"Example.Description",
				_GetTemplateForExampleDescription()
			},
			{
				"Example.Facebook",
				_GetTemplateForExampleFacebook()
			},
			{
				"Example.GooglePlus",
				_GetTemplateForExampleGooglePlus()
			},
			{
				"Example.Twitch",
				_GetTemplateForExampleTwitch()
			},
			{
				"Example.Twitter",
				_GetTemplateForExampleTwitter()
			},
			{
				"Example.YouTube",
				_GetTemplateForExampleYouTube()
			},
			{
				"Heading.AccountControls",
				_GetTemplateForHeadingAccountControls()
			},
			{
				"Heading.AccountInfo",
				_GetTemplateForHeadingAccountInfo()
			},
			{
				"Heading.Billing",
				_GetTemplateForHeadingBilling()
			},
			{
				"Heading.BlockedUsers",
				_GetTemplateForHeadingBlockedUsers()
			},
			{
				"Heading.ContactSettings",
				_GetTemplateForHeadingContactSettings()
			},
			{
				"Heading.DesktopPush",
				_GetTemplateForHeadingDesktopPush()
			},
			{
				"Heading.Dialog.AddPassword",
				_GetTemplateForHeadingDialogAddPassword()
			},
			{
				"Heading.Dialog.AddPhone",
				_GetTemplateForHeadingDialogAddPhone()
			},
			{
				"Heading.Dialog.ChangeEmail",
				_GetTemplateForHeadingDialogChangeEmail()
			},
			{
				"Heading.Dialog.ChangeEmailConfirmation",
				_GetTemplateForHeadingDialogChangeEmailConfirmation()
			},
			{
				"Heading.Dialog.ChangePassword",
				_GetTemplateForHeadingDialogChangePassword()
			},
			{
				"Heading.Dialog.ChangePasswordConfirmation",
				_GetTemplateForHeadingDialogChangePasswordConfirmation()
			},
			{
				"Heading.Dialog.ChangePasswordSuccess",
				_GetTemplateForHeadingDialogChangePasswordSuccess()
			},
			{
				"Heading.Dialog.ChangeUsername",
				_GetTemplateForHeadingDialogChangeUsername()
			},
			{
				"Heading.Dialog.DefaultError",
				_GetTemplateForHeadingDialogDefaultError()
			},
			{
				"Heading.Dialog.DefaultSuccess",
				_GetTemplateForHeadingDialogDefaultSuccess()
			},
			{
				"Heading.Dialog.EditPhone",
				_GetTemplateForHeadingDialogEditPhone()
			},
			{
				"Heading.Dialog.InsufficientFunds",
				_GetTemplateForHeadingDialogInsufficientFunds()
			},
			{
				"Heading.Dialog.InvalidUsername",
				_GetTemplateForHeadingDialogInvalidUsername()
			},
			{
				"Heading.Dialog.PinCreate",
				_GetTemplateForHeadingDialogPinCreate()
			},
			{
				"Heading.Dialog.PinCreateSuccessConfirmation",
				_GetTemplateForHeadingDialogPinCreateSuccessConfirmation()
			},
			{
				"Heading.Dialog.PinUnlock",
				_GetTemplateForHeadingDialogPinUnlock()
			},
			{
				"Heading.Dialog.RemovePhone",
				_GetTemplateForHeadingDialogRemovePhone()
			},
			{
				"Heading.Dialog.VerifiedEmailRequired",
				_GetTemplateForHeadingDialogVerifiedEmailRequired()
			},
			{
				"Heading.Dialog.VerifyEmail",
				_GetTemplateForHeadingDialogVerifyEmail()
			},
			{
				"Heading.Dialog.VerifyPhone",
				_GetTemplateForHeadingDialogVerifyPhone()
			},
			{
				"Heading.FastTrack",
				_GetTemplateForHeadingFastTrack()
			},
			{
				"Heading.MembershipStatus",
				_GetTemplateForHeadingMembershipStatus()
			},
			{
				"Heading.NotificationOptions",
				_GetTemplateForHeadingNotificationOptions()
			},
			{
				"Heading.Notifications",
				_GetTemplateForHeadingNotifications()
			},
			{
				"Heading.Notifications.ActionWhen",
				_GetTemplateForHeadingNotificationsActionWhen()
			},
			{
				"Heading.Notifications.DesktopPush",
				_GetTemplateForHeadingNotificationsDesktopPush()
			},
			{
				"Heading.Notifications.MobilePush",
				_GetTemplateForHeadingNotificationsMobilePush()
			},
			{
				"Heading.Notifications.Stream",
				_GetTemplateForHeadingNotificationsStream()
			},
			{
				"Heading.NotificationStream",
				_GetTemplateForHeadingNotificationStream()
			},
			{
				"Heading.OtherSettings",
				_GetTemplateForHeadingOtherSettings()
			},
			{
				"Heading.PageTitle",
				_GetTemplateForHeadingPageTitle()
			},
			{
				"Heading.Personal",
				_GetTemplateForHeadingPersonal()
			},
			{
				"Heading.Pin",
				_GetTemplateForHeadingPin()
			},
			{
				"Heading.PrivacySettings",
				_GetTemplateForHeadingPrivacySettings()
			},
			{
				"Heading.RenevalDate",
				_GetTemplateForHeadingRenevalDate()
			},
			{
				"Heading.Restrictions",
				_GetTemplateForHeadingRestrictions()
			},
			{
				"Heading.SecureSignOut",
				_GetTemplateForHeadingSecureSignOut()
			},
			{
				"Heading.SocialNetworks",
				_GetTemplateForHeadingSocialNetworks()
			},
			{
				"Heading.SocialSignOn",
				_GetTemplateForHeadingSocialSignOn()
			},
			{
				"Heading.SuccessDialogTitle",
				_GetTemplateForHeadingSuccessDialogTitle()
			},
			{
				"Heading.Tab.AccountInfo",
				_GetTemplateForHeadingTabAccountInfo()
			},
			{
				"Heading.Tab.Billing",
				_GetTemplateForHeadingTabBilling()
			},
			{
				"Heading.Tab.FastTrack",
				_GetTemplateForHeadingTabFastTrack()
			},
			{
				"Heading.Tab.Notifications",
				_GetTemplateForHeadingTabNotifications()
			},
			{
				"Heading.Tab.Privacy",
				_GetTemplateForHeadingTabPrivacy()
			},
			{
				"Heading.Tab.Security",
				_GetTemplateForHeadingTabSecurity()
			},
			{
				"Heading.Transactions",
				_GetTemplateForHeadingTransactions()
			},
			{
				"Heading.TwoStepVerification",
				_GetTemplateForHeadingTwoStepVerification()
			},
			{
				"Heading.Xbox",
				_GetTemplateForHeadingXbox()
			},
			{
				"Label.AccountPinDisabled",
				_GetTemplateForLabelAccountPinDisabled()
			},
			{
				"Label.AccountPinEnabled",
				_GetTemplateForLabelAccountPinEnabled()
			},
			{
				"Label.AccountRestrictionDisabled",
				_GetTemplateForLabelAccountRestrictionDisabled()
			},
			{
				"Label.AccountRestrictionEnabled",
				_GetTemplateForLabelAccountRestrictionEnabled()
			},
			{
				"Label.AddEmail",
				_GetTemplateForLabelAddEmail()
			},
			{
				"Label.AddEmailParent",
				_GetTemplateForLabelAddEmailParent()
			},
			{
				"Label.AddPassword",
				_GetTemplateForLabelAddPassword()
			},
			{
				"Label.AddPhone",
				_GetTemplateForLabelAddPhone()
			},
			{
				"Label.AddPhoneLink",
				_GetTemplateForLabelAddPhoneLink()
			},
			{
				"Label.BillingHelp",
				_GetTemplateForLabelBillingHelp()
			},
			{
				"Label.BillingHelpWithLink",
				_GetTemplateForLabelBillingHelpWithLink()
			},
			{
				"Label.BillingHistoryCardNumber",
				_GetTemplateForLabelBillingHistoryCardNumber()
			},
			{
				"Label.BillingHistoryCost",
				_GetTemplateForLabelBillingHistoryCost()
			},
			{
				"Label.BillingHistoryDate",
				_GetTemplateForLabelBillingHistoryDate()
			},
			{
				"Label.BillingHistoryDescription",
				_GetTemplateForLabelBillingHistoryDescription()
			},
			{
				"Label.BillingHistoryGeneralErrors",
				_GetTemplateForLabelBillingHistoryGeneralErrors()
			},
			{
				"Label.BillingHistoryNoTransactions",
				_GetTemplateForLabelBillingHistoryNoTransactions()
			},
			{
				"Label.BillingHistoryPaymentType",
				_GetTemplateForLabelBillingHistoryPaymentType()
			},
			{
				"Label.Birthday",
				_GetTemplateForLabelBirthday()
			},
			{
				"Label.BuildersClub",
				_GetTemplateForLabelBuildersClub()
			},
			{
				"Label.BuildersClubJoin",
				_GetTemplateForLabelBuildersClubJoin()
			},
			{
				"Label.ChangeYourUsername",
				_GetTemplateForLabelChangeYourUsername()
			},
			{
				"Label.ChooseLanguage",
				_GetTemplateForLabelChooseLanguage()
			},
			{
				"Label.ClassicTheme",
				_GetTemplateForLabelClassicTheme()
			},
			{
				"Label.ConnectAccount",
				_GetTemplateForLabelConnectAccount()
			},
			{
				"Label.Country",
				_GetTemplateForLabelCountry()
			},
			{
				"Label.CountryTitle",
				_GetTemplateForLabelCountryTitle()
			},
			{
				"Label.DarkTheme",
				_GetTemplateForLabelDarkTheme()
			},
			{
				"Label.Dialog.AddEmailOver13",
				_GetTemplateForLabelDialogAddEmailOver13()
			},
			{
				"Label.Dialog.AddEmailUnder13",
				_GetTemplateForLabelDialogAddEmailUnder13()
			},
			{
				"Label.Dialog.AddPhoneField",
				_GetTemplateForLabelDialogAddPhoneField()
			},
			{
				"Label.Dialog.AddPhonePassword",
				_GetTemplateForLabelDialogAddPhonePassword()
			},
			{
				"Label.Dialog.ChangeEmailField",
				_GetTemplateForLabelDialogChangeEmailField()
			},
			{
				"Label.Dialog.ChangeEmailOver13",
				_GetTemplateForLabelDialogChangeEmailOver13()
			},
			{
				"Label.Dialog.ChangeEmailUnder13",
				_GetTemplateForLabelDialogChangeEmailUnder13()
			},
			{
				"Label.Dialog.ChangePasswordConfirm",
				_GetTemplateForLabelDialogChangePasswordConfirm()
			},
			{
				"Label.Dialog.ChangePasswordCurrent",
				_GetTemplateForLabelDialogChangePasswordCurrent()
			},
			{
				"Label.Dialog.ChangePasswordNew",
				_GetTemplateForLabelDialogChangePasswordNew()
			},
			{
				"Label.Dialog.ChangeUsernameAccountPassword",
				_GetTemplateForLabelDialogChangeUsernameAccountPassword()
			},
			{
				"Label.Dialog.ChangeUsernameField",
				_GetTemplateForLabelDialogChangeUsernameField()
			},
			{
				"Label.Dialog.ConfirmPin",
				_GetTemplateForLabelDialogConfirmPin()
			},
			{
				"Label.Dialog.CreatePin",
				_GetTemplateForLabelDialogCreatePin()
			},
			{
				"Label.Dialog.EditPhoneCurrentNumber",
				_GetTemplateForLabelDialogEditPhoneCurrentNumber()
			},
			{
				"Label.Dialog.EmailAddressChanged",
				_GetTemplateForLabelDialogEmailAddressChanged()
			},
			{
				"Label.Dialog.EmailRequired",
				_GetTemplateForLabelDialogEmailRequired()
			},
			{
				"Label.Dialog.VerifiedEmail",
				_GetTemplateForLabelDialogVerifiedEmail()
			},
			{
				"Label.Dialog.VerifyPassword",
				_GetTemplateForLabelDialogVerifyPassword()
			},
			{
				"Label.Dialog.VerifyPhoneCode",
				_GetTemplateForLabelDialogVerifyPhoneCode()
			},
			{
				"Label.Dialog.VerifyPhoneCodeLabel",
				_GetTemplateForLabelDialogVerifyPhoneCodeLabel()
			},
			{
				"Label.Dialog.VerifySms",
				_GetTemplateForLabelDialogVerifySms()
			},
			{
				"Label.DropDown.Custom",
				_GetTemplateForLabelDropDownCustom()
			},
			{
				"Label.DropDown.Default",
				_GetTemplateForLabelDropDownDefault()
			},
			{
				"Label.DropDown.Everyone",
				_GetTemplateForLabelDropDownEveryone()
			},
			{
				"Label.DropDown.Followers",
				_GetTemplateForLabelDropDownFollowers()
			},
			{
				"Label.DropDown.Following",
				_GetTemplateForLabelDropDownFollowing()
			},
			{
				"Label.DropDown.Friends",
				_GetTemplateForLabelDropDownFriends()
			},
			{
				"Label.DropDown.High",
				_GetTemplateForLabelDropDownHigh()
			},
			{
				"Label.DropDown.Low",
				_GetTemplateForLabelDropDownLow()
			},
			{
				"Label.DropDown.Medium",
				_GetTemplateForLabelDropDownMedium()
			},
			{
				"Label.DropDown.None",
				_GetTemplateForLabelDropDownNone()
			},
			{
				"Label.DropDown.NoOne",
				_GetTemplateForLabelDropDownNoOne()
			},
			{
				"Label.DropDown.Off",
				_GetTemplateForLabelDropDownOff()
			},
			{
				"Label.Email",
				_GetTemplateForLabelEmail()
			},
			{
				"Label.EmailParent",
				_GetTemplateForLabelEmailParent()
			},
			{
				"Label.EmailVerificationPending",
				_GetTemplateForLabelEmailVerificationPending()
			},
			{
				"Label.ExpirationDate",
				_GetTemplateForLabelExpirationDate()
			},
			{
				"Label.ExpirationDateMessage",
				_GetTemplateForLabelExpirationDateMessage()
			},
			{
				"Label.Facebook",
				_GetTemplateForLabelFacebook()
			},
			{
				"Label.FastTrack.Accuracy",
				_GetTemplateForLabelFastTrackAccuracy()
			},
			{
				"Label.FastTrack.AllFastTrackMembers",
				_GetTemplateForLabelFastTrackAllFastTrackMembers()
			},
			{
				"Label.FastTrack.ReportMonth",
				_GetTemplateForLabelFastTrackReportMonth()
			},
			{
				"Label.FastTrack.ReportYear",
				_GetTemplateForLabelFastTrackReportYear()
			},
			{
				"Label.FastTrack.Statistics",
				_GetTemplateForLabelFastTrackStatistics()
			},
			{
				"Label.FastTrack.You",
				_GetTemplateForLabelFastTrackYou()
			},
			{
				"Label.Gender",
				_GetTemplateForLabelGender()
			},
			{
				"Label.GooglePlus",
				_GetTemplateForLabelGooglePlus()
			},
			{
				"Label.LightTheme",
				_GetTemplateForLabelLightTheme()
			},
			{
				"Label.LocaleTitle",
				_GetTemplateForLabelLocaleTitle()
			},
			{
				"Label.MembershipName",
				_GetTemplateForLabelMembershipName()
			},
			{
				"Label.MembershipStatusRobloxPremium",
				_GetTemplateForLabelMembershipStatusRobloxPremium()
			},
			{
				"Label.Notifications.AddedToPrivateServer",
				_GetTemplateForLabelNotificationsAddedToPrivateServer()
			},
			{
				"Label.Notifications.Chat",
				_GetTemplateForLabelNotificationsChat()
			},
			{
				"Label.Notifications.ConversationUniverseChanged",
				_GetTemplateForLabelNotificationsConversationUniverseChanged()
			},
			{
				"Label.Notifications.DeveloperMetricsAvailable",
				_GetTemplateForLabelNotificationsDeveloperMetricsAvailable()
			},
			{
				"Label.Notifications.FriendRequestAccepted",
				_GetTemplateForLabelNotificationsFriendRequestAccepted()
			},
			{
				"Label.Notifications.FriendRequestReceived",
				_GetTemplateForLabelNotificationsFriendRequestReceived()
			},
			{
				"Label.Notifications.GameUpdate",
				_GetTemplateForLabelNotificationsGameUpdate()
			},
			{
				"Label.Notifications.PartyInvited",
				_GetTemplateForLabelNotificationsPartyInvited()
			},
			{
				"Label.Notifications.PartyJoined",
				_GetTemplateForLabelNotificationsPartyJoined()
			},
			{
				"Label.Notifications.PrivateMessage",
				_GetTemplateForLabelNotificationsPrivateMessage()
			},
			{
				"Label.Notifications.TeamCreateInvite",
				_GetTemplateForLabelNotificationsTeamCreateInvite()
			},
			{
				"Label.Password",
				_GetTemplateForLabelPassword()
			},
			{
				"Label.Phone",
				_GetTemplateForLabelPhone()
			},
			{
				"Label.PinTimeMins",
				_GetTemplateForLabelPinTimeMins()
			},
			{
				"Label.PinTimeRemaining",
				_GetTemplateForLabelPinTimeRemaining()
			},
			{
				"Label.PinTimeSecs",
				_GetTemplateForLabelPinTimeSecs()
			},
			{
				"Label.PremiumClub",
				_GetTemplateForLabelPremiumClub()
			},
			{
				"Label.PreviousUsernames",
				_GetTemplateForLabelPreviousUsernames()
			},
			{
				"Label.PrivacyMode",
				_GetTemplateForLabelPrivacyMode()
			},
			{
				"Label.RenevalDate",
				_GetTemplateForLabelRenevalDate()
			},
			{
				"Label.RenevalDateMessage",
				_GetTemplateForLabelRenevalDateMessage()
			},
			{
				"Label.RobloxPremiumClub",
				_GetTemplateForLabelRobloxPremiumClub()
			},
			{
				"Label.RobuxProductName",
				_GetTemplateForLabelRobuxProductName()
			},
			{
				"Label.SignOutAllSessions",
				_GetTemplateForLabelSignOutAllSessions()
			},
			{
				"Label.SocialLinksVisibility",
				_GetTemplateForLabelSocialLinksVisibility()
			},
			{
				"Label.SocialUsername",
				_GetTemplateForLabelSocialUsername()
			},
			{
				"Label.ThemeTitle",
				_GetTemplateForLabelThemeTitle()
			},
			{
				"Label.ToolTip.ContactSettings",
				_GetTemplateForLabelToolTipContactSettings()
			},
			{
				"Label.ToolTip.PinLocked",
				_GetTemplateForLabelToolTipPinLocked()
			},
			{
				"Label.ToolTip.PinUnlocked",
				_GetTemplateForLabelToolTipPinUnlocked()
			},
			{
				"Label.ToolTip.PrivacyMode",
				_GetTemplateForLabelToolTipPrivacyMode()
			},
			{
				"Label.ToolTip.WhoCanChatInApp",
				_GetTemplateForLabelToolTipWhoCanChatInApp()
			},
			{
				"Label.ToolTip.WhoCanChatInGame",
				_GetTemplateForLabelToolTipWhoCanChatInGame()
			},
			{
				"Label.ToolTip.WhoCanFindMeByPhone",
				_GetTemplateForLabelToolTipWhoCanFindMeByPhone()
			},
			{
				"Label.ToolTip.WhoCanInviteVIP",
				_GetTemplateForLabelToolTipWhoCanInviteVIP()
			},
			{
				"Label.ToolTip.WhoCanJoinGame",
				_GetTemplateForLabelToolTipWhoCanJoinGame()
			},
			{
				"Label.ToolTip.WhoCanMessageMe",
				_GetTemplateForLabelToolTipWhoCanMessageMe()
			},
			{
				"Label.ToolTip.WhoCanSeeInventory",
				_GetTemplateForLabelToolTipWhoCanSeeInventory()
			},
			{
				"Label.TradeFilter",
				_GetTemplateForLabelTradeFilter()
			},
			{
				"Label.Twitch",
				_GetTemplateForLabelTwitch()
			},
			{
				"Label.Twitter",
				_GetTemplateForLabelTwitter()
			},
			{
				"Label.TwoStepEmail",
				_GetTemplateForLabelTwoStepEmail()
			},
			{
				"Label.TwoStepPrerequisite",
				_GetTemplateForLabelTwoStepPrerequisite()
			},
			{
				"Label.TwoStepVerification",
				_GetTemplateForLabelTwoStepVerification()
			},
			{
				"Label.TwoStepVerificationEnabled",
				_GetTemplateForLabelTwoStepVerificationEnabled()
			},
			{
				"Label.UpdateEmail",
				_GetTemplateForLabelUpdateEmail()
			},
			{
				"Label.UpdatePhone",
				_GetTemplateForLabelUpdatePhone()
			},
			{
				"Label.UseDeviceLanguage",
				_GetTemplateForLabelUseDeviceLanguage()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.Verified",
				_GetTemplateForLabelVerified()
			},
			{
				"Label.Verify",
				_GetTemplateForLabelVerify()
			},
			{
				"Label.WhoCanChatInApp",
				_GetTemplateForLabelWhoCanChatInApp()
			},
			{
				"Label.WhoCanChatInGame",
				_GetTemplateForLabelWhoCanChatInGame()
			},
			{
				"Label.WhoCanFindMeByPhone",
				_GetTemplateForLabelWhoCanFindMeByPhone()
			},
			{
				"Label.WhoCanInviteVIP",
				_GetTemplateForLabelWhoCanInviteVIP()
			},
			{
				"Label.WhoCanJoinGame",
				_GetTemplateForLabelWhoCanJoinGame()
			},
			{
				"Label.WhoCanMessageMe",
				_GetTemplateForLabelWhoCanMessageMe()
			},
			{
				"Label.WhoCanSeeInventory",
				_GetTemplateForLabelWhoCanSeeInventory()
			},
			{
				"Label.WhoCanTradeWithMe",
				_GetTemplateForLabelWhoCanTradeWithMe()
			},
			{
				"Label.XboxConnected",
				_GetTemplateForLabelXboxConnected()
			},
			{
				"Label.YouTube",
				_GetTemplateForLabelYouTube()
			},
			{
				"LabelInsufficientRobux",
				_GetTemplateForLabelInsufficientRobux()
			},
			{
				"Message.Error.AccountHasPin",
				_GetTemplateForMessageErrorAccountHasPin()
			},
			{
				"Message.Error.AccountLocked",
				_GetTemplateForMessageErrorAccountLocked()
			},
			{
				"Message.Error.Default",
				_GetTemplateForMessageErrorDefault()
			},
			{
				"Message.Error.Email.AlreadyVerified",
				_GetTemplateForMessageErrorEmailAlreadyVerified()
			},
			{
				"Message.Error.Email.FeatureDisabled",
				_GetTemplateForMessageErrorEmailFeatureDisabled()
			},
			{
				"Message.Error.Email.IncorrectPassword",
				_GetTemplateForMessageErrorEmailIncorrectPassword()
			},
			{
				"Message.Error.Email.InvalidEmail",
				_GetTemplateForMessageErrorEmailInvalidEmail()
			},
			{
				"Message.Error.Email.NoEmailAssociated",
				_GetTemplateForMessageErrorEmailNoEmailAssociated()
			},
			{
				"Message.Error.Email.PinLocked",
				_GetTemplateForMessageErrorEmailPinLocked()
			},
			{
				"Message.Error.Email.SameEmail",
				_GetTemplateForMessageErrorEmailSameEmail()
			},
			{
				"Message.Error.Email.TooManyAccounts",
				_GetTemplateForMessageErrorEmailTooManyAccounts()
			},
			{
				"Message.Error.Email.TooManyUpdates",
				_GetTemplateForMessageErrorEmailTooManyUpdates()
			},
			{
				"Message.Error.Email.TooManyVerify",
				_GetTemplateForMessageErrorEmailTooManyVerify()
			},
			{
				"Message.Error.Email.Unknown",
				_GetTemplateForMessageErrorEmailUnknown()
			},
			{
				"Message.Error.IncorrectPin",
				_GetTemplateForMessageErrorIncorrectPin()
			},
			{
				"Message.Error.InvalidPinFormat",
				_GetTemplateForMessageErrorInvalidPinFormat()
			},
			{
				"Message.Error.NoPin",
				_GetTemplateForMessageErrorNoPin()
			},
			{
				"Message.Error.NoVerifiedEmail",
				_GetTemplateForMessageErrorNoVerifiedEmail()
			},
			{
				"Message.Error.System",
				_GetTemplateForMessageErrorSystem()
			},
			{
				"Message.Error.TooManyRequests",
				_GetTemplateForMessageErrorTooManyRequests()
			},
			{
				"MessageEmailAddSuccess",
				_GetTemplateForMessageEmailAddSuccess()
			},
			{
				"MessageEmailAlreadyVerifiedError",
				_GetTemplateForMessageEmailAlreadyVerifiedError()
			},
			{
				"MessageFeatureDisabledError",
				_GetTemplateForMessageFeatureDisabledError()
			},
			{
				"MessageInsufficientRobuxErrorForUserName",
				_GetTemplateForMessageInsufficientRobuxErrorForUserName()
			},
			{
				"MessageInvalidEmail",
				_GetTemplateForMessageInvalidEmail()
			},
			{
				"MessageNoEmailAssociatedError",
				_GetTemplateForMessageNoEmailAssociatedError()
			},
			{
				"MessagePermissionError",
				_GetTemplateForMessagePermissionError()
			},
			{
				"MessagePinLockedError",
				_GetTemplateForMessagePinLockedError()
			},
			{
				"MessageSameEmailError",
				_GetTemplateForMessageSameEmailError()
			},
			{
				"MessageSettingsUpdateSuccess",
				_GetTemplateForMessageSettingsUpdateSuccess()
			},
			{
				"MessageTooManyAccountsOnEmailError",
				_GetTemplateForMessageTooManyAccountsOnEmailError()
			},
			{
				"MessageTooManyAttemptsError",
				_GetTemplateForMessageTooManyAttemptsError()
			},
			{
				"MessageUnknownError",
				_GetTemplateForMessageUnknownError()
			},
			{
				"MessageWrongPassword",
				_GetTemplateForMessageWrongPassword()
			},
			{
				"Respones.InvalidCodePhone",
				_GetTemplateForResponesInvalidCodePhone()
			},
			{
				"Respones.InventoryAndTradePrivacyConflictError",
				_GetTemplateForResponesInventoryAndTradePrivacyConflictError()
			},
			{
				"Response.CodeRequired",
				_GetTemplateForResponseCodeRequired()
			},
			{
				"Response.Dialog.BirthdayChangeDefaultWarning",
				_GetTemplateForResponseDialogBirthdayChangeDefaultWarning()
			},
			{
				"Response.Dialog.BirthdayChangePasswordBody",
				_GetTemplateForResponseDialogBirthdayChangePasswordBody()
			},
			{
				"Response.Dialog.BirthdayChangePasswordTitle",
				_GetTemplateForResponseDialogBirthdayChangePasswordTitle()
			},
			{
				"Response.Dialog.BirthdayChangeSocialWarning",
				_GetTemplateForResponseDialogBirthdayChangeSocialWarning()
			},
			{
				"Response.Dialog.ChangePasswordIncorrectPassword",
				_GetTemplateForResponseDialogChangePasswordIncorrectPassword()
			},
			{
				"Response.Dialog.ChangePasswordNoMatch",
				_GetTemplateForResponseDialogChangePasswordNoMatch()
			},
			{
				"Response.Dialog.ChangePasswordTooShortError",
				_GetTemplateForResponseDialogChangePasswordTooShortError()
			},
			{
				"Response.Dialog.ChangeUsernameNoInput",
				_GetTemplateForResponseDialogChangeUsernameNoInput()
			},
			{
				"Response.Dialog.ChangeUsernameNotAllowed",
				_GetTemplateForResponseDialogChangeUsernameNotAllowed()
			},
			{
				"Response.Dialog.ChangeUsernameNotAvailable",
				_GetTemplateForResponseDialogChangeUsernameNotAvailable()
			},
			{
				"Response.Dialog.ChangeUsernameSuccess",
				_GetTemplateForResponseDialogChangeUsernameSuccess()
			},
			{
				"Response.Dialog.CountryListError",
				_GetTemplateForResponseDialogCountryListError()
			},
			{
				"Response.Dialog.CurrencyServiceError",
				_GetTemplateForResponseDialogCurrencyServiceError()
			},
			{
				"Response.Dialog.DefaultErrorMessage",
				_GetTemplateForResponseDialogDefaultErrorMessage()
			},
			{
				"Response.Dialog.DefaultErrorTitle",
				_GetTemplateForResponseDialogDefaultErrorTitle()
			},
			{
				"Response.Dialog.DefaultSuccessMessage",
				_GetTemplateForResponseDialogDefaultSuccessMessage()
			},
			{
				"Response.Dialog.DisconnectXBoxError",
				_GetTemplateForResponseDialogDisconnectXBoxError()
			},
			{
				"Response.Dialog.EmailSentForVerification",
				_GetTemplateForResponseDialogEmailSentForVerification()
			},
			{
				"Response.Dialog.InvalidEmailAddress",
				_GetTemplateForResponseDialogInvalidEmailAddress()
			},
			{
				"Response.Dialog.InvalidPhoneNumber",
				_GetTemplateForResponseDialogInvalidPhoneNumber()
			},
			{
				"Response.Dialog.InvalidUsername",
				_GetTemplateForResponseDialogInvalidUsername()
			},
			{
				"Response.Dialog.PasswordRulesError",
				_GetTemplateForResponseDialogPasswordRulesError()
			},
			{
				"Response.Dialog.PinCreateConfirmation",
				_GetTemplateForResponseDialogPinCreateConfirmation()
			},
			{
				"Response.Dialog.PinCreateMismatch",
				_GetTemplateForResponseDialogPinCreateMismatch()
			},
			{
				"Response.Dialog.SignoutSessionFailed",
				_GetTemplateForResponseDialogSignoutSessionFailed()
			},
			{
				"Response.Dialog.SignoutSessionsConfirmation",
				_GetTemplateForResponseDialogSignoutSessionsConfirmation()
			},
			{
				"Response.Dialog.TwoStepDisableWarning",
				_GetTemplateForResponseDialogTwoStepDisableWarning()
			},
			{
				"Response.Dialog.TwoStepSuccessTitle",
				_GetTemplateForResponseDialogTwoStepSuccessTitle()
			},
			{
				"Response.Dialog.TwoStepSucessBody",
				_GetTemplateForResponseDialogTwoStepSucessBody()
			},
			{
				"Response.Dialog.UpdateInventorySetting",
				_GetTemplateForResponseDialogUpdateInventorySetting()
			},
			{
				"Response.Dialog.UpdateNotificationSettingsError",
				_GetTemplateForResponseDialogUpdateNotificationSettingsError()
			},
			{
				"Response.Dialog.UpdateTradeSetting",
				_GetTemplateForResponseDialogUpdateTradeSetting()
			},
			{
				"Response.Dialog.VerifyPhoneInvalidCode",
				_GetTemplateForResponseDialogVerifyPhoneInvalidCode()
			},
			{
				"Response.Dialog.Warning",
				_GetTemplateForResponseDialogWarning()
			},
			{
				"Response.FeatureDisabled",
				_GetTemplateForResponseFeatureDisabled()
			},
			{
				"Response.GeneralError",
				_GetTemplateForResponseGeneralError()
			},
			{
				"Response.IncorrectCodeTooManyTimes",
				_GetTemplateForResponseIncorrectCodeTooManyTimes()
			},
			{
				"Response.IncorrectPasswordTryAgain",
				_GetTemplateForResponseIncorrectPasswordTryAgain()
			},
			{
				"Response.InvalidPhoneTryAgain",
				_GetTemplateForResponseInvalidPhoneTryAgain()
			},
			{
				"Response.NotificationBar.PhoneRemovedConfirmation",
				_GetTemplateForResponseNotificationBarPhoneRemovedConfirmation()
			},
			{
				"Response.NotificationBar.PhoneVerifyConfirmation",
				_GetTemplateForResponseNotificationBarPhoneVerifyConfirmation()
			},
			{
				"Response.NumberAlreadyAssociated",
				_GetTemplateForResponseNumberAlreadyAssociated()
			},
			{
				"Response.PinRequired",
				_GetTemplateForResponsePinRequired()
			},
			{
				"Response.SocialMedia.ValidationError",
				_GetTemplateForResponseSocialMediaValidationError()
			},
			{
				"ResponseAgeDownError",
				_GetTemplateForResponseAgeDownError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.AccountSettings";
	}

	protected virtual string _GetTemplateForActionBillingHistoryLoadMore()
	{
		return "Load More";
	}

	protected virtual string _GetTemplateForActionCancelRenewal()
	{
		return "Cancel Renewal";
	}

	protected virtual string _GetTemplateForActionDialogAddEmail()
	{
		return "Add Email";
	}

	protected virtual string _GetTemplateForActionDialogAddPhone()
	{
		return "Add Phone";
	}

	protected virtual string _GetTemplateForActionDialogCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDialogChangeEmail()
	{
		return "Change Email";
	}

	protected virtual string _GetTemplateForActionDialogChangeEmailConfirmation()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogChangePassword()
	{
		return "Update";
	}

	protected virtual string _GetTemplateForActionDialogChangePasswordConfirmation()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogChangeUsernameBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForActionDialogClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionDialogEditPhonePrimary()
	{
		return "Edit Phone";
	}

	protected virtual string _GetTemplateForActionDialogEditPhoneSecondary()
	{
		return "Remove Phone Number";
	}

	protected virtual string _GetTemplateForActionDialogInsufficientFundsBuy()
	{
		return "Buy";
	}

	protected virtual string _GetTemplateForActionDialogNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForActionDialogPinCreate()
	{
		return "Add";
	}

	protected virtual string _GetTemplateForActionDialogPinCreateOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogPinUnlock()
	{
		return "Unlock";
	}

	protected virtual string _GetTemplateForActionDialogRemovePhonePrimary()
	{
		return "Remove";
	}

	protected virtual string _GetTemplateForActionDialogRemovePhoneSecondary()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDialogSend()
	{
		return "Send";
	}

	protected virtual string _GetTemplateForActionDialogSuccess()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogUpdate()
	{
		return "Update";
	}

	protected virtual string _GetTemplateForActionDialogVerifyEmailOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogVerifyEmailPrimary()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForActionDialogVerifyEmailRetry()
	{
		return "Retry";
	}

	protected virtual string _GetTemplateForActionDialogVerifyPhonePrimary()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForActionDialogVerifyPhoneResendLink()
	{
		return "Resend Code";
	}

	protected virtual string _GetTemplateForActionDialogVerifyPhoneSecondary()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionDialogYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForActionHide()
	{
		return "Hide";
	}

	protected virtual string _GetTemplateForActionJoin()
	{
		return "Join";
	}

	protected virtual string _GetTemplateForActionJoinBuildersClub()
	{
		return "Join Builders Club";
	}

	protected virtual string _GetTemplateForActionSave()
	{
		return "Save";
	}

	protected virtual string _GetTemplateForActionShow()
	{
		return "Show";
	}

	protected virtual string _GetTemplateForActionSignoutAllSessions()
	{
		return "Sign out";
	}

	protected virtual string _GetTemplateForActionSocialDisconnect()
	{
		return "Disconnect";
	}

	protected virtual string _GetTemplateForActionSuccessDialogButtonText()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionUnblock()
	{
		return "Unblock";
	}

	protected virtual string _GetTemplateForActionUpgradeMembership()
	{
		return "Upgrade Membership";
	}

	protected virtual string _GetTemplateForDescriptionAccountControls()
	{
		return "You can setup account restrictions on this account to restrict access to account settings and uncurated content";
	}

	/// <summary>
	/// Key: "Description.AccountEmailRevertEmail.From"
	/// From address for account email revert email that is sent out to the old account when the new account email is verified.
	/// English String: "{escapeLiteralStart}Roblox Email Reset{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionAccountEmailRevertEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox Email Reset{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionAccountEmailRevertEmailFrom()
	{
		return "{escapeLiteralStart}Roblox Email Reset{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.AccountEmailRevertEmail.HtmlBody"
	/// Html body for account email revert email that is sent out to the old account when the new account email is verified.
	/// English String: "Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{aTagWithHref}{revertAccountEmailLinkWithTicket}{hrefEnd}{revertAccountEmailLink}{aTagEnd}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}."
	/// </summary>
	public virtual string DescriptionAccountEmailRevertEmailHtmlBody(string lineBreak, string username, string oldEmailAddress, string newEmailAddress, string aTagWithHref, string revertAccountEmailLinkWithTicket, string hrefEnd, string revertAccountEmailLink, string aTagEnd, string robloxInfoEmailAddress)
	{
		return $"Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{aTagWithHref}{revertAccountEmailLinkWithTicket}{hrefEnd}{revertAccountEmailLink}{aTagEnd}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}.";
	}

	protected virtual string _GetTemplateForDescriptionAccountEmailRevertEmailHtmlBody()
	{
		return "Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{aTagWithHref}{revertAccountEmailLinkWithTicket}{hrefEnd}{revertAccountEmailLink}{aTagEnd}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}.";
	}

	/// <summary>
	/// Key: "Description.AccountEmailRevertEmail.PlainBody"
	/// Plain body for account email revert email that is sent out to the old account when the new account email is verified.
	/// English String: "Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{revertAccountEmailLink}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}."
	/// </summary>
	public virtual string DescriptionAccountEmailRevertEmailPlainBody(string lineBreak, string username, string oldEmailAddress, string newEmailAddress, string revertAccountEmailLink, string robloxInfoEmailAddress)
	{
		return $"Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{revertAccountEmailLink}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}.";
	}

	protected virtual string _GetTemplateForDescriptionAccountEmailRevertEmailPlainBody()
	{
		return "Dear Roblox user,{lineBreak}{lineBreak}We noticed that you have changed the email address for your {username} account from {oldEmailAddress} to {newEmailAddress}. Just in case you really didn't mean to change it, or you think someone else changed it by mistake, then we need you to click this link{lineBreak}{revertAccountEmailLink}{lineBreak}to change the email back. You will also need to enter a new password. That way we will know for sure that your account is secure and safe.{lineBreak}{lineBreak}If you are happy with your new email address on Roblox you don't have to do anything! It's already set up.{lineBreak}Please do not reply to this message. If you have any questions please email {robloxInfoEmailAddress}.";
	}

	protected virtual string _GetTemplateForDescriptionAccountEmailRevertEmailSubject()
	{
		return "Roblox Email Reset";
	}

	/// <summary>
	/// Key: "Description.AccountRestrictionsEnabled"
	/// English String: "This account can only access our curated content on the platform. Additionally, contact settings (under the {linkStart}Privacy{linkEnd} page) will be set to Off."
	/// </summary>
	public virtual string DescriptionAccountRestrictionsEnabled(string linkStart, string linkEnd)
	{
		return $"This account can only access our curated content on the platform. Additionally, contact settings (under the {linkStart}Privacy{linkEnd} page) will be set to Off.";
	}

	protected virtual string _GetTemplateForDescriptionAccountRestrictionsEnabled()
	{
		return "This account can only access our curated content on the platform. Additionally, contact settings (under the {linkStart}Privacy{linkEnd} page) will be set to Off.";
	}

	/// <summary>
	/// Key: "Description.BlockedLimitMessage"
	/// English String: "You're blocking {totalBlockedCount} of {maxBlockedCount} users allowed:"
	/// </summary>
	public virtual string DescriptionBlockedLimitMessage(string totalBlockedCount, string maxBlockedCount)
	{
		return $"You're blocking {totalBlockedCount} of {maxBlockedCount} users allowed:";
	}

	protected virtual string _GetTemplateForDescriptionBlockedLimitMessage()
	{
		return "You're blocking {totalBlockedCount} of {maxBlockedCount} users allowed:";
	}

	/// <summary>
	/// Key: "Description.ContactSetting"
	/// English String: "Contact Settings are locked because Account Restrictions (under {linkStart}Security{linkEnd} page) is enabled"
	/// </summary>
	public virtual string DescriptionContactSetting(string linkStart, string linkEnd)
	{
		return $"Contact Settings are locked because Account Restrictions (under {linkStart}Security{linkEnd} page) is enabled";
	}

	protected virtual string _GetTemplateForDescriptionContactSetting()
	{
		return "Contact Settings are locked because Account Restrictions (under {linkStart}Security{linkEnd} page) is enabled";
	}

	protected virtual string _GetTemplateForDescriptionDesktopPush1()
	{
		return "See notifications on this computer even when Roblox is closed.";
	}

	protected virtual string _GetTemplateForDescriptionDesktopPush2()
	{
		return "To see notifications, you may be prompted to turn on push notifications on your browser.";
	}

	protected virtual string _GetTemplateForDescriptionDesktopPush3()
	{
		return "Desktop notifications for this device.";
	}

	protected virtual string _GetTemplateForDescriptionDialogAddPhone()
	{
		return "Please confirm your country code and enter your phone number. We will send a text message to complete verification. (Note: Text messaging charges may apply)";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeEmailConfirmation()
	{
		return "An email has been sent for verification";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeEmailWarning()
	{
		return "The account email will not change until the new email has been verified.";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangePasswordConfirmation()
	{
		return "You have successfully changed your password.";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeUsernameDisclaimer()
	{
		return "Important: Original account creation date will carry over to your new username.";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeUsernameForFree()
	{
		return "Change username once for free.";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeUsernameHistory()
	{
		return "Previous forum posts will appear under your old username and will NOT carry over to your new username.";
	}

	/// <summary>
	/// Key: "Description.Dialog.ChangeUsernamePageText"
	/// English String: "Change username for {robuxIcon} {price}?"
	/// </summary>
	public virtual string DescriptionDialogChangeUsernamePageText(string robuxIcon, string price)
	{
		return $"Change username for {robuxIcon} {price}?";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeUsernamePageText()
	{
		return "Change username for {robuxIcon} {price}?";
	}

	protected virtual string _GetTemplateForDescriptionDialogChangeUsernameTitle()
	{
		return "Change Username";
	}

	protected virtual string _GetTemplateForDescriptionDialogEditPhoneWarning()
	{
		return "The phone number will not change until the new phone number has been verified.";
	}

	protected virtual string _GetTemplateForDescriptionDialogEmailProvideAndVerifyWarning()
	{
		return "You must provide and verify your email before you can change your username.";
	}

	protected virtual string _GetTemplateForDescriptionDialogEmailVerificationSent()
	{
		return "Thanks! Your verification email has been sent.";
	}

	protected virtual string _GetTemplateForDescriptionDialogEmailVerifyWarning()
	{
		return "You must verify your email before you can change your username.";
	}

	protected virtual string _GetTemplateForDescriptionDialogFacebookDisconnectWarning()
	{
		return "Please add password to secure your account before disconnecting from Facebook.";
	}

	/// <summary>
	/// Key: "Description.Dialog.InsufficientFundsWarning"
	/// English String: "You need {robuxToBuy} more to change your username. Would you like to buy more Robux?"
	/// </summary>
	public virtual string DescriptionDialogInsufficientFundsWarning(string robuxToBuy)
	{
		return $"You need {robuxToBuy} more to change your username. Would you like to buy more Robux?";
	}

	protected virtual string _GetTemplateForDescriptionDialogInsufficientFundsWarning()
	{
		return "You need {robuxToBuy} more to change your username. Would you like to buy more Robux?";
	}

	protected virtual string _GetTemplateForDescriptionDialogMissingEmailAccountPin()
	{
		return "You must provide and verify your email before you can add an Account PIN.";
	}

	protected virtual string _GetTemplateForDescriptionDialogMissingEmailTwoStepVerification()
	{
		return "You must provide and verify your email before you can enable 2 Step Verification.";
	}

	protected virtual string _GetTemplateForDescriptionDialogMissingEmailUsername()
	{
		return "You must provide and verify your email before you can change your username.";
	}

	protected virtual string _GetTemplateForDescriptionDialogPinUnlock()
	{
		return "Enter the Account PIN attached to your account";
	}

	/// <summary>
	/// Key: "Description.Dialog.RemovePhoneWarning"
	/// English String: "Are you sure that you want to remove your phone number which ends with {phoneLast4}?"
	/// </summary>
	public virtual string DescriptionDialogRemovePhoneWarning(string phoneLast4)
	{
		return $"Are you sure that you want to remove your phone number which ends with {phoneLast4}?";
	}

	protected virtual string _GetTemplateForDescriptionDialogRemovePhoneWarning()
	{
		return "Are you sure that you want to remove your phone number which ends with {phoneLast4}?";
	}

	protected virtual string _GetTemplateForDescriptionDialogUnverifiedEmailAccountPin()
	{
		return "You must verify your email before you can add an Account PIN.";
	}

	protected virtual string _GetTemplateForDescriptionDialogUnverifiedEmailTwoStepVerification()
	{
		return "You must verify your email before you can enable 2 Step Verification.";
	}

	protected virtual string _GetTemplateForDescriptionDialogUnverifiedEmailUsername()
	{
		return "You must verify your email before you can change your username.";
	}

	protected virtual string _GetTemplateForDescriptionFastTrack()
	{
		return "You have been enrolled in the Fast Track reporting program for making good abuse reports.  Your abuse reports are now Fast Tracked for review.  Stay in the program by continuing to make good abuse reports. Thank you for helping to make Roblox a positive experience!";
	}

	protected virtual string _GetTemplateForDescriptionFastTrackStatistics()
	{
		return "Statistics";
	}

	protected virtual string _GetTemplateForDescriptionHelpTextDescription()
	{
		return "Do not provide any details that can be used to identify you outside Roblox.";
	}

	protected virtual string _GetTemplateForDescriptionHelpTextFastTrackAccuracy()
	{
		return "Accuracy is how often moderation agreed with abuse reports. Your number will show after you submit several reports. 'Everyone' means all of the Fast Track members as a group.";
	}

	protected virtual string _GetTemplateForDescriptionHelpTextPrivacyMode()
	{
		return "Updating age to under 13 will enable Privacy Mode.";
	}

	protected virtual string _GetTemplateForDescriptionHoverTextChangePassword()
	{
		return "Change Password";
	}

	protected virtual string _GetTemplateForDescriptionHoverTextChangeUsername()
	{
		return "Change Username";
	}

	protected virtual string _GetTemplateForDescriptionHoverTextUpdateEmail()
	{
		return "Update Email";
	}

	protected virtual string _GetTemplateForDescriptionMembershipHelp()
	{
		return "For billing and payment questions: info@roblox.com";
	}

	protected virtual string _GetTemplateForDescriptionMembershipStatus()
	{
		return "You're not a member yet. Join Builders Club today!";
	}

	protected virtual string _GetTemplateForDescriptionMembershipStatusRobloxPremium()
	{
		return "You're not a member yet. Join Roblox Premium today!";
	}

	protected virtual string _GetTemplateForDescriptionMobilePush1()
	{
		return "See notifications on your devices' home screens. You can turn them on or off from the Roblox app.";
	}

	protected virtual string _GetTemplateForDescriptionMobilePush2()
	{
		return "Mobile push notifications for this device.";
	}

	protected virtual string _GetTemplateForDescriptionNotificationStream1()
	{
		return "See notifications in my stream. Click the notifications icon in the top bar to view these notifications.";
	}

	protected virtual string _GetTemplateForDescriptionNotificationStream2()
	{
		return "After you turn off a notification type, we won't send you any new notifications of that type.";
	}

	protected virtual string _GetTemplateForDescriptionRenevalFromWebsiteOnly()
	{
		return "Note: If you would like to cancel your renewal membership, please log in from the website.";
	}

	protected virtual string _GetTemplateForDescriptionSuccessDialogMessage()
	{
		return "Saved  Successfully!";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationSecondary()
	{
		return "A verified email is required";
	}

	/// <summary>
	/// Key: "Description.TwoStepverificationSecondaryEnabled"
	/// English String: "When you log in from a new device, codes will be sent to {email}"
	/// </summary>
	public virtual string DescriptionTwoStepverificationSecondaryEnabled(string email)
	{
		return $"When you log in from a new device, codes will be sent to {email}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepverificationSecondaryEnabled()
	{
		return "When you log in from a new device, codes will be sent to {email}";
	}

	/// <summary>
	/// Key: "Description.UsernameChangeEmail.Body"
	/// Body for username change email that is sent out on a successful change of username
	/// English String: "Hello Roblox user, {lineBreaks}Your username has recently been changed from {oldUsername} to {newUsername}. If you did not request a username change, please email {robloxInfoEmailAddress}."
	/// </summary>
	public virtual string DescriptionUsernameChangeEmailBody(string lineBreaks, string oldUsername, string newUsername, string robloxInfoEmailAddress)
	{
		return $"Hello Roblox user, {lineBreaks}Your username has recently been changed from {oldUsername} to {newUsername}. If you did not request a username change, please email {robloxInfoEmailAddress}.";
	}

	protected virtual string _GetTemplateForDescriptionUsernameChangeEmailBody()
	{
		return "Hello Roblox user, {lineBreaks}Your username has recently been changed from {oldUsername} to {newUsername}. If you did not request a username change, please email {robloxInfoEmailAddress}.";
	}

	/// <summary>
	/// Key: "Description.UsernameChangeEmail.From"
	/// From address for username change email that is sent out on a successful change of username
	/// English String: "{escapeLiteralStart}Roblox Username Change{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionUsernameChangeEmailFrom(string escapeLiteralStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteralStart}Roblox Username Change{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionUsernameChangeEmailFrom()
	{
		return "{escapeLiteralStart}Roblox Username Change{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionUsernameChangeEmailSubject()
	{
		return "Roblox Username Change";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.From.Over13"
	/// From address for verification email that is sent out when an over 13 user adds an email to the account
	/// English String: "{escapeLiteratStart}Roblox Email Verification{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionVerificationEmailFromOver13(string escapeLiteratStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteratStart}Roblox Email Verification{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailFromOver13()
	{
		return "{escapeLiteratStart}Roblox Email Verification{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.From.Under13"
	/// From address for verification email that is sent out when an under 13 user adds an email to the account
	/// English String: "{escapeLiteratStart}Roblox Account Authorization{escapeLiteralEnd} {fromEmailAddress}"
	/// </summary>
	public virtual string DescriptionVerificationEmailFromUnder13(string escapeLiteratStart, string escapeLiteralEnd, string fromEmailAddress)
	{
		return $"{escapeLiteratStart}Roblox Account Authorization{escapeLiteralEnd} {fromEmailAddress}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailFromUnder13()
	{
		return "{escapeLiteratStart}Roblox Account Authorization{escapeLiteralEnd} {fromEmailAddress}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.HtmlBody.Over13	"
	/// Email body of verification email that is sent out when an over 13 user adds an email to the account
	/// English String: "Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the button below to complete the verification process.{lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{targetBlank}{buttonStart}Verify Email{buttonEnd}{aTagEnd}"
	/// </summary>
	public virtual string DescriptionVerificationEmailHtmlBodyOver13(string lineBreak, string username, string aTagStartWithHref, string verificationLink, string targetBlank, string buttonStart, string buttonEnd, string aTagEnd)
	{
		return $"Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the button below to complete the verification process.{lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{targetBlank}{buttonStart}Verify Email{buttonEnd}{aTagEnd}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailHtmlBodyOver13()
	{
		return "Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the button below to complete the verification process.{lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{targetBlank}{buttonStart}Verify Email{buttonEnd}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.HtmlBody.Under13"
	/// Email body of verification email that is sent out when an under 13 user adds an email to the account
	/// English String: "Hello,{lineBreak}{lineBreak}Your child created the account {boldTagStart}{username}{boldTagEnd} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below: {lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{hrefEnd}{buttonStart}Verify Email{buttonEnd}{aTagEnd}{lineBreak}{lineBreak}{boldTagStart}About Roblox{boldTagEnd}{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {aTagStartWithHref}{parentalPageLink}{hrefEnd}{parentalPageLink}{aTagEnd}{lineBreak}{lineBreak}Roblox also offers {boldTagStart}parental controls{boldTagEnd}. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}"
	/// </summary>
	public virtual string DescriptionVerificationEmailHtmlBodyUnder13(string lineBreak, string boldTagStart, string username, string boldTagEnd, string aTagStartWithHref, string verificationLink, string hrefEnd, string buttonStart, string buttonEnd, string aTagEnd, string parentalPageLink, string accountSecurityLink, string accountPrivacyLink, string supportPageLink, string privacyPageLink, string robloxWebsiteLink)
	{
		return $"Hello,{lineBreak}{lineBreak}Your child created the account {boldTagStart}{username}{boldTagEnd} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below: {lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{hrefEnd}{buttonStart}Verify Email{buttonEnd}{aTagEnd}{lineBreak}{lineBreak}{boldTagStart}About Roblox{boldTagEnd}{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {aTagStartWithHref}{parentalPageLink}{hrefEnd}{parentalPageLink}{aTagEnd}{lineBreak}{lineBreak}Roblox also offers {boldTagStart}parental controls{boldTagEnd}. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailHtmlBodyUnder13()
	{
		return "Hello,{lineBreak}{lineBreak}Your child created the account {boldTagStart}{username}{boldTagEnd} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below: {lineBreak}{lineBreak}{aTagStartWithHref}{verificationLink}{hrefEnd}{buttonStart}Verify Email{buttonEnd}{aTagEnd}{lineBreak}{lineBreak}{boldTagStart}About Roblox{boldTagEnd}{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {aTagStartWithHref}{parentalPageLink}{hrefEnd}{parentalPageLink}{aTagEnd}{lineBreak}{lineBreak}Roblox also offers {boldTagStart}parental controls{boldTagEnd}. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.HtmlBody.Under13.Part2"
	/// Email body of verification email that is sent out when an under 13 user adds an email to the account part 2
	/// English String: "You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}"
	/// </summary>
	public virtual string DescriptionVerificationEmailHtmlBodyUnder13Part2(string lineBreak, string aTagStartWithHref, string accountSecurityLink, string hrefEnd, string aTagEnd, string accountPrivacyLink, string boldTagStart, string boldTagEnd, string supportPageLink, string privacyPageLink, string robloxWebsiteLink)
	{
		return $"You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailHtmlBodyUnder13Part2()
	{
		return "You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {aTagStartWithHref}{accountSecurityLink}{hrefEnd}{accountSecurityLink}{aTagEnd}.{lineBreak}{lineBreak}To change chat settings, please visit: {aTagStartWithHref}{accountPrivacyLink}{hrefEnd}{accountPrivacyLink}{aTagEnd}.{lineBreak}{lineBreak}{boldTagStart}Privacy{boldTagEnd}{lineBreak}{lineBreak}You may remove your child's account by contacting customer service at {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {aTagStartWithHref}{privacyPageLink}{hrefEnd}{privacyPageLink}{aTagEnd}.{lineBreak}{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team {lineBreak}{lineBreak} Do not reply to this email directly. {lineBreak}{lineBreak} {aTagStartWithHref}{robloxWebsiteLink}{hrefEnd}{robloxWebsiteLink}{aTagEnd} {lineBreak}{lineBreak} {aTagStartWithHref}{supportPageLink}{hrefEnd}{supportPageLink}{aTagEnd}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.PlainBody.Over13"
	/// Email body of verification email that is sent out when an over 13 user adds an email to the account
	/// English String: "Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the link below to complete the verification process{lineBreak}{verificationLink}.\n"
	/// </summary>
	public virtual string DescriptionVerificationEmailPlainBodyOver13(string lineBreak, string username, string verificationLink)
	{
		return $"Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the link below to complete the verification process{lineBreak}{verificationLink}.\n";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailPlainBodyOver13()
	{
		return "Dear Roblox user,{lineBreak}{lineBreak}We are pleased that you have chosen to secure your {username} account by providing an email address.{lineBreak}By verifying the email address associated with your Roblox account, you enable a higher level of account security.{lineBreak}Please click the link below to complete the verification process{lineBreak}{verificationLink}.\n";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.PlainBody.Under13"
	/// Email body of verification email that is sent out when an under 13 user adds an email to the account
	/// English String: "Hello,{lineBreak}{lineBreak}Your child created the account {username} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below:{lineBreak}{lineBreak}{verificationLink}{lineBreak}{lineBreak}About Roblox{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {parentalPageLink}{lineBreak}{lineBreak}Roblox also offers parental controls. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {accountSecurityLink}{lineBreak}{lineBreak}To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}"
	/// </summary>
	public virtual string DescriptionVerificationEmailPlainBodyUnder13(string lineBreak, string username, string verificationLink, string parentalPageLink, string accountSecurityLink, string chatPrivacyLink, string supportPageLink, string privacyPageLink, string robloxWebiteLink)
	{
		return $"Hello,{lineBreak}{lineBreak}Your child created the account {username} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below:{lineBreak}{lineBreak}{verificationLink}{lineBreak}{lineBreak}About Roblox{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {parentalPageLink}{lineBreak}{lineBreak}Roblox also offers parental controls. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {accountSecurityLink}{lineBreak}{lineBreak}To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailPlainBodyUnder13()
	{
		return "Hello,{lineBreak}{lineBreak}Your child created the account {username} on Roblox, an online entertainment platform that enables kids to imagine, create, and play together in immersive, user-generated 3D worlds. Our platform also provides a free development tool called “Roblox Studio” that allows users to create anything they imagine, from simple drag-and-drop building experiences to complex multiplayer games. Millions of kids have used Roblox to imagine what it’s like to create the ultimate theme park, compete as a professional race car driver, star in a fashion show, or simply build a dream home and hang out with friends.{lineBreak}{lineBreak}This email is to inform you that your child has provided us with a username, date of birth, and a parent’s email address. The parent’s email address is only used for account management, password resets if the child forgets their password, and to notify parents of changes to the child’s account access. To verify your email address, please click the button below:{lineBreak}{lineBreak}{verificationLink}{lineBreak}{lineBreak}About Roblox{lineBreak}{lineBreak}Roblox is dedicated to building an enjoyable, family-friendly environment. We are constantly evolving our safety features and working with digital safety experts to ensure that all players have a safe, comfortable place to play, chat, and collaborate on creative projects. We recommend that you visit our Parent’s Guide to help yourself get acquainted with our platform and find helpful tips for creating a positive experience for your kids on Roblox: {parentalPageLink}{lineBreak}{lineBreak}Roblox also offers parental controls. Parents can enable a parent PIN and change their child’s communication and chat settings. You can find these controls by visiting the security and privacy tabs in the account settings while logged into your child’s account.{lineBreak}{lineBreak}To add a parent PIN, please visit: {accountSecurityLink}{lineBreak}{lineBreak}To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}";
	}

	/// <summary>
	/// Key: "Description.VerificationEmail.PlainBody.Under13.Part2"
	/// Email body of verification email that is sent out when an under 13 user adds an email to the account part 2
	/// English String: "To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}"
	/// </summary>
	public virtual string DescriptionVerificationEmailPlainBodyUnder13Part2(string chatPrivacyLink, string lineBreak, string supportPageLink, string privacyPageLink, string robloxWebiteLink)
	{
		return $"To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailPlainBodyUnder13Part2()
	{
		return "To change chat settings, please visit: {chatPrivacyLink} {lineBreak}{lineBreak}Privacy{lineBreak}{lineBreak} You may remove your child's account by contacting customer service at {supportPageLink}. Your email will not be used for any other purpose, disclosed to third parties, or combined with any other personal information collected from your child. Please review our privacy policy for more information at {privacyPageLink}.{lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team{lineBreak}Do not reply to this email directly.{lineBreak}{robloxWebiteLink}{lineBreak}{supportPageLink}";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailSubjectOver13()
	{
		return "Roblox Email Verification";
	}

	protected virtual string _GetTemplateForDescriptionVerificationEmailSubjectUnder13()
	{
		return "Roblox Account Authorization";
	}

	protected virtual string _GetTemplateForExampleDescription()
	{
		return "Describe yourself(1000 character limit)";
	}

	protected virtual string _GetTemplateForExampleFacebook()
	{
		return "e.g. www.facebook.com/Roblox";
	}

	protected virtual string _GetTemplateForExampleGooglePlus()
	{
		return "e.g. http://plus.google.com/profileId";
	}

	protected virtual string _GetTemplateForExampleTwitch()
	{
		return "e.g. www.twitch.tv/roblox/profile";
	}

	protected virtual string _GetTemplateForExampleTwitter()
	{
		return "e.g. @Roblox";
	}

	protected virtual string _GetTemplateForExampleYouTube()
	{
		return "e.g. www.youtube.com/user/roblox";
	}

	protected virtual string _GetTemplateForHeadingAccountControls()
	{
		return "What are Account Controls?";
	}

	protected virtual string _GetTemplateForHeadingAccountInfo()
	{
		return "Account Info";
	}

	protected virtual string _GetTemplateForHeadingBilling()
	{
		return "Billing";
	}

	protected virtual string _GetTemplateForHeadingBlockedUsers()
	{
		return "Blocked Users";
	}

	protected virtual string _GetTemplateForHeadingContactSettings()
	{
		return "Contact Settings";
	}

	protected virtual string _GetTemplateForHeadingDesktopPush()
	{
		return "Desktop Push";
	}

	protected virtual string _GetTemplateForHeadingDialogAddPassword()
	{
		return "Add Password";
	}

	protected virtual string _GetTemplateForHeadingDialogAddPhone()
	{
		return "Add Phone";
	}

	protected virtual string _GetTemplateForHeadingDialogChangeEmail()
	{
		return "Change My Email";
	}

	protected virtual string _GetTemplateForHeadingDialogChangeEmailConfirmation()
	{
		return "Email Address Changed";
	}

	protected virtual string _GetTemplateForHeadingDialogChangePassword()
	{
		return "Change Password";
	}

	protected virtual string _GetTemplateForHeadingDialogChangePasswordConfirmation()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingDialogChangePasswordSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingDialogChangeUsername()
	{
		return "Change Username";
	}

	protected virtual string _GetTemplateForHeadingDialogDefaultError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForHeadingDialogDefaultSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingDialogEditPhone()
	{
		return "Edit Phone";
	}

	protected virtual string _GetTemplateForHeadingDialogInsufficientFunds()
	{
		return "Insufficient Funds";
	}

	protected virtual string _GetTemplateForHeadingDialogInvalidUsername()
	{
		return "Invalid Username";
	}

	protected virtual string _GetTemplateForHeadingDialogPinCreate()
	{
		return "Add PIN";
	}

	protected virtual string _GetTemplateForHeadingDialogPinCreateSuccessConfirmation()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingDialogPinUnlock()
	{
		return "Account PIN Required";
	}

	protected virtual string _GetTemplateForHeadingDialogRemovePhone()
	{
		return "Remove Phone";
	}

	protected virtual string _GetTemplateForHeadingDialogVerifiedEmailRequired()
	{
		return "Verified Email Required";
	}

	protected virtual string _GetTemplateForHeadingDialogVerifyEmail()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForHeadingDialogVerifyPhone()
	{
		return "Verify Phone";
	}

	protected virtual string _GetTemplateForHeadingFastTrack()
	{
		return "Fast Track";
	}

	protected virtual string _GetTemplateForHeadingMembershipStatus()
	{
		return "Membership status";
	}

	protected virtual string _GetTemplateForHeadingNotificationOptions()
	{
		return "Notify me when";
	}

	protected virtual string _GetTemplateForHeadingNotifications()
	{
		return "Notifications";
	}

	protected virtual string _GetTemplateForHeadingNotificationsActionWhen()
	{
		return "Notify me when";
	}

	protected virtual string _GetTemplateForHeadingNotificationsDesktopPush()
	{
		return "Desktop Push";
	}

	protected virtual string _GetTemplateForHeadingNotificationsMobilePush()
	{
		return "Mobile Push";
	}

	protected virtual string _GetTemplateForHeadingNotificationsStream()
	{
		return "Notification Stream";
	}

	protected virtual string _GetTemplateForHeadingNotificationStream()
	{
		return "Notification Stream";
	}

	protected virtual string _GetTemplateForHeadingOtherSettings()
	{
		return "Other Settings";
	}

	protected virtual string _GetTemplateForHeadingPageTitle()
	{
		return "My Settings";
	}

	protected virtual string _GetTemplateForHeadingPersonal()
	{
		return "Personal";
	}

	protected virtual string _GetTemplateForHeadingPin()
	{
		return "Account PIN";
	}

	protected virtual string _GetTemplateForHeadingPrivacySettings()
	{
		return "Privacy Settings";
	}

	protected virtual string _GetTemplateForHeadingRenevalDate()
	{
		return "Renewal date";
	}

	protected virtual string _GetTemplateForHeadingRestrictions()
	{
		return "Account Restrictions";
	}

	protected virtual string _GetTemplateForHeadingSecureSignOut()
	{
		return "Secure Sign Out";
	}

	protected virtual string _GetTemplateForHeadingSocialNetworks()
	{
		return "Social Networks";
	}

	protected virtual string _GetTemplateForHeadingSocialSignOn()
	{
		return "Social Sign On";
	}

	protected virtual string _GetTemplateForHeadingSuccessDialogTitle()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForHeadingTabAccountInfo()
	{
		return "Account Info";
	}

	protected virtual string _GetTemplateForHeadingTabBilling()
	{
		return "Billing";
	}

	protected virtual string _GetTemplateForHeadingTabFastTrack()
	{
		return "Fast Track";
	}

	protected virtual string _GetTemplateForHeadingTabNotifications()
	{
		return "Notifications";
	}

	protected virtual string _GetTemplateForHeadingTabPrivacy()
	{
		return "Privacy";
	}

	protected virtual string _GetTemplateForHeadingTabSecurity()
	{
		return "Security";
	}

	protected virtual string _GetTemplateForHeadingTransactions()
	{
		return "Transactions";
	}

	protected virtual string _GetTemplateForHeadingTwoStepVerification()
	{
		return "2 Step Verification";
	}

	protected virtual string _GetTemplateForHeadingXbox()
	{
		return "Xbox";
	}

	protected virtual string _GetTemplateForLabelAccountPinDisabled()
	{
		return "Account PIN is currently disabled";
	}

	protected virtual string _GetTemplateForLabelAccountPinEnabled()
	{
		return "Account PIN is currently enabled";
	}

	protected virtual string _GetTemplateForLabelAccountRestrictionDisabled()
	{
		return "Account Restrictions is currently disabled";
	}

	protected virtual string _GetTemplateForLabelAccountRestrictionEnabled()
	{
		return "Account Restrictions is currently enabled";
	}

	protected virtual string _GetTemplateForLabelAddEmail()
	{
		return "Add Email";
	}

	protected virtual string _GetTemplateForLabelAddEmailParent()
	{
		return "Add Parent's Email";
	}

	protected virtual string _GetTemplateForLabelAddPassword()
	{
		return "Add Password:";
	}

	protected virtual string _GetTemplateForLabelAddPhone()
	{
		return "Add Phone";
	}

	protected virtual string _GetTemplateForLabelAddPhoneLink()
	{
		return "Add Phone";
	}

	protected virtual string _GetTemplateForLabelBillingHelp()
	{
		return "For billing and payment questions:";
	}

	/// <summary>
	/// Key: "Label.BillingHelpWithLink"
	/// English String: "For billing and payment questions, please see the {aTagStartWithHref}{billingHelpPagesLink}{hrefEnd}billing help pages{aTagEnd}."
	/// </summary>
	public virtual string LabelBillingHelpWithLink(string aTagStartWithHref, string billingHelpPagesLink, string hrefEnd, string aTagEnd)
	{
		return $"For billing and payment questions, please see the {aTagStartWithHref}{billingHelpPagesLink}{hrefEnd}billing help pages{aTagEnd}.";
	}

	protected virtual string _GetTemplateForLabelBillingHelpWithLink()
	{
		return "For billing and payment questions, please see the {aTagStartWithHref}{billingHelpPagesLink}{hrefEnd}billing help pages{aTagEnd}.";
	}

	/// <summary>
	/// Key: "Label.BillingHistoryCardNumber"
	/// English String: "Ending in {lastFourCard}"
	/// </summary>
	public virtual string LabelBillingHistoryCardNumber(string lastFourCard)
	{
		return $"Ending in {lastFourCard}";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryCardNumber()
	{
		return "Ending in {lastFourCard}";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryCost()
	{
		return "Cost";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryDate()
	{
		return "Date";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryDescription()
	{
		return "Description";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryGeneralErrors()
	{
		return "Service is currently disabled, please try again later.";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryNoTransactions()
	{
		return "No Transactions";
	}

	protected virtual string _GetTemplateForLabelBillingHistoryPaymentType()
	{
		return "Payment Type";
	}

	protected virtual string _GetTemplateForLabelBirthday()
	{
		return "Birthday";
	}

	protected virtual string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	/// <summary>
	/// Key: "Label.BuildersClubJoin"
	/// English String: "You're not a member yet. Join {startSpan}Builders Club{endSpan} today!"
	/// </summary>
	public virtual string LabelBuildersClubJoin(string startSpan, string endSpan)
	{
		return $"You're not a member yet. Join {startSpan}Builders Club{endSpan} today!";
	}

	protected virtual string _GetTemplateForLabelBuildersClubJoin()
	{
		return "You're not a member yet. Join {startSpan}Builders Club{endSpan} today!";
	}

	protected virtual string _GetTemplateForLabelChangeYourUsername()
	{
		return "change your username";
	}

	protected virtual string _GetTemplateForLabelChooseLanguage()
	{
		return "Choose Language";
	}

	protected virtual string _GetTemplateForLabelClassicTheme()
	{
		return "Off";
	}

	protected virtual string _GetTemplateForLabelConnectAccount()
	{
		return "Connect account:";
	}

	protected virtual string _GetTemplateForLabelCountry()
	{
		return "Choose a Country/Region";
	}

	protected virtual string _GetTemplateForLabelCountryTitle()
	{
		return "Location";
	}

	protected virtual string _GetTemplateForLabelDarkTheme()
	{
		return "Dark";
	}

	protected virtual string _GetTemplateForLabelDialogAddEmailOver13()
	{
		return "Add My Email";
	}

	protected virtual string _GetTemplateForLabelDialogAddEmailUnder13()
	{
		return "Add Parent's Email";
	}

	protected virtual string _GetTemplateForLabelDialogAddPhoneField()
	{
		return "Phone Number";
	}

	protected virtual string _GetTemplateForLabelDialogAddPhonePassword()
	{
		return "Verify Account Password";
	}

	protected virtual string _GetTemplateForLabelDialogChangeEmailField()
	{
		return "Change My Email";
	}

	protected virtual string _GetTemplateForLabelDialogChangeEmailOver13()
	{
		return "Change My Email";
	}

	protected virtual string _GetTemplateForLabelDialogChangeEmailUnder13()
	{
		return "Change Parent's Email";
	}

	protected virtual string _GetTemplateForLabelDialogChangePasswordConfirm()
	{
		return "Confirm Password";
	}

	protected virtual string _GetTemplateForLabelDialogChangePasswordCurrent()
	{
		return "Current Password";
	}

	protected virtual string _GetTemplateForLabelDialogChangePasswordNew()
	{
		return "New Password";
	}

	protected virtual string _GetTemplateForLabelDialogChangeUsernameAccountPassword()
	{
		return "Account Password";
	}

	protected virtual string _GetTemplateForLabelDialogChangeUsernameField()
	{
		return "Desired Username (3-20 characters)";
	}

	protected virtual string _GetTemplateForLabelDialogConfirmPin()
	{
		return "Confirm your PIN";
	}

	/// <summary>
	/// Key: "Label.Dialog.CreatePin"
	/// English String: "Create a {digitCount}-digit PIN"
	/// </summary>
	public virtual string LabelDialogCreatePin(string digitCount)
	{
		return $"Create a {digitCount}-digit PIN";
	}

	protected virtual string _GetTemplateForLabelDialogCreatePin()
	{
		return "Create a {digitCount}-digit PIN";
	}

	protected virtual string _GetTemplateForLabelDialogEditPhoneCurrentNumber()
	{
		return "Current Number:";
	}

	protected virtual string _GetTemplateForLabelDialogEmailAddressChanged()
	{
		return "Email Address Changed";
	}

	protected virtual string _GetTemplateForLabelDialogEmailRequired()
	{
		return "Email Required";
	}

	protected virtual string _GetTemplateForLabelDialogVerifiedEmail()
	{
		return "Verified email:";
	}

	protected virtual string _GetTemplateForLabelDialogVerifyPassword()
	{
		return "Verify Account Password";
	}

	/// <summary>
	/// Key: "Label.Dialog.VerifyPhoneCode"
	/// English String: "Enter Code ({digitCount}-digit)"
	/// </summary>
	public virtual string LabelDialogVerifyPhoneCode(string digitCount)
	{
		return $"Enter Code ({digitCount}-digit)";
	}

	protected virtual string _GetTemplateForLabelDialogVerifyPhoneCode()
	{
		return "Enter Code ({digitCount}-digit)";
	}

	protected virtual string _GetTemplateForLabelDialogVerifyPhoneCodeLabel()
	{
		return "Enter the code we just sent to your phone";
	}

	protected virtual string _GetTemplateForLabelDialogVerifySms()
	{
		return "Verify SMS";
	}

	protected virtual string _GetTemplateForLabelDropDownCustom()
	{
		return "Custom";
	}

	protected virtual string _GetTemplateForLabelDropDownDefault()
	{
		return "Default";
	}

	protected virtual string _GetTemplateForLabelDropDownEveryone()
	{
		return "Everyone";
	}

	protected virtual string _GetTemplateForLabelDropDownFollowers()
	{
		return "Friends, Users I Follow, and Followers";
	}

	protected virtual string _GetTemplateForLabelDropDownFollowing()
	{
		return "Friends and Users I Follow";
	}

	protected virtual string _GetTemplateForLabelDropDownFriends()
	{
		return "Friends";
	}

	protected virtual string _GetTemplateForLabelDropDownHigh()
	{
		return "High";
	}

	protected virtual string _GetTemplateForLabelDropDownLow()
	{
		return "Low";
	}

	protected virtual string _GetTemplateForLabelDropDownMedium()
	{
		return "Medium";
	}

	protected virtual string _GetTemplateForLabelDropDownNone()
	{
		return "None";
	}

	protected virtual string _GetTemplateForLabelDropDownNoOne()
	{
		return "No one";
	}

	protected virtual string _GetTemplateForLabelDropDownOff()
	{
		return "Off";
	}

	protected virtual string _GetTemplateForLabelEmail()
	{
		return "Email address:";
	}

	protected virtual string _GetTemplateForLabelEmailParent()
	{
		return "Parent's Email address:";
	}

	protected virtual string _GetTemplateForLabelEmailVerificationPending()
	{
		return "Pending verification";
	}

	protected virtual string _GetTemplateForLabelExpirationDate()
	{
		return "Expiration date";
	}

	/// <summary>
	/// Key: "Label.ExpirationDateMessage"
	/// English String: "Expires on {startSpan}{expirationDate}{endSpan}"
	/// </summary>
	public virtual string LabelExpirationDateMessage(string startSpan, string expirationDate, string endSpan)
	{
		return $"Expires on {startSpan}{expirationDate}{endSpan}";
	}

	protected virtual string _GetTemplateForLabelExpirationDateMessage()
	{
		return "Expires on {startSpan}{expirationDate}{endSpan}";
	}

	protected virtual string _GetTemplateForLabelFacebook()
	{
		return "Facebook:";
	}

	protected virtual string _GetTemplateForLabelFastTrackAccuracy()
	{
		return "Accuracy";
	}

	protected virtual string _GetTemplateForLabelFastTrackAllFastTrackMembers()
	{
		return "Everyone";
	}

	protected virtual string _GetTemplateForLabelFastTrackReportMonth()
	{
		return "Month";
	}

	protected virtual string _GetTemplateForLabelFastTrackReportYear()
	{
		return "Year";
	}

	protected virtual string _GetTemplateForLabelFastTrackStatistics()
	{
		return "Statistics";
	}

	protected virtual string _GetTemplateForLabelFastTrackYou()
	{
		return "You";
	}

	protected virtual string _GetTemplateForLabelGender()
	{
		return "Gender";
	}

	protected virtual string _GetTemplateForLabelGooglePlus()
	{
		return "Google+:";
	}

	protected virtual string _GetTemplateForLabelLightTheme()
	{
		return "Light";
	}

	protected virtual string _GetTemplateForLabelLocaleTitle()
	{
		return "Language";
	}

	/// <summary>
	/// Key: "Label.MembershipName"
	/// English String: "{startSpan}Builders Club{endSpan} membership"
	/// </summary>
	public virtual string LabelMembershipName(string startSpan, string endSpan)
	{
		return $"{startSpan}Builders Club{endSpan} membership";
	}

	protected virtual string _GetTemplateForLabelMembershipName()
	{
		return "{startSpan}Builders Club{endSpan} membership";
	}

	protected virtual string _GetTemplateForLabelMembershipStatusRobloxPremium()
	{
		return "You're not a member yet. Join Roblox Premium today!";
	}

	protected virtual string _GetTemplateForLabelNotificationsAddedToPrivateServer()
	{
		return "I am invited to a VIP server";
	}

	protected virtual string _GetTemplateForLabelNotificationsChat()
	{
		return "Someone chats with me";
	}

	protected virtual string _GetTemplateForLabelNotificationsConversationUniverseChanged()
	{
		return "Someone pins a new game to play together";
	}

	protected virtual string _GetTemplateForLabelNotificationsDeveloperMetricsAvailable()
	{
		return "Analytics report becomes available";
	}

	protected virtual string _GetTemplateForLabelNotificationsFriendRequestAccepted()
	{
		return "Someone accepts my friend request";
	}

	protected virtual string _GetTemplateForLabelNotificationsFriendRequestReceived()
	{
		return "I receive a friend request";
	}

	protected virtual string _GetTemplateForLabelNotificationsGameUpdate()
	{
		return "I receive update notifications";
	}

	protected virtual string _GetTemplateForLabelNotificationsPartyInvited()
	{
		return "Someone invites me to a party";
	}

	protected virtual string _GetTemplateForLabelNotificationsPartyJoined()
	{
		return "Someone joins a party I'm in";
	}

	protected virtual string _GetTemplateForLabelNotificationsPrivateMessage()
	{
		return "I receive a private message";
	}

	protected virtual string _GetTemplateForLabelNotificationsTeamCreateInvite()
	{
		return "Someone invites me to edit a game";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Password:";
	}

	protected virtual string _GetTemplateForLabelPhone()
	{
		return "Phone Number:";
	}

	protected virtual string _GetTemplateForLabelPinTimeMins()
	{
		return "min";
	}

	protected virtual string _GetTemplateForLabelPinTimeRemaining()
	{
		return "Time Remaining";
	}

	protected virtual string _GetTemplateForLabelPinTimeSecs()
	{
		return "sec";
	}

	/// <summary>
	/// Key: "Label.PremiumClub"
	/// English String: "Roblox Premium {amount}"
	/// </summary>
	public virtual string LabelPremiumClub(string amount)
	{
		return $"Roblox Premium {amount}";
	}

	protected virtual string _GetTemplateForLabelPremiumClub()
	{
		return "Roblox Premium {amount}";
	}

	protected virtual string _GetTemplateForLabelPreviousUsernames()
	{
		return "Previous usernames:";
	}

	protected virtual string _GetTemplateForLabelPrivacyMode()
	{
		return "Privacy Mode";
	}

	protected virtual string _GetTemplateForLabelRenevalDate()
	{
		return "Renewal date";
	}

	/// <summary>
	/// Key: "Label.RenevalDateMessage"
	/// English String: "Automatically renew on {startSpan}{expirationDate}{endSpan}."
	/// </summary>
	public virtual string LabelRenevalDateMessage(string startSpan, string expirationDate, string endSpan)
	{
		return $"Automatically renew on {startSpan}{expirationDate}{endSpan}.";
	}

	protected virtual string _GetTemplateForLabelRenevalDateMessage()
	{
		return "Automatically renew on {startSpan}{expirationDate}{endSpan}.";
	}

	/// <summary>
	/// Key: "Label.RobloxPremiumClub"
	/// English String: "Roblox Premium {amount}"
	/// </summary>
	public virtual string LabelRobloxPremiumClub(string amount)
	{
		return $"Roblox Premium {amount}";
	}

	protected virtual string _GetTemplateForLabelRobloxPremiumClub()
	{
		return "Roblox Premium {amount}";
	}

	/// <summary>
	/// Key: "Label.RobuxProductName"
	/// The robux package name
	/// English String: "{amount} Robux"
	/// </summary>
	public virtual string LabelRobuxProductName(string amount)
	{
		return $"{amount} Robux";
	}

	protected virtual string _GetTemplateForLabelRobuxProductName()
	{
		return "{amount} Robux";
	}

	protected virtual string _GetTemplateForLabelSignOutAllSessions()
	{
		return "Sign out of all other sessions";
	}

	protected virtual string _GetTemplateForLabelSocialLinksVisibility()
	{
		return "Visible to:";
	}

	/// <summary>
	/// Key: "Label.SocialUsername"
	/// English String: "Connected as {socialUsername}"
	/// </summary>
	public virtual string LabelSocialUsername(string socialUsername)
	{
		return $"Connected as {socialUsername}";
	}

	protected virtual string _GetTemplateForLabelSocialUsername()
	{
		return "Connected as {socialUsername}";
	}

	protected virtual string _GetTemplateForLabelThemeTitle()
	{
		return "Theme";
	}

	protected virtual string _GetTemplateForLabelToolTipContactSettings()
	{
		return "Custom - Control your own settings. Default - Enable chat and messages with Friends. Off - Disables chat and messages.";
	}

	protected virtual string _GetTemplateForLabelToolTipPinLocked()
	{
		return "All settings are locked. To edit, please unlock with your PIN";
	}

	protected virtual string _GetTemplateForLabelToolTipPinUnlocked()
	{
		return "Click to lock your Settings page";
	}

	protected virtual string _GetTemplateForLabelToolTipPrivacyMode()
	{
		return "Click here for more information";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanChatInApp()
	{
		return "This setting controls who this user will be allowed to chat with in the app and on the web (separate from in game). The setting also prevents this user from posting on Forums and group walls.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanChatInGame()
	{
		return "This setting controls who this user will be allowed to chat with in game.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanFindMeByPhone()
	{
		return "This setting controls who can find you using the phone number you provided.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanInviteVIP()
	{
		return "This setting controls who can join this user in VIP servers - servers that can only be joined by invitation of the server owner.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanJoinGame()
	{
		return "This setting controls who can see which game I'm in and join me in my server. Selecting no one means no one can follow me into my specific server, but I will be playing with other users.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanMessageMe()
	{
		return "This setting controls who this user can receive messages from in their messages inbox.";
	}

	protected virtual string _GetTemplateForLabelToolTipWhoCanSeeInventory()
	{
		return "This setting controls who can see your inventory.";
	}

	protected virtual string _GetTemplateForLabelTradeFilter()
	{
		return "Trade quality filter";
	}

	protected virtual string _GetTemplateForLabelTwitch()
	{
		return "Twitch";
	}

	protected virtual string _GetTemplateForLabelTwitter()
	{
		return "Twitter:";
	}

	protected virtual string _GetTemplateForLabelTwoStepEmail()
	{
		return "enable 2 Step Verification";
	}

	protected virtual string _GetTemplateForLabelTwoStepPrerequisite()
	{
		return "A verified email is required.";
	}

	protected virtual string _GetTemplateForLabelTwoStepVerification()
	{
		return "Improve your account security. A code will be required when you login from a new device.";
	}

	protected virtual string _GetTemplateForLabelTwoStepVerificationEnabled()
	{
		return "Your account is protected!";
	}

	protected virtual string _GetTemplateForLabelUpdateEmail()
	{
		return "Update Email";
	}

	protected virtual string _GetTemplateForLabelUpdatePhone()
	{
		return "Update Phone";
	}

	protected virtual string _GetTemplateForLabelUseDeviceLanguage()
	{
		return "Use Device Language";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username:";
	}

	protected virtual string _GetTemplateForLabelVerified()
	{
		return "Verified";
	}

	protected virtual string _GetTemplateForLabelVerify()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForLabelWhoCanChatInApp()
	{
		return "Who can chat with me in app?";
	}

	protected virtual string _GetTemplateForLabelWhoCanChatInGame()
	{
		return "Who can chat with me?";
	}

	protected virtual string _GetTemplateForLabelWhoCanFindMeByPhone()
	{
		return "Who can find me by my phone number?";
	}

	protected virtual string _GetTemplateForLabelWhoCanInviteVIP()
	{
		return "Who can invite me to VIP Servers?";
	}

	protected virtual string _GetTemplateForLabelWhoCanJoinGame()
	{
		return "Who can join me?";
	}

	protected virtual string _GetTemplateForLabelWhoCanMessageMe()
	{
		return "Who can message me?";
	}

	protected virtual string _GetTemplateForLabelWhoCanSeeInventory()
	{
		return "Who can see my inventory?";
	}

	protected virtual string _GetTemplateForLabelWhoCanTradeWithMe()
	{
		return "Who can trade with me?";
	}

	protected virtual string _GetTemplateForLabelXboxConnected()
	{
		return "Connected with an Xbox account";
	}

	protected virtual string _GetTemplateForLabelYouTube()
	{
		return "YouTube:";
	}

	protected virtual string _GetTemplateForLabelInsufficientRobux()
	{
		return "Insufficient Robux";
	}

	protected virtual string _GetTemplateForMessageErrorAccountHasPin()
	{
		return "The account already has a PIN. Try making a different request.";
	}

	protected virtual string _GetTemplateForMessageErrorAccountLocked()
	{
		return "The account is locked. Unlock the acount before performing the action.";
	}

	protected virtual string _GetTemplateForMessageErrorDefault()
	{
		return "Something went wrong, please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailAlreadyVerified()
	{
		return "The email is already verified.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailFeatureDisabled()
	{
		return "This feature is currently disabled. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailIncorrectPassword()
	{
		return "Password is incorrect.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailInvalidEmail()
	{
		return "Invalid email address.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailNoEmailAssociated()
	{
		return "No email address is associated with the account.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailPinLocked()
	{
		return "PIN is locked.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailSameEmail()
	{
		return "This is already the current email.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailTooManyAccounts()
	{
		return "There are too many accounts associated with this email address.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailTooManyUpdates()
	{
		return "Too many attempts to update email. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailTooManyVerify()
	{
		return "Too many attempts to send verification email. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageErrorEmailUnknown()
	{
		return "An unknown error occured.";
	}

	protected virtual string _GetTemplateForMessageErrorIncorrectPin()
	{
		return "Incorrect PIN.";
	}

	protected virtual string _GetTemplateForMessageErrorInvalidPinFormat()
	{
		return "Invalid PIN format.";
	}

	protected virtual string _GetTemplateForMessageErrorNoPin()
	{
		return "No PIN exists on the account.";
	}

	protected virtual string _GetTemplateForMessageErrorNoVerifiedEmail()
	{
		return "The account does not have a verified email.";
	}

	protected virtual string _GetTemplateForMessageErrorSystem()
	{
		return "System error.";
	}

	protected virtual string _GetTemplateForMessageErrorTooManyRequests()
	{
		return "Too many requests made. Try again later.";
	}

	protected virtual string _GetTemplateForMessageEmailAddSuccess()
	{
		return "Email Added";
	}

	protected virtual string _GetTemplateForMessageEmailAlreadyVerifiedError()
	{
		return "Your email is already verified!";
	}

	protected virtual string _GetTemplateForMessageFeatureDisabledError()
	{
		return "This feature is currently disabled. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageInsufficientRobuxErrorForUserName()
	{
		return "You don't have enough Robux to change your username.";
	}

	protected virtual string _GetTemplateForMessageInvalidEmail()
	{
		return "Invalid Email";
	}

	protected virtual string _GetTemplateForMessageNoEmailAssociatedError()
	{
		return "You must associate an email address with your account";
	}

	protected virtual string _GetTemplateForMessagePermissionError()
	{
		return "You don't have enough Robux to change your username.";
	}

	protected virtual string _GetTemplateForMessagePinLockedError()
	{
		return "PIN is locked.";
	}

	protected virtual string _GetTemplateForMessageSameEmailError()
	{
		return "This is already the current verified email.";
	}

	protected virtual string _GetTemplateForMessageSettingsUpdateSuccess()
	{
		return "Your settings have been updated.";
	}

	protected virtual string _GetTemplateForMessageTooManyAccountsOnEmailError()
	{
		return "There are too many accounts associated with this email address.";
	}

	protected virtual string _GetTemplateForMessageTooManyAttemptsError()
	{
		return "Too many attempts. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageUnknownError()
	{
		return "An unknown error occurred.";
	}

	protected virtual string _GetTemplateForMessageWrongPassword()
	{
		return "Your password is incorrect.";
	}

	protected virtual string _GetTemplateForResponesInvalidCodePhone()
	{
		return "Code is invalid. Please check your phone and try again.";
	}

	protected virtual string _GetTemplateForResponesInventoryAndTradePrivacyConflictError()
	{
		return "The value for \"Who can trade with me\" should be the same or more restrictive than the value for \"Who can see my inventory\".";
	}

	protected virtual string _GetTemplateForResponseCodeRequired()
	{
		return "A code is required. Please enter your code.";
	}

	protected virtual string _GetTemplateForResponseDialogBirthdayChangeDefaultWarning()
	{
		return "Changing your birthday to under age 13 cannot be un-done. Are you sure you want to continue?";
	}

	protected virtual string _GetTemplateForResponseDialogBirthdayChangePasswordBody()
	{
		return "You must add a password to your Roblox account to change your birthday.";
	}

	protected virtual string _GetTemplateForResponseDialogBirthdayChangePasswordTitle()
	{
		return "Must Add Password";
	}

	protected virtual string _GetTemplateForResponseDialogBirthdayChangeSocialWarning()
	{
		return "Changing your birthday to under age 13 cannot be un-done. Your Social Sign On from Facebook will be disabled and you will need to sign on using your Roblox password.";
	}

	protected virtual string _GetTemplateForResponseDialogChangePasswordIncorrectPassword()
	{
		return "Your current password is incorrect, the password was not changed.";
	}

	protected virtual string _GetTemplateForResponseDialogChangePasswordNoMatch()
	{
		return "Passwords do not match";
	}

	protected virtual string _GetTemplateForResponseDialogChangePasswordTooShortError()
	{
		return "Must be at least 8 characters long";
	}

	protected virtual string _GetTemplateForResponseDialogChangeUsernameNoInput()
	{
		return "Please enter a username.";
	}

	protected virtual string _GetTemplateForResponseDialogChangeUsernameNotAllowed()
	{
		return "Username not appropriate for Roblox.";
	}

	protected virtual string _GetTemplateForResponseDialogChangeUsernameNotAvailable()
	{
		return "This username is already in use.";
	}

	protected virtual string _GetTemplateForResponseDialogChangeUsernameSuccess()
	{
		return "Successfully changed username.";
	}

	protected virtual string _GetTemplateForResponseDialogCountryListError()
	{
		return "Error loading country list";
	}

	protected virtual string _GetTemplateForResponseDialogCurrencyServiceError()
	{
		return "There was an error with the currency service. Try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogDefaultErrorMessage()
	{
		return "Something went wrong, please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogDefaultErrorTitle()
	{
		return "Error occured";
	}

	protected virtual string _GetTemplateForResponseDialogDefaultSuccessMessage()
	{
		return "Saved Successfully!";
	}

	protected virtual string _GetTemplateForResponseDialogDisconnectXBoxError()
	{
		return "There was an error disconnecting your Xbox account, please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogEmailSentForVerification()
	{
		return "An email has been sent for verification.";
	}

	protected virtual string _GetTemplateForResponseDialogInvalidEmailAddress()
	{
		return "Invalid Email Address";
	}

	protected virtual string _GetTemplateForResponseDialogInvalidPhoneNumber()
	{
		return "Invalid phone number";
	}

	protected virtual string _GetTemplateForResponseDialogInvalidUsername()
	{
		return "Press Send to submit the ticket or press Cancel to edit the username.  The username is very important information and may help get your issue addressed quicker.";
	}

	protected virtual string _GetTemplateForResponseDialogPasswordRulesError()
	{
		return "Password must contain at least 2 digits, 4 letters, 1 symbol, and be at least 8 characters.";
	}

	protected virtual string _GetTemplateForResponseDialogPinCreateConfirmation()
	{
		return "Your PIN is now set. You will need to enter this PIN before accessing the Settings page in the future.";
	}

	protected virtual string _GetTemplateForResponseDialogPinCreateMismatch()
	{
		return "PINs do not match";
	}

	protected virtual string _GetTemplateForResponseDialogSignoutSessionFailed()
	{
		return "There was an error signing you out of all other sessions, please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogSignoutSessionsConfirmation()
	{
		return "You have been signed out of all other sessions.";
	}

	protected virtual string _GetTemplateForResponseDialogTwoStepDisableWarning()
	{
		return "If you turn off 2-Step Verification, only your password will be needed when you login from a new device. Are you sure?";
	}

	protected virtual string _GetTemplateForResponseDialogTwoStepSuccessTitle()
	{
		return "2 Step Verification Enabled";
	}

	protected virtual string _GetTemplateForResponseDialogTwoStepSucessBody()
	{
		return "Your account is now protected! No further action is required at this time. A security code will be sent next time you login from a new device.";
	}

	protected virtual string _GetTemplateForResponseDialogUpdateInventorySetting()
	{
		return "We have updated your inventory privacy setting. The inventory and trade settings must be consistent.";
	}

	protected virtual string _GetTemplateForResponseDialogUpdateNotificationSettingsError()
	{
		return "There was an error updating your notification settings, please try again later.";
	}

	protected virtual string _GetTemplateForResponseDialogUpdateTradeSetting()
	{
		return "We have updated your trade privacy setting. The inventory and trade settings must be consistent.";
	}

	protected virtual string _GetTemplateForResponseDialogVerifyPhoneInvalidCode()
	{
		return "Code is invalid. Please check your phone and try again.";
	}

	protected virtual string _GetTemplateForResponseDialogWarning()
	{
		return "Warning";
	}

	protected virtual string _GetTemplateForResponseFeatureDisabled()
	{
		return "This feature is currently disabled. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseGeneralError()
	{
		return "An error occurred. Please try again.";
	}

	protected virtual string _GetTemplateForResponseIncorrectCodeTooManyTimes()
	{
		return "You have entered the incorrect code too many times.";
	}

	protected virtual string _GetTemplateForResponseIncorrectPasswordTryAgain()
	{
		return "Incorrect password. Please check your password and try again.";
	}

	protected virtual string _GetTemplateForResponseInvalidPhoneTryAgain()
	{
		return "Phone number format is invalid. Please check and try again.";
	}

	protected virtual string _GetTemplateForResponseNotificationBarPhoneRemovedConfirmation()
	{
		return "Phone has been removed";
	}

	protected virtual string _GetTemplateForResponseNotificationBarPhoneVerifyConfirmation()
	{
		return "Phone has been successfully updated!";
	}

	protected virtual string _GetTemplateForResponseNumberAlreadyAssociated()
	{
		return "Number is already associated with another account.";
	}

	protected virtual string _GetTemplateForResponsePinRequired()
	{
		return "Please enter your PIN to change your settings.";
	}

	protected virtual string _GetTemplateForResponseSocialMediaValidationError()
	{
		return "The social network link is not valid.";
	}

	protected virtual string _GetTemplateForResponseAgeDownError()
	{
		return "Sorry but you cannot change your age to under 13.  If you are under 13, please create a new account and contact support to delete your old account.";
	}
}
