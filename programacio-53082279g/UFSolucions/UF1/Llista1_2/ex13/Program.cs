using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any, restant;

            // OPCIÓ 1
            // 1. Demanar a l'usuari que introdueixi l'any
            Console.WriteLine("Introdueix un any de 4 dígits (p. ex., 2024):");
            any = Convert.ToInt32(Console.ReadLine());

            // --- Càlcul del Primer Dígit (Milers) ---
            // El dígit de les unitats de miler s'obté per divisió entera.
            int digit1 = any / 1000;
            Console.WriteLine("Dígit de les unitats de miler: " + digit1);

            // Restar el valor del primer dígit al total (Eliminem els milers)
            // Exemple: 2024 - (2 * 1000) = 24
            restant = any - (digit1 * 1000);

            // --- Càlcul del Segon Dígit (Centenes) ---
            // El dígit de les centenes s'obté per divisió entera del que resta.
            int digit2 = restant / 100;
            Console.WriteLine("Dígit de les centenes: " + digit2);

            // Restar el valor del segon dígit al que queda (Eliminem les centenes)
            // Exemple: 24 - (0 * 100) = 24
            restant = restant - (digit2 * 100);

            // --- Càlcul del Tercer Dígit (Desenes) ---
            // El dígit de les desenes s'obté per divisió entera del que resta.
            int digit3 = restant / 10;
            Console.WriteLine("Dígit de les desenes: " + digit3);

            // Restar el valor del tercer dígit al que queda (Eliminem les desenes)
            // Exemple: 24 - (2 * 10) = 4
            restant = restant - (digit3 * 10);

            // --- Càlcul del Quart Dígit (Unitats) ---
            // El que resta és el dígit de les unitats.
            int digit4 = restant;
            Console.WriteLine("Dígit de les unitats: " + digit4);


            //OPCIÓ 2
            // 1. Demanar a l'usuari que introdueixi l'any
            Console.WriteLine("Introdueix un any de 4 dígits (p. ex., 2024):");
            any = Convert.ToInt32(Console.ReadLine());

            // Primer Dígit (Milers - A): Divisió entera per 1000
            int digit1 = any / 1000;
            Console.WriteLine("Dígit de les unitats de miler: " + digit1);

            // Segon Dígit (Centenes - B): 
            // 1. Restem els milers i dividim per 100, O
            // 2. Mòdul per 1000 per eliminar els milers (BCD), i després dividim per 100 (B)
            int digit2 = (any % 1000) / 100;
            Console.WriteLine("Dígit de les centenes: " + digit2);

            // Tercer Dígit (Desenes - C):
            // Mòdul per 100 per eliminar milers i centenes (CD), i després dividim per 10 (C)
            int digit3 = (any % 100) / 10;
            Console.WriteLine("Dígit de les desenes: " + digit3);

            // Quart Dígit (Unitats - D): Mòdul per 10
            int digit4 = any % 10;
            Console.WriteLine("Dígit de les unitats: " + digit4);

        }
    }
}
