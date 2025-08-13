namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_fr_fr : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Fermer";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Signaler un comportement abusif";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Envoyer";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "Commentaire (facultatif)...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "Signaler un comportement abusif";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "Merci\u00a0!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "Voir tout le règlement.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "Les utilisateurs qui n'obéissent pas au règlement recevront d'abord un avertissement. En cas de récidive, nous pourrons leur interdire de revenir sur Roblox. C'est ainsi que nous permettons à tout le monde de s'amuser en toute sécurité\u00a0!";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "Agression, harcèlement ou discours haineux";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "Intimidation, harcèlement, Discrimination";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "Contenu inapproprié - emplacement, image ou modèle";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "Drague";

	public override string LabelCategoryInappropriate => "Langage inapproprié - contenu grossier ou adulte";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "Autre violation";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "Demande ou communication d'informations personnelles";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "Triche, exploitation de bugs ou arnaque";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "Vol de compte - hameçonnage, piratage ou échange";

	public override string LabelCategoryThreats => "Menaces dans la vie réelle ou menaces de suicide";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "Commentaire\u00a0:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "Supprimer le message (et ses réponses)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "Conserver le message en l'état";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "Contenu adulte";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "Publicité";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "Harcèlement";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "Inapproprié";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "Aucun";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "Atteinte à la vie privée";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "Grossièretés";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "Arnaque";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "Spam";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "Infraction mineure non classifiée";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "REMARQUE\u00a0: La suppression de ce message supprimera également ses réponses. Si vous choisissez de modifier ou de supprimer le message, ce signalement sautera la file des comportements abusifs et ira directement dans la file de l'utilisateur.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "JavaScript doit être activé pour que vous puissiez visionner cette vidéo.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "Vous n'êtes pas sûr(e) de savoir si ce que vous essayez de signaler est contraire au règlement\u00a0?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "Politique de confidentialité";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "Motif";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "Pas d'insulte";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "Pas de partage ou d'échange de compte";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "Pas de drague";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "Pas de demande d'informations personnelles (numéro de téléphone, adresse e-mail, etc.)";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Voici quelques-unes des règles de base de Roblox\u00a0:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Sécurité Roblox.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "Modifier le corps";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "Modifier l'objet et le corps";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "Voir le règlement de la communauté";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "Sélectionnez une catégorie";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "Sélectionnez tout média inapproprié\u00a0:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "Choisis un motif pour ton action de modération\u00a0:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Objet\u00a0:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "Un ou plusieurs champs requis sont vides ou non valides.";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "Un problème est survenu lors du chargement des catégories de signalement.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "Un problème est survenu lors de l'envoi de ton signalement.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "La page a rencontré un problème.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "Ton signalement a été envoyé.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "Merci de ton rapport.  Nous l'évaluerons pour déterminer s’il y a eu une violation de nos conditions d’utilisation.  Pour plus d’informations, consulte ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "Ce compte ne possède pas les autorisations suffisantes.";

	public ReportAbuseResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Fermer";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Signaler un comportement abusif";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Envoyer";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "Commentaire (facultatif)...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "Signaler un comportement abusif";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Merci\u00a0!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "Voir tout le règlement.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "Les utilisateurs qui n'obéissent pas au règlement recevront d'abord un avertissement. En cas de récidive, nous pourrons leur interdire de revenir sur Roblox. C'est ainsi que nous permettons à tout le monde de s'amuser en toute sécurité\u00a0!";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "Agression, harcèlement ou discours haineux";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "Intimidation, harcèlement, Discrimination";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "Contenu inapproprié - emplacement, image ou modèle";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "Drague";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "Langage inapproprié - contenu grossier ou adulte";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "Autre violation";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "Demande ou communication d'informations personnelles";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "Triche, exploitation de bugs ou arnaque";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "Vol de compte - hameçonnage, piratage ou échange";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "Menaces dans la vie réelle ou menaces de suicide";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "Commentaire\u00a0:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Supprimer le message (et ses réponses)";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "Conserver le message en l'état";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "Contenu adulte";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "Publicité";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "Harcèlement";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "Inapproprié";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "Aucun";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "Atteinte à la vie privée";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "Grossièretés";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "Arnaque";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "Spam";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "Infraction mineure non classifiée";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "REMARQUE\u00a0: La suppression de ce message supprimera également ses réponses. Si vous choisissez de modifier ou de supprimer le message, ce signalement sautera la file des comportements abusifs et ira directement dans la file de l'utilisateur.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "JavaScript doit être activé pour que vous puissiez visionner cette vidéo.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "Vous n'êtes pas sûr(e) de savoir si ce que vous essayez de signaler est contraire au règlement\u00a0?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "Politique de confidentialité";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "Motif";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "Pas d'insulte";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "Pas de partage ou d'échange de compte";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "Pas de drague";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "Pas de demande d'informations personnelles (numéro de téléphone, adresse e-mail, etc.)";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Voici quelques-unes des règles de base de Roblox\u00a0:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Sécurité Roblox.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "Modifier le corps";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "Modifier l'objet et le corps";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "Voir le règlement de la communauté";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "Sélectionnez une catégorie";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "Sélectionnez tout média inapproprié\u00a0:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "Choisis un motif pour ton action de modération\u00a0:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Objet\u00a0:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"Expliquez-nous pourquoi {creatorName} enfreint les règles de Roblox.";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "Expliquez-nous pourquoi {creatorName} enfreint les règles de Roblox.";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "Un ou plusieurs champs requis sont vides ou non valides.";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "Un problème est survenu lors du chargement des catégories de signalement.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "Un problème est survenu lors de l'envoi de ton signalement.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "La page a rencontré un problème.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Ton signalement a été envoyé.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "Merci de ton rapport.  Nous l'évaluerons pour déterminer s’il y a eu une violation de nos conditions d’utilisation.  Pour plus d’informations, consulte ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "Ce compte ne possède pas les autorisations suffisantes.";
	}
}
