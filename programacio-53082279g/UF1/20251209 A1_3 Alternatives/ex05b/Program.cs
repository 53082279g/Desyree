namespace ex05b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parell i positiu
            i/o divisible entre 7
            i MAI 42*/

            int numero;
            bool parell, divisible7;

            Console.WriteLine("Escriu un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            parell = numero % 2 == 0;
            divisible7 = numero % 7 == 0;

            if (parell)
            {
                Console.WriteLine($"El número {numero} és parell.");
            }
            else
            {
                Console.WriteLine($"El número {numero} és senar.");
            }
            if (divisible7)
            {
                Console.WriteLine($"El número {numero} és divisible entre 7.");
            }
            else
            {
                Console.WriteLine($"El número {numero} és indivisible entre 7.");
            }
                if (numero == 42)
            {
                Console.WriteLine("Número prohibido.");
            }
            else
            {
                if (numero == 00 && numero % 2 == 0)
                {
                    Console.WriteLine("Número numeret");
                }
                else if (numero % 7 == 0)
                {
                    Console.WriteLine("Número correcte");
                }
                else
                {
                    Console.WriteLine("El número no és correcte");
                }
            }

        }
    }
}