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
            IPastryCalories calories = new pastryCalories(410);

            if (toppingsModel.IsFreshBerries) 
                calories = new freshBerriesDecorator(calories);
            if (toppingsModel.IsWhippedCream) 
                calories = new whippedCreamDecorator(calories);
            if (toppingsModel.IsSprinkles) 
                calories = new sprinklesDecorator(calories);
            if (toppingsModel.IsChocolateDrizzle) 
                calories = new chocolateDrizzleDecorator(calories);
            if (toppingsModel.IsCaramelSauce) 
                calories = new caramelSauceDecorator(calories);

            int pastryCheckedCalories = calories.calories();
            toppingsModel.CaloriesValue = pastryCheckedCalories;

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
