using System;
using System.Web;

namespace Roblox.YouTube;

public class YouTubeVideo
{
	public class YouTubeVideoSettings
	{
		public enum ThemeColor
		{
			Light,
			Dark
		}

		internal byte _ShowControls;

		internal byte _DisableKeyboardControls = 1;

		internal byte _EnableJSApi;

		internal byte _HDEnabled;

		internal byte _AnnotationsEnabled = 3;

		internal string _ThemeColor = "dark";

		internal int _StartTime;

		public bool ShowControls
		{
			get
			{
				return _ShowControls == 1;
			}
			set
			{
				if (value)
				{
					_ShowControls = 1;
				}
				else
				{
					_ShowControls = 0;
				}
			}
		}

		public bool KeyboardControlsEnabled
		{
			get
			{
				return _DisableKeyboardControls == 0;
			}
			set
			{
				if (value)
				{
					_DisableKeyboardControls = 0;
				}
				else
				{
					_DisableKeyboardControls = 1;
				}
			}
		}

		public bool JSApiEnabled
		{
			get
			{
				return _EnableJSApi == 1;
			}
			set
			{
				if (value)
				{
					_EnableJSApi = 1;
				}
				else
				{
					_EnableJSApi = 0;
				}
			}
		}

		public bool HDEnabled
		{
			get
			{
				return _HDEnabled == 1;
			}
			set
			{
				if (value)
				{
					_HDEnabled = 1;
				}
				else
				{
					_HDEnabled = 0;
				}
			}
		}

		public bool AnnotationsEnabled
		{
			get
			{
				return _AnnotationsEnabled == 1;
			}
			set
			{
				if (value)
				{
					_AnnotationsEnabled = 1;
				}
				else
				{
					_AnnotationsEnabled = 3;
				}
			}
		}

		public ThemeColor ChromeThemeColor
		{
			get
			{
				if (_ThemeColor == "dark")
				{
					return ThemeColor.Dark;
				}
				return ThemeColor.Light;
			}
			set
			{
				if (value == ThemeColor.Light)
				{
					_ThemeColor = "light";
				}
				else
				{
					_ThemeColor = "dark";
				}
			}
		}

		public int StartTime
		{
			get
			{
				return _StartTime;
			}
			set
			{
				if (value < 0)
				{
					_StartTime = 0;
				}
				else
				{
					_StartTime = value;
				}
			}
		}

		public YouTubeVideoSettings(int startTime = 0, ThemeColor chromeThemeColor = ThemeColor.Dark, bool hdEnabled = false, bool showControls = false, bool keyboardControlsEnabled = false, bool jsApiEnabled = false, bool annotationsEnabled = false)
		{
			StartTime = startTime;
			ChromeThemeColor = chromeThemeColor;
			HDEnabled = hdEnabled;
			ShowControls = showControls;
			KeyboardControlsEnabled = keyboardControlsEnabled;
			JSApiEnabled = jsApiEnabled;
			AnnotationsEnabled = annotationsEnabled;
		}
	}

	private YouTubeVideoSettings _VideoSettings;

	private VideoItem _Video;

	private string _VideoID { get; set; }

	public int TotalSeconds
	{
		get
		{
			if (_Video == null)
			{
				return 0;
			}
			return _Video.TotalSeconds;
		}
	}

	public string VideoID => _VideoID;

	public string Title
	{
		get
		{
			if (_Video == null)
			{
				return string.Empty;
			}
			return _Video.Title;
		}
	}

	public string Description
	{
		get
		{
			if (_Video == null)
			{
				return string.Empty;
			}
			return _Video.Description;
		}
	}

	public bool SupportsEmbedding
	{
		get
		{
			if (_Video == null)
			{
				return false;
			}
			return _Video.SupportsEmbedding;
		}
	}

	private void _InitDefaultSettings()
	{
		_VideoSettings = new YouTubeVideoSettings();
	}

	public YouTubeVideo(string assetHash, YouTubeVideoSettings settings = null)
	{
		_VideoID = assetHash.Trim();
		if (settings == null)
		{
			_InitDefaultSettings();
		}
		else
		{
			_VideoSettings = settings;
		}
	}

	public YouTubeVideo(Uri youTubeUrl, YouTubeVideoSettings settings = null)
	{
		if (youTubeUrl.Host.Contains("youtu.be"))
		{
			_VideoID = youTubeUrl.AbsolutePath.TrimStart('/');
		}
		else
		{
			string sQuery = youTubeUrl.Query;
			_VideoID = HttpUtility.ParseQueryString(sQuery).Get("v").Trim();
		}
		if (settings == null)
		{
			_InitDefaultSettings();
		}
		else
		{
			_VideoSettings = settings;
		}
	}

	/// <summary>
	/// Fetches the video from YouTube (web request) to load data regarding this video.  Not needed to general the URL.
	/// </summary>
	public bool LoadVideo()
	{
		if (_Video == null)
		{
			_Video = VideoParser.GetVideoItem(_VideoID);
		}
		if (_Video == null)
		{
			return false;
		}
		_VideoID = _Video.Id;
		return true;
	}

	public string GetUrl(bool https)
	{
		if (string.IsNullOrEmpty(_VideoID))
		{
			return string.Empty;
		}
		return string.Format("{0}://www.youtube.com?v={1}", https ? "https" : "http", _VideoID);
	}

	public string GetEmbedUrl(bool https)
	{
		if (string.IsNullOrEmpty(_VideoID))
		{
			return string.Empty;
		}
		return string.Format("{0}://www.youtube.com/embed/{1}?wmode=opaque&version=3&rel=0&modestbranding=1&showinfo=0&showsearch=0&controls={2}&disablekb={3}&enablejsapi={4}&playerapiid={5}&hd={6}&iv_load_policy={7}{8}&start={9}&theme={10}", https ? "https" : "http", _VideoID, _VideoSettings._ShowControls, _VideoSettings._DisableKeyboardControls, _VideoSettings._EnableJSApi, "wefs", _VideoSettings._HDEnabled, _VideoSettings._AnnotationsEnabled, "", _VideoSettings._StartTime, _VideoSettings._ThemeColor);
	}
}
