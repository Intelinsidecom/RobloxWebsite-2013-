using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

/// <summary>
/// Summary description for Countdown.
/// </summary>
[DefaultProperty("Text")]
[ToolboxData("<{0}:Countdown runat=server></{0}:Countdown>")]
public class Countdown : WebControl
{
	private TimeSpan timeSpan;

	[Bindable(true)]
	[DefaultValue("")]
	public TimeSpan TimeSpan
	{
		get
		{
			return timeSpan;
		}
		set
		{
			timeSpan = value;
		}
	}

	[Bindable(true)]
	[DefaultValue("")]
	public int Seconds
	{
		get
		{
			return (int)timeSpan.TotalSeconds;
		}
		set
		{
			timeSpan = new TimeSpan(0, 0, value);
		}
	}

	/// <summary> 
	/// Render this control to the output parameter specified.
	/// </summary>
	/// <param name="output"> The HTML writer to write out to </param>
	protected override void Render(HtmlTextWriter output)
	{
		if (timeSpan.TotalDays >= 1.0)
		{
			output.Write("{0:D}d {1:D}h {2:D}m", (int)timeSpan.TotalDays, timeSpan.Hours, timeSpan.Minutes);
		}
		else if (timeSpan.TotalHours >= 1.0)
		{
			output.Write("{0:D}h {1:D}m", (int)timeSpan.TotalHours, timeSpan.Minutes);
		}
		else if (timeSpan.TotalMinutes >= 1.0)
		{
			output.Write("{0:D}m", (int)timeSpan.TotalMinutes);
		}
		else if (timeSpan.Ticks > 0)
		{
			output.Write("<1m");
		}
		else
		{
			output.Write("");
		}
	}
}
