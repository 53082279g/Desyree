namespace _20251202_ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15-Calcula el canvi d'una quantitat en euros
            utilitzant la quantitat mínima de monedes.
            El comerç no accepta bitllets de 500€ i 200€.
            Has de començar amb bitllets de 100€, després 50€, 20€, 10€, 5€,
            2€, 1€, 50 cèntims, 20 cèntims, 10 cèntims, 5 cèntims, 2 cèntims i 1 cèntim.
            Suposa que el comerç té canvi il·limitat disponible utilitzant
            bitllets i monedes il·limitats.*/

            //Definir les variables
            double canviEuros;
            int canvi, bitllet100, bitllet50, bitllet20, bitllet10, bitllet5, euro2, euro1, cent50, cent20, cent10, cent5, cent2, cent1;

            //Entrada
            Console.Write("Escriu el valor del canvi en euros: ");
            canviEuros = Convert.ToDouble(Console.ReadLine());
            canvi = (int)(canviEuros * 100);

            bitllet100 = canvi / 10000;
            canvi %= 10000;
            bitllet50 = canvi / 5000;
            canvi %= 5000;
            bitllet20 = canvi / 2000;
            canvi %= 2000;
            bitllet10 = canvi / 1000;
            canvi %= 1000;
            euro2 = canvi / 200;
            canvi %= 200;
            euro1 = canvi / 100;
            canvi %= 100;
            cent50 = canvi / 50;
            canvi %= 50;
            cent20 = canvi / 20;
            canvi %= 20;
            cent10 = canvi / 10;
            canvi %= 10;
            cent5 = canvi / 5;
            canvi %= 5;
            cent2 = canvi / 2;
            canvi %= 2;
            cent1 = canvi / 1;
            canvi %= 1;

            //Calculs
            canviEuros = canviEuros / 100;

            //Sortida
            Console.Write($"El canvi a tornar al client és: {canviEuros} euros");
        }
    }
}