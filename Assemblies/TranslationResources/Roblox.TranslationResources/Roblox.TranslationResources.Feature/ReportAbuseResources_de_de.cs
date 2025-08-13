namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_de_de : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Schließen";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Senden";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "Kommentar (optional)\u00a0...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "Danke!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "Alle Regeln ansehen.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "Benutzer, die gegen die Regeln verstoßen, werden zuerst verwarnt. Sollten sie ihr Verhalten danach nicht ändern, können wir sie dazu auffordern, Roblox nicht mehr zu benutzen. So bleibt Roblox unterhaltsam und sicher!";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "Mobbing, Belästigung, Hassbekundigungen";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "Mobbing, Belästigung, Diskriminierung";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "Unangemessene Inhalte\u00a0– Ort, Bild, Modell";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "Dating";

	public override string LabelCategoryInappropriate => "Unangemessene Sprache – Kraftausdrücke und nicht jugendfreie Inhalte";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "Anderer Regelverstoß";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "Fragen nach oder Bereitstellung von persönlichen Informationen";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "Ausnutzen von Spielfehlern, Schummeln, Betrug";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "Kontodiebstahl\u00a0– Phishing, Hacking, Handel mit Konten";

	public override string LabelCategoryThreats => "Bedrohungen in der realen Welt und Suizidandrohungen";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "Kommentar:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "Post (und sämtliche Antworten) löschen";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "Post unverändert lassen";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "Nicht jugendfreie Inhalte";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "Werbung";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "Belästigung";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "Unangemessen";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "Keine Auswahl";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "Datenschutz";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "Kraftausdrücke";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "Betrug";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "Spam";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "Nicht klassifiziert, gemäßigt";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "HINWEIS: Wenn du diesen Post löschst, werden auch die Antworten darauf gelöscht. Solltest du den Post bereinigen oder löschen, übergeht diese Meldung die Liste der Verstöße und landet direkt in der Benutzerliste.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "Um dieses Video abzuspielen, muss JavaScript aktiviert sein.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "Du bist dir nicht sicher, ob die Sache, die du melden möchtest, wirklich ein Regelverstoß ist?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "Datenschutzrichtlinien";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "Grund";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "Keine Schimpfwörter";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "Kein Teilen von oder Handeln mit Konten";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "Kein Dating\u00a0– Frage nicht, ob jemand dein Partner werden will";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "Keine Fragen nach persönlichen Informationen wie Handynummern oder E-Mail-Adressen";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Hier sind einige der Grundregeln für Roblox:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Roblox-Sicherheit.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "Nachrichtentext bereinigen";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "Nachrichtentitel und -text bereinigen";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "Community-Regeln ansehen";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "Bitte wähle eine Kategorie.";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "Wähle alle unangemessenen Elemente:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "Wähle einen Grund für deine Aktion als Moderator:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Betreff:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "Mindestens eine erforderliche Angabe fehlt oder ist ungültig.";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "Beim Laden der Meldungskategorien ist ein Problem aufgetreten.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "Beim Senden deiner Meldung ist ein Problem aufgetreten.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "Es gab ein Problem mit der Seite.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "Deine Meldung wurde gesendet.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "Vielen Dank für deine Meldung. Wir werden nachprüfen, ob ein Verstoß gegen unsere Nutzungsbedingungen vorliegt. Weitere Informationen findest du hier ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "Dieses Konto verfügt nicht über genügend Berechtigungen.";

	public ReportAbuseResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Schließen";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Senden";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "Kommentar (optional)\u00a0...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "Danke!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "Alle Regeln ansehen.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "Benutzer, die gegen die Regeln verstoßen, werden zuerst verwarnt. Sollten sie ihr Verhalten danach nicht ändern, können wir sie dazu auffordern, Roblox nicht mehr zu benutzen. So bleibt Roblox unterhaltsam und sicher!";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "Mobbing, Belästigung, Hassbekundigungen";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "Mobbing, Belästigung, Diskriminierung";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "Unangemessene Inhalte\u00a0– Ort, Bild, Modell";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "Dating";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "Unangemessene Sprache – Kraftausdrücke und nicht jugendfreie Inhalte";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "Anderer Regelverstoß";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "Fragen nach oder Bereitstellung von persönlichen Informationen";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "Ausnutzen von Spielfehlern, Schummeln, Betrug";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "Kontodiebstahl\u00a0– Phishing, Hacking, Handel mit Konten";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "Bedrohungen in der realen Welt und Suizidandrohungen";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "Kommentar:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Post (und sämtliche Antworten) löschen";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "Post unverändert lassen";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "Nicht jugendfreie Inhalte";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "Werbung";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "Belästigung";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "Unangemessen";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "Keine Auswahl";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "Datenschutz";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "Kraftausdrücke";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "Betrug";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "Spam";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "Nicht klassifiziert, gemäßigt";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "HINWEIS: Wenn du diesen Post löschst, werden auch die Antworten darauf gelöscht. Solltest du den Post bereinigen oder löschen, übergeht diese Meldung die Liste der Verstöße und landet direkt in der Benutzerliste.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "Um dieses Video abzuspielen, muss JavaScript aktiviert sein.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "Du bist dir nicht sicher, ob die Sache, die du melden möchtest, wirklich ein Regelverstoß ist?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "Datenschutzrichtlinien";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "Grund";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "Keine Schimpfwörter";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "Kein Teilen von oder Handeln mit Konten";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "Kein Dating\u00a0– Frage nicht, ob jemand dein Partner werden will";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "Keine Fragen nach persönlichen Informationen wie Handynummern oder E-Mail-Adressen";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Hier sind einige der Grundregeln für Roblox:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Roblox-Sicherheit.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "Nachrichtentext bereinigen";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "Nachrichtentitel und -text bereinigen";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "Community-Regeln ansehen";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "Bitte wähle eine Kategorie.";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "Wähle alle unangemessenen Elemente:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "Wähle einen Grund für deine Aktion als Moderator:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Betreff:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"Bitte teile uns mit, warum du denkst, dass {creatorName} gegen die Regeln von Roblox verstößt.";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "Bitte teile uns mit, warum du denkst, dass {creatorName} gegen die Regeln von Roblox verstößt.";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "Mindestens eine erforderliche Angabe fehlt oder ist ungültig.";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "Beim Laden der Meldungskategorien ist ein Problem aufgetreten.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "Beim Senden deiner Meldung ist ein Problem aufgetreten.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Es gab ein Problem mit der Seite.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Deine Meldung wurde gesendet.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "Vielen Dank für deine Meldung. Wir werden nachprüfen, ob ein Verstoß gegen unsere Nutzungsbedingungen vorliegt. Weitere Informationen findest du hier ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "Dieses Konto verfügt nicht über genügend Berechtigungen.";
	}
}
