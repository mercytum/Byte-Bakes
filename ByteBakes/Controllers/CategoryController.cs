// Controller for Category Operations
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ByteBakes.Data;
using ByteBakes.Models.Categories;

namespace ByteBakes.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context) { _context = context; }


        // This would be implemented if I could get it to work as a dropdown menu but could not
        // Created it as a page linked to the categories. Would be created upon page selection.
     //   public ActionResult SelectCategory()
      //  {
           // List<SelectListItem> items = new List<SelectListItem>();
           // items.Add(new SelectListItem { Text = "Bread", Value = "0" });
           // items.Add(new SelectListItem { Text = "Cake", Value = "1" });
           // items.Add(new SelectListItem { Text = "Pastry", Value = "2" });
          //  items.Add(new SelectListItem { Text = "Sweet", Value = "3" });

           // ViewBag.CategoryType = items;
           // return View();

       // }




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
