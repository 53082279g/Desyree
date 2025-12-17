namespace Exercici_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double notaMitjana;

            Console.Write("Escriu la nota1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriu la nota2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriu la nota3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            notaMitjana = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("La nota mitjana es la seguent: " + Math.Round(notaMitjana,2));
        }
    }
}