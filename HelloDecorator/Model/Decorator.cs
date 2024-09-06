namespace HelloDecorator;

public abstract class BeverageDecorator : Beverage
{
    protected Beverage beverage;
    
    protected BeverageDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
    
}