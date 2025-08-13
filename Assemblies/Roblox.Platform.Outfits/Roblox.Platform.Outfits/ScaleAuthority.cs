using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Outfits;

public class ScaleAuthority : IScaleAuthority
{
	/// <inheritdoc />
	public Scale GetClampedScale(out bool valid, Scale scalesModelToClamp, Scale existingScale)
	{
		if (scalesModelToClamp == null)
		{
			throw new PlatformArgumentNullException("scalesModelToClamp");
		}
		return GetClampedScale(out valid, scalesModelToClamp.Height, scalesModelToClamp.Width, scalesModelToClamp.Head, scalesModelToClamp.Proportion, scalesModelToClamp.BodyType, existingScale);
	}

	/// <inheritdoc />
	public Scale GetClampedScale(out bool valid, decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType, Scale existingScale)
	{
		valid = false;
		if (!head.HasValue || !proportion.HasValue || !bodyType.HasValue)
		{
			if (existingScale != null)
			{
				if (!head.HasValue)
				{
					head = existingScale.Head;
				}
				if (!proportion.HasValue)
				{
					proportion = existingScale.Proportion;
				}
				if (!bodyType.HasValue)
				{
					bodyType = existingScale.BodyType;
				}
			}
			else
			{
				if (!head.HasValue)
				{
					head = ScaleRules.Head.Default;
				}
				if (!proportion.HasValue)
				{
					proportion = ScaleRules.Proportion.Default;
				}
				if (!bodyType.HasValue)
				{
					bodyType = ScaleRules.BodyType.Default;
				}
			}
		}
		height = ((height == 0m) ? ScaleRules.Height.Default : height);
		width = ((width == 0m) ? ScaleRules.Width.Default : width);
		decimal? num = head;
		head = ((num.GetValueOrDefault() == default(decimal) && num.HasValue) ? new decimal?(ScaleRules.Head.Default) : head);
		valid = ScaleRules.Valid(height, width, head.Value, proportion.Value, bodyType.Value);
		height = ScaleRules.Height.ClampAndRound(height);
		width = ScaleRules.Width.ClampAndRound(width);
		head = ScaleRules.Head.ClampAndRound(head.Value);
		proportion = ScaleRules.Proportion.ClampAndRound(proportion.Value);
		bodyType = ScaleRules.BodyType.ClampAndRound(bodyType.Value);
		return new Scale
		{
			Height = height,
			Width = width,
			Head = head.Value,
			Proportion = proportion.Value,
			BodyType = bodyType.Value
		};
	}

	/// <inheritdoc />
	public IEnumerable<ScaleRules> CheckScale(decimal height, decimal width, decimal? head, decimal? proportion, decimal? bodyType)
	{
		List<ScaleRules> scaleRulesViolated = new List<ScaleRules>();
		if (!ScaleRules.Height.InRange(height))
		{
			scaleRulesViolated.Add(ScaleRules.Height);
		}
		if (!ScaleRules.Width.InRange(width))
		{
			scaleRulesViolated.Add(ScaleRules.Width);
		}
		if (head.HasValue && !ScaleRules.Head.InRange(head.Value))
		{
			scaleRulesViolated.Add(ScaleRules.Head);
		}
		if (proportion.HasValue && !ScaleRules.Proportion.InRange(proportion.Value))
		{
			scaleRulesViolated.Add(ScaleRules.Proportion);
		}
		if (bodyType.HasValue && !ScaleRules.BodyType.InRange(bodyType.Value))
		{
			scaleRulesViolated.Add(ScaleRules.BodyType);
		}
		return scaleRulesViolated;
	}

	/// <inheritdoc />
	public IEnumerable<ScaleRules> CompareMinAndMaxScales(Scale minScalesModel, Scale maxScalesModel)
	{
		List<ScaleRules> scaleRulesViolated = new List<ScaleRules>();
		if (minScalesModel.Height > maxScalesModel.Height)
		{
			scaleRulesViolated.Add(ScaleRules.Height);
		}
		if (minScalesModel.Width > maxScalesModel.Width)
		{
			scaleRulesViolated.Add(ScaleRules.Width);
		}
		if (minScalesModel.Head > maxScalesModel.Head)
		{
			scaleRulesViolated.Add(ScaleRules.Head);
		}
		if (minScalesModel.BodyType > maxScalesModel.BodyType)
		{
			scaleRulesViolated.Add(ScaleRules.BodyType);
		}
		if (minScalesModel.Proportion > maxScalesModel.Proportion)
		{
			scaleRulesViolated.Add(ScaleRules.Proportion);
		}
		return scaleRulesViolated;
	}
}
