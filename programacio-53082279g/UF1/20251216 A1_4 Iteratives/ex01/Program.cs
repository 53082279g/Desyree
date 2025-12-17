namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1-Programa que validi una nota (0..10) amb while.
            Que demani una nota, i si no està entre 0 i 10 que la torni a demanar,
            i si no està ...*/

            int nota;

            Console.WriteLine("Introdueix una nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            //while(nota <0 || nota>10 )
            while(!(nota >= 0 &&nota <=10))
            {
                Console.WriteLine("Lo nota entrada no és correcta.");
                Console.Write("Escriu una nova nota: ");
                nota= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Molt bé, la nota {nota} és correcta");
        }
    }
}