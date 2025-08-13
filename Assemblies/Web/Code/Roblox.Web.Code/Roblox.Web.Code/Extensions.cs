using System.Collections.Generic;
using System.Web.UI;

namespace Roblox.Web.Code;

public static class Extensions
{
	/// <summary>
	/// Searches recursively in this control to find a control with the name specified.
	/// </summary>
	/// <param name="root">The Control in which to begin searching.</param>
	/// <param name="id">The ID of the control to be found.</param>
	/// <returns>The control if it is found or null if it is not.</returns>
	public static Control FindControlR(this Control root, string id)
	{
		if (root != null)
		{
			Control controlFound = root.FindControl(id);
			if (controlFound != null)
			{
				return controlFound;
			}
			foreach (Control control in root.Controls)
			{
				controlFound = control.FindControlR(id);
				if (controlFound != null)
				{
					return controlFound;
				}
			}
		}
		return null;
	}

	/// <summary>
	/// Returns a list of controls under the root element
	/// </summary>
	public static List<Control> GetControlList(this Control root)
	{
		return root.GetControlList<Control>();
	}

	/// <summary>
	/// Returns a list of controls of type T underneath the root element
	/// </summary>
	/// <typeparam name="T">Type of controls you want to extract</typeparam>
	/// <param name="root">Parent node you want to get controls under</param>
	public static List<T> GetControlList<T>(this Control root) where T : Control
	{
		List<T> resultCollection = new List<T>();
		_GetControlList(root.Controls, resultCollection);
		return resultCollection;
	}

	private static void _GetControlList<T>(ControlCollection controlCollection, List<T> resultCollection) where T : Control
	{
		foreach (Control control in controlCollection)
		{
			if (control is T)
			{
				resultCollection.Add((T)control);
			}
			if (control.HasControls())
			{
				_GetControlList(control.Controls, resultCollection);
			}
		}
	}
}
