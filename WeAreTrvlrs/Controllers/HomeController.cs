using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeAreTrvlrs.Contract.Repositories;
using WeAreTrvlrs.DAL.Data;
using WeAreTrvlrs.DAL.Repositories;
using WeAreTrvlrs.Model;

namespace WeAreTrvlrs.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<OnlineUsers> onlineUsers = new OnlineUsersRepository(new DataContext());
    
        // GET: Home
        public ActionResult Index()
        {
            DataContext dbContext = new DataContext();
            var table = (from a in dbContext.OnlineUsers
                         orderby a.status descending
                         select a
                         ).ToList();
            return View(table);
       
        }

        public PartialViewResult AllFriends()
        {


            DataContext dbContext = new DataContext();
            var table = (from a in dbContext.OnlineUsers
                         orderby a.status descending
                         select a
                         ).ToList();
            return PartialView(table);
        }

        public PartialViewResult SearchFriends(string toSearch)
        {


            DataContext dbContext = new DataContext();
            var table = (from a in dbContext.OnlineUsers
                         where a.Name.Contains(toSearch)
                         select a
                         ).ToList();
            return PartialView("_ChatBox",table);
        }
    }
}