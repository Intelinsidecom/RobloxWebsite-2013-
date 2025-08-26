namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_zh_cjv : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day} å¤©";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day} å¤©";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days} å¤©";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days} å¤©";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour} å°æ—¶";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour} å°æ—¶";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours} å°æ—¶";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours} å°æ—¶";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute} åˆ†";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute} åˆ†";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes} åˆ†";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes} åˆ†";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month} ä¸ªæœˆ";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month} ä¸ªæœˆ";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months} ä¸ªæœˆ";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months} ä¸ªæœˆ";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number} ä¸ªæœˆ";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number} ä¸ªæœˆ";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second} ç§’";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second} ç§’";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds} ç§’";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds} ç§’";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week} ä¸ªæ˜ŸæœŸ";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week} ä¸ªæ˜ŸæœŸ";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks} ä¸ªæ˜ŸæœŸ";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks} ä¸ªæ˜ŸæœŸ";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year} å¹´";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year} å¹´";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years} å¹´";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years} å¹´";
	}
}


}
