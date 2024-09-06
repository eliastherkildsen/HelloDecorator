namespace HelloDecorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating HouseBlend beverage!");
            Beverage beverage = new HouseBlend();
            Console.WriteLine($"The price is {beverage.Cost()}");
            
            Console.WriteLine("Adding sugar!");
            beverage = new Sugar(beverage);
            Console.WriteLine($"The price is {beverage.Cost()}");
            
            // this will overide! - and thereforthe beverage is a new coffee 
            Console.WriteLine("Adding decaf");
            beverage = new Decaf(); 
            Console.WriteLine($"The price is {beverage.Cost()}");
            


        }
    }
}