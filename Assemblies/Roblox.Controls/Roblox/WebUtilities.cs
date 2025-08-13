using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Roblox;

public class WebUtilities
{
	/// <summary>
	/// Utility routine that finds the HtmlForm of the Page
	/// Note: ASP.NET 2.0 implements this as a property
	/// </summary>
	/// <returns>The HtmlForm of the page</returns>
	public static HtmlForm GetForm(Page page)
	{
		foreach (Control child in page.Controls)
		{
			if (child is HtmlForm)
			{
				return (HtmlForm)child;
			}
		}
		return null;
	}

	public static void SetMetaContent(HtmlHead header, string name, string value)
	{
		foreach (Control control in header.Controls)
		{
			if (control is HtmlMeta meta && meta.Name == name)
			{
				meta.EnableViewState = false;
				meta.Content = value;
				return;
			}
		}
		HtmlMeta i = new HtmlMeta();
		i.Name = name;
		i.Content = value;
		i.EnableViewState = false;
		header.Controls.Add(i);
	}

	/// <summary>
	/// function to create metagas in header with property and content attributes.
	/// </summary>
	/// <param name="header"></param>
	/// <param name="propertyValue">value you want to set for property attribute</param>
	/// <param name="contentValue">value you want to set for content attribute</param>
	public static void SetMetaTagsWithPropertyAttribute(HtmlHead header, string propertyValue, string contentValue)
	{
		using (IEnumerator<HtmlMeta> enumerator = (from Control control in header.Controls
			select control as HtmlMeta into meta
			where meta != null && meta.Attributes.Count > 0 && !string.IsNullOrEmpty(meta.Attributes["property"]) && string.Compare(meta.Attributes["property"], propertyValue, ignoreCase: true) == 0
			select meta).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				HtmlMeta meta2 = enumerator.Current;
				meta2.EnableViewState = false;
				meta2.Content = contentValue;
				return;
			}
		}
		HtmlMeta i = new HtmlMeta();
		i.Attributes.Add("property", propertyValue);
		i.Content = contentValue;
		i.EnableViewState = false;
		header.Controls.Add(i);
	}
}
