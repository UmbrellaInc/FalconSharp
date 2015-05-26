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

            //var falcon = new FalconClient("NLcbUTN3IAsKH2X89Dh5NCU2XZX_SXou_7gy3t8uJONHbI3bSyqG1hwusZwwTOo3C8D4f4N6MCB9e5UH2yWW_8y4S-86SKRmtLkLR_xWCzmRZymBVnoGPDVSUThywK9cc9xMfWEN_M-fXpCCuviU5CLP4A7HdgL9OyxbzF2AmAo");
            var falcon = new FalconClient("NLcbUTN3IAsKH2X89Dh5NCU2XZX_SXou_7gy3t8uJONHbI3bSyqG1hwusZwwTOo3C8D4f4N6MCB9e5UH2yWW_8y4S-86SKRmtLkLR_xWCzmRZymBVnoGPDVSUThywK9cc9xMfWEN_M-fXpCCuviU5CLP4A7HdgL9OyxbzF2AmAo", fiddlerProxy);
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