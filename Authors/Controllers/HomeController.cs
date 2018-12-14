using System.Web.Mvc;

namespace Authors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }      
    }
}