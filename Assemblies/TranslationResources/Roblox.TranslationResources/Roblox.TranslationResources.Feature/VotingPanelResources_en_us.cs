using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class VotingPanelResources_en_us : TranslationResourcesBase, IVotingPanelResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.Accept"
	/// English String: "Verify"
	/// </summary>
	public virtual string LabelAccept => "Verify";

	/// <summary>
	/// Key: "Label.AccountPageTitle"
	/// English String: "Account"
	/// </summary>
	public virtual string LabelAccountPageTitle => "Account";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneMessage"
	/// English String: "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days."
	/// </summary>
	public virtual string LabelAccountUnderDayOneMessage => "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days.";

	/// <summary>
	/// Key: "Label.AccountUnderDayOneTitle"
	/// English String: "Voter Feedback"
	/// </summary>
	public virtual string LabelAccountUnderDayOneTitle => "Voter Feedback";

	/// <summary>
	/// Key: "Label.AssetNotVoteableMessage"
	/// English String: "This asset may not be voted on at this time."
	/// </summary>
	public virtual string LabelAssetNotVoteableMessage => "This asset may not be voted on at this time.";

	/// <summary>
	/// Key: "Label.AssetNotVoteableTitle"
	/// English String: "Unable to Vote"
	/// </summary>
	public virtual string LabelAssetNotVoteableTitle => "Unable to Vote";

	/// <summary>
	/// Key: "Label.BuyGamePassMessage"
	/// English String: "You must own this game pass before you can vote on it."
	/// </summary>
	public virtual string LabelBuyGamePassMessage => "You must own this game pass before you can vote on it.";

	/// <summary>
	/// Key: "Label.BuyGamePassTitle"
	/// English String: "Buy Game Pass"
	/// </summary>
	public virtual string LabelBuyGamePassTitle => "Buy Game Pass";

	/// <summary>
	/// Key: "Label.Decline"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelDecline => "Cancel";

	/// <summary>
	/// Key: "Label.EmailVerifiedTitle"
	/// English String: "Verify Your Email"
	/// </summary>
	public virtual string LabelEmailVerifiedTitle => "Verify Your Email";

	/// <summary>
	/// Key: "Label.FloodCheckMessage"
	/// English String: "You're voting too quickly. Come back later and try again."
	/// </summary>
	public virtual string LabelFloodCheckMessage => "You're voting too quickly. Come back later and try again.";

	/// <summary>
	/// Key: "Label.FloodCheckTitle"
	/// English String: "Slow Down"
	/// </summary>
	public virtual string LabelFloodCheckTitle => "Slow Down";

	/// <summary>
	/// Key: "Label.GuestUserTitle"
	/// English String: "Login to Vote"
	/// </summary>
	public virtual string LabelGuestUserTitle => "Login to Vote";

	/// <summary>
	/// Key: "Label.InstallPluginMessage"
	/// English String: "You must install this plugin before you can vote on it."
	/// </summary>
	public virtual string LabelInstallPluginMessage => "You must install this plugin before you can vote on it.";

	/// <summary>
	/// Key: "Label.InstallPluginTitle"
	/// English String: "Install Plugin"
	/// </summary>
	public virtual string LabelInstallPluginTitle => "Install Plugin";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Login"
	/// </summary>
	public virtual string LabelLogin => "Login";

	/// <summary>
	/// Key: "Label.LoginOrRegisterPageTitle"
	/// English String: "login or register"
	/// </summary>
	public virtual string LabelLoginOrRegisterPageTitle => "login or register";

	/// <summary>
	/// Key: "Label.Ok"
	/// English String: "OK"
	/// </summary>
	public virtual string LabelOk => "OK";

	/// <summary>
	/// Key: "Label.PlayGameMessage"
	/// English String: "You must play the game before you can vote on it."
	/// </summary>
	public virtual string LabelPlayGameMessage => "You must play the game before you can vote on it.";

	/// <summary>
	/// Key: "Label.PlayGameTitle"
	/// English String: "Play Game"
	/// </summary>
	public virtual string LabelPlayGameTitle => "Play Game";

	/// <summary>
	/// Key: "Label.UnknownProblemMessage"
	/// English String: "There was an unknown problem voting. Please try again."
	/// </summary>
	public virtual string LabelUnknownProblemMessage => "There was an unknown problem voting. Please try again.";

	/// <summary>
	/// Key: "Label.UnknownProblemTitle"
	/// English String: "Something Broke"
	/// </summary>
	public virtual string LabelUnknownProblemTitle => "Something Broke";

	/// <summary>
	/// Key: "Label.UseModelMessage"
	/// English String: "You must use this model before you can vote on it."
	/// </summary>
	public virtual string LabelUseModelMessage => "You must use this model before you can vote on it.";

	/// <summary>
	/// Key: "Label.UseModelTitle"
	/// English String: "Use Model"
	/// </summary>
	public virtual string LabelUseModelTitle => "Use Model";

	/// <summary>
	/// Key: "Label.YouMustLoginToVote"
	/// English String: "You must login to vote."
	/// </summary>
	public virtual string LabelYouMustLoginToVote => "You must login to vote.";

	public VotingPanelResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.Accept",
				_GetTemplateForLabelAccept()
			},
			{
				"Label.AccountPageTitle",
				_GetTemplateForLabelAccountPageTitle()
			},
			{
				"Label.AccountUnderDayOneMessage",
				_GetTemplateForLabelAccountUnderDayOneMessage()
			},
			{
				"Label.AccountUnderDayOneTitle",
				_GetTemplateForLabelAccountUnderDayOneTitle()
			},
			{
				"Label.AssetNotVoteableMessage",
				_GetTemplateForLabelAssetNotVoteableMessage()
			},
			{
				"Label.AssetNotVoteableTitle",
				_GetTemplateForLabelAssetNotVoteableTitle()
			},
			{
				"Label.BuyGamePassMessage",
				_GetTemplateForLabelBuyGamePassMessage()
			},
			{
				"Label.BuyGamePassTitle",
				_GetTemplateForLabelBuyGamePassTitle()
			},
			{
				"Label.Decline",
				_GetTemplateForLabelDecline()
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
				"Label.FloodCheckMessage",
				_GetTemplateForLabelFloodCheckMessage()
			},
			{
				"Label.FloodCheckTitle",
				_GetTemplateForLabelFloodCheckTitle()
			},
			{
				"Label.GuestUserMessage",
				_GetTemplateForLabelGuestUserMessage()
			},
			{
				"Label.GuestUserTitle",
				_GetTemplateForLabelGuestUserTitle()
			},
			{
				"Label.InstallPluginMessage",
				_GetTemplateForLabelInstallPluginMessage()
			},
			{
				"Label.InstallPluginTitle",
				_GetTemplateForLabelInstallPluginTitle()
			},
			{
				"Label.Login",
				_GetTemplateForLabelLogin()
			},
			{
				"Label.LoginOrRegisterPageTitle",
				_GetTemplateForLabelLoginOrRegisterPageTitle()
			},
			{
				"Label.Ok",
				_GetTemplateForLabelOk()
			},
			{
				"Label.PlayGameMessage",
				_GetTemplateForLabelPlayGameMessage()
			},
			{
				"Label.PlayGameTitle",
				_GetTemplateForLabelPlayGameTitle()
			},
			{
				"Label.UnknownProblemMessage",
				_GetTemplateForLabelUnknownProblemMessage()
			},
			{
				"Label.UnknownProblemTitle",
				_GetTemplateForLabelUnknownProblemTitle()
			},
			{
				"Label.UseModelMessage",
				_GetTemplateForLabelUseModelMessage()
			},
			{
				"Label.UseModelTitle",
				_GetTemplateForLabelUseModelTitle()
			},
			{
				"Label.YouMustLoginToVote",
				_GetTemplateForLabelYouMustLoginToVote()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.VotingPanel";
	}

	protected virtual string _GetTemplateForLabelAccept()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForLabelAccountPageTitle()
	{
		return "Account";
	}

	protected virtual string _GetTemplateForLabelAccountUnderDayOneMessage()
	{
		return "You will be able to vote on Games and Studio Models later, after you've had a chance to experience Roblox a bit more. Come back to this page in a couple days.";
	}

	protected virtual string _GetTemplateForLabelAccountUnderDayOneTitle()
	{
		return "Voter Feedback";
	}

	protected virtual string _GetTemplateForLabelAssetNotVoteableMessage()
	{
		return "This asset may not be voted on at this time.";
	}

	protected virtual string _GetTemplateForLabelAssetNotVoteableTitle()
	{
		return "Unable to Vote";
	}

	protected virtual string _GetTemplateForLabelBuyGamePassMessage()
	{
		return "You must own this game pass before you can vote on it.";
	}

	protected virtual string _GetTemplateForLabelBuyGamePassTitle()
	{
		return "Buy Game Pass";
	}

	protected virtual string _GetTemplateForLabelDecline()
	{
		return "Cancel";
	}

	/// <summary>
	/// Key: "Label.EmailVerifiedMessage"
	/// English String: "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page."
	/// </summary>
	public virtual string LabelEmailVerifiedMessage(string accountPageLink)
	{
		return $"You must verify your email before you can vote. You can verify your email on the {accountPageLink} page.";
	}

	protected virtual string _GetTemplateForLabelEmailVerifiedMessage()
	{
		return "You must verify your email before you can vote. You can verify your email on the {accountPageLink} page.";
	}

	protected virtual string _GetTemplateForLabelEmailVerifiedTitle()
	{
		return "Verify Your Email";
	}

	protected virtual string _GetTemplateForLabelFloodCheckMessage()
	{
		return "You're voting too quickly. Come back later and try again.";
	}

	protected virtual string _GetTemplateForLabelFloodCheckTitle()
	{
		return "Slow Down";
	}

	/// <summary>
	/// Key: "Label.GuestUserMessage"
	/// English String: "Please {loginOrRegisterPageLink} to continue."
	/// </summary>
	public virtual string LabelGuestUserMessage(string loginOrRegisterPageLink)
	{
		return $"Please {loginOrRegisterPageLink} to continue.";
	}

	protected virtual string _GetTemplateForLabelGuestUserMessage()
	{
		return "Please {loginOrRegisterPageLink} to continue.";
	}

	protected virtual string _GetTemplateForLabelGuestUserTitle()
	{
		return "Login to Vote";
	}

	protected virtual string _GetTemplateForLabelInstallPluginMessage()
	{
		return "You must install this plugin before you can vote on it.";
	}

	protected virtual string _GetTemplateForLabelInstallPluginTitle()
	{
		return "Install Plugin";
	}

	protected virtual string _GetTemplateForLabelLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForLabelLoginOrRegisterPageTitle()
	{
		return "login or register";
	}

	protected virtual string _GetTemplateForLabelOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForLabelPlayGameMessage()
	{
		return "You must play the game before you can vote on it.";
	}

	protected virtual string _GetTemplateForLabelPlayGameTitle()
	{
		return "Play Game";
	}

	protected virtual string _GetTemplateForLabelUnknownProblemMessage()
	{
		return "There was an unknown problem voting. Please try again.";
	}

	protected virtual string _GetTemplateForLabelUnknownProblemTitle()
	{
		return "Something Broke";
	}

	protected virtual string _GetTemplateForLabelUseModelMessage()
	{
		return "You must use this model before you can vote on it.";
	}

	protected virtual string _GetTemplateForLabelUseModelTitle()
	{
		return "Use Model";
	}

	protected virtual string _GetTemplateForLabelYouMustLoginToVote()
	{
		return "You must login to vote.";
	}
}
