namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Subtract(2, 8)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        { 
            return (a * b);
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }