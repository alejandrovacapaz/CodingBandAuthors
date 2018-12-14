using AuthorsService.Service;
using System.Web.Mvc;

namespace Authors.Controllers
{
    public class HomeController : Controller
    {
        private CommonService _commonService; 
        public HomeController(CommonService commonService)
        {
            _commonService = commonService;
        }
        public ActionResult Index()
        {
            var books = _commonService.GetAllBooks();
            return View(books);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var book = _commonService.GetBook(id);
            return View(book);
        }      
    }
}