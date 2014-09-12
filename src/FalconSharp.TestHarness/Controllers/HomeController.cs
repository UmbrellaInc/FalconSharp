using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FalconSharp.TestHarness.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var fiddlerProxy = new WebProxy("127.0.0.1", 8888);

			var falcon = new FalconClient("api_key");
			var channels = falcon.GetChannels();
			var content = falcon.GetContent(channels.Items.First().Id, limit: 10, offset:100);

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}