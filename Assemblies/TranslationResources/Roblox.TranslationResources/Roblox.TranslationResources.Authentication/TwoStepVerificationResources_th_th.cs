namespace Roblox.TranslationResources.Authentication;

/// <summary>
/// This class overrides TwoStepVerificationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TwoStepVerificationResources_th_th : TwoStepVerificationResources_en_us, ITwoStepVerificationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "ยกเล\u0e34ก";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public override string ActionResend => "ส\u0e48งรห\u0e31สใหม\u0e48";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public override string ActionStartOver => "เร\u0e34\u0e48มต\u0e49นใหม\u0e48หมด";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "ส\u0e48ง";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public override string ActionVerify => "ตรวจสอบ";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public override string LabelCode => "รห\u0e31ส";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public override string LabelDidNotReceive => "ไม\u0e48ได\u0e49ร\u0e31บรห\u0e31ส?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public override string LabelEnterCode => "ป\u0e49อนรห\u0e31ส (6 หล\u0e31ก)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public override string LabelEnterEmailCode => "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางอ\u0e35เมล";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public override string LabelEnterTextCode => "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางการส\u0e48งข\u0e49อความ";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public override string LabelEnterTwoStepVerificationCode => "ป\u0e49อนรห\u0e31สการย\u0e37นย\u0e31นสองข\u0e31\u0e49นตอนของค\u0e38ณ";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public override string LabelFacebookPasswordWarning => "หากค\u0e38ณได\u0e49ใช\u0e49การลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วย Facebook มาก\u0e48อน ค\u0e38ณจะต\u0e49องต\u0e31\u0e49งรห\u0e31สผ\u0e48าน";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public override string LabelLearnMore => "เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34ม";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public override string LabelNewCode => "รห\u0e31สใหม\u0e48";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public override string LabelRobloxSupport => "ฝ\u0e48ายสน\u0e31บสน\u0e38น Roblox";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public override string LabelTrustThisDevice => "เช\u0e37\u0e48ออ\u0e38ปกรณ\u0e4cน\u0e35\u0e49เป\u0e47นเวลา 30 ว\u0e31น";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public override string LabelTwoStepVerification => "การตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49น";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public override string ResponseCodeSent => "ส\u0e48งรห\u0e31สแล\u0e49ว";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public override string ResponseFeatureNotAvailable => "ฟ\u0e35เจอร\u0e4cไม\u0e48พร\u0e49อมใช\u0e49งาน กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38น";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public override string ResponseInvalidCode => "รห\u0e31สไม\u0e48ถ\u0e39กต\u0e49อง";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public override string ResponseSystemErrorReturnToLogin => "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ กร\u0e38ณากล\u0e31บส\u0e39\u0e48หน\u0e49าการเข\u0e49าส\u0e39\u0e48ระบบ";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public override string ResponseTooManyAttempts => "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public override string ResponseTooManyCharacters => "ม\u0e35อ\u0e31กขระมากเก\u0e34นไป";

	public TwoStepVerificationResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "ยกเล\u0e34ก";
	}

	protected override string _GetTemplateForActionResend()
	{
		return "ส\u0e48งรห\u0e31สใหม\u0e48";
	}

	protected override string _GetTemplateForActionStartOver()
	{
		return "เร\u0e34\u0e48มต\u0e49นใหม\u0e48หมด";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "ส\u0e48ง";
	}

	protected override string _GetTemplateForActionVerify()
	{
		return "ตรวจสอบ";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"สว\u0e31สด\u0e35 {accountName}{lineBreak}{lineBreak}ค\u0e38ณเป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ คร\u0e31\u0e49งถ\u0e31ดไปท\u0e35\u0e48ค\u0e38ณเข\u0e49าส\u0e39\u0e48ระบบจากอ\u0e38ปกรณ\u0e4cใหม\u0e48 ค\u0e38ณก\u0e47จะต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ย 6 หล\u0e31กท\u0e35\u0e48ทาง Roblox ได\u0e49ส\u0e48งให\u0e49ก\u0e31บค\u0e38ณทางอ\u0e35เมล{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "สว\u0e31สด\u0e35 {accountName}{lineBreak}{lineBreak}ค\u0e38ณเป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ คร\u0e31\u0e49งถ\u0e31ดไปท\u0e35\u0e48ค\u0e38ณเข\u0e49าส\u0e39\u0e48ระบบจากอ\u0e38ปกรณ\u0e4cใหม\u0e48 ค\u0e38ณก\u0e47จะต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ย 6 หล\u0e31กท\u0e35\u0e48ทาง Roblox ได\u0e49ส\u0e48งให\u0e49ก\u0e31บค\u0e38ณทางอ\u0e35เมล{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"สว\u0e31สด\u0e35{lineBreak}{lineBreak}ม\u0e35การเป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35ล\u0e39กของ Roblox ของค\u0e38ณ {accountName} คร\u0e31\u0e49งถ\u0e31ดไปท\u0e35\u0e48พวกเขาเข\u0e49าส\u0e39\u0e48ระบบจากอ\u0e38ปกรณ\u0e4cใหม\u0e48 พวกเขาก\u0e47จะต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ย 6 หล\u0e31กท\u0e35\u0e48ทาง Roblox ได\u0e49ส\u0e48งให\u0e49ก\u0e31บค\u0e38ณทางอ\u0e35เมล{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "สว\u0e31สด\u0e35{lineBreak}{lineBreak}ม\u0e35การเป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35ล\u0e39กของ Roblox ของค\u0e38ณ {accountName} คร\u0e31\u0e49งถ\u0e31ดไปท\u0e35\u0e48พวกเขาเข\u0e49าส\u0e39\u0e48ระบบจากอ\u0e38ปกรณ\u0e4cใหม\u0e48 พวกเขาก\u0e47จะต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ย 6 หล\u0e31กท\u0e35\u0e48ทาง Roblox ได\u0e49ส\u0e48งให\u0e49ก\u0e31บค\u0e38ณทางอ\u0e35เมล{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"เป\u0e34ดการทำงานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox แล\u0e49ว: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "เป\u0e34ดการทำงานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox แล\u0e49ว: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"สว\u0e31สด\u0e35{accountName}{lineBreak}{lineBreak}ค\u0e38ณป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ ค\u0e38ณจะไม\u0e48จำเป\u0e47นต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ยสำหร\u0e31บการเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35ของค\u0e38ณอ\u0e35กต\u0e48อไป{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "สว\u0e31สด\u0e35{accountName}{lineBreak}{lineBreak}ค\u0e38ณป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox ของค\u0e38ณ ค\u0e38ณจะไม\u0e48จำเป\u0e47นต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ยสำหร\u0e31บการเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35ของค\u0e38ณอ\u0e35กต\u0e48อไป{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"สว\u0e31สด\u0e35{lineBreak}{lineBreak}ม\u0e35การป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35ล\u0e39กของ Roblox ของค\u0e38ณ {accountName} พวกเขาจะไม\u0e48จำเป\u0e47นต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ยสำหร\u0e31บการเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35น\u0e31\u0e49นอ\u0e35กต\u0e48อไป{lineBreak}{lineBreak}Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "สว\u0e31สด\u0e35{lineBreak}{lineBreak}ม\u0e35การป\u0e34ดการใช\u0e49งานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35ล\u0e39กของ Roblox ของค\u0e38ณ {accountName} พวกเขาจะไม\u0e48จำเป\u0e47นต\u0e49องป\u0e49อนรห\u0e31สร\u0e31กษาความปลอดภ\u0e31ยสำหร\u0e31บการเข\u0e49าส\u0e39\u0e48บ\u0e31ญช\u0e35น\u0e31\u0e49นอ\u0e35กต\u0e48อไป{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"ป\u0e34ดการทำงานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox แล\u0e49ว: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "ป\u0e34ดการทำงานการตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox แล\u0e49ว: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}({ipAddress}){spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}({ipAddress}){spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country} ({ipAddress}){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country} ({ipAddress}){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} (จากภายใน Roblox){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} (จากภายใน Roblox){spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {city}, {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {city}, {region}, {country}{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}รห\u0e31สการเข\u0e49าส\u0e39\u0e48ระบบสำหร\u0e31บ {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}ป\u0e49อนรห\u0e31สน\u0e35\u0e49ในหน\u0e49าจอการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอนเพ\u0e37\u0e48อจบการเข\u0e49าส\u0e39\u0e48ระบบ รห\u0e31สน\u0e35\u0e49จะหมดอาย\u0e38ใน 15 นาท\u0e35 {lineBreak}{lineBreak}อ\u0e35เมลน\u0e35\u0e49ส\u0e48งมาให\u0e49ค\u0e38ณเน\u0e37\u0e48องจากบ\u0e31ญช\u0e35ของค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox จากเบราว\u0e4cเซอร\u0e4cใหม\u0e48หร\u0e37ออ\u0e38ปกรณ\u0e4cใหม\u0e48 หากค\u0e38ณไม\u0e48ได\u0e49พยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox อาจม\u0e35ใครบางคนพยายามเข\u0e49าถ\u0e36งบ\u0e31ญช\u0e35ของค\u0e38ณ เราขอแนะนำให\u0e49ค\u0e38ณเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ หากค\u0e38ณไม\u0e48ใช\u0e48ผ\u0e39\u0e49ทำการร\u0e49องขอน\u0e35\u0e49{lineBreak}{lineBreak}ร\u0e35ซอร\u0e4cส:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}เปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34มเก\u0e35\u0e48ยวก\u0e31บการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอน{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ปกป\u0e49องบ\u0e31ญช\u0e35ของค\u0e38ณให\u0e49ปลอดภ\u0e31ย{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ฝ\u0e48ายสน\u0e31บสน\u0e38นท\u0e31\u0e48วไปของ Roblox{aTagEnd}{lineBreak}{lineBreak}ขอบค\u0e38ณ{lineBreak}{lineBreak}ท\u0e35มงาน Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}รห\u0e31สการเข\u0e49าส\u0e39\u0e48ระบบสำหร\u0e31บ {accountName}: {lineBreak}{lineBreak} {code} {spanEndTag}{lineBreak}{lineBreak}ป\u0e49อนรห\u0e31สน\u0e35\u0e49ในหน\u0e49าจอการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอนเพ\u0e37\u0e48อจบการเข\u0e49าส\u0e39\u0e48ระบบ รห\u0e31สน\u0e35\u0e49จะหมดอาย\u0e38ใน 15 นาท\u0e35 {lineBreak}{lineBreak}อ\u0e35เมลน\u0e35\u0e49ส\u0e48งมาให\u0e49ค\u0e38ณเน\u0e37\u0e48องจากบ\u0e31ญช\u0e35ของค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox จากเบราว\u0e4cเซอร\u0e4cใหม\u0e48หร\u0e37ออ\u0e38ปกรณ\u0e4cใหม\u0e48 หากค\u0e38ณไม\u0e48ได\u0e49พยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox อาจม\u0e35ใครบางคนพยายามเข\u0e49าถ\u0e36งบ\u0e31ญช\u0e35ของค\u0e38ณ เราขอแนะนำให\u0e49ค\u0e38ณเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ หากค\u0e38ณไม\u0e48ใช\u0e48ผ\u0e39\u0e49ทำการร\u0e49องขอน\u0e35\u0e49{lineBreak}{lineBreak}ร\u0e35ซอร\u0e4cส:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}เปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ{aTagEnd}{lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34มเก\u0e35\u0e48ยวก\u0e31บการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอน{aTagEnd}{lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}ปกป\u0e49องบ\u0e31ญช\u0e35ของค\u0e38ณให\u0e49ปลอดภ\u0e31ย{aTagEnd}{lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}ฝ\u0e48ายสน\u0e31บสน\u0e38นท\u0e31\u0e48วไปของ Roblox{aTagEnd}{lineBreak}{lineBreak}ขอบค\u0e38ณ{lineBreak}{lineBreak}ท\u0e35มงาน Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}รห\u0e31สการเข\u0e49าส\u0e39\u0e48ระบบสำหร\u0e31บ {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}ป\u0e49อนรห\u0e31สน\u0e35\u0e49ในหน\u0e49าจอการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอนเพ\u0e37\u0e48อจบการเข\u0e49าส\u0e39\u0e48ระบบ รห\u0e31สน\u0e35\u0e49จะหมดอาย\u0e38ใน 15 นาท\u0e35 {lineBreak}{lineBreak}อ\u0e35เมลน\u0e35\u0e49ส\u0e48งมาให\u0e49ค\u0e38ณเน\u0e37\u0e48องจากบ\u0e31ญช\u0e35ของค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox จากเบราว\u0e4cเซอร\u0e4cใหม\u0e48หร\u0e37ออ\u0e38ปกรณ\u0e4cใหม\u0e48 หากค\u0e38ณไม\u0e48ได\u0e49พยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox อาจม\u0e35ใครบางคนพยายามเข\u0e49าถ\u0e36งบ\u0e31ญช\u0e35ของค\u0e38ณ เราขอแนะนำให\u0e49ค\u0e38ณเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ หากค\u0e38ณไม\u0e48ใช\u0e48ผ\u0e39\u0e49ทำการร\u0e49องขอน\u0e35\u0e49{lineBreak}{lineBreak}ร\u0e35ซอร\u0e4cส: {lineBreak}เปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ [{accountInfoPageLink}] {lineBreak}เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34มเก\u0e35\u0e48ยวก\u0e31บการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอน [{twoStepVerificationHelpArticleLink}]{lineBreak}ปกป\u0e49องบ\u0e31ญช\u0e35ของค\u0e38ณให\u0e49ปลอดภ\u0e31ย [{keepAccountSafeArticleLink}]{lineBreak}ฝ\u0e48ายสน\u0e31บสน\u0e38นท\u0e31\u0e48วไปของ Roblox [{supportPageLink}] {lineBreak}{lineBreak}ขอบค\u0e38ณ{lineBreak}{lineBreak}ท\u0e35มงาน Roblox";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}รห\u0e31สการเข\u0e49าส\u0e39\u0e48ระบบสำหร\u0e31บ {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}ป\u0e49อนรห\u0e31สน\u0e35\u0e49ในหน\u0e49าจอการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอนเพ\u0e37\u0e48อจบการเข\u0e49าส\u0e39\u0e48ระบบ รห\u0e31สน\u0e35\u0e49จะหมดอาย\u0e38ใน 15 นาท\u0e35 {lineBreak}{lineBreak}อ\u0e35เมลน\u0e35\u0e49ส\u0e48งมาให\u0e49ค\u0e38ณเน\u0e37\u0e48องจากบ\u0e31ญช\u0e35ของค\u0e38ณพยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox จากเบราว\u0e4cเซอร\u0e4cใหม\u0e48หร\u0e37ออ\u0e38ปกรณ\u0e4cใหม\u0e48 หากค\u0e38ณไม\u0e48ได\u0e49พยายามเข\u0e49าส\u0e39\u0e48ระบบ Roblox อาจม\u0e35ใครบางคนพยายามเข\u0e49าถ\u0e36งบ\u0e31ญช\u0e35ของค\u0e38ณ เราขอแนะนำให\u0e49ค\u0e38ณเปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ หากค\u0e38ณไม\u0e48ใช\u0e48ผ\u0e39\u0e49ทำการร\u0e49องขอน\u0e35\u0e49{lineBreak}{lineBreak}ร\u0e35ซอร\u0e4cส: {lineBreak}เปล\u0e35\u0e48ยนรห\u0e31สผ\u0e48านของค\u0e38ณ [{accountInfoPageLink}] {lineBreak}เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34มเก\u0e35\u0e48ยวก\u0e31บการย\u0e37นย\u0e31น 2 ข\u0e31\u0e49นตอน [{twoStepVerificationHelpArticleLink}]{lineBreak}ปกป\u0e49องบ\u0e31ญช\u0e35ของค\u0e38ณให\u0e49ปลอดภ\u0e31ย [{keepAccountSafeArticleLink}]{lineBreak}ฝ\u0e48ายสน\u0e31บสน\u0e38นท\u0e31\u0e48วไปของ Roblox [{supportPageLink}] {lineBreak}{lineBreak}ขอบค\u0e38ณ{lineBreak}{lineBreak}ท\u0e35มงาน Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}({ipAddress}){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}({ipAddress}){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country} ({ipAddress}){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country} ({ipAddress}){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} (จากภายใน Roblox){lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} (จากภายใน Roblox){lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {region}, {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {city}, {region}, {country}{lineBreak}{lineBreak}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "การร\u0e49องขอการเข\u0e49าส\u0e39\u0e48ระบบท\u0e35\u0e48ได\u0e49ร\u0e31บจาก {username} ท\u0e35\u0e48จาก {city}, {region}, {country}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public override string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"รห\u0e31สการย\u0e37นย\u0e31นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox: {accountName}";
	}

	protected override string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "รห\u0e31สการย\u0e37นย\u0e31นสำหร\u0e31บบ\u0e31ญช\u0e35 Roblox: {accountName}";
	}

	protected override string _GetTemplateForLabelCode()
	{
		return "รห\u0e31ส";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public override string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"ป\u0e49อนรห\u0e31ส {codeLength} หล\u0e31ก";
	}

	protected override string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "ป\u0e49อนรห\u0e31ส {codeLength} หล\u0e31ก";
	}

	protected override string _GetTemplateForLabelDidNotReceive()
	{
		return "ไม\u0e48ได\u0e49ร\u0e31บรห\u0e31ส?";
	}

	protected override string _GetTemplateForLabelEnterCode()
	{
		return "ป\u0e49อนรห\u0e31ส (6 หล\u0e31ก)";
	}

	protected override string _GetTemplateForLabelEnterEmailCode()
	{
		return "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางอ\u0e35เมล";
	}

	protected override string _GetTemplateForLabelEnterTextCode()
	{
		return "ป\u0e49อนรห\u0e31สท\u0e35\u0e48เราเพ\u0e34\u0e48งส\u0e48งให\u0e49ค\u0e38ณทางการส\u0e48งข\u0e49อความ";
	}

	protected override string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "ป\u0e49อนรห\u0e31สการย\u0e37นย\u0e31นสองข\u0e31\u0e49นตอนของค\u0e38ณ";
	}

	protected override string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "หากค\u0e38ณได\u0e49ใช\u0e49การลงช\u0e37\u0e48อเข\u0e49าส\u0e39\u0e48ระบบด\u0e49วย Facebook มาก\u0e48อน ค\u0e38ณจะต\u0e49องต\u0e31\u0e49งรห\u0e31สผ\u0e48าน";
	}

	protected override string _GetTemplateForLabelLearnMore()
	{
		return "เร\u0e35ยนร\u0e39\u0e49เพ\u0e34\u0e48มเต\u0e34ม";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public override string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"ต\u0e49องการความช\u0e48วยเหล\u0e37อง\u0e31\u0e49นเหรอ? ต\u0e34ดต\u0e48อ {supportLink}";
	}

	protected override string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "ต\u0e49องการความช\u0e48วยเหล\u0e37อง\u0e31\u0e49นเหรอ? ต\u0e34ดต\u0e48อ {supportLink}";
	}

	protected override string _GetTemplateForLabelNewCode()
	{
		return "รห\u0e31สใหม\u0e48";
	}

	protected override string _GetTemplateForLabelRobloxSupport()
	{
		return "ฝ\u0e48ายสน\u0e31บสน\u0e38น Roblox";
	}

	protected override string _GetTemplateForLabelTrustThisDevice()
	{
		return "เช\u0e37\u0e48ออ\u0e38ปกรณ\u0e4cน\u0e35\u0e49เป\u0e47นเวลา 30 ว\u0e31น";
	}

	protected override string _GetTemplateForLabelTwoStepVerification()
	{
		return "การตรวจสอบย\u0e37นย\u0e31นต\u0e31วตน 2 ข\u0e31\u0e49น";
	}

	protected override string _GetTemplateForResponseCodeSent()
	{
		return "ส\u0e48งรห\u0e31สแล\u0e49ว";
	}

	protected override string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "ฟ\u0e35เจอร\u0e4cไม\u0e48พร\u0e49อมใช\u0e49งาน กร\u0e38ณาต\u0e34ดต\u0e48อฝ\u0e48ายสน\u0e31บสน\u0e38น";
	}

	protected override string _GetTemplateForResponseInvalidCode()
	{
		return "รห\u0e31สไม\u0e48ถ\u0e39กต\u0e49อง";
	}

	protected override string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "เก\u0e34ดข\u0e49อผ\u0e34ดพลาดก\u0e31บระบบ กร\u0e38ณากล\u0e31บส\u0e39\u0e48หน\u0e49าการเข\u0e49าส\u0e39\u0e48ระบบ";
	}

	protected override string _GetTemplateForResponseTooManyAttempts()
	{
		return "ม\u0e35การดำเน\u0e34นการซ\u0e49ำมากเก\u0e34นไป กร\u0e38ณาลองใหม\u0e48อ\u0e35กคร\u0e31\u0e49งในภายหล\u0e31ง";
	}

	protected override string _GetTemplateForResponseTooManyCharacters()
	{
		return "ม\u0e35อ\u0e31กขระมากเก\u0e34นไป";
	}
}
