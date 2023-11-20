using ClassLibrary;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string to add curreny:");

            string withoutCurrency = Console.ReadLine();
            Console.WriteLine(withoutCurrency.ToCurrency());
        }
    }
}