using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Roblox.Controls;

/// <summary>
/// Utility functions for doing JScript rendering
/// </summary>
public sealed class ScriptingUtilities
{
	/// <summary>
	/// Gets the complete client ID of a control for scripting (includes containing
	/// objects like Forms).
	///
	/// Example: Form1.WebControl1
	/// </summary>
	/// <param name="control"></param>
	/// <returns>The ID of the object for scripting</returns>
	public static string Express(Control control)
	{
		if (control == null)
		{
			return "nothing";
		}
		if (control.ID == null)
		{
			return "document.all.namedItem(\"" + control.UniqueID + "\")";
		}
		Control form = control.Parent;
		while (form != null && !(form is HtmlForm))
		{
			form = form.Parent;
		}
		if (form == null)
		{
			return control.ClientID;
		}
		return form.ClientID + "." + control.ClientID;
	}

	/// <summary>
	/// Gets the complete client ID of a control for scripting
	/// </summary>
	/// <param name="control">the containing control</param>
	/// <param name="childID">the ID of the HTML object</param>
	/// <returns></returns>
	public static string Express(Control control, string childID)
	{
		if (control == null)
		{
			return "nothing";
		}
		Control form = control.Parent;
		while (form != null && !(form is HtmlForm))
		{
			form = form.Parent;
		}
		if (form == null)
		{
			return control.ClientID;
		}
		return form.ID + "." + childID;
	}
}
