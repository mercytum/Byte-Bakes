// Pastry Concrete Factory for Abstract Factory Pattern

namespace ByteBakes.Models.Categories
{
    public class PastryFactory : IByteBakesFactory
    {

        public Category CreateProduct(string name)
        {
            string type = name switch
            {
                "Croissant" => "Croissant",
                "Eclair" => "Eclair",
                "Puff" => "Puff Pastry",
                "Macaron" => "Macaron",
                _ => "Generic Pastry"
            };
            return new Category { Name = type, CategoryName = "Pastry", Type = type };
        }
    }
}
