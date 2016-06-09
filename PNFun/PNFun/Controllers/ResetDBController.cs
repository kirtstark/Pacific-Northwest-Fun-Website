using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PNFun.Models;
using PNFun.DAL;

namespace PNFun.Controllers
{
    public class ResetDBController : Controller
    {
        //
        // GET: /ResetDB/
        public ActionResult Index()
        {
            ResetDB.clearDB();
            ResetDB.PopulateDB();

            return View();
        }
    }
}
