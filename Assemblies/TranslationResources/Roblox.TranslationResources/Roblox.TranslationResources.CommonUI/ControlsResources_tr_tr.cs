namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_tr_tr : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Kabul Et";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Kabul Et";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "İzin ver";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Geri";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "İptal Et";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Doğrula";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Sil";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Vazgeç";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Hayır";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "Tamam";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Kaydet";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gönder";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Evet";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Tarih";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Nisan";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Ağustos";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Gün";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Aralık";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Şubat";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Ocak";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Temmuz";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Haziran";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Mart";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Mayıs";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Ay";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Sonraki";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Kasım";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Ekim";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Önceki";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Eylül";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Yıl";

	public ControlsResources_tr_tr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Kabul Et";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Kabul Et";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "İzin ver";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Geri";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "İptal Et";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Doğrula";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Sil";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Vazgeç";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Hayır";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "Tamam";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Kaydet";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gönder";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Evet";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Tarih";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Nisan";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Ağustos";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Sayfa {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Sayfa {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Gün";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Aralık";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Şubat";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Ocak";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Temmuz";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Haziran";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Mart";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Mayıs";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Ay";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Sonraki";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Kasım";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Ekim";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Önceki";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Eylül";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Yıl";
	}
}
