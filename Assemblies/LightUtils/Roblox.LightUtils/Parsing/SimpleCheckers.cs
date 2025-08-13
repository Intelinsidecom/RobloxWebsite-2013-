using System.Collections.Generic;

namespace Roblox.LightUtils
{
	public static class SimpleCheckers
	{
		public static bool CheckSomePropertyEmpty(object obj, out string[] emptyProperties)
		{
			var props = new List<string>();
			bool result = false;
			foreach (var info in obj.GetType().GetProperties())
			{
				if (info.PropertyType == typeof(string) && string.IsNullOrWhiteSpace((string)info.GetValue(obj)))
				{
					props.Add(info.Name);
					result = true;
				}
			}
			emptyProperties = props.ToArray();
			return result;
		}
	}
}
