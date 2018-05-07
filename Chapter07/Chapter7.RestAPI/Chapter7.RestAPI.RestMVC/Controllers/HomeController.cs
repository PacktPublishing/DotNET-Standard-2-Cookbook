using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Chapter7.RestAPI.RestLib;


namespace Chapter7.RestAPI.RestMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var service = "https://jsonplaceholder.typicode.com";

            var restClient = new PostsReader(service);

            var result = await restClient.GetPostById(1);

            ViewBag.Post = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(result);


            return View();
        }
    }
}