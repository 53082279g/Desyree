namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*L'altitud dels avions es mesura en peus. 1 metre són 39,27 polzades i 1 peu són 12
            polzades. 1 polzada són 2,54 cm. Escriu un programa que ens demani una quantitat de
            peus i ens informi del seu equivalent en metres.
            .*/

            //Declario de variables
            double metres;
            double polzades;
            double peus;

            //Entrada        
            Console.WriteLine("Entra els peus:");
            peus = Convert.ToDouble(Console.ReadLine());

            //Calculs
            polzades = peus * 12;
            metres = polzades * 0.0254; // 2.54cm;

            //Sortida
            Console.WriteLine("El metres son " + metres);
        }
    }
}
