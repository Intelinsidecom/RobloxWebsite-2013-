using System;
using System.Threading;
using Grpc.Core;

namespace Roblox.Captcha.Captcha.V1
{
    public class CaptchaAPIClient
    {
        public AllowedResponse Allowed(AllowedRequest request, Metadata metadata = null, DateTime? deadline = null, CancellationToken cancellationToken = default)
        {
            // Minimal stub: treat empty/whitespace token as challenge required
            bool challenge = string.IsNullOrWhiteSpace(request?.CaptchaToken);
            return new AllowedResponse { Challenge = challenge };
        }
    }
}
