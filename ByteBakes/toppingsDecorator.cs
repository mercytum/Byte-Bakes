namespace ByteBakes
{
    public class toppingsDecorator
    {
    }

    //base interface
    public interface IPastryCalories
    {
        public int calories();
    }
    
    //concrete implementation
    public class pastryCalories: IPastryCalories
    {
        public int myCalories {  get; set; }
        public pastryCalories(int pastryCalories)
        {
            myCalories = pastryCalories;
        }
        public int calories()
        {
            return myCalories;
        }
    }

    //concrete decorators
    class freshBerriesDecorator: IPastryCalories
    {
        private readonly IPastryCalories pastryCalories;

        public freshBerriesDecorator(IPastryCalories calories)
        {
            pastryCalories = calories;
        }

        public int calories()
        {
            return pastryCalories.calories() + 30;
        }
    }

    class whippedCreamDecorator : IPastryCalories
    {
        private readonly IPastryCalories pastryCalories;

        public whippedCreamDecorator(IPastryCalories calories)
        {
            pastryCalories = calories;
        }

        public int calories()
        {
            return pastryCalories.calories() + 110;
        }
    }

    class sprinklesDecorator : IPastryCalories
    {
        private readonly IPastryCalories pastryCalories;

        public sprinklesDecorator(IPastryCalories calories)
        {
            pastryCalories = calories;
        }

        public int calories()
        {
            return pastryCalories.calories() + 200;
        }
    }

    class chocolateDrizzleDecorator : IPastryCalories
    {
        private readonly IPastryCalories pastryCalories;

        public chocolateDrizzleDecorator(IPastryCalories calories)
        {
            pastryCalories = calories;
        }

        public int calories()
        {
            return pastryCalories.calories() + 120;
        }
    }

    class caramelSauceDecorator : IPastryCalories
    {
        private readonly IPastryCalories pastryCalories;

        public caramelSauceDecorator(IPastryCalories calories)
        {
            pastryCalories = calories;
        }

        public int calories()
        {
            return pastryCalories.calories() + 150;
        }
    }
}
