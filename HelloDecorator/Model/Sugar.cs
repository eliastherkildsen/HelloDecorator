namespace HelloDecorator;

public class Sugar : BeverageDecorator
{

    public Sugar(Beverage beverage) : base(beverage)
    {
    }


    public override double Cost()
    {
        return beverage.Cost() + 0.1;
    }

    public override string Description()
    {
        return "Sugar";
    }
}