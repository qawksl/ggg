namespace ggg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // О(N)
            long fact = 1;
            int h1 = Convert.ToInt32(Console.ReadLine()); // Факториал какого числа.
            if (fact == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i <= h1; i++)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
