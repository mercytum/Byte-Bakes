// Sweet Concrete Factory for Abstract Factory Pattern

namespace ByteBakes.Models.Categories
{
    public class SweetFactory : IByteBakesFactory
    {

        public Category CreateProduct(string name)
        {
            string type = name switch
            {
                "Pie" => "Pie",
                "Cookies" => "Cookies",
                "CinnamonRolls" => "Cinnamon Rolls",
                "Cupcake" => "Cupcake",
                _ => "Generic Sweet"
            };
            return new Category { Name = type, CategoryName = "Sweets", Type = type };
        }
    }
}
