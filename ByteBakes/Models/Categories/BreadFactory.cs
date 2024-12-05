// Bread Concrete Factory for Abstract Factory Pattern

namespace ByteBakes.Models.Categories
{
    public class BreadFactory : IByteBakesFactory
    {
        public ICake CreateCake => throw new NotImplementedException();
        public ISweet CreateSweet => throw new NotImplementedException();
        public IPastry CreatePastry => throw new NotImplementedException();

        IBread IByteBakesFactory.CreateBread => throw new NotImplementedException();

        public IBread CreateBread() => new Sourdough();

        // Fix here. Might have to make it implement 1 of each like Hw 3, and re-name the factories
        //public IBread CreateBread() => new SweetBread();
        //public IBread CreateBread() => new Brioche();
        //public IBread CreateBread() => new Bagel();
    }
}
