using System;

namespace Roblox.Web.Metrics;

/// <summary>
/// A model for containing endpoint metric information
/// </summary>
public class ActionMetricsModel
{
	/// <summary>
	/// The action name
	/// </summary>
	public string ActionName { get; set; }

	/// <summary>
	/// The controller name
	/// </summary>
	public string ControllerName { get; set; }

	/// <summary>
	/// When the action was chosen for execution
	/// </summary>
	public DateTime ActionExecutionStartTime { get; set; }
}
