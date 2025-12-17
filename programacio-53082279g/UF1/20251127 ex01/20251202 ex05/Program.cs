namespace _20251202_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5-Escriu un programa per demanar una lletra pel teclat
            i mostrar el seu codi ASCII a la pantalla.*/

            //Declaració variables
            int lletraNumero;
            char lletra;

            //Entrada
            Console.WriteLine("Escriu una lletra: ");
            lletra = Convert.ToChar(Console.ReadLine());

            //Calculs
            lletraNumero = lletra;

            //Sortida
            Console.WriteLine($"La lletra {lletra} te el número {lletraNumero}");
        }
    }
}