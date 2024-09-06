namespace HelloDecorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating HouseBlend beverage!");
            Beverage beverage = new HouseBlend(); // Choosing the base to decorate. 
            Console.WriteLine($"The price is {beverage.Cost()}");
            Console.WriteLine($"The description is {beverage.Description()}");
            
            Console.WriteLine("Adding sugar!");
            beverage = new Sugar(beverage); // Decorating
            Console.WriteLine($"The price is {beverage.Cost()}");
            Console.WriteLine($"The description is {beverage.Description()}");
            
            Console.WriteLine("Adding milk!");
            beverage = new Milk(beverage); // Decorating
            Console.WriteLine($"The price is {beverage.Cost()}");
            Console.WriteLine($"The description is {beverage.Description()}");

            


        }
    }
}