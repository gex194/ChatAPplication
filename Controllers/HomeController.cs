using System.Web;
using System.Web.Mvc;

namespace ChatApplication.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index ()
        {
            return View();
        }
    }
}