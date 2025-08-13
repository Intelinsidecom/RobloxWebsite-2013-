using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace Roblox.LightUtils
{
	public static class SimpleLogger
	{
		public static LogLevelEnum LogLevel
		{
			get
			{
				if (ForceLogLevel != null) return ForceLogLevel.Value;
				if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LogLevel"))) return LogLevelEnum.Info;
				if (!Enum.TryParse(Environment.GetEnvironmentVariable("LogLevel"), true, out LogLevelEnum logLevel)) return LogLevelEnum.Info;
				return logLevel;
			}
		}
		public static bool UseJsonOutput
		{
			get
			{
				if (ForceJsonOutput != null) return ForceJsonOutput.Value;
				return !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("LogAsJson")) && Convert.ToBoolean(Environment.GetEnvironmentVariable("LogAsJson"));
			}
		}

		public static void Trace(string message, object context = null)
		{
			Write(LogLevelEnum.Trace, message, context, null);
		}
		public static void Info(string message, object context = null)
		{
			Write(LogLevelEnum.Info, message, context, null);
		}
		public static void Error(string message, object context = null)
		{
			Write(LogLevelEnum.Error, message, context, null);
		}
		public static void Error(string message, Exception ex, object context = null)
		{
			Write(LogLevelEnum.Error, message, context, ex);
		}
		public static void Warning(string message, object context = null)
		{
			Write(LogLevelEnum.Warn, message, context, null);
		}
		private static void Write(LogLevelEnum logLevel, string message, object contextObj = null, Exception ex = null)
		{
			if (logLevel < LogLevel)
			{
				return;
			}
			var log = new Dictionary<string, object>
			{
				{
					"message",
					message
				},
				{
					"logLevel",
					logLevel.ToString()
				},
				{
					"time",
					DateTime.Now.ToString("O")
				}
			};
			if (ex != null)
			{
				if (UseJsonOutput)
				{
					var value = new
					{
                        ex.Message,
						Type = ex.GetType().ToString(),
                        ex.StackTrace,
                        ex.HResult,
						InnerException = (ex.InnerException != null) ? new
						{
                            ex.InnerException.Message,
							Type = ex.InnerException.GetType().ToString(),
                            ex.InnerException.StackTrace,
                            ex.HResult
						} : null
					};
					log.Add("exception", JsonConvert.SerializeObject(value, _JsonSettings));
				}
				else
				{
					log.Add("exception", ex);
				}
			}
			try
			{
				if (contextObj != null)
				{
                    if (contextObj is Dictionary<string, object> context)
                    {
                        using (var enumerator = context.Keys.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                string key = enumerator.Current;
                                if (!IsReservedKey(key))
                                {
                                    log.Add(key, context[key]);
                                }
                            }
                            goto NEXT;
                        }
                    }
                    foreach (var info in contextObj.GetType().GetProperties())
					{
						if (!IsReservedKey(info.Name))
						{
							log.Add(info.Name, info.GetValue(contextObj));
						}
					}
				}
				NEXT:
				if (UseJsonOutput)
				{
					Console.WriteLine(JsonConvert.SerializeObject(log, _JsonSettings));
				}
				else
				{
					lock (_LockObject)
					{
						Console.Write($"[{DateTime.Now:O} {logLevel}] {message}");
						foreach (var keys in log)
						{
							if (!IsReservedKey(keys.Key))
							{
								Console.Write(string.Format(", {0} = {1}", keys.Key, keys.Value));
							}
						}
						Console.WriteLine();
					}
				}
			}
			catch
			{
			}
		}

		private static bool IsReservedKey(string key)
		{
			return key == "logLevel" || key == "message" || key == "time";
		}

		private static readonly object _LockObject = new Object();
		public static bool? ForceJsonOutput = null;
		public static LogLevelEnum? ForceLogLevel = null;
		private static readonly JsonSerializerSettings _JsonSettings = new JsonSerializerSettings()
        {
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore
		};

		public enum LogLevelEnum
		{
			Trace = 1,
			Info,
			Warn,
			Error
		}
	}
}
