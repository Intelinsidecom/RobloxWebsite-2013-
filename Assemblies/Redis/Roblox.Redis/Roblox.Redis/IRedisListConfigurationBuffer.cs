using System.Security.Cryptography.X509Certificates;
using StackExchange.Redis;

namespace Roblox.Redis;

public interface IRedisListConfigurationBuffer
{
	string RedisListKey { get; }

	ConfigurationOptions GetConfigurationOptions();

	bool NeedsReCreation(string propertyName);

	X509Certificate OptionsOnCertificateSelection(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
