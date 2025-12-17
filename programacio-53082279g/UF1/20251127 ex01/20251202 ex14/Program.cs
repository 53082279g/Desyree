namespace _20251202_ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14-Escriu un programa per mostrar l'hora en format hh:mm:ss
            a partir d'una quantitat de segons donada com a entrada.
            Per exemple, si l'entrada és 4000, la sortida ha de ser 01:06:40.*/

            //Declarar les variables
            int hores, minuts, segons;

            //Entrada
            Console.WriteLine("Entra els segons a calcular: ");
            segons = Convert.ToInt32(Console.ReadLine());

            //Calcul
            hores = segons / 3600;
            segons %= 3600;
            minuts = segons/ 60;
            segons = segons %= 60;

            //Sortida
            Console.WriteLine($"El temps calculat és de: {hores} hores, {minuts} minuts i {segons} segons");
        }
    }
}