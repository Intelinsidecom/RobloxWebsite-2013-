using System;
using System.Web.UI;

namespace Roblox.Web.Base;

public abstract class CustomUserControlBase : UserControl
{
	public CustomUserControlBase()
	{
		base.Load += Page_Load;
	}

	protected virtual void Page_Load(object sender, EventArgs e)
	{
	}
}
