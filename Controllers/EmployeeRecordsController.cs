using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class EmployeeRecordsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}