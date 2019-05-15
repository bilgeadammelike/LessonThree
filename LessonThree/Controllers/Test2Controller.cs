using LessonThree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LessonThree.Controllers
{
    public class Test2Controller : ApiController
    {
        //http://localhost:15701/api/GetEmployeeByID/1/hede
        //http://localhost:15701/api/employees/1/hede

        [HttpGet]
        //yazdığınız isimlendirme sırasında querystringten alır ona göre matching işlemini yapar.
        [Route("api/{employees}/{id}/{userName}")]
        [ActionName("GetEmployeeByID")]
        public Product Get(string userName, int id)
        {
            return new Product { ProductName = "productName" };
        }


        //http://localhost:15701/api/products/1/orders/56
        //api keywordünü kullanırsak.

        // //http://localhost:15701/products/1/orders/56
        [Route("products/{customerId}/orders/{orderId}")]
        [HttpGet]
        public IEnumerable<Product> FindOrdersByProducts(int customerId, int orderId)
        {
            return null;
        }


        //Soru
        #region MyRegion
        [Route("view/keyword/{keyword}/country/{country}/state/{state}/city/{city}/page/{page}")]
        [HttpGet]
        public Product Index(int? page, string keyword = "", string city = "", string state = "", string country = "")
        {
            return new Product { ProductName = "karışık Product" };
        }
        #endregion


        [Route("~/test2/{name:maxlength(5)?}")]
        public string GetHede(string name)
        {
            return "hello";
        }

        #region AcceptVerbs
        //http://localhost:15701/api/kolleksiyon params alanında değer paramı gönderilirse  put ve posta izin verecektir
        [Route("api/kolleksiyon")]
        [AcceptVerbs("POST", "PUT")]
        public string KolleksiyonHazirla(int kolleksiyonId)
        {
            return "put ve post çalıştı.";
        }
        #endregion
    }


 
}
