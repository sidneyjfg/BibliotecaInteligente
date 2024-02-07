using Microsoft.AspNetCore.Mvc;
using BibliotecaInteligente.Models;

namespace BibliotecaInteligente.Controllers
{
    public class accountController : Controller
    {
        [HttpGet];
        public IActionResult Login()
        {
            return View();

        }

        public ActionResult Verify  ()
        {
            return View;
        }
    }
}
