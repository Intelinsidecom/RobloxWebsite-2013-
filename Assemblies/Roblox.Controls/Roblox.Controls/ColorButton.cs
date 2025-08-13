using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Roblox.Controls;

[DefaultProperty("BackColor")]
[ToolboxData("<{0}:ColorButton runat=server></{0}:ColorButton>")]
public class ColorButton : WebControl, IButtonControl, IPostBackEventHandler
{
	private bool causesValidation;

	private string commandArgument;

	private string commandName;

	private string validationGroup;

	public bool CausesValidation
	{
		get
		{
			return causesValidation;
		}
		set
		{
			causesValidation = value;
		}
	}

	public string CommandArgument
	{
		get
		{
			return commandArgument;
		}
		set
		{
			commandArgument = value;
		}
	}

	public string CommandName
	{
		get
		{
			return commandName;
		}
		set
		{
			commandName = value;
		}
	}

	public string PostBackUrl
	{
		get
		{
			throw new Exception("The method or operation is not implemented.");
		}
		set
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}

	public string ValidationGroup
	{
		get
		{
			return validationGroup;
		}
		set
		{
			validationGroup = value;
		}
	}

	public string Text
	{
		get
		{
			return "";
		}
		set
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}

	public event EventHandler Click;

	public event CommandEventHandler Command;

	public override void RenderControl(HtmlTextWriter writer)
	{
		AddAttributesToRender(writer);
		writer.AddAttribute(HtmlTextWriterAttribute.Onclick, Page.ClientScript.GetPostBackEventReference(this, CommandArgument));
		writer.RenderBeginTag(HtmlTextWriterTag.Div);
		writer.RenderEndTag();
	}

	protected override void RenderContents(HtmlTextWriter output)
	{
	}

	public void RaisePostBackEvent(string eventArgument)
	{
		if (this.Click != null)
		{
			this.Click(this, new EventArgs());
		}
		CommandEventArgs commandEventArgs = new CommandEventArgs(CommandName, eventArgument);
		if (this.Command != null)
		{
			this.Command(this, commandEventArgs);
		}
		RaiseBubbleEvent(this, commandEventArgs);
	}
}
