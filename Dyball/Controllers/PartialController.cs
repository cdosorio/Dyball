using Microsoft.AspNetCore.Mvc;

namespace Dyball.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult AboutComponent() => PartialView();

        public IActionResult AppComponent() => PartialView();

        public IActionResult ContactComponent() => PartialView();

        public IActionResult IndexComponent() => PartialView();

        public IActionResult LoginComponent() => PartialView();

        public IActionResult RegisterComponent() => PartialView();
    }
}