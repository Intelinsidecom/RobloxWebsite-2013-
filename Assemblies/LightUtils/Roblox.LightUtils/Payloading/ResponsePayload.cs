namespace Roblox.LightUtils
{
	public static class ResponsePayload
	{
		public static object Bad(string message, int? code = null, string reason = null)
		{
			var response = new
			{
				Success = false,
				Message = message,
				Reason = reason,
				Code = code
			};
			SimpleLogger.Trace("returning non OK response", response);
			return response;
		}
		public static object Ok(string message = null, int? code = null)
		{
			return new
			{
				Success = true,
				Message = message,
				Code = code
			};
		}
	}
}
