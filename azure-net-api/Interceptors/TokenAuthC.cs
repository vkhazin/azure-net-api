using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace azure_net_api.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class TokenAuthC: AuthorizationFilterAttribute
    {
        //TODO: Move headerKey to config
        private const string headerKey = "x-app-key";
        //TODO: Move registered keys to config or to external db
        private const string appKey = "377dab30-da05-491b-9cee-e95ec6ec7cc1";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var header = actionContext.Request.Headers.FirstOrDefault(
                h => string.Equals(h.Key, headerKey, StringComparison.InvariantCultureIgnoreCase)
            );

            if (header.Value == null || header.Value.First() != appKey)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.Unauthorized) {
                    ReasonPhrase = "Invalid or missing x-app-key"
                };
                throw new HttpResponseException(msg);
            }
        }
    }
}
