using System.Diagnostics.Metrics;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*9.- Escriu un programa per convertir una quantitat de polzades a metres.
             * Cal tenir en compte que una polzada són 2,54 cm.*/

            //Declario de variables
            double metres;
            double polzades;

            //Entrada
            Console.WriteLine("Entra les polzades:");
            polzades = Convert.ToDouble(Console.ReadLine());
                               
            metres = polzades * 0.0254; // 2.54cm;

            //Sortida
            Console.WriteLine("El metres son " + metres);
        }
    }
}
