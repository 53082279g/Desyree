namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3-Calcula el valor absolut d’ún número.
            El valor absolut de 3 és 3. De -3 és 3. (sempre positiu) */

            double valor, resultat;

            Console.WriteLine("Escriu un valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            resultat = Convert.ToDouble(Console.ReadLine());

            if (valor <= 0)
            {
                resultat = valor * 1;
            }
            else (valor >= 0)
            {
                resultat = valor;
            }

            Console.WriteLine($"El valor absolut de {valor} és {resultat}");
        }
    }
}