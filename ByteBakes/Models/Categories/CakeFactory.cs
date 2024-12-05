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

        // Fix here. Might have to make it implement 1 of each like Hw 3, and re-name the factories
        //public ICake CreateCake => new ChocolateCake(); 
        //public ICake CreateCake => new CarrotCake();
        //public ICake CreateCake() => new VelvetCake();



    }
}
