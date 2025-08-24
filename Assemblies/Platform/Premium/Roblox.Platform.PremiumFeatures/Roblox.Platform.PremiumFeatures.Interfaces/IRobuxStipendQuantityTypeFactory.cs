namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// Robux stipend quantity type factory
/// </summary>
public interface IRobuxStipendQuantityTypeFactory
{
	/// <summary>
	/// None id
	/// </summary>
	/// <returns></returns>
	byte NoneId();

	/// <summary>
	/// 15 id
	/// </summary>
	/// <returns></returns>
	byte FifteenId();

	/// <summary>
	/// 35 id
	/// </summary>
	/// <returns></returns>
	byte ThirtyFiveId();

	/// <summary>
	/// 60 id
	/// </summary>
	/// <returns></returns>
	byte SixtyId();

	/// <summary>
	/// 100 id
	/// </summary>
	/// <returns></returns>
	byte OneHundredId();

	/// <summary>
	/// Get Robux stipend quantity type model by id
	/// </summary>
	/// <param name="id">Id</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IRobuxStipendQuantityTypeModel" /></returns>
	IRobuxStipendQuantityTypeModel Get(byte id);
}
