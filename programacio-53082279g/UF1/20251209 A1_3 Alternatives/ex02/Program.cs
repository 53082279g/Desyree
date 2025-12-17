namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2-Donat el següent codi,
            afegir una condició per determinar si les tres temperatures són iguals
            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;
            iguals = //ESCRIU AQUÍ L’EXPRESSIÓ BOOLEANA;
            if (iguals) {
            Console.WriteLine("Les tres temperatures són iguals.");
            } else {
            Console.WriteLine("Les temperatures no són iguals.");
            }*/

            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;

            iguals = t1 == t2 && t2 == t3;

        }
    }
}