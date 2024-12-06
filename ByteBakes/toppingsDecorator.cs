namespace ByteBakes
{
    public class toppingsDecorator
    {
    }

    //base interface
    interface IPastry
    {
        string GetPastryType();
    }
    
    //concrete implementation
    class Pastry: IPastry
    {
        public string GetPastryType()
        {
            return "This is a pastry type";
        }
    }

    //base decorator
    class PastryDecorator : IPastry
    {
        private IPastry _pastry;

        public PastryDecorator(IPastry pastry)
        {
            _pastry = pastry;
        }

        public virtual string GetPastryType()
        {
            return _pastry.GetPastryType();
        }
    }

    //concrete decorators
    class FreshBerriesDecorator: PastryDecorator
    {
        public FreshBerriesDecorator(IPastry pastry) : base(pastry) { }

        public override string GetPastryType()
        {
            string type = base.GetPastryType();
            type += "\r\n with fresh berries";
            return type;
        }
    }

    class WhippedCreamDecorator : PastryDecorator
    {
        public WhippedCreamDecorator(IPastry pastry) : base(pastry) { }

        public override string GetPastryType()
        {
            string type = base.GetPastryType();
            type += "\r\n with whipped cream";
            return type;
        }
    }

    class SprinklesDecorator : PastryDecorator
    {
        public SprinklesDecorator(IPastry pastry) : base(pastry) { }

        public override string GetPastryType()
        {
            string type = base.GetPastryType();
            type += "\r\n with sprinkles";
            return type;
        }
    }

    class ChocolateDrizzleDecorator : PastryDecorator
    {
        public ChocolateDrizzleDecorator(IPastry pastry) : base(pastry) { }

        public override string GetPastryType()
        {
            string type = base.GetPastryType();
            type += "\r\n with chocolate drizzle";
            return type;
        }
    }

    class CaramelSauceDecorator : PastryDecorator
    {
        public CaramelSauceDecorator(IPastry pastry) : base(pastry) { }

        public override string GetPastryType()
        {
            string type = base.GetPastryType();
            type += "\r\n with carmel sauce";
            return type;
        }
    }
}
