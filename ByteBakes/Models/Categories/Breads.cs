// Concrete Products for Breads using the Abstract Factory Design Pattern


namespace ByteBakes.Models.Categories
{
    public class Sourdough : IBread
    {
        public string Name => "Sourdough";

        string IBread.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class SweetBread : IBread
    {

        public string Name => "SweetBread";


        string IBread.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }

    public class Brioche : IBread
    {

        public string Name => "Brioche";


        string IBread.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }


    public class Bagel : IBread
    {

        public string Name => "Bagel";


        string IBread.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }




}
