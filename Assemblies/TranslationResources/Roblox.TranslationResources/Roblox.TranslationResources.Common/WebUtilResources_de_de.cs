namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_de_de : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day} Tag";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day} Tag";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days} Tage";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days} Tage";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour} Stunde";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour} Stunde";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours} Stunden";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours} Stunden";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute} Minute";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute} Minute";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes} Minuten";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes} Minuten";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month} Monat";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month} Monat";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months} Monate";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months} Monate";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number} Monate";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number} Monate";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second} Sekunde";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second} Sekunde";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds} Sekunden";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds} Sekunden";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week} Woche";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week} Woche";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks} Wochen";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks} Wochen";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year} Jahr";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year} Jahr";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years} Jahre";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years} Jahre";
	}
}
