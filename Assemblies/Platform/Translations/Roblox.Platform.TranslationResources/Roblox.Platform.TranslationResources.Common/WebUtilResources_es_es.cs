namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_es_es : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day}\u00a0día";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day}\u00a0día";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days}\u00a0días";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days}\u00a0días";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour}\u00a0hora";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour}\u00a0hora";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours}\u00a0horas";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours}\u00a0horas";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute}\u00a0minuto";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute}\u00a0minuto";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes}\u00a0minutos";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes}\u00a0minutos";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month}\u00a0mes";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month}\u00a0mes";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months}\u00a0meses";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months}\u00a0meses";
	}

	/// <summary>
	/// Key: "GetLabelMonthsUppercase"
	/// For example, "12 Months"
	/// English String: "{number} Months"
	/// </summary>
	public override string GetLabelMonthsUppercase(string number)
	{
		return $"{number} meses";
	}

	protected override string _GetTemplateForGetLabelMonthsUppercase()
	{
		return "{number} meses";
	}

	/// <summary>
	/// Key: "GetLabelSecond"
	/// English String: "{second} second"
	/// </summary>
	public override string GetLabelSecond(string second)
	{
		return $"{second}\u00a0segundo";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second}\u00a0segundo";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds}\u00a0segundos";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds}\u00a0segundos";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week}\u00a0semana";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week}\u00a0semana";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks}\u00a0semanas";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks}\u00a0semanas";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year}\u00a0año";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year}\u00a0año";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years}\u00a0años";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years}\u00a0años";
	}
}
