namespace new_brench1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello this is my one homework!");

            Console.Write(" please namber type : ");
            int namber = Console.Read();
            int n1000 = namber / 1000;
            int n100 = namber / 100;
            int n10 = namber / 10;
            int n1 = namber / 10%10;
           int mac=   Math.Max(Math.Max(n1000, n100), Math.Max(n10, n1));
            Console.WriteLine($" nambers maxsimal = {mac}");

        }
    }
}