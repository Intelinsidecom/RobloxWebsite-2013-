namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_vi_vn : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "Đồng ý";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "Đồng ý";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "Cho phép";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "Quay lại";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "Hủy";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "Xác nhận";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "Xóa";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "Hủy bỏ";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "Không";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "OK";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "Lưu";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "Gửi";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "Có";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "Ngày tháng";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "Tháng 4";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "Tháng 8";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "Ngày";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "Tháng 12";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "Tháng 2";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "Tháng 1";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "Tháng 7";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "Tháng 6";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "Tháng 3";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "Tháng 5";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "Tháng";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Tiếp theo";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "Tháng 11";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "Tháng 10";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Trước";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "Tháng 9";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "Năm";

	public ControlsResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "Đồng ý";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "Đồng ý";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "Cho phép";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "Quay lại";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "Hủy";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "Xác nhận";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "Xóa";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "Hủy bỏ";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "Không";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "OK";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "Lưu";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "Gửi";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "Có";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "Ngày tháng";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "Tháng 4";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "Tháng 8";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"Trang {currentPage}";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "Trang {currentPage}";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "Ngày";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "Tháng 12";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "Tháng 2";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "Tháng 1";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "Tháng 7";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "Tháng 6";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "Tháng 3";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "Tháng 5";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "Tháng";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Tiếp theo";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "Tháng 11";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "Tháng 10";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Trước";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "Tháng 9";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "Năm";
	}
}
