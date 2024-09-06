namespace HelloDecorator;

public class Whip : BeverageDecorator
{
    
    public Whip(Beverage beverage) : base(beverage){}


    public override double Cost()
    {
        return beverage.Cost() + 0.1; 
    }

    public override string Description()
    {
        return beverage.Description() + ", Whip"; 
    }
}