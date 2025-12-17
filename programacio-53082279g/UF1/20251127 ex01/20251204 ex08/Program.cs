namespace _20251204_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8-Escriu un programa per convertir "Dolars" a "Euros".
            El programa ens ha de demanar quants Euros són un dólar,
            i la quantitat de dolars que volem convertir.
            Feu que es mostri el símbol $ i el símbol € correctament.*/

            //Variables
            double dolar, euro, totalDolars, totalEuros;
            dolar = 0.86;
            euro = 1.17;

            //Entrada
            Console.WriteLine($"Escriu la quantitat de dólars a convertir en euros: ");
            Convert.ToDouble(Console.ReadLine());
            totalDolars = Console.WriteLine($"El total de dólars són: {dolar * euro}");
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Escriu la quantitat d'euros a convertir en dólars: ");
            Console.WriteLine($"Un euro és: totalDolars % dolars");
            totalDolars = Convert.ToDouble(Console.ReadLine());

            //Calculs
            totalDolars = euro % dolar;
            totalEuros = dolar % euro;

            //Sortida
            Console.WriteLine($"Un dólar és: {euro} + €");
            Console.WriteLine($"Un euro és: {dolar} + $");

        }
    }
}