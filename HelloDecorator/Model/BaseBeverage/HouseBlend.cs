namespace HelloDecorator;

public class HouseBlend : Beverage
{
    public override double Cost()
    {
        return 0.5;
    }

    public override string Description()
    {
        return "House Blend";
    }
}