using System.Linq;
using System.Net;
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
			var content = falcon.GetContent(channels.Items.First().Id, limit: 10, offset: 100);

			return View();
		}
	}
}