using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonThree.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        public int? CategoryID { get; set; }
        public int ProductID { get; set; }



    }
}