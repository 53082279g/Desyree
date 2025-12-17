namespace Calcul_edat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entra la teva edat");
            double edat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La teva edat NO es: " + edat);
            Console.WriteLine("Entra l'any actual");


            double anyActual = Convert.ToDouble(Console.ReadLine());
            double anyNaixement = anyActual - edat;
            Console.WriteLine("NO vares nèixer el: " + anyNaixement);
        }
    }
}