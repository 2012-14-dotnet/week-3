using Microsoft.AspNetCore.Mvc;

namespace PizzaWorld.DemoMVC.Controllers
{
  //HTTP Verbs / Methods

  // CRUD = POST, GET, UPDATE, DELETE
  //http://localhost:5000/home
  [Route("[controller]")] // route parser
  public class HomeController : Controller
  {
    [HttpGet]
    public ViewResult Banana()
    {
      return View();
    }

    public ViewResult Index()
    {
      return View();
    }
  }
}