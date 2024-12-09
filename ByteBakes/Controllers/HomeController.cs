using ByteBakes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ByteBakes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Cheesecake()
        {
            var toppingsModel = new MyToppingsModel();
          
            return View(toppingsModel);
        }

        [HttpPost]
        public IActionResult CheesecakeUpdateCalories(MyToppingsModel toppingsModel)
        {
            int calories = 410;
            if (toppingsModel.IsFreshBerries) calories += 30;
            if (toppingsModel.IsWhippedCream) calories += 110;
            if (toppingsModel.IsSprinkles) calories += 200;
            if (toppingsModel.IsChocolateDrizzle) calories += 120;
            if (toppingsModel.IsCaramelSauce) calories += 150;

            // Set the updated calories value in the model
            toppingsModel.CaloriesValue = calories;

            // Return the updated calories value as JSON for AJAX
            return Json(toppingsModel.CaloriesValue);
        }

        public IActionResult Cakes()
        {
            return View();
        }

        public IActionResult WhyByteBakes()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Subscribe()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
