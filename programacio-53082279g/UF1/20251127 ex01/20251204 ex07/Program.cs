namespace _20251204_ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7-Escriu un programa per mostrar el resultat del residu
            i la divisió entera de 2 números enters.*/
            ;

            //Variables
            double residu, resultat;
            int numero1, numero2;

            //Entrada
            Console.WriteLine("Introdueix el primer nombre a calcular: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el segon nombre a calcular: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            //Calculs
            residu = numero1 % numero2;
            resultat = numero1 / numero2;

            //Sortida
            Console.WriteLine("Hem dividit " + numero1 + " i " + numero2);
            Console.WriteLine("El resultat ha estat: " + resultat);
            Console.WriteLine("El residu és: " + residu);
            

        }
    }
}