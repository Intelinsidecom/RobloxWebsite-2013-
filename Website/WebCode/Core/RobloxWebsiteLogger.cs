using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website
{
    public class RobloxWebsiteLogger
    {
        public RobloxWebsiteLogger(bool removeLineBreaks = false)
        {
            // removeLineBreaks is ignored in this minimal implementation
        }

        public void Info(string format, params object[] args)
        {
            WriteLine("INFO", format, args);
        }

        public void Warning(string format, params object[] args)
        {
            WriteLine("WARN", format, args);
        }

        public void Error(Exception ex)
        {
            WriteLine("ERROR", ex?.ToString() ?? string.Empty);
        }

        public void Error(string format, params object[] args)
        {
            WriteLine("ERROR", format, args);
        }

        private static void WriteLine(string level, string format, params object[] args)
        {
            string message = (args != null && args.Length > 0) ? string.Format(format, args) : format;
            try
            {
                Console.WriteLine($"{DateTime.Now:O} [{level}] {message}");
            }
            catch
            {
                // Swallow logging exceptions to avoid breaking the site
            }
        }
    }
}