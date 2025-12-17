namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaració de variables
            int nota;
            double notaFinal;

            //Demanar valors entrada (inputs)
            Console.Write("Escriu una nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            //Calcula algoritme
            notaFinal = nota * 30.0 / 100;

            //Mostra valors
            Console.WriteLine("La nota és " + nota + ". La nota final és " + notaFinal + ".");
            Console.WriteLine("La nota és {0} i la nota final és {1}", nota, notaFinal);
            Console.WriteLine($"La nota és {nota} i la nota final és {notaFinal}");

        }
    }
}