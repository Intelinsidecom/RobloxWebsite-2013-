using System;

namespace Roblox.Platform.Outfits;

public static class ColorConverter
{
	private class ColorXyz
	{
		public double X { get; set; }

		public double Y { get; set; }

		public double Z { get; set; }
	}

	private class ColorLab
	{
		public double L { get; set; }

		public double A { get; set; }

		public double B { get; set; }
	}

	private const double _Epsilon = 0.008856451679035631;

	private const double _Kappa = 903.2962962962963;

	private static readonly ColorXyz _WhiteReference = new ColorXyz
	{
		X = 95.047,
		Y = 100.0,
		Z = 108.883
	};

	/// <summary>
	/// Calculates the Delta-E distance between two colors given in RGB.
	/// </summary>
	/// <param name="color1"></param>
	/// <param name="color2"></param>
	/// <returns>A double representing the Delta-E difference between color1 and color2</returns>
	public static double DeltaE(IColor color1, IColor color2)
	{
		ColorLab color3 = ConvertRgbToLab(color1);
		ColorLab color2Lab = ConvertRgbToLab(color2);
		return Cie2000Difference(color3, color2Lab);
	}

	/// <summary>
	/// Implements the CIE2000 method of Delta-E: 
	/// https://en.wikipedia.org/wiki/Color_difference#CIEDE2000
	/// </summary>
	/// <param name="color1"></param>
	/// <param name="color2"></param>
	/// <returns>A double representing the CIE2000 Delta-E between color1 and color2</returns>
	private static double Cie2000Difference(ColorLab color1, ColorLab color2)
	{
		double degrees360InRadians = DegreesToRadians(360.0);
		double degrees180InRadians = DegreesToRadians(180.0);
		double pow25To7 = Math.Pow(25.0, 7.0);
		double num = Math.Sqrt(color1.A * color1.A + color1.B * color1.B);
		double c2 = Math.Sqrt(color2.A * color2.A + color2.B * color2.B);
		double barC = (num + c2) / 2.0;
		double g = 0.5 * (1.0 - Math.Sqrt(Math.Pow(barC, 7.0) / (Math.Pow(barC, 7.0) + pow25To7)));
		double a1Prime = (1.0 + g) * color1.A;
		double a2Prime = (1.0 + g) * color2.A;
		double cPrime1 = Math.Sqrt(a1Prime * a1Prime + color1.B * color1.B);
		double cPrime2 = Math.Sqrt(a2Prime * a2Prime + color2.B * color2.B);
		double hPrime1;
		if (color1.B == 0.0 && a1Prime == 0.0)
		{
			hPrime1 = 0.0;
		}
		else
		{
			hPrime1 = Math.Atan2(color1.B, a1Prime);
			if (hPrime1 < 0.0)
			{
				hPrime1 += degrees360InRadians;
			}
		}
		double hPrime2;
		if (color2.B == 0.0 && a2Prime == 0.0)
		{
			hPrime2 = 0.0;
		}
		else
		{
			hPrime2 = Math.Atan2(color2.B, a2Prime);
			if (hPrime2 < 0.0)
			{
				hPrime2 += degrees360InRadians;
			}
		}
		double num2 = color2.L - color1.L;
		double deltaCPrime = cPrime2 - cPrime1;
		double cPrimeProduct = cPrime1 * cPrime2;
		double deltaHPrime;
		if (cPrimeProduct == 0.0)
		{
			deltaHPrime = 0.0;
		}
		else
		{
			deltaHPrime = hPrime2 - hPrime1;
			if (deltaHPrime < 0.0 - degrees180InRadians)
			{
				deltaHPrime += degrees360InRadians;
			}
			else if (deltaHPrime > degrees180InRadians)
			{
				deltaHPrime -= degrees360InRadians;
			}
		}
		deltaHPrime = 2.0 * Math.Sqrt(cPrimeProduct) * Math.Sin(deltaHPrime / 2.0);
		double barLPrime = (color1.L + color2.L) / 2.0;
		double barCPrime = (cPrime1 + cPrime2) / 2.0;
		double hPrimeSum = hPrime1 + hPrime2;
		double barHPrime = ((cPrime1 * cPrime1 == 0.0) ? hPrimeSum : ((Math.Abs(hPrime1 - hPrime2) <= degrees180InRadians) ? (hPrimeSum / 2.0) : ((!(hPrimeSum < degrees360InRadians)) ? ((hPrimeSum - degrees360InRadians) / 2.0) : ((hPrimeSum + degrees360InRadians) / 2.0))));
		double t = 1.0 - 0.17 * Math.Cos(barHPrime - DegreesToRadians(30.0)) + 0.24 * Math.Cos(2.0 * barHPrime) + 0.32 * Math.Cos(3.0 * barHPrime + DegreesToRadians(6.0)) - 0.2 * Math.Cos(4.0 * barHPrime - DegreesToRadians(63.0));
		double deltaTheta = DegreesToRadians(30.0) * Math.Exp(0.0 - Math.Pow((barHPrime - DegreesToRadians(275.0)) / DegreesToRadians(25.0), 2.0));
		double rC = 2.0 * Math.Sqrt(Math.Pow(barCPrime, 7.0) / (Math.Pow(barCPrime, 7.0) + pow25To7));
		double sL = 1.0 + 0.015 * Math.Pow(barLPrime - 50.0, 2.0) / Math.Sqrt(20.0 + Math.Pow(barLPrime - 50.0, 2.0));
		double sC = 1.0 + 0.045 * barCPrime;
		double sH = 1.0 + 0.015 * barCPrime * t;
		double rT = (0.0 - Math.Sin(2.0 * deltaTheta)) * rC;
		return Math.Sqrt(Math.Pow(num2 / (1.0 * sL), 2.0) + Math.Pow(deltaCPrime / (1.0 * sC), 2.0) + Math.Pow(deltaHPrime / (1.0 * sH), 2.0) + rT * (deltaCPrime / (1.0 * sC)) * (deltaHPrime / (1.0 * sH)));
	}

	private static double DegreesToRadians(double degrees)
	{
		return degrees * (Math.PI / 180.0);
	}

	private static ColorLab ConvertRgbToLab(IColor color)
	{
		return ConvertXyzToLab(ConvertRgbToXyz(color));
	}

	private static ColorXyz ConvertRgbToXyz(IColor color)
	{
		double num = PivotRgb((double)(int)color.R / 255.0);
		double g = PivotRgb((double)(int)color.G / 255.0);
		double b = PivotRgb((double)(int)color.B / 255.0);
		double x = num * 0.4124 + g * 0.3576 + b * 0.1805;
		double y = num * 0.2126 + g * 0.7152 + b * 0.0722;
		double z = num * 0.0193 + g * 0.1192 + b * 0.9505;
		return new ColorXyz
		{
			X = x,
			Y = y,
			Z = z
		};
	}

	private static ColorLab ConvertXyzToLab(ColorXyz color)
	{
		double x = PivotXyz(color.X / _WhiteReference.X);
		double y = PivotXyz(color.Y / _WhiteReference.Y);
		double z = PivotXyz(color.Z / _WhiteReference.Z);
		return new ColorLab
		{
			L = Math.Max(0.0, 116.0 * y - 16.0),
			A = 500.0 * (x - y),
			B = 200.0 * (y - z)
		};
	}

	private static double PivotRgb(double n)
	{
		if (n > 0.04045)
		{
			return Math.Pow((n + 0.055) / 1.055, 2.4) * 100.0;
		}
		return n / 12.92 * 100.0;
	}

	private static double PivotXyz(double n)
	{
		if (n > 0.008856451679035631)
		{
			return Math.Pow(n, 1.0 / 3.0);
		}
		return 903.2962962962963 * n + 0.0;
	}
}
