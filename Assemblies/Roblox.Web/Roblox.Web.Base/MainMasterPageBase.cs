using System;
using System.Web;

namespace Roblox.Web.Base;

/// <summary>
/// Class: CustomMasterPageBase
/// Type: Abstract
/// Description: The aim of this class is to hook up the MAIN Page events to event handlers from any aspx page
/// that inherits from this class.
/// </summary>
public abstract class MainMasterPageBase : SimpleMasterPageBase
{
	protected bool _gutterAdsEnabled;

	protected string _leftGutterAdSlot;

	protected string _rightGutterAdSlot;

	protected bool _isFirstTimeVisit;

	protected bool _defaultPageBanner;

	protected string _BannerAdSlotName = "Roblox_Default_Top_728x90";

	protected bool _takeoverEnabled;

	protected bool _isBanner970px;

	protected string _adFormat;

	public bool isIE6
	{
		get
		{
			if (HttpContext.Current.Request.Browser.Browser == "IE")
			{
				return HttpContext.Current.Request.Browser.Version.IndexOf("6") != -1;
			}
			return false;
		}
	}

	public bool IsFirstTimeVisit => _isFirstTimeVisit;

	public bool GutterAdsEnabled
	{
		get
		{
			return _gutterAdsEnabled;
		}
		set
		{
			_gutterAdsEnabled = value;
		}
	}

	public string LeftGutterAdSlot
	{
		get
		{
			return _leftGutterAdSlot;
		}
		set
		{
			_leftGutterAdSlot = value;
		}
	}

	public string RightGutterAdSlot
	{
		get
		{
			return _rightGutterAdSlot;
		}
		set
		{
			_rightGutterAdSlot = value;
		}
	}

	public bool DefaultPageBannerEnabled
	{
		get
		{
			return _defaultPageBanner;
		}
		set
		{
			_defaultPageBanner = value;
		}
	}

	public bool TakeoverEnabled
	{
		get
		{
			return _takeoverEnabled;
		}
		set
		{
			_takeoverEnabled = value;
		}
	}

	public bool IsBanner970px
	{
		get
		{
			return _isBanner970px;
		}
		set
		{
			_isBanner970px = value;
		}
	}

	public string AdFormat
	{
		get
		{
			return _adFormat;
		}
		set
		{
			_adFormat = value;
		}
	}

	public string BannerAdSlotName
	{
		get
		{
			return _BannerAdSlotName;
		}
		set
		{
			_BannerAdSlotName = value;
		}
	}

	public bool ShowRetargeting { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Base.MainMasterPageBase" /> class.
	/// Hooks events to the page event handlers
	/// </summary>
	public MainMasterPageBase()
	{
		_gutterAdsEnabled = false;
		_leftGutterAdSlot = "";
		_rightGutterAdSlot = "";
		_isFirstTimeVisit = false;
		_defaultPageBanner = false;
		_takeoverEnabled = false;
		_isBanner970px = false;
		_adFormat = "";
	}

	protected int _GetBirthYear(string age)
	{
		DateTime date = DateTime.Now;
		if (age == "Over13")
		{
			return date.AddYears(-14).Year;
		}
		if (age == "Under13")
		{
			return date.Year;
		}
		return 0;
	}
}
