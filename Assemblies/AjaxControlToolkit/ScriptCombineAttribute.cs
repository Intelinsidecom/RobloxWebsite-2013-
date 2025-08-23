// NOTE: Placeholder attribute to replace dependency on external AjaxControlToolkit binary.
// Only includes ScriptCombineAttribute used by assembly-level attribute in Roblox.Thumbs.
using System;

namespace AjaxControlToolkit
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class ScriptCombineAttribute : Attribute
    {
        public ScriptCombineAttribute() { }
    }
}
