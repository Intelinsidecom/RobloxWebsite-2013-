using System;
using Roblox.EventLog;
using Roblox.PremiumFeatures.Enums;
using Roblox.PremiumFeatures.Interfaces.Converters;
using Roblox.PremiumFeatures.Interfaces.Entities;
using Roblox.PremiumFeatures.Interfaces.EntityFactories;

namespace Roblox.PremiumFeatures;

/// <summary>
/// Converts <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> enums to IDs.
/// </summary>
/// <seealso cref="T:Roblox.PremiumFeatures.Interfaces.Converters.IRobuxStipendFrequencyTypeConverter" />
public class RobuxStipendFrequencyTypeConverter : IRobuxStipendFrequencyTypeConverter
{
	private ILogger Logger;

	private IRobuxStipendFrequencyTypeEntityFactory RobuxStipendFrequencyTypeEntityFactory { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.PremiumFeatures.RobuxStipendFrequencyTypeConverter" /> class.
	/// </summary>
	/// <param name="robuxStipendFrequencyTypeEntityFactory">The <see cref="P:Roblox.PremiumFeatures.RobuxStipendFrequencyTypeConverter.RobuxStipendFrequencyTypeEntityFactory" />.</param>
	/// <param name="logger">The logger used to log issues.</param>
	public RobuxStipendFrequencyTypeConverter(IRobuxStipendFrequencyTypeEntityFactory robuxStipendFrequencyTypeEntityFactory, ILogger logger)
	{
		RobuxStipendFrequencyTypeEntityFactory = robuxStipendFrequencyTypeEntityFactory ?? throw new ArgumentNullException("robuxStipendFrequencyTypeEntityFactory");
		Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <summary>
	/// Gets the ID associated with the <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />
	/// </summary>
	/// <param name="frequencyType"></param>
	/// <returns></returns>
	public byte GetIdByType(RobuxStipendFrequencyType frequencyType)
	{
		IRobuxStipendFrequencyTypeEntity byValue = RobuxStipendFrequencyTypeEntityFactory.GetByValue(frequencyType.ToString());
		if (byValue == null)
		{
			Exception ex = new Exception($"Attempted lookup of unpersisted RobuxStipendFrequencyTypeEntity '{frequencyType}'");
			Logger.Error(ex);
			throw ex;
		}
		return byValue.Id;
	}

	/// <summary>
	/// Gets the<see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> associated with the given id
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public RobuxStipendFrequencyType? GetTypeById(byte id)
	{
		IRobuxStipendFrequencyTypeEntity frequencyTypeEntity = RobuxStipendFrequencyTypeEntityFactory.Get(id);
		if (frequencyTypeEntity == null)
		{
			return null;
		}
		if (!Enum.TryParse<RobuxStipendFrequencyType>(frequencyTypeEntity.Value, out var result))
		{
			return null;
		}
		return result;
	}
}
