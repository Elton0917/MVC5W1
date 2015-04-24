using MVC5W1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5W1.Controllers
{
    public class EasyReportController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: EasyReport
        public ActionResult Index()
        {
            return View(db.View_1);
        }

        // GET: EasyReport
        public ActionResult self_report()
        {
            return View(db.自訂檢視表);
        }
    }
}