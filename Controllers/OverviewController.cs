using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class OverviewController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}