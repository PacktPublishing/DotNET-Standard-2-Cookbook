using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chapter3.LogFile.LogAppMvc.Models;
using Chapter3.LogFile.LogLib;

namespace Chapter3.LogFile.LogAppMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TextLog logFile = new TextLog();
            logFile.WriteLog("You are in the Index action.");
            logFile.CloseLog();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            TextLog logFile = new TextLog();
            logFile.WriteLog("You are in the About action.");
            logFile.CloseLog();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            TextLog logFile = new TextLog();
            logFile.WriteLog("You are in the Contact action.");
            logFile.CloseLog();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
