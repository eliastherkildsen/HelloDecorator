namespace HelloDecorator;

public class Wip : BeverageDecorator
{
    public Wip(Beverage beverage) : base(beverage)
    {
    }


    public override double Cost()
    {
        return beverage.Cost() + 0.2;
    }

    public override string Description()
    {
        return "Wip"; 
    }
}