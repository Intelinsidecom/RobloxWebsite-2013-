namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides MessagesResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class MessagesResources_id_id : MessagesResources_en_us, IMessagesResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.PreviousPage"
	/// button title
	/// English String: "Go to the Previous Page"
	/// </summary>
	public override string ActionPreviousPage => "Kembali ke Halaman Sebelumnya";

	/// <summary>
	/// Key: "Action.ReturnHome"
	/// button title
	/// English String: "Return Home"
	/// </summary>
	public override string ActionReturnHome => "Kembali ke Beranda";

	/// <summary>
	/// Key: "Label.Error"
	/// English String: "Error"
	/// </summary>
	public override string LabelError => "Kesalahan";

	/// <summary>
	/// Key: "Label.ErrorImage"
	/// alternate text shown for error image
	/// English String: "Error Image"
	/// </summary>
	public override string LabelErrorImage => "Kesalahan Gambar";

	/// <summary>
	/// Key: "Label.TooManyCharacters"
	/// English String: "Too many characters!"
	/// </summary>
	public override string LabelTooManyCharacters => "Terlalu banyak karakter!";

	/// <summary>
	/// Key: "Message.AlwaysAllowed"
	/// English String: "Always allowed"
	/// </summary>
	public override string MessageAlwaysAllowed => "Selalu izinkan";

	/// <summary>
	/// Key: "Message.AnalyiticsCookies"
	/// English String: "Analytics Cookies"
	/// </summary>
	public override string MessageAnalyiticsCookies => "Cookie Analitik";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesDescription"
	/// English String: "These cookies used for improving site performance or understanding site usage."
	/// </summary>
	public override string MessageAnalyiticsCookiesDescription => "Cookie ini digunakan untuk meningkatkan kinerja situs atau mengetahui penggunaan situs.";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem1"
	/// English String: "Google Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem1 => "Google Analytics";

	/// <summary>
	/// Key: "Message.AnalyiticsCookiesItem2"
	/// English String: "Google Universal Analytics"
	/// </summary>
	public override string MessageAnalyiticsCookiesItem2 => "Google Universal Analytics";

	/// <summary>
	/// Key: "Message.EssentialCookies"
	/// English String: "Essential Cookies"
	/// </summary>
	public override string MessageEssentialCookies => "Cookie Utama";

	/// <summary>
	/// Key: "Message.EssentialCookiesDescription"
	/// English String: "These cookies are required to provide the functionality on the site, such as for user authentication, securing the system or saving cookie preferences."
	/// </summary>
	public override string MessageEssentialCookiesDescription => "Cookie ini diperlukan untuk memberikan fungsi pada situs, seperti untuk autentikasi pengguna, mengamankan sistem atau menyimpan preferensi cookie.";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem1"
	/// English String: "Roblox"
	/// </summary>
	public override string MessageEssentialCookiesItem1 => "Roblox";

	/// <summary>
	/// Key: "Message.EssentialCookiesItem2"
	/// English String: "Zendesk"
	/// </summary>
	public override string MessageEssentialCookiesItem2 => "Zendesk";

	/// <summary>
	/// Key: "Message.ManageCookies"
	/// English String: "Manage Cookies"
	/// </summary>
	public override string MessageManageCookies => "Kelola Cookie";

	/// <summary>
	/// Key: "MessageEssentialCookiesItem3"
	/// English String: "Gigya"
	/// </summary>
	public override string MessageEssentialCookiesItem3 => "Gigya";

	/// <summary>
	/// Key: "Response.AccessDenied"
	/// 403 error message
	/// English String: "Access Denied"
	/// </summary>
	public override string ResponseAccessDenied => "Akses Ditolak";

	/// <summary>
	/// Key: "Response.AccessDeniedDescription"
	/// 403 error message detail
	/// English String: "You don't have permission to view this page"
	/// </summary>
	public override string ResponseAccessDeniedDescription => "Kamu tidak memiliki izin untuk melihat halaman ini";

	/// <summary>
	/// Key: "Response.BadRequest"
	/// 400 error message title
	/// English String: "Bad Request"
	/// </summary>
	public override string ResponseBadRequest => "Permintaan Salah";

	/// <summary>
	/// Key: "Response.BadRequestDescription"
	/// error message detail for 400 error
	/// English String: "There was a problem with your request"
	/// </summary>
	public override string ResponseBadRequestDescription => "Ada masalah pada permintaanmu";

	/// <summary>
	/// Key: "Response.InternalServerError"
	/// 500 error message title
	/// English String: "Internal Server Error"
	/// </summary>
	public override string ResponseInternalServerError => "Kesalahan Server Internal";

	/// <summary>
	/// Key: "Response.InternalServerErrorDescription"
	/// 500 error message description
	/// English String: "An unexpected error occurred"
	/// </summary>
	public override string ResponseInternalServerErrorDescription => "Terjadi kesalahan tak terduga";

	/// <summary>
	/// Key: "Response.PageNotFound"
	/// 404 error message title
	/// English String: "Page Not found"
	/// </summary>
	public override string ResponsePageNotFound => "Halaman Tidak Ditemukan";

	/// <summary>
	/// Key: "Response.PageNotFoundDescrition"
	/// 404 error message description
	/// English String: "Page cannot be found or no longer exists"
	/// </summary>
	public override string ResponsePageNotFoundDescrition => "Halaman tidak dapat ditemukan atau sudah tidak ada";

	/// <summary>
	/// Key: "Response.RequestError"
	/// error message for incorrect request
	/// English String: "Error with your request"
	/// </summary>
	public override string ResponseRequestError => "Kesalahan pada permintaanmu";

	/// <summary>
	/// Key: "Response.SomethingWentWrong"
	/// default error message
	/// English String: "Something went wrong"
	/// </summary>
	public override string ResponseSomethingWentWrong => "Terjadi kesalahan";

	/// <summary>
	/// Key: "Response.TooManyAttemptsText"
	/// English String: "Too Many Attempts"
	/// </summary>
	public override string ResponseTooManyAttemptsText => "Terlalu Banyak Percobaan";

	/// <summary>
	/// Key: "Response.UnexpectedError"
	/// default error description
	/// English String: "An unexpected error occurred. Please try again later."
	/// </summary>
	public override string ResponseUnexpectedError => "Terjadi kesalahan tak terduga. Harap coba lagi nanti.";

	public MessagesResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionPreviousPage()
	{
		return "Kembali ke Halaman Sebelumnya";
	}

	protected override string _GetTemplateForActionReturnHome()
	{
		return "Kembali ke Beranda";
	}

	/// <summary>
	/// Key: "CookieLawNoticev2"
	/// Incorrect key, obsoleted
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string CookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox menggunakan cookie untuk mempersonalisasi konten, menyediakan fitur media sosial, dan menganalisis lalu lintas situs kami. Untuk mempelajari lebih lanjut tentang cara kami menggunakan cookie dan cara {startLink}mengatur preferensi cookie{endLink}, silakan mengacu pada {startLink2}Kebijakan Privasi dan Cookie{endLink2}.";
	}

	protected override string _GetTemplateForCookieLawNoticev2()
	{
		return "Roblox menggunakan cookie untuk mempersonalisasi konten, menyediakan fitur media sosial, dan menganalisis lalu lintas situs kami. Untuk mempelajari lebih lanjut tentang cara kami menggunakan cookie dan cara {startLink}mengatur preferensi cookie{endLink}, silakan mengacu pada {startLink2}Kebijakan Privasi dan Cookie{endLink2}.";
	}

	/// <summary>
	/// Key: "Description.ContactCustomerService"
	/// message shown on common error pages
	/// English String: "If you continue to receive this page, please contact customer service at {emailLink}"
	/// </summary>
	public override string DescriptionContactCustomerService(string emailLink)
	{
		return $"Jika kamu terus melihat halaman ini, harap hubungi layanan pelanggan di {emailLink}";
	}

	protected override string _GetTemplateForDescriptionContactCustomerService()
	{
		return "Jika kamu terus melihat halaman ini, harap hubungi layanan pelanggan di {emailLink}";
	}

	protected override string _GetTemplateForLabelError()
	{
		return "Kesalahan";
	}

	protected override string _GetTemplateForLabelErrorImage()
	{
		return "Kesalahan Gambar";
	}

	protected override string _GetTemplateForLabelTooManyCharacters()
	{
		return "Terlalu banyak karakter!";
	}

	protected override string _GetTemplateForMessageAlwaysAllowed()
	{
		return "Selalu izinkan";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookies()
	{
		return "Cookie Analitik";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesDescription()
	{
		return "Cookie ini digunakan untuk meningkatkan kinerja situs atau mengetahui penggunaan situs.";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem1()
	{
		return "Google Analytics";
	}

	protected override string _GetTemplateForMessageAnalyiticsCookiesItem2()
	{
		return "Google Universal Analytics";
	}

	/// <summary>
	/// Key: "Message.CookieLawNotice"
	/// Cookies are used for Internet-based data storage, and this message warns users that we use them to improve their experience. See https://en.wikipedia.org/wiki/HTTP_cookie for more information.
	/// English String: "Roblox uses cookies to offer you a better experience. For further information, including information on how to withdraw consent and how to manage the use of cookies on Roblox, please refer to our {startLink}Privacy and Cookie Policy{endLink}."
	/// </summary>
	public override string MessageCookieLawNotice(string startLink, string endLink)
	{
		return $"Roblox memakai cookie untuk memberikan pengalaman yang lebih baik. Untuk informasi lebih lanjut, termasuk informasi cara mencabut persetujuan dan cara mengelola penggunaan cookie di Roblox, silakan baca {startLink}Kebijakan Privasi dan Cookie{endLink} kami.";
	}

	protected override string _GetTemplateForMessageCookieLawNotice()
	{
		return "Roblox memakai cookie untuk memberikan pengalaman yang lebih baik. Untuk informasi lebih lanjut, termasuk informasi cara mencabut persetujuan dan cara mengelola penggunaan cookie di Roblox, silakan baca {startLink}Kebijakan Privasi dan Cookie{endLink} kami.";
	}

	/// <summary>
	/// Key: "Message.CookieLawNoticev2"
	/// English String: "Roblox uses cookies to personalize content, provide social media features and analyze the traffic on our site. To learn about how we use cookies and how you can {startLink}manage cookie preferences{endLink}, please refer to our {startLink2}Privacy and Cookie Policy{endLink2}."
	/// </summary>
	public override string MessageCookieLawNoticev2(string startLink, string endLink, string startLink2, string endLink2)
	{
		return $"Roblox menggunakan cookie untuk mempersonalisasi konten, menyediakan fitur media sosial, dan menganalisis lalu lintas situs kami. Untuk mempelajari lebih lanjut tentang cara kami menggunakan cookie dan cara {startLink}mengatur preferensi cookie{endLink}, silakan mengacu pada {startLink2}Kebijakan Privasi dan Cookie{endLink2}.";
	}

	protected override string _GetTemplateForMessageCookieLawNoticev2()
	{
		return "Roblox menggunakan cookie untuk mempersonalisasi konten, menyediakan fitur media sosial, dan menganalisis lalu lintas situs kami. Untuk mempelajari lebih lanjut tentang cara kami menggunakan cookie dan cara {startLink}mengatur preferensi cookie{endLink}, silakan mengacu pada {startLink2}Kebijakan Privasi dan Cookie{endLink2}.";
	}

	/// <summary>
	/// Key: "Message.CookieModalText"
	/// English String: "Please choose whether this site may use cookies as described below. You can learn more about how this site uses cookies and related technologies by reading our {startLink}privacy policy{endLink}."
	/// </summary>
	public override string MessageCookieModalText(string startLink, string endLink)
	{
		return $"Pilih jika situs ini dapat menggunakan cookie seperti yang dijelaskan di bawah ini. Anda dapat mempelajari tentang cara situs ini menggunakan cookie dan tentang teknologi yang terkait dengan membaca {startLink}kebijakan privasi{endLink} kami.";
	}

	protected override string _GetTemplateForMessageCookieModalText()
	{
		return "Pilih jika situs ini dapat menggunakan cookie seperti yang dijelaskan di bawah ini. Anda dapat mempelajari tentang cara situs ini menggunakan cookie dan tentang teknologi yang terkait dengan membaca {startLink}kebijakan privasi{endLink} kami.";
	}

	protected override string _GetTemplateForMessageEssentialCookies()
	{
		return "Cookie Utama";
	}

	protected override string _GetTemplateForMessageEssentialCookiesDescription()
	{
		return "Cookie ini diperlukan untuk memberikan fungsi pada situs, seperti untuk autentikasi pengguna, mengamankan sistem atau menyimpan preferensi cookie.";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem1()
	{
		return "Roblox";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem2()
	{
		return "Zendesk";
	}

	protected override string _GetTemplateForMessageManageCookies()
	{
		return "Kelola Cookie";
	}

	protected override string _GetTemplateForMessageEssentialCookiesItem3()
	{
		return "Gigya";
	}

	protected override string _GetTemplateForResponseAccessDenied()
	{
		return "Akses Ditolak";
	}

	protected override string _GetTemplateForResponseAccessDeniedDescription()
	{
		return "Kamu tidak memiliki izin untuk melihat halaman ini";
	}

	protected override string _GetTemplateForResponseBadRequest()
	{
		return "Permintaan Salah";
	}

	protected override string _GetTemplateForResponseBadRequestDescription()
	{
		return "Ada masalah pada permintaanmu";
	}

	protected override string _GetTemplateForResponseInternalServerError()
	{
		return "Kesalahan Server Internal";
	}

	protected override string _GetTemplateForResponseInternalServerErrorDescription()
	{
		return "Terjadi kesalahan tak terduga";
	}

	protected override string _GetTemplateForResponsePageNotFound()
	{
		return "Halaman Tidak Ditemukan";
	}

	protected override string _GetTemplateForResponsePageNotFoundDescrition()
	{
		return "Halaman tidak dapat ditemukan atau sudah tidak ada";
	}

	protected override string _GetTemplateForResponseRequestError()
	{
		return "Kesalahan pada permintaanmu";
	}

	protected override string _GetTemplateForResponseSomethingWentWrong()
	{
		return "Terjadi kesalahan";
	}

	protected override string _GetTemplateForResponseTooManyAttemptsText()
	{
		return "Terlalu Banyak Percobaan";
	}

	protected override string _GetTemplateForResponseUnexpectedError()
	{
		return "Terjadi kesalahan tak terduga. Harap coba lagi nanti.";
	}
}
