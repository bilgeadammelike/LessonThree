using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonThree.Controllers
{
    public class CustomerController : ApiController
    {
        //api/root/{id} 
        public IHttpActionResult Get(int id)
        {
            return Json("OK");
        }
    }
}
