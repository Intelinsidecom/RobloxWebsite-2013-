using System;
using System.Collections.Generic;
using System.Web;
using Roblox.Instrumentation;

namespace Roblox.Web.Base;

public abstract class RobloxHandlerBase : IHttpHandler
{
	public enum ContentReturnType
	{
		HTML,
		JSON,
		PDF
	}

	private static CorsOriginValidator _CorsOriginValidator = new CorsOriginValidator(StaticCounterRegistry.Instance);

	private static readonly Dictionary<ContentReturnType, string> _ReturnTypeMappings = new Dictionary<ContentReturnType, string>
	{
		{
			ContentReturnType.HTML,
			"text/html"
		},
		{
			ContentReturnType.JSON,
			"application/json"
		},
		{
			ContentReturnType.PDF,
			"application/pdf"
		}
	};

	protected virtual bool CorsEnabled => false;

	protected virtual bool CorsCredentialsRequired => false;

	protected virtual List<string> CorsExposedHeaders => null;

	public abstract ContentReturnType ReturnType { get; }

	public virtual bool IsReusable => true;

	public virtual void SetCachePolicy(HttpContext context)
	{
		context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
		context.Response.Cache.SetNoStore();
		context.Response.Cache.SetExpires(DateTime.MinValue);
	}

	public virtual void SetContentType(HttpContext context)
	{
		context.Response.ContentType = _ReturnTypeMappings[ReturnType];
	}

	public abstract void DoProcessRequest(HttpContext context);

	public void ProcessRequest(HttpContext context)
	{
		if (context.Request.HttpMethod == "OPTIONS")
		{
			CorsHeaders.AddCorsHeadersForOptions(context.Request, context.Response);
		}
		else if (ValidateRequest(context))
		{
			SetCachePolicy(context);
			SetContentType(context);
			SetCorsHeaders(context);
			DoProcessRequest(context);
		}
	}

	public virtual bool ValidateRequest(HttpContext context)
	{
		if (context.Request.RequestType.Equals("post", StringComparison.OrdinalIgnoreCase))
		{
			return XsrfTokenHelper.RequestIsValid(context);
		}
		return true;
	}

	public virtual string GetTokenKey(HttpContext context)
	{
		return XsrfTokenHelper.GetXsrfSafeTokenKey(context);
	}

	private void SetCorsHeaders(HttpContext context)
	{
		if (CorsEnabled)
		{
			string originToAdd = _CorsOriginValidator.GetValidatedOriginToAdd(context.Request.UrlReferrer, context.Request.Headers["Origin"]);
			if (originToAdd != null)
			{
				context.Response.Headers["Access-Control-Allow-Origin"] = originToAdd;
			}
			if (CorsExposedHeaders != null)
			{
				string headersValue = string.Join(",", CorsExposedHeaders);
				context.Response.Headers["Access-Control-Expose-Headers"] = headersValue;
			}
			if (CorsCredentialsRequired)
			{
				context.Response.Headers["Access-Control-Allow-Credentials"] = "true";
			}
		}
	}
}
