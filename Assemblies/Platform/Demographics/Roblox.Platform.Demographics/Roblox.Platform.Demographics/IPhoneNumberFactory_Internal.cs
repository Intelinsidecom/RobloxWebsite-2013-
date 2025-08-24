namespace Roblox.Platform.Demographics;

internal interface IPhoneNumberFactory_Internal : IPhoneNumberFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumber" /> by its ID.
	/// </summary>
	IPhoneNumber GetById(int id);
}
