using System;
using Roblox.Platform.Outfits.Properties;

namespace Roblox.Platform.Outfits;

/// <summary>
/// Do not change the 'default' values for any of these scales without serious thought
/// It will cause all existing users with default scale to have a new thumbnail key
/// </summary>
public class ScaleRules
{
	public static ScaleRules Height = new ScaleRules("Height", () => Settings.Default.ScaleHeightMin, () => Settings.Default.ScaleHeightMax, () => Settings.Default.ScaleHeightDefault);

	public static ScaleRules Width = new ScaleRules("Width", () => Settings.Default.ScaleWidthMin, () => Settings.Default.ScaleWidthMax, () => Settings.Default.ScaleWidthDefault);

	public static ScaleRules Head = new ScaleRules("Head", () => Settings.Default.ScaleHeadMin, () => Settings.Default.ScaleHeadMax, () => Settings.Default.ScaleHeadDefault);

	public static ScaleRules Depth = new ScaleRules("Depth", () => Settings.Default.ScaleDepthMin, () => Settings.Default.ScaleDepthMax, () => Settings.Default.ScaleDepthDefault);

	public static ScaleRules Proportion = new ScaleRules("Proportion", () => Settings.Default.ScaleProportionMin, () => Settings.Default.ScaleProportionMax, () => Settings.Default.ScaleProportionDefault);

	public static ScaleRules BodyType = new ScaleRules("BodyType", () => Settings.Default.ScaleBodyTypeMin, () => Settings.Default.ScaleBodyTypeMax, () => Settings.Default.ScaleBodyTypeDefault);

	private readonly Func<decimal> _MinGetter;

	private readonly Func<decimal> _MaxGetter;

	private readonly Func<decimal> _DefaultGetter;

	public string Name;

	public decimal Min => _MinGetter();

	public decimal Max => _MaxGetter();

	public decimal Default => _DefaultGetter();

	public decimal Increment => Settings.Default.ScaleIncrement;

	/// <summary>
	/// Depth is calculated based on width.
	/// </summary>
	public decimal CalculateDepth(decimal width)
	{
		decimal depthDecreaseToWidthDecreaseRatio = default(decimal);
		if (Settings.Default.ScaleDepthWidthRatio > 0m)
		{
			depthDecreaseToWidthDecreaseRatio = Settings.Default.ScaleDepthWidthRatio;
		}
		decimal depth = 1m - (1m - width) * depthDecreaseToWidthDecreaseRatio;
		return Depth.ClampAndRound(depth);
	}

	/// <summary>
	/// Returns false if any of the parameters are out of range of valid inputs
	/// </summary>
	public static bool Valid(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		if (Height.InRange(height) && Width.InRange(width) && Head.InRange(head) && Proportion.InRange(proportion))
		{
			return BodyType.InRange(bodyType);
		}
		return false;
	}

	/// <summary>
	/// Returns false if any of the parameters are different from their default values.
	/// Disregards depth because it is calculated based on the other parameters.
	/// </summary>
	public static bool IsDefault(decimal height, decimal width, decimal head, decimal proportion, decimal bodyType)
	{
		if (height == Height.Default && width == Width.Default && head == Head.Default && proportion == Proportion.Default)
		{
			return bodyType == BodyType.Default;
		}
		return false;
	}

	public ScaleRules(string name, Func<decimal> minGetter, Func<decimal> maxGetter, Func<decimal> defaultGetter)
	{
		Name = name;
		_MinGetter = minGetter;
		_MaxGetter = maxGetter;
		_DefaultGetter = defaultGetter;
	}

	public bool InRange(decimal input)
	{
		if (Min <= input)
		{
			return input <= Max;
		}
		return false;
	}

	public decimal Round(decimal input)
	{
		if (Increment == 0m)
		{
			return input;
		}
		return Increment * Math.Round(input / Increment);
	}

	/// <summary>
	/// Clamps the input to the min and max for this scale dimension.
	/// Rounds to the nearest increment if necessary.
	/// </summary>
	/// <param name="input"></param>
	public decimal ClampAndRound(decimal input)
	{
		if (input < Min)
		{
			return Min;
		}
		if (input > Max)
		{
			return Max;
		}
		return Round(input);
	}
}
