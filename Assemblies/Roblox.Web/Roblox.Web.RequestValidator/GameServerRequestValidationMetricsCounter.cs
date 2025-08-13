namespace Roblox.Web.RequestValidator;

internal enum GameServerRequestValidationMetricsCounter
{
	ValidRequest,
	AlternateAccessKeyUsed,
	InvalidIpAddress,
	InvalidAccessKey,
	MissingAccessKey,
	InvalidPlaceId,
	InvalidGameId,
	JobSignatureInvalid,
	AlternateJobSignatureSaltUsed
}
