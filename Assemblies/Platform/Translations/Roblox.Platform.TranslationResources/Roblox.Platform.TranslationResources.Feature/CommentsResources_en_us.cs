using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CommentsResources_en_us : TranslationResourcesBase, ICommentsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public virtual string ActionLogin => "Login";

	/// <summary>
	/// Key: "Heading.Comments"
	/// English String: "Comments"
	/// </summary>
	public virtual string HeadingComments => "Comments";

	/// <summary>
	/// Key: "Heading.LoginToComment"
	/// modal heading
	/// English String: "Login to Comment"
	/// </summary>
	public virtual string HeadingLoginToComment => "Login to Comment";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public virtual string LabelAccountPageTitle => "Account";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.CharactersRemaining"
	/// English String: "characters remaining"
	/// </summary>
	public virtual string LabelCharactersRemaining => "characters remaining";

	/// <summary>
	/// Key: "Label.CommentModerated"
	/// Feedback for user when their comment has been moderated
	/// English String: "Your comment has been moderated."
	/// </summary>
	public virtual string LabelCommentModerated => "Your comment has been moderated.";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public virtual string LabelEmailVerifiedTitle => "Verify Your Email";

	/// <summary>
	/// Key: "Label.FeatureNotAvailable"
	/// English String: "This feature is not available."
	/// </summary>
	public virtual string LabelFeatureNotAvailable => "This feature is not available.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedMessage"
	/// English String: "Comments should be about the item or place on which you are commenting. Links are not permitted."
	/// </summary>
	public virtual string LabelLinksNotAllowedMessage => "Comments should be about the item or place on which you are commenting. Links are not permitted.";

	/// <summary>
	/// Key: "Label.LinksNotAllowedTitle"
	/// English String: "Links Not Allowed"
	/// </summary>
	public virtual string LabelLinksNotAllowedTitle => "Links Not Allowed";

	/// <summary>
	/// Key: "Label.MoreComments"
	/// English String: "More Comments"
	/// </summary>
	public virtual string LabelMoreComments => "More Comments";

	/// <summary>
	/// Key: "Label.NoCommentsFound"
	/// English String: "No comments found."
	/// </summary>
	public virtual string LabelNoCommentsFound => "No comments found.";

	/// <summary>
	/// Key: "Label.PostComment"
	/// English String: "Post Comment"
	/// </summary>
	public virtual string LabelPostComment => "Post Comment";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public virtual string LabelReportAbuse => "Report Abuse";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string LabelSeeMore => "See More";

	/// <summary>
	/// Key: "Label.SorryWrong"
	/// English String: "Sorry, something went wrong."
	/// </summary>
	public virtual string LabelSorryWrong => "Sorry, something went wrong.";

	/// <summary>
	/// Key: "Label.Text"
	/// English String: "text"
	/// </summary>
	public virtual string LabelText => "text";

	/// <summary>
	/// Key: "Label.TooManyChracters"
	/// English String: "Too many characters!"
	/// </summary>
	public virtual string LabelTooManyChracters => "Too many characters!";

	/// <summary>
	/// Key: "Label.TooManyNewLines"
	/// English String: "Too many newlines!"
	/// </summary>
	public virtual string LabelTooManyNewLines => "Too many newlines!";

	/// <summary>
	/// Key: "Label.UnknownError"
	/// English String: "Unknown error occurred."
	/// </summary>
	public virtual string LabelUnknownError => "Unknown error occurred.";

	/// <summary>
	/// Key: "Label.UserFlooded"
	/// Feedback for users when they are flooded (both globally and per specific item) when posting comments for an item
	/// English String: "You are posting comments too fast. Wait a while before your next comment."
	/// </summary>
	public virtual string LabelUserFlooded => "You are posting comments too fast. Wait a while before your next comment.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "username"
	/// </summary>
	public virtual string LabelUsername => "username";

	/// <summary>
	/// Key: "Label.UserTooNew"
	/// Feedback for user when they try to post a comments for an item with a newly registered account
	/// English String: "Accounts must be older than 1 day to post comments."
	/// </summary>
	public virtual string LabelUserTooNew => "Accounts must be older than 1 day to post comments.";

	/// <summary>
	/// Key: "Label.Verify"
	/// English String: "Verify"
	/// </summary>
	public virtual string LabelVerify => "Verify";

	/// <summary>
	/// Key: "Label.WriteAComment"
	/// English String: "Write a comment!"
	/// </summary>
	public virtual string LabelWriteAComment => "Write a comment!";

	public CommentsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Login",
				_GetTemplateForActionLogin()
			},
			{
				"Description.LoginToComment",
				_GetTemplateForDescriptionLoginToComment()
			},
			{
				"Heading.Comments",
				_GetTemplateForHeadingComments()
			},
			{
				"Heading.LoginToComment",
				_GetTemplateForHeadingLoginToComment()
			},
			{
				"Label.AccountPageTitle",
				_GetTemplateForLabelAccountPageTitle()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.CharactersRemaining",
				_GetTemplateForLabelCharactersRemaining()
			},
			{
				"Label.CommentModerated",
				_GetTemplateForLabelCommentModerated()
			},
			{
				"Label.EmailVerifiedMessage",
				_GetTemplateForLabelEmailVerifiedMessage()
			},
			{
				"Label.EmailVerifiedTitle",
				_GetTemplateForLabelEmailVerifiedTitle()
			},
			{
				"Label.FeatureNotAvailable",
				_GetTemplateForLabelFeatureNotAvailable()
			},
			{
				"Label.LinksNotAllowedMessage",
				_GetTemplateForLabelLinksNotAllowedMessage()
			},
			{
				"Label.LinksNotAllowedTitle",
				_GetTemplateForLabelLinksNotAllowedTitle()
			},
			{
				"Label.MoreComments",
				_GetTemplateForLabelMoreComments()
			},
			{
				"Label.NoCommentsFound",
				_GetTemplateForLabelNoCommentsFound()
			},
			{
				"Label.PostComment",
				_GetTemplateForLabelPostComment()
			},
			{
				"Label.ReportAbuse",
				_GetTemplateForLabelReportAbuse()
			},
			{
				"Label.SeeMore",
				_GetTemplateForLabelSeeMore()
			},
			{
				"Label.SorryWrong",
				_GetTemplateForLabelSorryWrong()
			},
			{
				"Label.Text",
				_GetTemplateForLabelText()
			},
			{
				"Label.TooManyChracters",
				_GetTemplateForLabelTooManyChracters()
			},
			{
				"Label.TooManyNewLines",
				_GetTemplateForLabelTooManyNewLines()
			},
			{
				"Label.UnknownError",
				_GetTemplateForLabelUnknownError()
			},
			{
				"Label.UserFlooded",
				_GetTemplateForLabelUserFlooded()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.UserTooNew",
				_GetTemplateForLabelUserTooNew()
			},
			{
				"Label.Verify",
				_GetTemplateForLabelVerify()
			},
			{
				"Label.WriteAComment",
				_GetTemplateForLabelWriteAComment()
			},
			{
				"Label.XHoursAgo",
				_GetTemplateForLabelXHoursAgo()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Comments";
	}

	protected virtual string _GetTemplateForActionLogin()
	{
		return "Login";
	}

	/// <summary>
	/// Key: "Description.LoginToComment"
	/// modal body text
	/// English String: "You must login to comment. Please {linkStart}login or register{linkEnd} to continue."
	/// </summary>
	public virtual string DescriptionLoginToComment(string linkStart, string linkEnd)
	{
		return $"You must login to comment. Please {linkStart}login or register{linkEnd} to continue.";
	}

	protected virtual string _GetTemplateForDescriptionLoginToComment()
	{
		return "You must login to comment. Please {linkStart}login or register{linkEnd} to continue.";
	}

	protected virtual string _GetTemplateForHeadingComments()
	{
		return "Comments";
	}

	protected virtual string _GetTemplateForHeadingLoginToComment()
	{
		return "Login to Comment";
	}

	protected virtual string _GetTemplateForLabelAccountPageTitle()
	{
		return "Account";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelCharactersRemaining()
	{
		return "characters remaining";
	}

	protected virtual string _GetTemplateForLabelCommentModerated()
	{
		return "Your comment has been moderated.";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public virtual string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"You must verify your email before you can comment. You can verify your email on the {accountPageLink} page.";
	}

	protected virtual string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "You must verify your email before you can comment. You can verify your email on the {accountPageLink} page.";
	}

	protected virtual string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verify Your Email";
	}

	protected virtual string _GetTemplateForLabelFeatureNotAvailable()
	{
		return "This feature is not available.";
	}

	protected virtual string _GetTemplateForLabelLinksNotAllowedMessage()
	{
		return "Comments should be about the item or place on which you are commenting. Links are not permitted.";
	}

	protected virtual string _GetTemplateForLabelLinksNotAllowedTitle()
	{
		return "Links Not Allowed";
	}

	protected virtual string _GetTemplateForLabelMoreComments()
	{
		return "More Comments";
	}

	protected virtual string _GetTemplateForLabelNoCommentsFound()
	{
		return "No comments found.";
	}

	protected virtual string _GetTemplateForLabelPostComment()
	{
		return "Post Comment";
	}

	protected virtual string _GetTemplateForLabelReportAbuse()
	{
		return "Report Abuse";
	}

	protected virtual string _GetTemplateForLabelSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForLabelSorryWrong()
	{
		return "Sorry, something went wrong.";
	}

	protected virtual string _GetTemplateForLabelText()
	{
		return "text";
	}

	protected virtual string _GetTemplateForLabelTooManyChracters()
	{
		return "Too many characters!";
	}

	protected virtual string _GetTemplateForLabelTooManyNewLines()
	{
		return "Too many newlines!";
	}

	protected virtual string _GetTemplateForLabelUnknownError()
	{
		return "Unknown error occurred.";
	}

	protected virtual string _GetTemplateForLabelUserFlooded()
	{
		return "You are posting comments too fast. Wait a while before your next comment.";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "username";
	}

	protected virtual string _GetTemplateForLabelUserTooNew()
	{
		return "Accounts must be older than 1 day to post comments.";
	}

	protected virtual string _GetTemplateForLabelVerify()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForLabelWriteAComment()
	{
		return "Write a comment!";
	}

	/// <summary>
	/// Key: "Label.XHoursAgo"
	/// English String: "{numberOfHours} hours ago"
	/// </summary>
	public virtual string LabelXHoursAgo(string numberOfHours)
	{
		return $"{numberOfHours} hours ago";
	}

	protected virtual string _GetTemplateForLabelXHoursAgo()
	{
		return "{numberOfHours} hours ago";
	}
}
