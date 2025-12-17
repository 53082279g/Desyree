namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3-Condició per determinar si les tres temperatures són totes diferents
            int t1 = 25;
            int t2 = 25;
            int t3 = 24;
            bool diferents;
            diferents = //ESCRIU AQUÍ L’EXPRESSIÓ BOOLEANA;
            if (diferents) {
            Console.WriteLine("Les tres temperatures són totes diferents.");
            } else {
            Console.WriteLine("Les temperatures no són totes diferents.");
            }*/

            int t1 = 23;
            int t2 = 25;
            int t3 = 24;
            bool diferents;

            diferents = t1 != t2 && t2 != t3 && t3 != t1;

            if (diferents)
            {
                Console.WriteLine("Les tres temperatures són totes diferents.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són totes diferents.");

            }



    }
}