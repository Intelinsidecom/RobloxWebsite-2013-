using System.Text.RegularExpressions;

namespace Roblox.Website.WebCode
{

    public static class BrowserUtils
    {
        // IE
        private const string IE_KEYWORD = "MSIE";
        private const string IE_TRIDENT_KEYWORD = "Trident";

        // Chrome
        private const string CHROME_KEYWORD = "Chrome";

        // Firefox
        private const string FIREFOX_KEYWORD = "Firefox";

        // Safari
        private const string SAFARI_KEYWORD = "Safari";

        // Opera
        private const string OPERA_KEYWORD = "Opera";

        // Other
        private const string MOZILLA_KEYWORD = "Mozilla";
        private const string APPLE_KEYWORD = "AppleWebKit";

        public static bool IsIE(string userAgent)
        {
            return userAgent.Contains(IE_KEYWORD) || userAgent.Contains(IE_TRIDENT_KEYWORD);
        }

        public static bool IsIE9OrNewer(string userAgent)
        {
            return userAgent.Contains($"{IE_KEYWORD} 9") || userAgent.Contains($"{IE_KEYWORD} 10") || IsIE11OrNewer(userAgent);
        }

        public static bool IsIE11OrNewer(string userAgent)
        {
            return userAgent.Contains(IE_TRIDENT_KEYWORD) && Regex.IsMatch(userAgent, @"rv(?::| )\d");
        }

        public static bool IsChrome(string userAgent)
        {
            return userAgent.Contains(CHROME_KEYWORD);
        }

        public static bool IsFirefox(string userAgent)
        {
            return userAgent.Contains(FIREFOX_KEYWORD);
        }

        public static bool IsSafari(string userAgent)
        {
            return userAgent.Contains(SAFARI_KEYWORD) && userAgent.Contains(MOZILLA_KEYWORD) && userAgent.Contains(APPLE_KEYWORD);
        }

        public static bool IsOpera(string userAgent)
        {
            return userAgent.Contains(OPERA_KEYWORD);
        }

        public static string GetBrowserStringFromUserAgent(string userAgent)
        {
            string browserString = null;

            if (IsIE(userAgent))
            {
                browserString = "IE";
                if (IsIE9OrNewer(userAgent))
                    browserString += "9+";
            }
            else if (IsChrome(userAgent))
            {
                browserString = "Chrome";
            }
            else if (IsFirefox(userAgent))
            {
                browserString = "Firefox";
            }
            else if (IsSafari(userAgent))
            {
                browserString = "Safari";
            }
            else if (IsOpera(userAgent))
            {
                browserString = "Opera";
            }
            return browserString;
        }

        public static int GetChromeVersion(string userAgent)
        {
            int bVersion = 0; // Default version

            // Extract browser version for Chrome
            Match result = Regex.Match(userAgent, @"Chrome\/(\d+)");
            if (result.Success)
                int.TryParse(result.Groups[1].Value, out bVersion);

            return bVersion;
        }
    }
}