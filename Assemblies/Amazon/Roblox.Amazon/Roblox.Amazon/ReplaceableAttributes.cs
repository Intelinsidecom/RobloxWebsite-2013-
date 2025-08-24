using System.Collections.Generic;
using Amazon.SimpleDB.Model;

namespace Roblox.Amazon;

public class ReplaceableAttributes : AttributesBase
{
	internal readonly List<ReplaceableAttribute> list = new List<ReplaceableAttribute>();

	public override void Add(string name, string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			ReplaceableAttribute attr = new ReplaceableAttribute();
			attr.Name = name;
			attr.Value = value;
			list.Add(attr);
		}
	}

	public void Add(string name, string value, bool replace)
	{
		ReplaceableAttribute attr = new ReplaceableAttribute();
		attr.Name = name;
		attr.Value = value;
		attr.Replace = replace;
		list.Add(attr);
	}

	/// <summary>
	/// Add empty attribute (used for deletion)
	/// </summary>
	public void Add(string name)
	{
		ReplaceableAttribute attr = new ReplaceableAttribute();
		attr.Name = name;
		list.Add(attr);
	}
}
