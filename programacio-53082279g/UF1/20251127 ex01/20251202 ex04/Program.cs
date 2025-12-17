namespace _20251202_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4-Escriu un programa que demani per teclat
            dos valors corresponents als coeficients a i b d’una equació de primer grau
            (ax + b = 0) i ens calculi la solució de l’equació.
            El programa després de demanar els dos valors,
            ens ha de mostrar l’equació i
            la solució mostrant els coeficients a i b
            així com la solució exactament amb dues xifres decimals.
            No cal considerar el cas a=0*/

            //Variables
            int a, x, b;

            //Entrada
            Console.WriteLine("Indica el coeficient 'a': ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indica el coeficient 'b': ");
            b = Convert.ToInt32(Console.ReadLine());

            //Calculs
            x = -b / a;

            //Sortida
            Console.WriteLine(x);
        }
    }
}