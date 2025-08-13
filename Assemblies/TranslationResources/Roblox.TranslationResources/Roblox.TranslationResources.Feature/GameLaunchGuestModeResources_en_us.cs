using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameLaunchGuestModeResources_en_us : TranslationResourcesBase, IGameLaunchGuestModeResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public virtual string ActionDialogClose => "Close";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Log In"
	/// </summary>
	public virtual string ActionDialogLogin => "Log In";

	/// <summary>
	/// Key: "Action.Dialog.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public virtual string ActionDialogOk => "OK";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public virtual string ActionDialogSignUp => "Sign Up";

	/// <summary>
	/// Key: "Action.Dialog.SignUpNow"
	/// button text
	/// English String: "Sign up now!"
	/// </summary>
	public virtual string ActionDialogSignUpNow => "Sign up now!";

	/// <summary>
	/// Key: "Description.Dialog.SignUpOrLogin"
	/// modal body text
	/// English String: "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now."
	/// </summary>
	public virtual string DescriptionDialogSignUpOrLogin => "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now.";

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodayOneDayRemaining"
	/// description text
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up."
	/// </summary>
	public virtual string DescriptionDialogSignUpTodayOneDayRemaining => "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up.";

	/// <summary>
	/// Key: "Description.Dialog.TrialOver"
	/// description
	/// English String: "Your trial period has ended. Please sign up to play games - it's free!"
	/// </summary>
	public virtual string DescriptionDialogTrialOver => "Your trial period has ended. Please sign up to play games - it's free!";

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingOneDayRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up."
	/// </summary>
	public virtual string DescriptionDialogYouArePlayingOneDayRemaining => "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up.";

	/// <summary>
	/// Key: "Heading.ChooseAvatar"
	/// modal heading
	/// English String: "Choose Your Avatar"
	/// </summary>
	public virtual string HeadingChooseAvatar => "Choose Your Avatar";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpOrLogin"
	/// modal heading
	/// English String: "Sign up for a free account or log in!"
	/// </summary>
	public virtual string HeadingDialogSignUpOrLogin => "Sign up for a free account or log in!";

	/// <summary>
	/// Key: "Heading.Dialog.SignUpToday"
	/// modal heading
	/// English String: "Sign Up Today!"
	/// </summary>
	public virtual string HeadingDialogSignUpToday => "Sign Up Today!";

	/// <summary>
	/// Key: "Label.HaveAccount"
	/// label
	/// English String: "I have an account"
	/// </summary>
	public virtual string LabelHaveAccount => "I have an account";

	public GameLaunchGuestModeResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Dialog.Close",
				_GetTemplateForActionDialogClose()
			},
			{
				"Action.Dialog.Login",
				_GetTemplateForActionDialogLogin()
			},
			{
				"Action.Dialog.Ok",
				_GetTemplateForActionDialogOk()
			},
			{
				"Action.Dialog.SignUp",
				_GetTemplateForActionDialogSignUp()
			},
			{
				"Action.Dialog.SignUpNow",
				_GetTemplateForActionDialogSignUpNow()
			},
			{
				"Description.Dialog.SignUpOrLogin",
				_GetTemplateForDescriptionDialogSignUpOrLogin()
			},
			{
				"Description.Dialog.SignUpTodayOneDayRemaining",
				_GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
			},
			{
				"Description.Dialog.SignUpTodaySomeDaysRemaining",
				_GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
			},
			{
				"Description.Dialog.TrialOver",
				_GetTemplateForDescriptionDialogTrialOver()
			},
			{
				"Description.Dialog.YouArePlayingOneDayRemaining",
				_GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
			},
			{
				"Description.Dialog.YouArePlayingSomeDaysRemaining",
				_GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
			},
			{
				"Heading.ChooseAvatar",
				_GetTemplateForHeadingChooseAvatar()
			},
			{
				"Heading.Dialog.SignUpOrLogin",
				_GetTemplateForHeadingDialogSignUpOrLogin()
			},
			{
				"Heading.Dialog.SignUpToday",
				_GetTemplateForHeadingDialogSignUpToday()
			},
			{
				"Label.HaveAccount",
				_GetTemplateForLabelHaveAccount()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameLaunchGuestMode";
	}

	protected virtual string _GetTemplateForActionDialogClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionDialogLogin()
	{
		return "Log In";
	}

	protected virtual string _GetTemplateForActionDialogOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionDialogSignUp()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForActionDialogSignUpNow()
	{
		return "Sign up now!";
	}

	protected virtual string _GetTemplateForDescriptionDialogSignUpOrLogin()
	{
		return "To play games, chat with friends, or customize your avatar, you'll need an account. Sign up for a free account or log in to play now.";
	}

	protected virtual string _GetTemplateForDescriptionDialogSignUpTodayOneDayRemaining()
	{
		return "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than a day left before we require free sign up.";
	}

	/// <summary>
	/// Key: "Description.Dialog.SignUpTodaySomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up."
	/// </summary>
	public virtual string DescriptionDialogSignUpTodaySomeDaysRemaining(string numDays)
	{
		return $"You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up.";
	}

	protected virtual string _GetTemplateForDescriptionDialogSignUpTodaySomeDaysRemaining()
	{
		return "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have less than {numDays} days left before we require free sign up.";
	}

	protected virtual string _GetTemplateForDescriptionDialogTrialOver()
	{
		return "Your trial period has ended. Please sign up to play games - it's free!";
	}

	protected virtual string _GetTemplateForDescriptionDialogYouArePlayingOneDayRemaining()
	{
		return "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have 1 gameplay left before we require free sign up.";
	}

	/// <summary>
	/// Key: "Description.Dialog.YouArePlayingSomeDaysRemaining"
	/// description
	/// English String: "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up."
	/// </summary>
	public virtual string DescriptionDialogYouArePlayingSomeDaysRemaining(string numDays)
	{
		return $"You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up.";
	}

	protected virtual string _GetTemplateForDescriptionDialogYouArePlayingSomeDaysRemaining()
	{
		return "You are playing in guest mode. To use all features available on Roblox, you will need to create an account. You have {numDays} gameplays left before we require free sign up.";
	}

	protected virtual string _GetTemplateForHeadingChooseAvatar()
	{
		return "Choose Your Avatar";
	}

	protected virtual string _GetTemplateForHeadingDialogSignUpOrLogin()
	{
		return "Sign up for a free account or log in!";
	}

	protected virtual string _GetTemplateForHeadingDialogSignUpToday()
	{
		return "Sign Up Today!";
	}

	protected virtual string _GetTemplateForLabelHaveAccount()
	{
		return "I have an account";
	}
}
