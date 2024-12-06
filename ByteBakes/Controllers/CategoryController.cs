// Controller for Category Operations
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ByteBakes.Data;
using ByteBakes.Models.Categories;


namespace ByteBakes.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ShopContext _context;

        public CategoryController(ShopContext context) { _context = context; }


        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpPost]
        public IActionResult Create(string category, string type)
        {
            IByteBakesFactory factory;
            // Select factory based on input
            if (category == "Cake") { factory = new CakeFactory(); }
            else if (category == "Bread") { factory = new BreadFactory(); }
            else if (category == "Pastry") { factory = new PastryFactory(); }
            else if (category == "Sweet") { factory = new SweetFactory(); }
            else { return BadRequest("Invalid category type."); }

            var product = factory.CreateProduct(type);

            _context.Categories.Add(product);


            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
