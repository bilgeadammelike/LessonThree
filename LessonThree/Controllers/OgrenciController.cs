using LessonThree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonThree.Controllers
{
    [RoutePrefix("api/ogrenci")]
    public class OgrenciController : ApiController
    {
        // GET /api/ogrenciler/1
        [Route("~/api/ogrenciler/{ogrenciId:int}")]
        public IEnumerable<Ogrenci> GetByOgrenci(int ogrenciId)
        {
            return null;
        }
    }
}
