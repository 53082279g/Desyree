using System.Diagnostics.CodeAnalysis;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i = 0, suma = 0;
            Console.WriteLine("Escriu números fins acabar en -1.");
            numero = Convert.ToInt32(Console.ReadLine());

            while(numero != -1)
            {
                suma += numero;
                i++;
                numero = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine($"Has fet {i} intents previs.");

        }
    }
}