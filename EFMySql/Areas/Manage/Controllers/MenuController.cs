using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Dao;
using Newtonsoft.Json;

namespace EFMySql.Areas.Manage.Controllers
{
    public class MenuController : Controller
    {
        // GET: Manage/Menu
        public ActionResult Index()
        {
            MysqlContext context = new MysqlContext();
            var menuList = context.Menus.ToList();
            ViewBag.MenuList= JsonConvert.SerializeObject(menuList);
            return View();
        }

        public JsonResult GetMenuList()
        {
            MysqlContext context = new MysqlContext();
            var menuList = context.Menus.ToList();
            //var newmenu= JsonConvert.SerializeObject(menuList);
            return Json(menuList, JsonRequestBehavior.AllowGet);
        }

    }
}