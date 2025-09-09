using System;
using System.Diagnostics;

namespace Roblox.Website
{
    // Minimal logger used by Global.asax.cs during development
    // Writes to Debug and Trace to avoid external logging dependencies.
    public class Logger
    {
        public void Warn(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            Debug.WriteLine("[WARN] " + message);
            Trace.TraceWarning(message);
        }

        public void Error(Exception ex)
        {
            if (ex == null) return;
            Debug.WriteLine("[ERROR] " + ex);
            Trace.TraceError(ex.ToString());
        }

        public void Error(string message)
        {
            if (string.IsNullOrEmpty(message)) return;
            Debug.WriteLine("[ERROR] " + message);
            Trace.TraceError(message);
        }
    }
}
