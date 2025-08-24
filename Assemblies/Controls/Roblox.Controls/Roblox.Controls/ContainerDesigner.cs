using System.Web.UI.Design;

namespace Roblox.Controls;

/// <summary>
/// A custom designer for Container
/// </summary>
public class ContainerDesigner : ContainerControlDesigner
{
	public override string FrameCaption => ((Container)base.Component).ID;
}
