using System;

namespace Roblox.Platform.Captcha.Captcha.V1
{
    public enum ActionType
    {
        Unknown = 0,
        Login = 1,
        Signup = 2
    }

    public enum Provider
    {
        Unknown = 0,
        Bedev2 = 1
    }

    public class AllowedRequest
    {
        public ActionType ActionType { get; set; }
        public string CaptchaToken { get; set; }
        public Provider Provider { get; set; }
    }

    public class AllowedResponse
    {
        // True means a challenge is required; false means passed
        public bool Challenge { get; set; }
    }
}
