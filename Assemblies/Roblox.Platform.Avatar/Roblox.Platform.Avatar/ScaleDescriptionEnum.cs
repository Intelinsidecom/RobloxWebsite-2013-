namespace Roblox.Platform.Avatar;

/// <summary>
/// For a given scale set (height/width only) how would it best be described?
/// Earlier items have precedence.  https://docs.google.com/drawings/d/1s7ciFapx34pPuWVv70uWt_e8JTb9wuoWbjgeV2z-_u4/edit
/// </summary>
public enum ScaleDescriptionEnum
{
	/// <summary>
	/// height==width==default value
	/// </summary>
	Standard = 1,
	/// <summary>
	/// height==width==maximum value
	/// </summary>
	Biggest,
	/// <summary>
	/// height==width==minimum value
	/// </summary>
	Smallest,
	/// <summary>
	/// height/width==1
	/// </summary>
	Proportional,
	/// <summary>
	/// height/width&gt;1
	/// </summary>
	Narrower,
	/// <summary>
	/// height/width&lt;1
	/// </summary>
	Wider
}
