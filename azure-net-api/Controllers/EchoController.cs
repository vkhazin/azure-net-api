using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace azure_net_api.Controllers
{
    [Interceptors.TokenAuthC]
    public class EchoController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new {
                machineName = System.Environment.MachineName
            });
        }
    }
}
