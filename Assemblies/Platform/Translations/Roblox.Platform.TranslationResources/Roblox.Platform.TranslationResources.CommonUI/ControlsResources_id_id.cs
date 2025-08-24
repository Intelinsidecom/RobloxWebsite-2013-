namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_id_id : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Terima";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Setuju";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Izinkan";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Kembali";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Batal";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Konfirmasi";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Hapus";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Buang";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Tidak";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "OKE";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Simpan";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Kirim";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Ya";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Tanggal";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "April";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Agustus";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Hari";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Desember";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Februari";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Januari";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Juli";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Juni";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Maret";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Mei";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Bulan";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Berikutnya";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "November";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Oktober";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Sebelumnya";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "September";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Tahun";

	public ControlsResources_id_id(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Terima";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Setuju";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Izinkan";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Kembali";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Batal";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Konfirmasi";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Hapus";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Buang";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Tidak";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "OKE";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Simpan";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Kirim";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Ya";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Tanggal";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "April";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Agustus";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Halaman {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Halaman {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Hari";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Desember";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Februari";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Januari";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Juli";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Juni";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Maret";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Mei";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Bulan";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Berikutnya";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "November";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Oktober";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Sebelumnya";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "September";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Tahun";
	}
}
