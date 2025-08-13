using System;
using System.Collections.Specialized;
using Roblox.Configuration;
using Roblox.Libraries.Cookies;

namespace Roblox.Web.Cookies;

public class SourceCookie : RobloxCookieBase
{
	private static readonly string _Name = "RBXSource";

	public static RobloxCookieIdentifier CookieIdentifier = new RobloxCookieIdentifier(_Name);

	protected override string Name => _Name;

	protected override TimeSpan? _ExpirationLength => TimeSpan.FromDays(30.0);

	public override string Domain
	{
		get
		{
			return RobloxEnvironment.Domain;
		}
		set
		{
		}
	}

	public DateTime? AcquisitionTime { get; set; }

	public string AcquisitionReferrer { get; set; }

	public string Medium { get; set; }

	public string Source { get; set; }

	public string Campaign { get; set; }

	public string AdGroup { get; set; }

	public string Keyword { get; set; }

	public string MatchType { get; set; }

	public bool SendInfo { get; set; }

	public override NameValueCollection DoSerializeValues()
	{
		return new NameValueCollection
		{
			{
				"rbx_acquisition_time",
				AcquisitionTime.HasValue ? AcquisitionTime.ToString() : ""
			},
			{ "rbx_acquisition_referrer", AcquisitionReferrer },
			{
				"rbx_medium",
				Medium ?? string.Empty
			},
			{
				"rbx_source",
				Source ?? string.Empty
			},
			{
				"rbx_campaign",
				Campaign ?? string.Empty
			},
			{
				"rbx_adgroup",
				AdGroup ?? string.Empty
			},
			{
				"rbx_keyword",
				Keyword ?? string.Empty
			},
			{
				"rbx_matchtype",
				MatchType ?? string.Empty
			},
			{
				"rbx_send_info",
				SendInfo ? "1" : "0"
			}
		};
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		if (DateTime.TryParse(keyValues["rbx_acquisition_time"], out var acquisitionTime))
		{
			AcquisitionTime = acquisitionTime;
		}
		AcquisitionReferrer = keyValues["rbx_acquisition_referrer"] ?? string.Empty;
		Medium = keyValues["rbx_medium"] ?? string.Empty;
		Source = keyValues["rbx_source"] ?? string.Empty;
		Campaign = keyValues["rbx_campaign"] ?? string.Empty;
		AdGroup = keyValues["rbx_adgroup"] ?? string.Empty;
		Keyword = keyValues["rbx_keyword"] ?? string.Empty;
		MatchType = keyValues["rbx_matchtype"] ?? string.Empty;
		SendInfo = keyValues["rbx_send_info"] == "1";
	}
}
