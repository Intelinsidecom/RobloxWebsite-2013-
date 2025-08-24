using System;
using System.Security.Cryptography;

namespace Roblox.Billing;

public sealed class RSAPKCS1SHA256SignatureDescription : SignatureDescription
{
	public RSAPKCS1SHA256SignatureDescription()
	{
		base.KeyAlgorithm = typeof(RSACryptoServiceProvider).FullName;
		base.DigestAlgorithm = typeof(SHA256Managed).FullName;
		base.FormatterAlgorithm = typeof(RSAPKCS1SignatureFormatter).FullName;
		base.DeformatterAlgorithm = typeof(RSAPKCS1SignatureDeformatter).FullName;
	}

	public override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		RSAPKCS1SignatureDeformatter rSAPKCS1SignatureDeformatter = new RSAPKCS1SignatureDeformatter(key);
		rSAPKCS1SignatureDeformatter.SetHashAlgorithm("SHA256");
		return rSAPKCS1SignatureDeformatter;
	}

	public override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		RSAPKCS1SignatureFormatter rSAPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(key);
		rSAPKCS1SignatureFormatter.SetHashAlgorithm("SHA256");
		return rSAPKCS1SignatureFormatter;
	}
}
