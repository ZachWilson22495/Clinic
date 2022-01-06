using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}