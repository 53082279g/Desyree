namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3-Programa que validi una resposta s/n amb while.
            Que demani una resposta s ó n, i si no és s ó n que la torni a demanar,
            i si no està ...*/

            char lletra;

            Console.Write("Escriu la resposta amb una lletra: ");
            lletra = Convert.ToChar(Console.ReadLine());

            //while (!(lletra == 's' || lletra == 'n'))
            while (lletra != 's' && lletra != 'n')
            {
                Console.WriteLine("Lletra incorrecta.");
                Console.Write("Escriu una nova lletra: ");
                lletra = Convert.ToChar(Console.ReadLine());

            }

        }
    }
}