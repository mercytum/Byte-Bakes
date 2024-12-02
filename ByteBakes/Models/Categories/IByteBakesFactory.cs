// Abstract Factory Interface

namespace ByteBakes.Models.Categories
{
    public interface IByteBakesFactory
    {
        ICake CreateCake { get; }

        IBread CreateBread { get; }
        IPastry CreatePastry { get; }
        ISweet CreateSweet { get; }
    }
}
