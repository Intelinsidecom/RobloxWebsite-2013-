using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using Roblox.Web.Properties;

namespace Roblox.Web.Base;

/// <summary>
/// Class: SimpleMasterPageBase
/// Type: Abstract
/// Description: The aim of this class is to hook up the standard Page events to event handlers from any aspx page
/// that inherits from this class.
/// </summary>
public abstract class SimpleMasterPageBase : MasterPage
{
	private ICollection<GPTAdData> _GPTAdData = new Collection<GPTAdData>();

	protected static readonly string MachineID = (Environment.MachineName.Contains("-") ? Environment.MachineName.Substring(Environment.MachineName.IndexOf("-") + 1) : Environment.MachineName);

	public string GPTAdSlotsDeclarationJS
	{
		get
		{
			StringBuilder declarationBuilder = new StringBuilder();
			foreach (GPTAdData gptData in GPTAdData)
			{
				declarationBuilder.AppendLine($"googletag.defineSlot({gptData.SlotPath}, {gptData.AdDimensions}, \"{gptData.RandomSlotIdentifyer}\").addService(googletag.pubads());");
			}
			return declarationBuilder.ToString();
		}
	}

	public ICollection<GPTAdData> GPTAdData
	{
		get
		{
			if (base.Master != null && base.Master is SimpleMasterPageBase)
			{
				return ((SimpleMasterPageBase)base.Master).GPTAdData;
			}
			return _GPTAdData;
		}
	}

	public ICollection<string> AdAttributeGenresCollection { get; set; }

	public string AdAttributeGenresString => string.Join(", ", AdAttributeGenresCollection.Select((string genre) => "\"" + genre + "\""));

	public string AdAttributeGenresCSV => string.Join(",", AdAttributeGenresCollection);

	protected string XsrfToken
	{
		get
		{
			if (XsrfTokensEnabled)
			{
				return XsrfTokenHelper.GetOrCreateToken(XsrfTokenHelper.GetXsrfSafeTokenKey(HttpContext.Current));
			}
			return string.Empty;
		}
	}

	protected bool XsrfTokensEnabled => Settings.Default.XsrfTokenValidationEnabled;

	public SimpleMasterPageBase()
	{
		base.Load += Page_Load;
		base.Init += Page_Init;
	}

	protected abstract void Page_Load(object sender, EventArgs e);

	protected virtual void Page_Init(object sender, EventArgs e)
	{
	}

	protected override void Render(HtmlTextWriter writer)
	{
		base.Render(writer);
		if (Settings.Default.PageBaseCacheControlMustRevalidateHeaderEnabled)
		{
			base.Response.Cache.AppendCacheExtension("must-revalidate");
		}
	}
}
