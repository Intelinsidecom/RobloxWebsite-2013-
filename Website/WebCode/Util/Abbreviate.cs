namespace Roblox.Web.Code.Util
{
    public static class Abbreviate
    {
        // Very simple truncation/abbreviation: 1,500 -> "1.5K", 2,000,000 -> "2M"
        public static string GetTruncValue(int value)
        {
            if (value >= 1_000_000)
                return (value / 1_000_000D).ToString("0.#") + "M";
            if (value >= 1_000)
                return (value / 1_000D).ToString("0.#") + "K";
            return value > 0 ? value.ToString("N0") : string.Empty;
        }
    }
}
