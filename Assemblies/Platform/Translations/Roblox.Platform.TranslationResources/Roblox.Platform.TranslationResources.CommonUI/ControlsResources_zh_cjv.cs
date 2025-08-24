namespace Roblox.TranslationResources.CommonUI;

/// <summary>
/// This class overrides ControlsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ControlsResources_zh_cjv : ControlsResources_en_us, IControlsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.Accept"
	/// English String: "Accept"
	/// </summary>
	public override string ActionAccept => "接受";

	/// <summary>
	/// Key: "Action.Agree"
	/// button label
	/// English String: "Agree"
	/// </summary>
	public override string ActionAgree => "同意";

	/// <summary>
	/// Key: "Action.Allow"
	/// Allow
	/// English String: "Allow"
	/// </summary>
	public override string ActionAllow => "允许";

	/// <summary>
	/// Key: "Action.Back"
	/// English String: "Back"
	/// </summary>
	public override string ActionBack => "返回";

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public override string ActionCancel => "取消";

	/// <summary>
	/// Key: "Action.Confirm"
	/// button label
	/// English String: "Confirm"
	/// </summary>
	public override string ActionConfirm => "确认";

	/// <summary>
	/// Key: "Action.Delete"
	/// English String: "Delete"
	/// </summary>
	public override string ActionDelete => "删除";

	/// <summary>
	/// Key: "Action.Discard"
	/// The button label of the modal that asks the user to confirm discarding unsaved changes
	/// English String: "Discard"
	/// </summary>
	public override string ActionDiscard => "放弃";

	/// <summary>
	/// Key: "Action.No"
	/// English String: "No"
	/// </summary>
	public override string ActionNo => "否";

	/// <summary>
	/// Key: "Action.OK"
	/// English String: "OK"
	/// </summary>
	public override string ActionOK => "好";

	/// <summary>
	/// Key: "Action.Save"
	/// English String: "Save"
	/// </summary>
	public override string ActionSave => "保存";

	/// <summary>
	/// Key: "Action.Submit"
	/// English String: "Submit"
	/// </summary>
	public override string ActionSubmit => "提交";

	/// <summary>
	/// Key: "Action.Yes"
	/// English String: "Yes"
	/// </summary>
	public override string ActionYes => "是";

	/// <summary>
	/// Key: "Birthdaypicker.Label.Date"
	/// English String: "Date"
	/// </summary>
	public override string BirthdaypickerLabelDate => "日期";

	/// <summary>
	/// Key: "Label.April"
	/// English String: "April"
	/// </summary>
	public override string LabelApril => "4月";

	/// <summary>
	/// Key: "Label.August"
	/// English String: "August"
	/// </summary>
	public override string LabelAugust => "8月";

	/// <summary>
	/// Key: "Label.Day"
	/// day of the month label
	/// English String: "Day"
	/// </summary>
	public override string LabelDay => "日";

	/// <summary>
	/// Key: "Label.December"
	/// English String: "December"
	/// </summary>
	public override string LabelDecember => "12月";

	/// <summary>
	/// Key: "Label.February"
	/// English String: "February"
	/// </summary>
	public override string LabelFebruary => "2月";

	/// <summary>
	/// Key: "Label.January"
	/// English String: "January"
	/// </summary>
	public override string LabelJanuary => "1月";

	/// <summary>
	/// Key: "Label.July"
	/// English String: "July"
	/// </summary>
	public override string LabelJuly => "7月";

	/// <summary>
	/// Key: "Label.June"
	/// English String: "June"
	/// </summary>
	public override string LabelJune => "6月";

	/// <summary>
	/// Key: "Label.March"
	/// English String: "March"
	/// </summary>
	public override string LabelMarch => "3月";

	/// <summary>
	/// Key: "Label.May"
	/// English String: "May"
	/// </summary>
	public override string LabelMay => "5月";

	/// <summary>
	/// Key: "Label.Month"
	/// Month
	/// English String: "Month"
	/// </summary>
	public override string LabelMonth => "月";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "下一步";

	/// <summary>
	/// Key: "Label.November"
	/// English String: "November"
	/// </summary>
	public override string LabelNovember => "11月";

	/// <summary>
	/// Key: "Label.October"
	/// English String: "October"
	/// </summary>
	public override string LabelOctober => "10月";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "上一步";

	/// <summary>
	/// Key: "Label.September"
	/// English String: "September"
	/// </summary>
	public override string LabelSeptember => "9月";

	/// <summary>
	/// Key: "Label.Year"
	/// Year
	/// English String: "Year"
	/// </summary>
	public override string LabelYear => "年";

	public ControlsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionAccept()
	{
		return "接受";
	}

	protected override string _GetTemplateForActionAgree()
	{
		return "同意";
	}

	protected override string _GetTemplateForActionAllow()
	{
		return "允许";
	}

	protected override string _GetTemplateForActionBack()
	{
		return "返回";
	}

	protected override string _GetTemplateForActionCancel()
	{
		return "取消";
	}

	protected override string _GetTemplateForActionConfirm()
	{
		return "确认";
	}

	protected override string _GetTemplateForActionDelete()
	{
		return "删除";
	}

	protected override string _GetTemplateForActionDiscard()
	{
		return "放弃";
	}

	protected override string _GetTemplateForActionNo()
	{
		return "否";
	}

	protected override string _GetTemplateForActionOK()
	{
		return "好";
	}

	protected override string _GetTemplateForActionSave()
	{
		return "保存";
	}

	protected override string _GetTemplateForActionSubmit()
	{
		return "提交";
	}

	protected override string _GetTemplateForActionYes()
	{
		return "是";
	}

	protected override string _GetTemplateForBirthdaypickerLabelDate()
	{
		return "日期";
	}

	protected override string _GetTemplateForLabelApril()
	{
		return "4月";
	}

	protected override string _GetTemplateForLabelAugust()
	{
		return "8月";
	}

	/// <summary>
	/// Key: "Label.CurrentPage"
	/// Label that includes current page number.
	/// English String: "Page {currentPage}"
	/// </summary>
	public override string LabelCurrentPage(string currentPage)
	{
		return $"第 {currentPage} 页";
	}

	protected override string _GetTemplateForLabelCurrentPage()
	{
		return "第 {currentPage} 页";
	}

	protected override string _GetTemplateForLabelDay()
	{
		return "日";
	}

	protected override string _GetTemplateForLabelDecember()
	{
		return "12月";
	}

	protected override string _GetTemplateForLabelFebruary()
	{
		return "2月";
	}

	protected override string _GetTemplateForLabelJanuary()
	{
		return "1月";
	}

	protected override string _GetTemplateForLabelJuly()
	{
		return "7月";
	}

	protected override string _GetTemplateForLabelJune()
	{
		return "6月";
	}

	protected override string _GetTemplateForLabelMarch()
	{
		return "3月";
	}

	protected override string _GetTemplateForLabelMay()
	{
		return "5月";
	}

	protected override string _GetTemplateForLabelMonth()
	{
		return "月";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "下一步";
	}

	protected override string _GetTemplateForLabelNovember()
	{
		return "11月";
	}

	protected override string _GetTemplateForLabelOctober()
	{
		return "10月";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "上一步";
	}

	protected override string _GetTemplateForLabelSeptember()
	{
		return "9月";
	}

	protected override string _GetTemplateForLabelYear()
	{
		return "年";
	}
}
