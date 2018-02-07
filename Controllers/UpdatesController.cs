using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class UpdatesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}