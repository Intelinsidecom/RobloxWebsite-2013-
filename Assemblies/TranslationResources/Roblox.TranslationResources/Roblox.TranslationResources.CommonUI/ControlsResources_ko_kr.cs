namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_ko_kr : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "수락";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "동의";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "허용";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "뒤로";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "취소";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "확인";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "삭제";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "취소";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "아니요";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "확인";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "저장";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "제출";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "예";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "날짜";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "4월";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "8월";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "일";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "12월";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "2월";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "1월";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "7월";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "6월";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "3월";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "5월";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "월";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "다음";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "11월";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "10월";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "이전";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "9월";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "년";

	public ControlsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "수락";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "동의";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "허용";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "뒤로";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "삭제";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "취소";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "아니요";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "확인";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "저장";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "제출";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "예";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "날짜";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "4월";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "8월";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"{currentPage}페이지";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "{currentPage}페이지";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "일";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "12월";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "2월";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "1월";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "7월";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "6월";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "3월";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "5월";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "월";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "다음";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "11월";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "10월";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "이전";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "9월";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "년";
	}
}
