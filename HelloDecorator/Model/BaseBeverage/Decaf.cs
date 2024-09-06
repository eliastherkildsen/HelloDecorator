namespace HelloDecorator;

public class Decaf : Beverage
{
    public override double Cost()
    {
        return 1.5; 
    }

    public override string Description()
    {
        return "Decaf";
    }
}