// Concrete Products for Pastries using the Abstract Factory Design Pattern


namespace ByteBakes.Models.Categories
{
    public class Croissant : IPastry
    {
        public string Name => "Croissant";

        string IPastry.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class Eclair : IPastry
    {
        public string Name => "Eclair";

        string IPastry.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    public class PuffPastry : IPastry
    {
        public string Name => "Puff Pastry";

        string IPastry.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    public class Macaron : IPastry
    {
        public string Name => "Macaron";

        string IPastry.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }





}
