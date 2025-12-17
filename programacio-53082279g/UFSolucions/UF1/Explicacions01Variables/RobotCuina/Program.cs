namespace RobotCuina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! com et dius?");

            // Crea una variable de string, obté l'entrada de l'usuari
            // des del teclat i la desa en la variable string
            String nom_usuari = Console.ReadLine();

            Console.WriteLine("Benvingut/da, " + nom_usuari);
            Console.WriteLine("Sóc el teu robot personal");

            Console.WriteLine("Què vols cuinar avui ?");
            String plat = Console.ReadLine();
            Console.WriteLine("Ohh! m’encanta el plat " + plat);


            Console.WriteLine("Tot i així farem pa de pessic");

            Console.WriteLine("Per quantes persones?");
            //recollir el número i posar-lo en una variable
            double persones = Convert.ToDouble(Console.ReadLine());

            //ingredients per persona
            double grams_ous = 0.33;
            double grams_iogurt_de_llimona = 0.3;
            double cullerada_oli = 0.25;
            double grams_farina = 45;
            /*double grams_sucre_blanc = 125;
            double grams_sobre_de_llevat = 0.25;
            double grams_de_sal = 0.75;
            double grams_ratlladura_llimona = 0.25;*/

            //Mostrar un missatge que posi els ous
            double total_grams_ous = grams_ous * persones;
            Console.WriteLine("Introdueix " + total_grams_ous + " ous");
            Console.WriteLine("Polsa una tecla per continuar");
            Console.ReadKey(); //El programa es queda aqui parat fins que es polsa una tecla

        
            double total_grams_iogurt_de_llimona = grams_iogurt_de_llimona * persones;
            double total_cullerada_oli = cullerada_oli * persones;
            double total_grams_farina = grams_farina * persones;

            //demanar els altres ingredients
            //????
            double total_grams = total_grams_ous + total_grams_iogurt_de_llimona + total_cullerada_oli + total_grams_farina;
            Console.WriteLine("Total grams dels ingredients "+ total_grams); // per quatre persones ha de sortir 183.52


            Console.WriteLine("Cuinant....");     
            Thread.Sleep(5000); // El program es queda aquí parat 5 segons           
            Console.WriteLine("Ja tens el plat "+ plat + " preparat!");
        }
    }
}
