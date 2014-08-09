using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShopStatistics.Controllers
{
    public class MyShopController : Controller
    {

        // GET: MyShop
        public ActionResult Home()
        {
            return View();
        }

        // GET: MyShop
        public ActionResult ShopStatsHome()
        {
            return View();
        }
    }
}