namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int majuscules_int;
            char majuscules_char;
            int lletra_int; //16 bits 

            //Exercici 6
            Console.WriteLine("Entra una lletra:");
            lletra_int = Convert.ToChar(Console.ReadLine());
            //passa a majuscula
            majuscules_int = lletra_int - 32;
            Console.WriteLine($"majuscules {majuscules_int}");
            //conversio a caracter
            majuscules_char = Convert.ToChar(majuscules_int);
            Console.WriteLine($"majuscules {majuscules_char}");

            //Exercici 6. Opció2
            Console.WriteLine("Entra una lletra:");
            string letra = Console.ReadLine();
            string letra_mayuscula = letra.ToUpper();
            Console.WriteLine(letra_mayuscula);

        }
    }
}
