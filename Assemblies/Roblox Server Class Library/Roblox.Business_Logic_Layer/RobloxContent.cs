using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Roblox.Business_Logic_Layer;

/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class RobloxContent
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Returns the cached ResourceManager instance used by this class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("Roblox.Business_Logic_Layer.RobloxContent", typeof(RobloxContent).Assembly);
			}
			return resourceMan;
		}
	}

	/// <summary>
	///   Overrides the current thread's CurrentUICulture property for all
	///   resource lookups using this strongly typed resource class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	public static byte[] BadgeAwarder => (byte[])ResourceManager.GetObject("BadgeAwarder", resourceCulture);

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	public static byte[] BadgeAwarderPlatform => (byte[])ResourceManager.GetObject("BadgeAwarderPlatform", resourceCulture);

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	public static byte[] Decal => (byte[])ResourceManager.GetObject("Decal", resourceCulture);

	internal RobloxContent()
	{
	}
}
