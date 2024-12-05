﻿// Sweets Concrete Factory for Abstract Factory Pattern


using ByteBakes.Models.Categories;
using System.Net;

namespace ByteBakes.Models.Categories
{
    public class SweetFactory : IByteBakesFactory
    {
        public ICake CreateCake => throw new NotImplementedException();

        public IBread CreateBread => throw new NotImplementedException();

        public IPastry CreatePastry => throw new NotImplementedException();

        ISweet IByteBakesFactory.CreateSweet => throw new NotImplementedException();

        public ISweet CreateSweet() => new Pie();
        // Fix here. Might have to make it implement 1 of each like Hw 3, and re-name the factories
        // public ISweet CreateSweet() => new Cupcake();
        //public ISweet CreateSweet() => new Cookies();
        //public ISweet CreateSweet() => new CinnamonRolls();



    }
}
