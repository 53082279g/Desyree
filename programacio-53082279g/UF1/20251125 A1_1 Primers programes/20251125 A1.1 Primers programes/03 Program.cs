namespace _20251125_A1._1_Primers_programes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            double radi, volum;
            Console.Write("Radi de l'esfera en metres ? ");
            radi = Convert.ToDouble(Console.ReadLine());
            volum = 4 / 3 + PI * Math.Pow(radi, 3);
            Console.WriteLine($"Esfera de radi {radi} té un volum de {volum} m3"); ;
        }
    }
}