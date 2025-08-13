namespace Roblox.Platform.Core;

/// <summary>
/// Represents an object containing all of the factories in a domain.
/// </summary>
/// <example>
/// <code>
/// public class MembershipDomainFactories : DomainFactoriesBase
/// {
///     public IUserFactory UserFactory { get; protected set; }
///     <br />
///     public IUserIdentifierFactory UserIdentifierFactory { get; protected set; }
///     <br />
///     protected MembershipDomainFactories()
///     {
///     }
///     <br />
///     public static MembershipDomainFactories Build()
///     {
///         var factories = new MembershipDomainFactories();
///         factories.UserFactory = new UserFactory(factories);
///         factories.UserIdentifierFactory = new UserIdentifierFactory(factories);
///         return factories;
///     }
/// }
///
/// public class TestableMembershipDomainFactories : MembershipDomainFactories
/// {
///     public static new MembershipDomainFactories Build()
///     {
///         var factories = new TestableMembershipDomainFactories();
///         factories.UserFactory = A.Fake&lt;IUserFactory&gt;();
///         factories.UserIdentifierFactory = A.Fake&lt;IUserIdentifierFactory&gt;();
///         return factories;
///     }
/// }
/// </code>
/// </example>
public abstract class DomainFactoriesBase
{
}
