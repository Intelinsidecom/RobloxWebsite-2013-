using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models;

[DataContract]
public class MembershipMigrationErrorResponse : MembershipMigrationResponse
{
	/// <summary>
	/// Error Code. see <see cref="T:Roblox.PremiumFeatures.MembershipMigrationsErrorCode" />
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false, IsRequired = false)]
	public MembershipMigrationsErrorCode ErrorCode { get; set; }

	/// <summary>
	/// Template string error message. For internal use. Use code to render an appropriate message depending on UI.
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false, IsRequired = false)]
	public string ErrorMessage { get; set; }
}
