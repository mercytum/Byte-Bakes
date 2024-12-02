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
            var catorgies = _context.Categories.ToList();
            return View(catorgies);
        }

        public IActionResult Create(string factoryType)
        {
            IByteBakesFactory factory;
            // Select factory based on input
            if (factoryType == "Cake") { factory = new CakeFactory(); }
            else if (factoryType == "Bread") { factory = new BreadFactory(); }
            else if (factoryType == "Pastry") { factory = new PastryFactory(); }
            else if (factoryType == "Sweet") { factory = new SweetFactory(); }
            else { return BadRequest("Invalid factory type."); }

            // Create products
            var cake = factory.CreateCake();
            var bread = factory.CreateBread();
            var pastry = factory.CreatePastry();
            var sweet = factory.CreateSweet();

            // Add to database
            _context.Categories.Add(new Category { Name = cake.Name, Type = "Cake" });
            _context.Categories.Add(new Category { Name = bread.Name, Type = "Bread" });
            _context.Categories.Add(new Category { Name = pastry.Name, Type = "Pastry" });
            _context.Categories.Add(new Category { Name = sweet.Name, Type = "Sweet" });

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
