using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter5.XmlDoc.XmlLib;

namespace Chapter5.XmlDoc.XmlMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var xmlFile = $"{Server.MapPath("~")}/testlog.xml";

            var xmlLog = new XMLLog(xmlFile);
            xmlLog.WriteToLog("Start at the Index() method");
            xmlLog.WriteToLog("Another log entry here");
            xmlLog.WriteToLog("Before the return statement");


            return View();
        }

        public ActionResult Display()
        {
            var xmlFile = $"{Server.MapPath("~")}/testlog.xml";

            var xmlLog = new XMLLog(xmlFile);

            ViewBag.LogDetails = xmlLog.ReadLog();

            return View();
        }
    }
}