namespace HelloDecorator;

public class DarkRoast : Beverage
{
    public override double Cost()
    {
        return 2.0; 
    }

    public override string Description()
    {
        return "Dark Roast";
    }
}