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
internal class CharacterAppearance
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	/// <summary>
	///   Returns the cached ResourceManager instance used by this class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("Roblox.Business_Logic_Layer.CharacterAppearance", typeof(CharacterAppearance).Assembly);
			}
			return resourceMan;
		}
	}

	/// <summary>
	///   Overrides the current thread's CurrentUICulture property for all
	///   resource lookups using this strongly typed resource class.
	/// </summary>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
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
	internal static byte[] DefaultAppearance => (byte[])ResourceManager.GetObject("DefaultAppearance", resourceCulture);

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	internal static byte[] Pants => (byte[])ResourceManager.GetObject("Pants", resourceCulture);

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	internal static byte[] Shirt => (byte[])ResourceManager.GetObject("Shirt", resourceCulture);

	/// <summary>
	///   Looks up a localized resource of type System.Byte[].
	/// </summary>
	internal static byte[] TeeShirt => (byte[])ResourceManager.GetObject("TeeShirt", resourceCulture);

	internal CharacterAppearance()
	{
	}
}
