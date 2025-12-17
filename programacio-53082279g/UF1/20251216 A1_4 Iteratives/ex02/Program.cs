namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2-Programa que validi una nota (0..10) amb dowhile*/

            int nota;

            do
            {
                Console.Write("Escriu una nota: ");
                nota = Convert.ToInt32(Console.ReadLine());
            } while (nota < 0 || nota > 10);
        }
    }
{