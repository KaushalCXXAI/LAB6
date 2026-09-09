using LAB6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB6.Controllers
{
    public class PRODUCTController : Controller
    {

        public ActionResult Index()
        {
            List<Productmodel> p = GetProduct();
            return View("product",p);
        }

        private List<Productmodel> GetProduct()
        {
            return new List<Productmodel>
            {
                new Productmodel { Id = 1, Name = "Laptop", Category = "Electronics", Price = 899.99m, Img = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8bGFwdG9wfGVufDB8fDB8fHww" },
                new Productmodel { Id = 2, Name = "Headphones", Category = "Electronics", Price = 49.99m, Img = "https://plus.unsplash.com/premium_photo-1679513691474-73102089c117?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MXx8aGVhZHBob25lc3xlbnwwfHwwfHx8MA%3D%3D" },
                new Productmodel { Id = 3, Name = "Running Shoes", Category = "Footwear", Price = 79.99m, Img = "https://images.unsplash.com/photo-1491553895911-0055eca6402d?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fHJ1bm5pbmclMjBzaG9lc3xlbnwwfHwwfHx8MA%3D%3D" }
            };
        }
    }
}