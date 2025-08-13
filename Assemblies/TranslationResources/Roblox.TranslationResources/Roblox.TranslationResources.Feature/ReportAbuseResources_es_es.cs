namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides ReportAbuseResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ReportAbuseResources_es_es : ReportAbuseResources_en_us, IReportAbuseResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Close"
	/// English String: "Close"
	/// </summary>
	public override string ActionClose => "Cerrar";

	/// <summary>
	/// Key: "Action.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string ActionReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Enviar";

	/// <summary>
	/// Key: "Example.Comment"
	/// English String: "Comment (optional)..."
	/// </summary>
	public override string ExampleComment => "Comentario (opcional)...";

	/// <summary>
	/// Key: "Heading.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string HeadingReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Heading.Success"
	/// English String: "Thank You!"
	/// </summary>
	public override string HeadingSuccess => "¡Gracias!";

	/// <summary>
	/// Key: "Label.AllRulesLink"
	/// English String: "See all rules."
	/// </summary>
	public override string LabelAllRulesLink => "Ver todas las normas.";

	/// <summary>
	/// Key: "Label.BlockWarning"
	/// English String: "Users who don't follow the rules will get a warning at first but if they keep it up we may ask them to not come to Roblox anymore. That way we can keep Roblox fun and safe!"
	/// </summary>
	public override string LabelBlockWarning => "Los usuarios que no cumplan las normas recibirán una advertencia primero, pero si persisten, les pediremos que no vuelvan a Roblox. De esta manera, Roblox seguirá siendo divertido y seguro.";

	/// <summary>
	/// Key: "Label.CategoryBullying"
	/// English String: "Bullying, Harassment, Hate Speech"
	/// </summary>
	public override string LabelCategoryBullying => "Abuso, acoso, discurso de odio";

	/// <summary>
	/// Key: "Label.CategoryBullyingV2"
	/// English String: "Bullying, Harassment, Discrimination"
	/// </summary>
	public override string LabelCategoryBullyingV2 => "Intimidación, acoso, discriminación";

	/// <summary>
	/// Key: "Label.CategoryContent"
	/// English String: "Inappropriate Content - Place, Image, Model"
	/// </summary>
	public override string LabelCategoryContent => "Conten. inadecuado: lugar, imagen, modelo";

	/// <summary>
	/// Key: "Label.CategoryDating"
	/// English String: "Dating"
	/// </summary>
	public override string LabelCategoryDating => "Solicitud de cita";

	public override string LabelCategoryInappropriate => "Lenguaje inadecuado, vulgar y contenido adulto";

	/// <summary>
	/// Key: "Label.CategoryOther"
	/// English String: "Other rule violation"
	/// </summary>
	public override string LabelCategoryOther => "Incumplimiento de otra norma";

	/// <summary>
	/// Key: "Label.CategoryPrivateInfo"
	/// English String: "Asking for or Giving Private Information"
	/// </summary>
	public override string LabelCategoryPrivateInfo => "Pedir o dar información privada";

	/// <summary>
	/// Key: "Label.CategoryScamming"
	/// English String: "Exploiting, Cheating, Scamming"
	/// </summary>
	public override string LabelCategoryScamming => "Exploits, trampas, estafa";

	/// <summary>
	/// Key: "Label.CategoryTheft"
	/// English String: "Account Theft - Phishing, Hacking, Trading"
	/// </summary>
	public override string LabelCategoryTheft => "Robo de cuenta: phishing, hacking, comerciar";

	public override string LabelCategoryThreats => "Amenazas en la vida real y de suicidio";

	/// <summary>
	/// Key: "Label.Comment"
	/// English String: "Comment:"
	/// </summary>
	public override string LabelComment => "Comentario:";

	/// <summary>
	/// Key: "Label.DeletePost"
	/// English String: "Delete Post (and any replies)"
	/// </summary>
	public override string LabelDeletePost => "Eliminar publicación (y todas las respuestas)";

	/// <summary>
	/// Key: "Label.LeaveUnchanged"
	/// English String: "Leave post unchanged"
	/// </summary>
	public override string LabelLeaveUnchanged => "No modificar la publicación";

	/// <summary>
	/// Key: "Label.ModCategoryAdultContent"
	/// English String: "Adult Content"
	/// </summary>
	public override string LabelModCategoryAdultContent => "Contenido para adultos";

	/// <summary>
	/// Key: "Label.ModCategoryAdvertisement"
	/// English String: "Advertisement"
	/// </summary>
	public override string LabelModCategoryAdvertisement => "Publicidad";

	/// <summary>
	/// Key: "Label.ModCategoryHarrasment"
	/// English String: "Harrasment"
	/// </summary>
	public override string LabelModCategoryHarrasment => "Acoso";

	/// <summary>
	/// Key: "Label.ModCategoryInappropriate"
	/// English String: "Inappropriate"
	/// </summary>
	public override string LabelModCategoryInappropriate => "Inadecuado";

	/// <summary>
	/// Key: "Label.ModCategoryNone"
	/// English String: "None"
	/// </summary>
	public override string LabelModCategoryNone => "Ninguno";

	/// <summary>
	/// Key: "Label.ModCategoryPrivacy"
	/// English String: "Privacy"
	/// </summary>
	public override string LabelModCategoryPrivacy => "Privacidad";

	/// <summary>
	/// Key: "Label.ModCategoryProfanity"
	/// English String: "Profanity"
	/// </summary>
	public override string LabelModCategoryProfanity => "Lenguaje vulgar";

	/// <summary>
	/// Key: "Label.ModCategoryScamming"
	/// English String: "Scamming"
	/// </summary>
	public override string LabelModCategoryScamming => "Estafa";

	/// <summary>
	/// Key: "Label.ModCategorySpam"
	/// English String: "Spam"
	/// </summary>
	public override string LabelModCategorySpam => "Spam";

	/// <summary>
	/// Key: "Label.ModCategoryUnclassified"
	/// English String: "Unclassified Mild"
	/// </summary>
	public override string LabelModCategoryUnclassified => "Moderado sin clasificar";

	/// <summary>
	/// Key: "Label.ModeratorNote"
	/// English String: "NOTE: Deleting this post you will also delete replies. If you choose to scrub or delete the post, this report will skip the abuse queue and go directly to the user queue."
	/// </summary>
	public override string LabelModeratorNote => "NOTA: eliminar esta publicación también eliminará las respuestas. Si eliges limpiar o eliminar la publicación, esta denuncia se saltará la cola de abusos e irá directamente a la cola de usuario.";

	/// <summary>
	/// Key: "Label.NeedJavaScript"
	/// English String: "You need JavaScript enabled to view this video."
	/// </summary>
	public override string LabelNeedJavaScript => "Necesitas tener JavaScript activado para ver este vídeo.";

	/// <summary>
	/// Key: "Label.NotSureQuestion"
	/// English String: "Not sure if the thing you are trying to report is really against the rules?"
	/// </summary>
	public override string LabelNotSureQuestion => "¿No sabes con seguridad si lo que intentas denunciar va de verdad contra las normas?";

	/// <summary>
	/// Key: "Label.PrivacyPolicyLink"
	/// English String: "Privacy Policy"
	/// </summary>
	public override string LabelPrivacyPolicyLink => "Política de privacidad";

	/// <summary>
	/// Key: "Label.Reason"
	/// English String: "Reason"
	/// </summary>
	public override string LabelReason => "Motivo";

	/// <summary>
	/// Key: "Label.Rules1"
	/// English String: "No swear words"
	/// </summary>
	public override string LabelRules1 => "No usar palabrotas";

	/// <summary>
	/// Key: "Label.Rules2"
	/// English String: "No account sharing or trading"
	/// </summary>
	public override string LabelRules2 => "No compartir ni vender cuentas";

	/// <summary>
	/// Key: "Label.Rules3"
	/// English String: "No dating - no asking for boyfriends or girlfriends"
	/// </summary>
	public override string LabelRules3 => "No buscar citas: no solicitar relaciones sentimentales";

	/// <summary>
	/// Key: "Label.Rules4"
	/// English String: "No asking real life info about each other - no asking for phone numbers or email addresses"
	/// </summary>
	public override string LabelRules4 => "No pedir información de la vida real de otros: no pedir números de teléfono ni direcciones de correo electrónico";

	/// <summary>
	/// Key: "Label.RulesHeading"
	/// English String: "Some of the basic rules of Roblox include the following:"
	/// </summary>
	public override string LabelRulesHeading => "Algunas de las normas básicas de Roblox incluyen las siguientes:";

	/// <summary>
	/// Key: "Label.SafetyHelpLink"
	/// Display text for a link to the safety help page
	/// English String: "Roblox Safety."
	/// </summary>
	public override string LabelSafetyHelpLink => "Seguridad de Roblox.";

	/// <summary>
	/// Key: "Label.ScrubBody"
	/// English String: "Scrub Body"
	/// </summary>
	public override string LabelScrubBody => "Limpiar cuerpo";

	/// <summary>
	/// Key: "Label.ScrubSubjectAndBody"
	/// English String: "Scrub Subject and Body"
	/// </summary>
	public override string LabelScrubSubjectAndBody => "Limpiar asunto y cuerpo";

	/// <summary>
	/// Key: "Label.SeeCommunityRules"
	/// English String: "See Community Rules"
	/// </summary>
	public override string LabelSeeCommunityRules => "Ver Normas de la comunidad";

	/// <summary>
	/// Key: "Label.SelectCategory"
	/// English String: "Please select a category"
	/// </summary>
	public override string LabelSelectCategory => "Elige una categoría";

	/// <summary>
	/// Key: "Label.SelectMedia"
	/// English String: "Select any inappropriate media:"
	/// </summary>
	public override string LabelSelectMedia => "Selecciona cualquier medio inadecuado:";

	/// <summary>
	/// Key: "Label.SelectReason"
	/// English String: "Select a reason for your moderation action:"
	/// </summary>
	public override string LabelSelectReason => "Elige un motivo para tu acción de moderar:";

	/// <summary>
	/// Key: "Label.Subject"
	/// English String: "Subject:"
	/// </summary>
	public override string LabelSubject => "Asunto:";

	/// <summary>
	/// Key: "Message.ErrorMissingParams"
	/// English String: "One or more required parameters are missing or invalid"
	/// </summary>
	public override string MessageErrorMissingParams => "Uno o más parámetros no han sido cumplimentados o no son válidos.";

	/// <summary>
	/// Key: "Message.ErrorReportingCategories"
	/// English String: "There was a problem loading reporting categories."
	/// </summary>
	public override string MessageErrorReportingCategories => "Ha habido un problema al cargar las categorías de las denuncias.";

	/// <summary>
	/// Key: "Message.ErrorSubmit"
	/// English String: "There was a problem submitting your report."
	/// </summary>
	public override string MessageErrorSubmit => "Ha habido un problema al enviar tu denuncia.";

	/// <summary>
	/// Key: "Message.GenericError"
	/// English String: "There was a problem with the page"
	/// </summary>
	public override string MessageGenericError => "Ha habido un problema con la página.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Your report has been sent."
	/// </summary>
	public override string MessageSuccess => "Se ha enviado tu denuncia.";

	/// <summary>
	/// Key: "Message.ThankYou"
	/// Thank you message to appear with confirmation of successful report. Followed by a link to the localized help page
	/// English String: "Thank you for your report.  We will investigate further to determine if there has been a violation of our Terms of Use.  For more information check out "
	/// </summary>
	public override string MessageThankYou => "Gracias por enviarnos la denuncia. Vamos a investigar más a fondo para ver si ha habido una infracción a nuestros Términos de uso. Para obtener información adicional, consulta ";

	/// <summary>
	/// Key: "Response.PermissionError"
	/// English String: "This account does not have enough permissions"
	/// </summary>
	public override string ResponsePermissionError => "Esta cuenta no tiene suficientes permisos.";

	public ReportAbuseResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionClose()
	{
		return "Cerrar";
	}

	protected override string _GetTemplateForActionReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Enviar";
	}

	protected override string _GetTemplateForExampleComment()
	{
		return "Comentario (opcional)...";
	}

	protected override string _GetTemplateForHeadingReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForHeadingSuccess()
	{
		return "¡Gracias!";
	}

	protected override string _GetTemplateForLabelAllRulesLink()
	{
		return "Ver todas las normas.";
	}

	protected override string _GetTemplateForLabelBlockWarning()
	{
		return "Los usuarios que no cumplan las normas recibirán una advertencia primero, pero si persisten, les pediremos que no vuelvan a Roblox. De esta manera, Roblox seguirá siendo divertido y seguro.";
	}

	protected override string _GetTemplateForLabelCategoryBullying()
	{
		return "Abuso, acoso, discurso de odio";
	}

	protected override string _GetTemplateForLabelCategoryBullyingV2()
	{
		return "Intimidación, acoso, discriminación";
	}

	protected override string _GetTemplateForLabelCategoryContent()
	{
		return "Conten. inadecuado: lugar, imagen, modelo";
	}

	protected override string _GetTemplateForLabelCategoryDating()
	{
		return "Solicitud de cita";
	}

	protected override string _GetTemplateForLabelCategoryInappropriate()
	{
		return "Lenguaje inadecuado, vulgar y contenido adulto";
	}

	protected override string _GetTemplateForLabelCategoryOther()
	{
		return "Incumplimiento de otra norma";
	}

	protected override string _GetTemplateForLabelCategoryPrivateInfo()
	{
		return "Pedir o dar información privada";
	}

	protected override string _GetTemplateForLabelCategoryScamming()
	{
		return "Exploits, trampas, estafa";
	}

	protected override string _GetTemplateForLabelCategoryTheft()
	{
		return "Robo de cuenta: phishing, hacking, comerciar";
	}

	protected override string _GetTemplateForLabelCategoryThreats()
	{
		return "Amenazas en la vida real y de suicidio";
	}

	protected override string _GetTemplateForLabelComment()
	{
		return "Comentario:";
	}

	protected override string _GetTemplateForLabelDeletePost()
	{
		return "Eliminar publicación (y todas las respuestas)";
	}

	protected override string _GetTemplateForLabelLeaveUnchanged()
	{
		return "No modificar la publicación";
	}

	protected override string _GetTemplateForLabelModCategoryAdultContent()
	{
		return "Contenido para adultos";
	}

	protected override string _GetTemplateForLabelModCategoryAdvertisement()
	{
		return "Publicidad";
	}

	protected override string _GetTemplateForLabelModCategoryHarrasment()
	{
		return "Acoso";
	}

	protected override string _GetTemplateForLabelModCategoryInappropriate()
	{
		return "Inadecuado";
	}

	protected override string _GetTemplateForLabelModCategoryNone()
	{
		return "Ninguno";
	}

	protected override string _GetTemplateForLabelModCategoryPrivacy()
	{
		return "Privacidad";
	}

	protected override string _GetTemplateForLabelModCategoryProfanity()
	{
		return "Lenguaje vulgar";
	}

	protected override string _GetTemplateForLabelModCategoryScamming()
	{
		return "Estafa";
	}

	protected override string _GetTemplateForLabelModCategorySpam()
	{
		return "Spam";
	}

	protected override string _GetTemplateForLabelModCategoryUnclassified()
	{
		return "Moderado sin clasificar";
	}

	protected override string _GetTemplateForLabelModeratorNote()
	{
		return "NOTA: eliminar esta publicación también eliminará las respuestas. Si eliges limpiar o eliminar la publicación, esta denuncia se saltará la cola de abusos e irá directamente a la cola de usuario.";
	}

	protected override string _GetTemplateForLabelNeedJavaScript()
	{
		return "Necesitas tener JavaScript activado para ver este vídeo.";
	}

	protected override string _GetTemplateForLabelNotSureQuestion()
	{
		return "¿No sabes con seguridad si lo que intentas denunciar va de verdad contra las normas?";
	}

	protected override string _GetTemplateForLabelPrivacyPolicyLink()
	{
		return "Política de privacidad";
	}

	protected override string _GetTemplateForLabelReason()
	{
		return "Motivo";
	}

	protected override string _GetTemplateForLabelRules1()
	{
		return "No usar palabrotas";
	}

	protected override string _GetTemplateForLabelRules2()
	{
		return "No compartir ni vender cuentas";
	}

	protected override string _GetTemplateForLabelRules3()
	{
		return "No buscar citas: no solicitar relaciones sentimentales";
	}

	protected override string _GetTemplateForLabelRules4()
	{
		return "No pedir información de la vida real de otros: no pedir números de teléfono ni direcciones de correo electrónico";
	}

	protected override string _GetTemplateForLabelRulesHeading()
	{
		return "Algunas de las normas básicas de Roblox incluyen las siguientes:";
	}

	protected override string _GetTemplateForLabelSafetyHelpLink()
	{
		return "Seguridad de Roblox.";
	}

	protected override string _GetTemplateForLabelScrubBody()
	{
		return "Limpiar cuerpo";
	}

	protected override string _GetTemplateForLabelScrubSubjectAndBody()
	{
		return "Limpiar asunto y cuerpo";
	}

	protected override string _GetTemplateForLabelSeeCommunityRules()
	{
		return "Ver Normas de la comunidad";
	}

	protected override string _GetTemplateForLabelSelectCategory()
	{
		return "Elige una categoría";
	}

	protected override string _GetTemplateForLabelSelectMedia()
	{
		return "Selecciona cualquier medio inadecuado:";
	}

	protected override string _GetTemplateForLabelSelectReason()
	{
		return "Elige un motivo para tu acción de moderar:";
	}

	protected override string _GetTemplateForLabelSubject()
	{
		return "Asunto:";
	}

	/// <summary>
	/// Key: "Label.TellUsHow"
	/// English String: "Tell us how you think {creatorName} is breaking the rules of Roblox."
	/// </summary>
	public override string LabelTellUsHow(string creatorName)
	{
		return $"Dinos en qué crees que {creatorName} vulnera las normas de Roblox.";
	}

	protected override string _GetTemplateForLabelTellUsHow()
	{
		return "Dinos en qué crees que {creatorName} vulnera las normas de Roblox.";
	}

	protected override string _GetTemplateForMessageErrorMissingParams()
	{
		return "Uno o más parámetros no han sido cumplimentados o no son válidos.";
	}

	protected override string _GetTemplateForMessageErrorReportingCategories()
	{
		return "Ha habido un problema al cargar las categorías de las denuncias.";
	}

	protected override string _GetTemplateForMessageErrorSubmit()
	{
		return "Ha habido un problema al enviar tu denuncia.";
	}

	protected override string _GetTemplateForMessageGenericError()
	{
		return "Ha habido un problema con la página.";
	}

	protected override string _GetTemplateForMessageSuccess()
	{
		return "Se ha enviado tu denuncia.";
	}

	protected override string _GetTemplateForMessageThankYou()
	{
		return "Gracias por enviarnos la denuncia. Vamos a investigar más a fondo para ver si ha habido una infracción a nuestros Términos de uso. Para obtener información adicional, consulta ";
	}

	protected override string _GetTemplateForResponsePermissionError()
	{
		return "Esta cuenta no tiene suficientes permisos.";
	}
}
