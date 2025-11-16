using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Confirm()
        {
            return View();
        }
    }
}
