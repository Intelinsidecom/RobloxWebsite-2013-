namespace Roblox.Platform.Chat;

internal interface IDecoratorValidatorFactory
{
	IDecoratorValidator GetDecoratorValidator(string decorator);
}
