namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSmall = 25;
            double priceLarg = 35;
            double taxRate = 6.6;
            Console.WriteLine("What Number of Small Carpets :");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Number of Larg Carpets :");
            int largCarpets = Convert.ToInt32(Console.ReadLine());
            double cost = (smallCarpets * priceSmall) + (largCarpets * priceLarg);
            Console.WriteLine($"Number Of Small Carpets is :{smallCarpets}");
            Console.WriteLine($"Number Of Larg  Carpets is :{largCarpets}");
            Console.WriteLine("Price Per Small Carpets = 25$");
            Console.WriteLine("Price Per Larg Carpets = 35$");
            Console.WriteLine($"Cost {(smallCarpets * priceSmall) + (largCarpets * priceLarg)}");
            Console.WriteLine($"TaxRate = {taxRate} ");
            Console.WriteLine($"Total Estimate = {taxRate + cost}");
        }
    }
}
