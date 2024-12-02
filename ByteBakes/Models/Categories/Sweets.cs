// Concrete Products for Sweets using the Abstract Factory Design Pattern


namespace ByteBakes.Models.Categories
{
    public class Pie : ISweet
    {
        public string Name => "Pie";

        string ISweet.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Cupcake : ISweet
    {
        public string Name => "Cupcake";

        string ISweet.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }



    public class Cookies : ISweet
    {
        public string Name => "Cookies";

        string ISweet.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    public class CinnamonRolls : ISweet
    {
        public string Name => "Cinnamon Rolls";

        string ISweet.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }



}
