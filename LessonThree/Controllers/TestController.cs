using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonThree.Controllers
{
    [RoutePrefix("api/tst")]
    public class TestController : ApiController
    {

        [Route("get-json")]
        public IHttpActionResult Get()
        {
            return Json("OK");
        }
    }
}
