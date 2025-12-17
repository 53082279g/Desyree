namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segons = 4000;
            int hores,segons_sobrants, minuts;

            hores = segons / 3600;
            segons_sobrants = segons % 3600;

            minuts = segons_sobrants / 60;
            segons_sobrants = segons_sobrants % 60;

            segons = segons_sobrants;

            Console.WriteLine($"{hores:00}:{minuts:00}:{segons:00}");

        }
    }
}
