namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides WebUtilResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class WebUtilResources_pt_br : WebUtilResources_en_us, IWebUtilResources, ITranslationResources
{
	public WebUtilResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "GetLabelDay"
	/// English String: "{day} day"
	/// </summary>
	public override string GetLabelDay(string day)
	{
		return $"{day} dia";
	}

	protected override string _GetTemplateForGetLabelDay()
	{
		return "{day} dia";
	}

	/// <summary>
	/// Key: "GetLabelDays"
	/// English String: "{days} days"
	/// </summary>
	public override string GetLabelDays(string days)
	{
		return $"{days} dias";
	}

	protected override string _GetTemplateForGetLabelDays()
	{
		return "{days} dias";
	}

	/// <summary>
	/// Key: "GetLabelHour"
	/// English String: "{hour} hour"
	/// </summary>
	public override string GetLabelHour(string hour)
	{
		return $"{hour} hora";
	}

	protected override string _GetTemplateForGetLabelHour()
	{
		return "{hour} hora";
	}

	/// <summary>
	/// Key: "GetLabelHours"
	/// English String: "{hours} hours"
	/// </summary>
	public override string GetLabelHours(string hours)
	{
		return $"{hours} horas";
	}

	protected override string _GetTemplateForGetLabelHours()
	{
		return "{hours} horas";
	}

	/// <summary>
	/// Key: "GetLabelMinute"
	/// English String: "{minute} minute"
	/// </summary>
	public override string GetLabelMinute(string minute)
	{
		return $"{minute} minuto";
	}

	protected override string _GetTemplateForGetLabelMinute()
	{
		return "{minute} minuto";
	}

	/// <summary>
	/// Key: "GetLabelMinutes"
	/// English String: "{minutes} minutes"
	/// </summary>
	public override string GetLabelMinutes(string minutes)
	{
		return $"{minutes} minutos";
	}

	protected override string _GetTemplateForGetLabelMinutes()
	{
		return "{minutes} minutos";
	}

	/// <summary>
	/// Key: "GetLabelMonth"
	/// English String: "{month} month"
	/// </summary>
	public override string GetLabelMonth(string month)
	{
		return $"{month} mês";
	}

	protected override string _GetTemplateForGetLabelMonth()
	{
		return "{month} mês";
	}

	/// <summary>
	/// Key: "GetLabelMonths"
	/// English String: "{months} months"
	/// </summary>
	public override string GetLabelMonths(string months)
	{
		return $"{months} meses";
	}

	protected override string _GetTemplateForGetLabelMonths()
	{
		return "{months} meses";
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
		return $"{second} segundo";
	}

	protected override string _GetTemplateForGetLabelSecond()
	{
		return "{second} segundo";
	}

	/// <summary>
	/// Key: "GetLabelSeconds"
	/// English String: "{seconds} seconds"
	/// </summary>
	public override string GetLabelSeconds(string seconds)
	{
		return $"{seconds} segundos";
	}

	protected override string _GetTemplateForGetLabelSeconds()
	{
		return "{seconds} segundos";
	}

	/// <summary>
	/// Key: "GetLabelWeek"
	/// English String: "{week} week"
	/// </summary>
	public override string GetLabelWeek(string week)
	{
		return $"{week} semana";
	}

	protected override string _GetTemplateForGetLabelWeek()
	{
		return "{week} semana";
	}

	/// <summary>
	/// Key: "GetLabelWeeks"
	/// English String: "{weeks} weeks"
	/// </summary>
	public override string GetLabelWeeks(string weeks)
	{
		return $"{weeks} semanas";
	}

	protected override string _GetTemplateForGetLabelWeeks()
	{
		return "{weeks} semanas";
	}

	/// <summary>
	/// Key: "GetLabelYear"
	/// English String: "{year} year"
	/// </summary>
	public override string GetLabelYear(string year)
	{
		return $"{year} ano";
	}

	protected override string _GetTemplateForGetLabelYear()
	{
		return "{year} ano";
	}

	/// <summary>
	/// Key: "GetLabelYears"
	/// English String: "{years} years"
	/// </summary>
	public override string GetLabelYears(string years)
	{
		return $"{years} anos";
	}

	protected override string _GetTemplateForGetLabelYears()
	{
		return "{years} anos";
	}
}
