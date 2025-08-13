using System.Runtime.Serialization;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// A class that represents a DeleteTranslationResponse
/// </summary>
[DataContract]
public class DeleteTranslationResponse
{
	/// <summary>
	/// Gets or sets the status code.
	/// </summary>
	/// <value>
	/// The <see cref="T:Roblox.Platform.TranslationStorage.OperationStatusCode" />.
	/// </value>
	[DataMember(Name = "statusCode")]
	public OperationStatusCode StatusCode { get; set; }
}
