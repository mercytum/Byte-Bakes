// Pastry Concrete Factory for Abstract Factory Pattern


using System.Security.Claims;

namespace ByteBakes.Models.Categories
{
    public class PastryFactory : IByteBakesFactory
    {

        public ICake CreateCake => throw new NotImplementedException();
        public ISweet CreateSweet => throw new NotImplementedException();
        public IBread CreateBread => throw new NotImplementedException();

        IPastry IByteBakesFactory.CreatePastry => throw new NotImplementedException();

        public IPastry CreatePastry() => new Croissant();
        public IPastry CreatePastry() => new Eclair();
        public IPastry CreatePastry() => new PuffPastry();
        public IPastry CreatePastry() => new Macaron();

    }
}
