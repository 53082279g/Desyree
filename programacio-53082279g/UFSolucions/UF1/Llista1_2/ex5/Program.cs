namespace Llista1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lletra_int; //16 bits 
            char lletra_char; //32bits   

            //Console.WriteLine("Entra una lletra:");
            //lletra_char = Convert.ToInt32(Console.ReadLine()); //ERROR
            //Console.WriteLine("lletra_char  " + lletra_char);

            //Exercici 5. No funciona
            Console.WriteLine("Entra una lletra:");
            lletra_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("lletra_char  "+lletra_char); //mostra a

            //Exercici 5. Sí funciona
            Console.WriteLine("Entra una lletra:");
            lletra_int = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("lletra_char  "+ lletra_int); //mostra 97

        }
    }
}
