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

            //var falcon = new FalconClient("api_key");
            var falcon = new FalconClient("api_key", fiddlerProxy);
            var channels = falcon.GetChannels();
		    var uniqueNetworks = channels.Items.Select(x => x.Network).Distinct().ToArray();

		    foreach (var uniqueNetwork in uniqueNetworks)
		    {
		        var chan = channels.Items.First(x => x.Network == uniqueNetwork);
                var content = falcon.GetChannelContent(chan.Id, limit: 10, offset: 100);
		        var t = 1;
		    }

			return View();
		}
	}
}
