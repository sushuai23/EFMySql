using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Dao;

namespace WebUI.Areas.Manage.Controllers
{
    public class TestController : Controller
    {
        // GET: Manage/Test
        public ActionResult Index()
        {
            
            return View();
        }
    }
}