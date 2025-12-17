using System.Runtime.ConstrainedExecution;

namespace Robot_cuina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Com et dius?: ");
            string nomUsuari = Console.ReadLine();

            Console.WriteLine("Benvingut/da, " + nomUsuari);
            Console.WriteLine("Sóc el teu robot personal");

            Console.WriteLine("Què vols cuinar avui?");
            String plat = Console.ReadLine();
            Console.WriteLine("Ohh! M'encanta el plat " + plat);

            Console.WriteLine("Per quantes persones?");
            double persones = Convert.ToDouble(Console.ReadLine());

            double gramsOus = 0.33;
            double gramsIogurtDeLlimona = 0.3;
            double culleradaOli = 0.25;
            double gramsFarina = 45;
            
            double totalGramsOus = gramsOus * persones;
            double totalIogurtDeLlimona = gramsIogurtDeLlimona * persones;
            double totalCulleradaOli = culleradaOli * persones;
            double totalGramsFarina = gramsFarina * persones;
            
            Console.WriteLine("Introdueix " + totalGramsOus + " Ous");
            Console.WriteLine("Introdueix " + totalIogurtDeLlimona + " Iogurt De Llimona");
            Console.WriteLine("Introdueix " + totalCulleradaOli + " Cullerada Oli");
            Console.WriteLine("Introdueix " + totalGramsFarina + " Grams Farina");

            Console.WriteLine("Polsa una tecla per continuar");
            Console.ReadKey();

            double totalDeGrams = totalGramsOus + totalIogurtDeLlimona + totalCulleradaOli + totalGramsFarina;
            Console.WriteLine("Total de grams " + totalDeGrams);

            Console.WriteLine("Cuinant...");
            Thread.Sleep(5000);
            Console.WriteLine("Ja tens el plat "+ plat + " preparat!");
        }
    }
}