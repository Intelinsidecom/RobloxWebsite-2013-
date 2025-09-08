namespace Roblox.Platform.Authentication
{
    public interface ICredentialValidator
    {
        CredentialValidationResult ValidateCredentials(UserCredentials credentials);
        bool ValidateEmail(long userId, string email);
    }
}
