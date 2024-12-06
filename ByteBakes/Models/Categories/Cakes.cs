// Concrete Products for Cakes using the Abstract Factory Design Pattern

namespace ByteBakes.Models.Categories
{
    public class CheeseCake : ICake
    {
        public string Name => "Cheese Cake";

        string ICake.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class ChocolateCake : ICake
    {
        public string Name => "Chocolate Cake";

        string ICake.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class CarrotCake : ICake
    {
        public string Name => "Carrot Cake";

        string ICake.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class VelvetCake : ICake
    {
        public string Name => "Velvet Cake";

        string ICake.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
