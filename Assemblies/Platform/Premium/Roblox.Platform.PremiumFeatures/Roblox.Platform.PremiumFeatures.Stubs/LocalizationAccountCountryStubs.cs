namespace Roblox.Platform.Localization.Accounts
{
    // Minimal stubs to satisfy compile until real localization project is referenced
    public interface IAccountCountryAccessor
    {
        AccountCountry GetAccountCountry(long accountId);
    }

    public class AccountCountry
    {
        public CountryIdentifier CountryId { get; set; }
    }

    public class CountryIdentifier
    {
        public int? Id { get; set; }
    }
}
