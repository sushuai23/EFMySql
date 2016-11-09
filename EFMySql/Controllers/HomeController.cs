using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Dao;
using Application.Entity;

namespace EFMySql.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

        public void Test()
        {
            MysqlContext context=new MysqlContext();
            var list = context.Users.ToList();
            var one = context.Users.FirstOrDefault(p => p.Id == 2);
            context.Users.Add(new UserEntity()
            {
                UserName = "Admin"
            });
            context.SaveChanges();
        }
    }
}