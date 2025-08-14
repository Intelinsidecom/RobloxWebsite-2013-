using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website
{
    public class ExceptionHandlerListener : IExceptionHandlerListener
    {
        public void ExceptionLogged()
        {
            var ex = HttpContext.Current.Server.GetLastError();
            if (ex != null)
                Global.LogException(ex);
        }
    }
}