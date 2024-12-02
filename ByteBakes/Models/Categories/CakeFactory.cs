// Cakes Concrete Factory for Abstract Factory Pattern


namespace ByteBakes.Models.Categories
{
    public class CakeFactory : IByteBakesFactory
    {


        public IPastry CreatePastry => throw new NotImplementedException();
        public ISweet CreateSweet => throw new NotImplementedException();
        public IBread CreateBread => throw new NotImplementedException();

        ICake IByteBakesFactory.CreateCake => throw new NotImplementedException();

        public ICake CreateCake(){ return new CheeseCake();      } 

        public ICake CreateCake => new ChocolateCake(); 
        public ICake CreateCake => new CarrotCake();
        public ICake CreateCake() => new VelvetCake();



    }
}
