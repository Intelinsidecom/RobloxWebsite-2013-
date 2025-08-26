namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_ko_kr : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day}ì¼";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day}ì¼";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days}ì¼";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days}ì¼";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour}ì‹œê°„";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour}ì‹œê°„";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours}ì‹œê°„";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours}ì‹œê°„";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute}ë¶„";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute}ë¶„";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes}ë¶„";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes}ë¶„";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month}ê°œì›”";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month}ê°œì›”";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months}ê°œì›”";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months}ê°œì›”";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number}ê°œì›”";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number}ê°œì›”";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second}ì´ˆ";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second}ì´ˆ";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds}ì´ˆ";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds}ì´ˆ";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week}ì£¼";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week}ì£¼";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks}ì£¼";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks}ì£¼";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year}ë…„";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year}ë…„";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years}ë…„";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years}ë…„";
	}
}


}
