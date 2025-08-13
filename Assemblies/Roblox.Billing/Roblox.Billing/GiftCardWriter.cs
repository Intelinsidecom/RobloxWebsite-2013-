using System;
using System.IO;
using System.Text;
using System.Web;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Roblox.Billing.Business_Logic_Layer;

namespace Roblox.Billing;

public class GiftCardWriter
{
	private PdfDocument _CertificateDocument;

	private PdfPage _Page;

	private XGraphicsState _XGraphicsState;

	private static string _PlaceHolderRedemptionCode = "0123 4567 8901";

	private static XFont _HeaderFontLarge = new XFont("Arial", 18.0, (XFontStyle)1);

	private static XFont _HeaderFontMedium = new XFont("Arial", 14.0, (XFontStyle)1);

	private static XFont _TextFont = new XFont("Arial", 10.0, (XFontStyle)0);

	private static double _HeaderHeightLarge = _HeaderFontLarge.GetHeight();

	private static double _HeaderHeightMedium = _HeaderFontMedium.GetHeight();

	private static double _FontHeight = _TextFont.GetHeight();

	private const int _QuadrantPadding = 10;

	private string _To;

	private string _From;

	private string _Message;

	private string _ProductName;

	private string _RedemptionCode;

	private decimal _Value;

	private string _ResourcePath;

	public GiftCardWriter(HttpContext context, GiftCard giftCard, bool isPreview)
	{
		string themeName = GiftCardThemeType.Get(giftCard.ThemeTypeID).Name.ToLower();
		_ResourcePath = context.Request.PhysicalApplicationPath + "images/Gifting/Preview/giftcard_" + themeName + ".pdf";
		_To = giftCard.RecipientName;
		_From = giftCard.PurchaserName;
		_Message = giftCard.Message;
		_Value = giftCard.Value;
		_ProductName = giftCard.Product.Name;
		if (isPreview || giftCard.RedemptionCode == null)
		{
			_RedemptionCode = _PlaceHolderRedemptionCode;
		}
		else
		{
			_RedemptionCode = _FormatRedemptionCode(giftCard.RedemptionCode);
		}
	}

	public MemoryStream GetCertificateStream()
	{
		MemoryStream certificateStream = new MemoryStream();
		_CertificateDocument = PdfReader.Open(_ResourcePath);
		_Page = _CertificateDocument.Pages[0];
		_GenerateCertificate();
		_CertificateDocument.Save((Stream)certificateStream);
		_CertificateDocument.Close();
		return certificateStream;
	}

	private void _GenerateCertificate()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		XGraphics xGraphics = XGraphics.FromPdfPage(_Page);
		XTextFormatter val = new XTextFormatter(xGraphics);
		XRect quad = BeginQuadrant(xGraphics, 2);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + (((XRect)(ref quad)).Height / 2.0 - _HeaderHeightLarge / 2.0);
		val.Alignment = (XParagraphAlignment)2;
		val.DrawString(_RedemptionCode, _HeaderFontLarge, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		EndQuadrant(xGraphics);
		quad = BeginQuadrant(xGraphics, 4);
		val.Alignment = (XParagraphAlignment)2;
		string[] productStrings = _GetCertificateProductStrings();
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + 2.0 * _HeaderHeightLarge;
		val.DrawString(productStrings[0], _TextFont, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + _FontHeight;
		val.DrawString(productStrings[1], _HeaderFontLarge, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + 2.0 * _HeaderHeightLarge;
		val.DrawString("Awarded to", _TextFont, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + _HeaderHeightLarge;
		val.DrawString(_To, _HeaderFontLarge, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + 2.0 * _HeaderHeightLarge;
		val.DrawString(_Message, _TextFont, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		((XRect)(ref quad)).Y = ((XRect)(ref quad)).Y + 6.0 * _FontHeight;
		val.DrawString("From " + _From, _HeaderFontMedium, (XBrush)(object)XBrushes.Black, quad, XStringFormats.TopLeft);
		EndQuadrant(xGraphics);
	}

	private XRect BeginQuadrant(XGraphics xGraphics, int quadrant)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		_XGraphicsState = xGraphics.Save();
		double dx = 0.0;
		double dy = 0.0;
		double dt = 0.0;
		XRect rect = default(XRect);
		if (quadrant == 0)
		{
			((XRect)(ref rect))._002Ector(0.0, 0.0, XUnit.op_Implicit(_Page.Width), XUnit.op_Implicit(_Page.Height));
		}
		else
		{
			((XRect)(ref rect))._002Ector(10.0, 10.0, XUnit.op_Implicit(_Page.Width) / 2.0 - 20.0, XUnit.op_Implicit(_Page.Height) / 2.0 - 20.0);
			dt = ((quadrant != 1) ? 0.0 : 180.0);
			switch (quadrant)
			{
			case 1:
				dx = XUnit.op_Implicit(_Page.Width) / 2.0;
				dy = XUnit.op_Implicit(_Page.Height) / 2.0;
				break;
			case 2:
				dx = XUnit.op_Implicit(_Page.Width) / 2.0;
				break;
			case 3:
				dy = XUnit.op_Implicit(_Page.Height) / 2.0;
				break;
			case 4:
				dx = XUnit.op_Implicit(_Page.Width) / 2.0;
				dy = XUnit.op_Implicit(_Page.Height) / 2.0;
				break;
			}
		}
		xGraphics.TranslateTransform(dx, dy);
		xGraphics.RotateTransform(dt);
		return rect;
	}

	private void EndQuadrant(XGraphics xGraphics)
	{
		xGraphics.Restore(_XGraphicsState);
	}

	private string[] _GetCertificateProductStrings()
	{
		string[] productStrings = new string[2];
		if (!_ProductName.Equals("Gift Custom Value"))
		{
			productStrings[0] = _Value.ToString("C") + " Roblox Credits redeemable for";
			productStrings[1] = _ProductName.Replace("Gift ", "");
		}
		else
		{
			productStrings[0] = "";
			productStrings[1] = _Value.ToString("C") + " of Roblox Credits";
		}
		return productStrings;
	}

	private string _FormatRedemptionCode(string redemptionCode)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < redemptionCode.Length; i += 3)
		{
			sb.Append(redemptionCode.Substring(i, Math.Min(3, redemptionCode.Length - i)));
			sb.Append(" ");
		}
		return sb.ToString();
	}
}
