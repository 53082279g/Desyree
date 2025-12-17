namespace _20251202_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6-Escriu un programa per demanar una lletra minúscula
            i mostrar la lletra majúscula equivalent.*/

            //Variables
            char lletraMinus, lletraMajus;

            //Entrada
            Console.WriteLine("Escriu una lletra en minúscula:");
            lletraMinus = Convert.ToChar(Console.ReadLine());

            //Calculs
            lletraMajus = (char)(lletraMinus - 32);

            //Sortida
            Console.WriteLine($"La lletra en mayúscula és {lletraMajus}");
        }
    }
}